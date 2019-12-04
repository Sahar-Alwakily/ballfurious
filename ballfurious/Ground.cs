using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ballfurious
{
    public struct Ground
    {
        private int _w;
        private int _h;

        public int Width
        {
            get
            {
                return _w;
            }
            set
            {
                _w = value;
            }
        }

        public int Height
        {
            get
            {
                return _h;
            }
            set
            {
                _h = value;
            }
        }
    }
}
