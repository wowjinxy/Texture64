using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texture64
{
    public class Scales
    {
        public static int SCALE_5_8(int val)
        {
            return (val * 0xFF) / 0x1F;
        }

        public static byte SCALE_8_5(byte val)
        {
            return (byte)((((val) + 4) * 0x1F) / 0xFF);
        }

        public static byte SCALE_8_4(byte val)
        {
            return (byte)(val / 0x11);
        }

        public static int SCALE_3_8(byte val)
        {
            return (val * 0xFF) / 0x7;
        }

        public static byte SCALE_8_3(byte val)
        {
            return (byte)(val / 0x24);
        }
    }
}
