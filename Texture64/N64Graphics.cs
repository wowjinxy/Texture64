using System.Drawing;
using static Texture64.Scales;
using static Texture64.Colors;

namespace Texture64
{
    public enum ColorCodecs
    {
        RGBA16, RGBA32, IA16, IA8, IA4, I8, I4, CI8, CI4, ONEBPP,
        RGB565, RGB555, RGB24, RGB8, YUV422, YUV420, GRAYSCALE16, GRAYSCALE8,
        CMYK, ARGB4444, ARGB1555, RGBA5551, HSV, HSL, LAB, XYZ,
        BC1, BC2, BC3, ETC1, ETC2, PVRTC, ASTC, RLE, TWOBPP, FOURBPP, S3TC
    };

    class N64Graphics
    {
       // return number of bytes needed to encode numPixels using codec
        public static int PixelsToBytes(ColorCodecs codec, int numPixels)
        {
           int numBytes = 0;
           switch (codec)
           {
                case ColorCodecs.RGBA16: numBytes = numPixels * 2; break;
                case ColorCodecs.RGBA32: numBytes = numPixels * 4; break;
                case ColorCodecs.IA16:   numBytes = numPixels * 2; break;
                case ColorCodecs.IA8:    numBytes = numPixels;  break;
                case ColorCodecs.IA4:    numBytes = numPixels / 2; break;
                case ColorCodecs.I8:     numBytes = numPixels;  break;
                case ColorCodecs.I4:     numBytes = numPixels / 2; break;
                case ColorCodecs.CI8:    numBytes = numPixels;  break;
                case ColorCodecs.CI4:    numBytes = numPixels / 2; break;
                case ColorCodecs.ONEBPP: numBytes = numPixels / 8; break;
                case ColorCodecs.RGB565: numBytes = numPixels * 2; break;
                case ColorCodecs.RGB555: numBytes = numPixels * 2; break;
                case ColorCodecs.RGB24: numBytes = numPixels * 3; break;
                case ColorCodecs.RGB8: numBytes = numPixels; break;
            }
            return numBytes;
        }
    
       public static string CodecString(ColorCodecs codec)
       {
            switch (codec)
            {
                case ColorCodecs.RGBA16: return "rgba16";
                case ColorCodecs.RGBA32: return "rgba32";
                case ColorCodecs.IA16: return "ia16";
                case ColorCodecs.IA8: return "ia8";
                case ColorCodecs.IA4: return "ia4";
                case ColorCodecs.I8: return "i8";
                case ColorCodecs.I4: return "i4";
                case ColorCodecs.CI8: return "ci8";
                case ColorCodecs.CI4: return "ci4";
                case ColorCodecs.ONEBPP: return "1bpp";
                case ColorCodecs.RGB565: return "rgb565";
                case ColorCodecs.RGB555: return "rgb555";
                case ColorCodecs.RGB24: return "rgb24";
                case ColorCodecs.RGB8: return "rgb8";
            }
            return "unk";
       }
    
       public static Color MakeColor(byte[] data, byte[] palette, int offset, int select, ColorCodecs codec, AlphaMode mode)
      {
         Color color;
         switch (codec)
         {
            case ColorCodecs.RGBA16:
               color = RGBA16Color(data, offset);
               break;
            case ColorCodecs.RGBA32:
               color = RGBA32Color(data, offset);
               break;
            case ColorCodecs.IA16:
               color = IA16Color(data, offset);
               break;
            case ColorCodecs.IA8:
               color = IA8Color(data, offset);
               break;
            case ColorCodecs.IA4:
               color = IA4Color(data, offset, select);
               break;
            case ColorCodecs.I8:
               color = I8Color(data, offset, mode);
               break;
            case ColorCodecs.I4:
               color = I4Color(data, offset, select, mode);
               break;
            case ColorCodecs.CI8:
               color = CI8Color(data, palette, offset);
               break;
            case ColorCodecs.CI4:
               color = CI4Color(data, palette, offset, select);
               break;
            case ColorCodecs.ONEBPP:
               color = BPPColor(data, offset, select);
               break;
            case ColorCodecs.RGB565:
                color = RGB565Color(data, offset);
                break;
            case ColorCodecs.RGB555:
                color = RGB555Color(data, offset);
                break;
            case ColorCodecs.RGB24:
                color = RGB24Color(data, offset);
                break;
            case ColorCodecs.RGB8:
                color = RGB8Color(data, offset);
                break;
            default:
                color = RGBA16Color(data, offset);
                break;
            }
         return color;
      }
    
