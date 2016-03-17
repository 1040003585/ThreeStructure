using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Pbcatfmt
    {
        private string pbf_name;

        public string Pbf_name
        {
          get { return pbf_name;}
          set { pbf_name=value;}
        }
        private string pbf_frmt;

        public string Pbf_frmt
        {
          get { return pbf_frmt;}
          set { pbf_frmt=value;}
        }
        private int pbf_type;

        public int Pbf_type
        {
          get { return pbf_type;}
          set { pbf_type=value;}
        }
        private int pbf_cntr;

        public int Pbf_cntr
        {
          get { return pbf_cntr;}
          set { pbf_cntr=value;}
        }
    }
}
