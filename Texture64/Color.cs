using System;
using System.Drawing;
using static Texture64.Scales;

namespace Texture64
{
    public enum AlphaMode { AlphaBinary, AlphaCopyIntensity, AlphaOne }

    public static class Colors
    {
        private static Color CreateColor(int a, int r, int g, int b)
        {
            return Color.FromArgb(a, r, g, b);
        }

        public static Color RGBA16Color((byte c0, byte c1) colorTuple)
        {
            int r = SCALE_5_8((colorTuple.c0 & 0xF8) >> 3);
            int g = SCALE_5_8(((colorTuple.c0 & 0x07) << 2) | ((colorTuple.c1 & 0xC0) >> 6));
            int b = SCALE_5_8((colorTuple.c1 & 0x3E) >> 1);
            int a = ((colorTuple.c1 & 0x1) > 0) ? 255 : 0;
            return CreateColor(a, r, g, b);
        }

        public static Color RGBA16Color(byte[] data, int pixOffset)
        {
            ValidateArrayAndOffset(data, pixOffset, 2);
            return RGBA16Color((data[pixOffset], data[pixOffset + 1]));
        }

        public static Color RGBA32Color(byte[] data, int pixOffset)
        {
            ValidateArrayAndOffset(data, pixOffset, 4);
            return CreateColor(data[pixOffset + 3], data[pixOffset], data[pixOffset + 1], data[pixOffset + 2]);
        }

        public static Color IA16Color(byte[] data, int pixOffset)
        {
            ValidateArrayAndOffset(data, pixOffset, 2);
            int i = data[pixOffset];
            int a = data[pixOffset + 1];
            return CreateColor(a, i, i, i);
        }

        public static Color IA8Color(byte[] data, int pixOffset)
        {
            ValidateArrayAndOffset(data, pixOffset, 1);
            int i = (data[pixOffset] >> 4) * 0x11;
            int a = (data[pixOffset] & 0xF) * 0x11;
            return CreateColor(a, i, i, i);
        }

        public static Color IA4Color(byte[] data, int pixOffset, int nibble)
        {
            ValidateArrayAndOffset(data, pixOffset, 1);
            int shift = (1 - nibble) * 4;
            int val = (data[pixOffset] >> shift) & 0xF;
            int i = Scales.SCALE_3_8((byte)(val & 0x7));  // Mask to 3 bits before scaling
            int a = (val & 0x8) > 0 ? 0xFF : 0x00;  // Use the highest bit for alpha
            return CreateColor(a, i, i, i);
        }

        public static Color I8Color(byte[] data, int pixOffset, AlphaMode mode = AlphaMode.AlphaCopyIntensity)
        {
            ValidateArrayAndOffset(data, pixOffset, 1);
            int i = data[pixOffset];
            int a = i;
            switch (mode)
            {
                case AlphaMode.AlphaBinary: a = (i == 0) ? 0 : 0xFF; break;
                case AlphaMode.AlphaCopyIntensity: a = i; break;
                case AlphaMode.AlphaOne: a = 0xFF; break;
            }
            return CreateColor(a, i, i, i);
        }

        public static Color I4Color(byte[] data, int pixOffset, int nibble, AlphaMode mode = AlphaMode.AlphaCopyIntensity)
        {
            ValidateArrayAndOffset(data, pixOffset, 1);
            int shift = (1 - nibble) * 4;
            int i = (data[pixOffset] >> shift) & 0xF;
            i *= 0x11;
            int a = i;
            switch (mode)
            {
                case AlphaMode.AlphaBinary: a = (i == 0) ? 0 : 0xFF; break;
                case AlphaMode.AlphaCopyIntensity: a = i; break;
                case AlphaMode.AlphaOne: a = 0xFF; break;
            }
            return CreateColor(a, i, i, i);
        }

        public static Color CI8Color(byte[] data, byte[] palette, int pixOffset)
        {
            ValidateArrayAndOffset(data, pixOffset, 1);
            ValidateArrayAndOffset(palette, 0, 2); // Minimum palette length
            int palOffset = 2 * data[pixOffset];
            return RGBA16Color((palette[palOffset], palette[palOffset + 1]));
        }