       public static void RenderTexture(Graphics g, byte[] data, byte[] palette, int offset, int width, int height, int scale, ColorCodecs codec, AlphaMode mode)
       {
          Brush brush;
          for (int h = 0; h < height; h++)
          {
             for (int w = 0; w < width; w++)
             {
                int pixOffset = (h * width + w);
                int bytesPerPix = 1;
                int select = 0;
                switch (codec)
                {
                   case ColorCodecs.RGBA16: bytesPerPix = 2; pixOffset *= bytesPerPix; break;
                   case ColorCodecs.RGBA32: bytesPerPix = 4; pixOffset *= bytesPerPix; break;
                   case ColorCodecs.IA16: bytesPerPix = 2; pixOffset *= bytesPerPix; break;
                   case ColorCodecs.IA8: break;
                   case ColorCodecs.IA4:
                      select = pixOffset & 0x1;
                      pixOffset /= 2;
                      break;
                   case ColorCodecs.I8: break;
                   case ColorCodecs.I4:
                   case ColorCodecs.CI4:
                      select = pixOffset & 0x1;
                      pixOffset /= 2;
                      break;
                   case ColorCodecs.CI8: break;
                   case ColorCodecs.ONEBPP:
                      select = pixOffset & 0x7;
                      pixOffset /= 8;
                      break;
                        case ColorCodecs.RGB565: bytesPerPix = 2; pixOffset *= bytesPerPix; break;
                        case ColorCodecs.RGB555: bytesPerPix = 2; pixOffset *= bytesPerPix; break;
                        case ColorCodecs.RGB24: bytesPerPix = 3; pixOffset *= bytesPerPix; break;
                        case ColorCodecs.RGB8: bytesPerPix = 1; pixOffset *= bytesPerPix; break;
                    }
                    pixOffset += offset;
                if (data.Length > pixOffset + bytesPerPix - 1)
                {
                   brush = new SolidBrush(MakeColor(data, palette, pixOffset, select, codec, mode));
                   g.FillRectangle(brush, w * scale, h * scale, scale, scale);
                }
             }
          }
       }
    
       // return palette index of matching c0/c1 16-bit dataset, or -1 if not found
       private static int paletteIndex(byte[] pal, int palCount, byte c0, byte c1)
       {
          for (int i = 0; i < palCount; i++)
          {
             if (pal[2 * i] == c0 && pal[2 * i + 1] == c1)
             {
                return i;
             }
          }
          return -1;
       }
    
