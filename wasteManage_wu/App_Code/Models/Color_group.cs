using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Color_group
    {
        private string bm;

        public string Bm
        {
          get { return bm;}
          set { bm=value;}
        }
        private string mc;

        public string Mc
        {
          get { return mc;}
          set { mc=value;}
        }
        private string color_id;

        public string Color_id
        {
          get { return color_id;}
          set { color_id=value;}
        }
        private byte status;

        public byte Status
        {
          get { return status;}
          set { status=value;}
        }
    }
}