        public static Color CI4Color(byte[] data, byte[] palette, int pixOffset, int nibble)
        {
            ValidateArrayAndOffset(data, pixOffset, 1);
            ValidateArrayAndOffset(palette, 0, 2); // Minimum palette length
            int shift = (1 - nibble) * 4;
            int palOffset = 2 * ((data[pixOffset] >> shift) & 0xF);
            return RGBA16Color((palette[palOffset], palette[palOffset + 1]));
        }

        public static Color BPPColor(byte[] data, int pixOffset, int bit)
        {
            ValidateArrayAndOffset(data, pixOffset, 1);
            if (bit < 0 || bit > 7)
            {
                throw new ArgumentOutOfRangeException(nameof(bit));
            }
            int val = (data[pixOffset] >> (7 - bit)) & 0x1;
            int i = val == 0 ? 0x00 : 0xFF;
            int a = i;
            return CreateColor(a, i, i, i);
        }

        public static Color RGB565Color(byte[] data, int pixOffset)
        {
            ValidateArrayAndOffset(data, pixOffset, 2);
            ushort val = BitConverter.ToUInt16(data, pixOffset);

            // Extract and scale R, G, B values
            int r = SCALE_5_8((val & 0xF800) >> 11);  // Corrected the shift to 11
            int g = (val & 0x07E0) >> 5;              // Corrected the shift to 5, no need to scale as it's already 8 bits
            int b = SCALE_5_8(val & 0x001F);          // No shift needed

            return CreateColor(255, r, g, b);
        }

        public static Color RGB555Color(byte[] data, int pixOffset)
        {
            ValidateArrayAndOffset(data, pixOffset, 2);
            ushort val = BitConverter.ToUInt16(data, pixOffset);
            int r = SCALE_5_8((val & 0x7C00) >> 10);
            int g = SCALE_5_8((val & 0x03E0) >> 5);
            int b = SCALE_5_8(val & 0x001F);
            return CreateColor(255, r, g, b);
        }

        public static Color RGB24Color(byte[] data, int pixOffset)
        {
            ValidateArrayAndOffset(data, pixOffset, 3);
            int r = data[pixOffset];
            int g = data[pixOffset + 1];
            int b = data[pixOffset + 2];
            return CreateColor(255, r, g, b);
        }

        public static Color RGB8Color(byte[] data, int pixOffset)
        {
            ValidateArrayAndOffset(data, pixOffset, 1);
            byte val = data[pixOffset];
            int r = SCALE_3_8((byte)((val & 0xE0) >> 5));
            int g = SCALE_3_8((byte)((val & 0x1C) >> 2));
            int b = SCALE_2_8((byte)(val & 0x03));
            return CreateColor(255, r, g, b);
        }

        public static Color[] YUV422Color(byte[] data, int pixOffset)
        {
            ValidateArrayAndOffset(data, pixOffset, 4);
            byte y1 = data[pixOffset];
            byte u = data[pixOffset + 1];
            byte y2 = data[pixOffset + 2];
            byte v = data[pixOffset + 3];

            // Convert YUV to RGB (this is a simplified conversion)
            int r1 = (int)(y1 + 1.402 * (v - 128));
            int g1 = (int)(y1 - 0.344136 * (u - 128) - 0.714136 * (v - 128));
            int b1 = (int)(y1 + 1.772 * (u - 128));

            int r2 = (int)(y2 + 1.402 * (v - 128));
            int g2 = (int)(y2 - 0.344136 * (u - 128) - 0.714136 * (v - 128));
            int b2 = (int)(y2 + 1.772 * (u - 128));

            return new[] { CreateColor(255, r1, g1, b1), CreateColor(255, r2, g2, b2) };
        }

        public static Color Grayscale16Color(byte[] data, int pixOffset)
        {
            ValidateArrayAndOffset(data, pixOffset, 2);
            ushort gray = BitConverter.ToUInt16(data, pixOffset);
            int intensity = gray >> 8; // Scale down to 8-bit
            return CreateColor(255, intensity, intensity, intensity);
        }

        public static Color Grayscale8Color(byte[] data, int pixOffset)
        {
            ValidateArrayAndOffset(data, pixOffset, 1);
            byte gray = data[pixOffset];
            return CreateColor(255, gray, gray, gray);
        }

        private static void ValidateArrayAndOffset(byte[] array, int offset, int requiredLength)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (offset < 0 || offset + requiredLength > array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(offset));
            }
        }
    }
}