       public static void Convert(ref byte[] imageData, ref byte[] paletteData, ColorCodecs codec, Bitmap bm)
       {
          int numPixels = bm.Width * bm.Height;
          imageData = new byte[PixelsToBytes(codec, numPixels)];
          int palCount = 0;
          switch (codec)
          {
             case ColorCodecs.RGBA16:
                for (int y = 0; y < bm.Height; y++)
                {
                   for (int x = 0; x < bm.Width; x++)
                   {
                      Color col = bm.GetPixel(x, y);
                      byte r, g, b;
                      r = SCALE_8_5(col.R);
                      g = SCALE_8_5(col.G);
                      b = SCALE_8_5(col.B);
                      byte c0 = (byte)((r << 3) | (g >> 2));
                      byte c1 = (byte)(((g & 0x3) << 6) | (b << 1) | ((col.A > 0) ? 1 : 0));
                      int idx = 2 * (y * bm.Width + x);
                      imageData[idx + 0] = c0;
                      imageData[idx + 1] = c1;
                   }
                }
                break;
             case ColorCodecs.RGBA32:
                for (int y = 0; y < bm.Height; y++)
                {
                   for (int x = 0; x < bm.Width; x++)
                   {
                      Color col = bm.GetPixel(x, y);
                      int idx = 4 * (y * bm.Width + x);
                      imageData[idx + 0] = col.R;
                      imageData[idx + 1] = col.G;
                      imageData[idx + 2] = col.B;
                      imageData[idx + 3] = col.A;
                   }
                }
                break;
             case ColorCodecs.IA16:
                for (int y = 0; y < bm.Height; y++)
                {
                   for (int x = 0; x < bm.Width; x++)
                   {
                      Color col = bm.GetPixel(x, y);
                      int sum = col.R + col.G + col.B;
                      byte intensity = (byte)(sum / 3);
                      byte alpha = col.A;
                      int idx = 2 * (y * bm.Width + x);
                      imageData[idx + 0] = intensity;
                      imageData[idx + 1] = alpha;
                   }
                }
                break;
             case ColorCodecs.IA8:
                for (int y = 0; y < bm.Height; y++)
                {
                   for (int x = 0; x < bm.Width; x++)
                   {
                      Color col = bm.GetPixel(x, y);
                      int sum = col.R + col.G + col.B;
                      byte intensity = SCALE_8_4((byte)(sum / 3));
                      byte alpha = SCALE_8_4(col.A);
                      int idx = y * bm.Width + x;
                      imageData[idx] = (byte)((intensity << 4) | alpha);
                   }
                }
                break;
             case ColorCodecs.IA4:
                for (int y = 0; y < bm.Height; y++)
                {
                   for (int x = 0; x < bm.Width; x++)
                   {
                      Color col = bm.GetPixel(x, y);
                      int sum = col.R + col.G + col.B;
                      byte intensity = SCALE_8_3((byte)(sum / 3));
                      byte alpha = (byte)(col.A > 0 ? 1 : 0);
                      int idx = y * bm.Width + x;
                      byte old = imageData[idx / 2];
                      if ((idx % 2) > 0)
                      {
                         imageData[idx / 2] = (byte)((old & 0xF0) | (intensity << 1) | alpha);
                      }
                      else
                      {
                         imageData[idx / 2] = (byte)((old & 0x0F) | (((intensity << 1) | alpha) << 4));
                      }
                   }
                }
                break;
             case ColorCodecs.I8:
                for (int y = 0; y < bm.Height; y++)
                {
                   for (int x = 0; x < bm.Width; x++)
                   {
                      Color col = bm.GetPixel(x, y);
                      int sum = col.R + col.G + col.B;
                      byte intensity = (byte)(sum / 3);
                      int idx = y * bm.Width + x;
                      imageData[idx] = intensity;
                   }
                }
                break;
             case ColorCodecs.I4:
                for (int y = 0; y < bm.Height; y++)
                {
                   for (int x = 0; x < bm.Width; x++)
                   {
                      Color col = bm.GetPixel(x, y);
                      int sum = col.R + col.G + col.B;
                      byte intensity = SCALE_8_4((byte)(sum / 3));
                      int idx = y * bm.Width + x;
                      byte old = imageData[idx / 2];
                      if ((idx % 2) > 0)
                      {
                         imageData[idx / 2] = (byte)((old & 0xF0) | intensity);
                      }
                      else
                      {
                         imageData[idx / 2] = (byte)((old & 0x0F) | (intensity << 4));
                      }
                   }
                }
                break;
             case ColorCodecs.CI4:
                paletteData = new byte[16 * 2];
                for (int y = 0; y < bm.Height; y++)
                {
                   for (int x = 0; x < bm.Width; x++)
                   {
                      Color col = bm.GetPixel(x, y);
                      byte r, g, b;
                      r = SCALE_8_5(col.R);
                      g = SCALE_8_5(col.G);
                      b = SCALE_8_5(col.B);
                      byte c0 = (byte)((r << 3) | (g >> 2));
                      byte c1 = (byte)(((g & 0x3) << 6) | (b << 1) | ((col.A > 0) ? 1 : 0));
                      int idx = y * bm.Width + x;
                      int palIdx = paletteIndex(paletteData, palCount, c0, c1);
                      if (palIdx < 0)
                      {
                         if (palCount < paletteData.Length / 2)
                         {
                            palIdx = palCount;
                            paletteData[2 * palCount] = c0;
                            paletteData[2 * palCount + 1] = c1;
                            palCount++;
                         }
                         else
                         {
                            palIdx = 0;
                            // TODO: out of palette entries. error or pick closest?
                         }
                      }
                      byte old = imageData[idx / 2];
                      if ((idx % 2) > 0)
                      {
                         imageData[idx / 2] = (byte)((old & 0xF0) | (byte)palIdx);
                      }
                      else
                      {
                         imageData[idx / 2] = (byte)((old & 0x0F) | ((byte)palIdx << 4));
                      }
                   }
                }
                break;
             case ColorCodecs.CI8:
                paletteData = new byte[256 * 2];
                for (int y = 0; y < bm.Height; y++)
                {
                   for (int x = 0; x < bm.Width; x++)
                   {
                      Color col = bm.GetPixel(x, y);
                      byte r, g, b;
                      r = SCALE_8_5(col.R);
                      g = SCALE_8_5(col.G);
                      b = SCALE_8_5(col.B);
                      byte c0 = (byte)((r << 3) | (g >> 2));
                      byte c1 = (byte)(((g & 0x3) << 6) | (b << 1) | ((col.A > 0) ? 1 : 0));
                      int idx = y * bm.Width + x;
                      int palIdx = paletteIndex(paletteData, palCount, c0, c1);
                      if (palIdx < 0)
                      {
                         if (palCount < paletteData.Length / 2)
                         {
                            palIdx = palCount;
                            paletteData[2 * palCount] = c0;
                            paletteData[2 * palCount + 1] = c1;
                            palCount++;
                         }
                         else
                         {
                            palIdx = 0;
                            // TODO: out of palette entries. error or pick closest?
                         }
                      }
                      imageData[idx] = (byte)palIdx;
                   }
                }
                break;
             case ColorCodecs.ONEBPP:
                for (int y = 0; y < bm.Height; y++)
                {
                   for (int x = 0; x < bm.Width; x++)
                   {
                      Color col = bm.GetPixel(x, y);
                      int sum = col.R + col.G + col.B;
                      byte intensity = (sum > 0) ? (byte)1 : (byte)0;
                      int idx = y * bm.Width + x;
                      byte old = imageData[idx / 8];
                      int bit = idx % 8;
                      int mask = ~(1 << bit);
                      imageData[idx / 8] = (byte)((old & mask) | (intensity << bit));
                   }
                }
                break;
                case ColorCodecs.RGB565:
                    for (int y = 0; y < bm.Height; y++)
                    {
                        for (int x = 0; x < bm.Width; x++)
                        {
                            Color col = bm.GetPixel(x, y);
                            ushort rgb565 = (ushort)(((col.R >> 3) << 11) | ((col.G >> 2) << 5) | (col.B >> 3));
                            int idx = 2 * (y * bm.Width + x);
                            imageData[idx] = (byte)(rgb565 & 0xFF);
                            imageData[idx + 1] = (byte)(rgb565 >> 8);
                        }
                    }
                    break;

                case ColorCodecs.RGB555:
                    for (int y = 0; y < bm.Height; y++)
                    {
                        for (int x = 0; x < bm.Width; x++)
                        {
                            Color col = bm.GetPixel(x, y);
                            ushort rgb555 = (ushort)(((col.R >> 3) << 10) | ((col.G >> 3) << 5) | (col.B >> 3));
                            int idx = 2 * (y * bm.Width + x);
                            imageData[idx] = (byte)(rgb555 & 0xFF);
                            imageData[idx + 1] = (byte)(rgb555 >> 8);
                        }
                    }
                    break;

                case ColorCodecs.RGB24:
                    for (int y = 0; y < bm.Height; y++)
                    {
                        for (int x = 0; x < bm.Width; x++)
                        {
                            Color col = bm.GetPixel(x, y);
                            int idx = 3 * (y * bm.Width + x);
                            imageData[idx] = col.R;
                            imageData[idx + 1] = col.G;
                            imageData[idx + 2] = col.B;
                        }
                    }
                    break;

                case ColorCodecs.RGB8:
                    // Assuming RGB8 means grayscale 8-bit
                    for (int y = 0; y < bm.Height; y++)
                    {
                        for (int x = 0; x < bm.Width; x++)
                        {
                            Color col = bm.GetPixel(x, y);
                            byte gray = (byte)((col.R + col.G + col.B) / 3);
                            int idx = y * bm.Width + x;
                            imageData[idx] = gray;
                        }
                    }
                    break;
            }
       }
    }
}
