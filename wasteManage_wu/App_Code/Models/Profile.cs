using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Profile
    {
        private string bh;

        public string Bh
        {
          get { return bh;}
          set { bh=value;}
        }
        private string profile_id;

        public string Profile_id
        {
          get { return profile_id;}
          set { profile_id=value;}
        }
        private string profile_name;

        public string Profile_name
        {
          get { return profile_name;}
          set { profile_name=value;}
        }
        private string component_id;

        public string Component_id
        {
          get { return component_id;}
          set { component_id=value;}
        }
        private byte stutas;

        public byte Stutas
        {
          get { return stutas;}
          set { stutas=value;}
        }
        private int xh;

        public int Xh
        {
          get { return xh;}
          set { xh=value;}
        }
    }
}
