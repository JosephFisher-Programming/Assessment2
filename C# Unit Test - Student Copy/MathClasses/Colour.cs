using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Colour
    {
        public UInt32 colour;

        public Colour()
        {
            colour = 0;
        }

        public void Set(uint x)
        {
            colour = x;
        }

       
        public void SetAlpha(uint val)
        {
            colour = colour & (uint)0x00FFFFFF;
            colour = colour | (val << 24);
        }

        public void SetRed(uint val)
        {
            colour = colour & (uint)0xFF00FFFF;
            colour = colour | (val << 16);
        }

        public void SetBlue(uint val)
        {
            colour = colour & (uint)0xFFFFFF00;
            colour = colour | (val << 8);
        }
    }
}
