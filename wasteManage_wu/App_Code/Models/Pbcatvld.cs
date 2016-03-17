using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Pbcatvld
    {
        private string pbv_name;

        public string Pbv_name
        {
          get { return pbv_name;}
          set { pbv_name=value;}
        }
        private string pbv_vald;

        public string Pbv_vald
        {
          get { return pbv_vald;}
          set { pbv_vald=value;}
        }
        private int pbv_type;

        public int Pbv_type
        {
          get { return pbv_type;}
          set { pbv_type=value;}
        }
        private int pbv_cntr;

        public int Pbv_cntr
        {
          get { return pbv_cntr;}
          set { pbv_cntr=value;}
        }
        private string pbv_msg;

        public string Pbv_msg
        {
          get { return pbv_msg;}
          set { pbv_msg=value;}
        }
    }
}
