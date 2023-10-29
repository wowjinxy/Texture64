using System.Drawing;
using static Texture64.Scales;

namespace Texture64
{
    public class Colors
    {
        public static Color RGBA16Color(byte c0, byte c1)
        {
            int r = SCALE_5_8((c0 & 0xF8) >> 3);
            int g = SCALE_5_8(((c0 & 0x07) << 2) | ((c1 & 0xC0) >> 6));
            int b = SCALE_5_8((c1 & 0x3E) >> 1);
            int a = ((c1 & 0x1) > 0) ? 255 : 0;
            return Color.FromArgb(a, r, g, b);
        }

        public static Color RGBA16Color(byte[] data, int pixOffset)
        {
            byte c0 = data[pixOffset];
            byte c1 = data[pixOffset + 1];

            return RGBA16Color(c0, c1);
        }

        public static Color RGBA32Color(byte[] data, int pixOffset)
        {
            int r, g, b, a;
            r = data[pixOffset];
            g = data[pixOffset + 1];
            b = data[pixOffset + 2];
            a = data[pixOffset + 3];
            return Color.FromArgb(a, r, g, b);
        }

        public static Color IA16Color(byte[] data, int pixOffset)
        {
            int i = data[pixOffset];
            int a = data[pixOffset + 1];
            return Color.FromArgb(a, i, i, i);
        }

        public static Color IA8Color(byte[] data, int pixOffset)
        {
            int i, a;
            byte c = data[pixOffset];
            i = (c >> 4) * 0x11;
            a = (c & 0xF) * 0x11;
            return Color.FromArgb(a, i, i, i);
        }

        public static Color IA4Color(byte[] data, int pixOffset, int nibble)
        {
            int shift = (1 - nibble) * 4;
            int i, a;
            int val = (data[pixOffset] >> shift) & 0xF;
            i = SCALE_3_8((byte)(val >> 1));
            a = (val & 0x1) > 0 ? 0xFF : 0x00;
            return Color.FromArgb(a, i, i, i);
        }

        public static Color I8Color(byte[] data, int pixOffset, AlphaMode mode = AlphaMode.AlphaCopyIntensity)
        {
            int i = data[pixOffset];
            int a = i;
            switch (mode)
            {
                case AlphaMode.AlphaBinary: a = (i == 0) ? 0 : 0xFF; break;
                case AlphaMode.AlphaCopyIntensity: a = i; break;
                case AlphaMode.AlphaOne: a = 0xFF; break;
            }
            return Color.FromArgb(a, i, i, i);
        }

        public static Color I4Color(byte[] data, int pixOffset, int nibble, AlphaMode mode = AlphaMode.AlphaCopyIntensity)
        {
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
            return Color.FromArgb(a, i, i, i);
        }

        public static Color CI8Color(byte[] data, byte[] palette, int pixOffset)
        {
            byte c0, c1;
            int palOffset = 2 * data[pixOffset];
            c0 = palette[palOffset];
            c1 = palette[palOffset + 1];

            return RGBA16Color(c0, c1);
        }

        public static Color CI4Color(byte[] data, byte[] palette, int pixOffset, int nibble)
        {
            byte c0, c1;
            int shift = (1 - nibble) * 4;
            int palOffset = 2 * ((data[pixOffset] >> shift) & 0xF);
            c0 = palette[palOffset];
            c1 = palette[palOffset + 1];

            return RGBA16Color(c0, c1);
        }

        public static Color BPPColor(byte[] data, int pixOffset, int bit)
        {
            int i, a;
            int val = (data[pixOffset] >> (7 - bit)) & 0x1;
            i = a = val == 0 ? 0x00 : 0xFF;
            return Color.FromArgb(a, i, i, i);
        }
    }
}
