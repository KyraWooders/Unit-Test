using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Color
    {
        public UInt32 color;

        private byte _red = 0;
        private byte _green = 0;
        private byte _blue = 0;
        private byte _alpha = 0;

        private int red3;
        private int green3;
        private int blue3;
        
        public Color()
        {
            color = 0;
        }

        public Color(byte r, byte g, byte b, byte a)
        {
            _red = r;
            _green = g;
            _blue = b;
            _alpha = a;
            int red2 = _red << 24;
            int green2 = _green << 16;
            int blue2 = _blue << 8;
            red3 = red2;
            green3 = green2;
            blue3 = blue2;
            color = (UInt32)(red3 + green3 + blue3 + _alpha);
        }

        public byte GetRed()
        {
            return _red;
        }

        public byte GetGreen()
        {
            return _green;
        }

        public byte GetBlue()
        {
            return _blue;
        }

        public byte GetAlpha()
        {
            return _alpha;
        }

        public void SetRed(byte r)
        {
            red3 = r << 24;
            color = (UInt32)(red3 + green3 + blue3 + _alpha);
        }

        public void SetBlue(byte b)
        {
            blue3 = b << 8;
            color = (UInt32)(red3 + green3 + blue3 + _alpha);
        }

        public void SetAlpha(byte a)
        {
            _alpha = a;
            color = (UInt32)(red3 + green3 + blue3 + _alpha);
        }

        public void SetGreen(byte g)
        {
            green3 = g << 16;
            color = (UInt32)(red3 + green3 + blue3 + _alpha);
        }
    }
}
