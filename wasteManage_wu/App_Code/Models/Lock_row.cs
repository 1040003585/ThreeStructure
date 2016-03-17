using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Lock_row
    {
        private string windowname;

        public string Windowname
        {
          get { return windowname;}
          set { windowname=value;}
        }
        private string bh;

        public string Bh
        {
          get { return bh;}
          set { bh=value;}
        }
        private string username;

        public string Username
        {
          get { return username;}
          set { username=value;}
        }
        private byte row;

        public byte Row
        {
          get { return row;}
          set { row=value;}
        }
        private byte xh;

        public byte Xh
        {
          get { return xh;}
          set { xh=value;}
        }
    }
}
