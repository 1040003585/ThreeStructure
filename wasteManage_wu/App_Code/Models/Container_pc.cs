using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Container_pc
    {
        private string container_id;

        public string Container_id
        {
          get { return container_id;}
          set { container_id=value;}
        }
        private DateTime rq;

        public DateTime Rq
        {
          get { return rq;}
          set { rq=value;}
        }
        private DateTime import_rq;

        public DateTime Import_rq
        {
          get { return import_rq;}
          set { import_rq=value;}
        }
        private string user_id;

        public string User_id
        {
          get { return user_id;}
          set { user_id=value;}
        }
        private byte bz;

        public byte Bz
        {
          get { return bz;}
          set { bz=value;}
        }
    }
}
