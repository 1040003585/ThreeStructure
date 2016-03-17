using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Sys_number
    {
        private string type;

        public string Type
        {
          get { return type;}
          set { type=value;}
        }
        private int num;

        public int Num
        {
          get { return num;}
          set { num=value;}
        }
        private DateTime rq;

        public DateTime Rq
        {
          get { return rq;}
          set { rq=value;}
        }
        private string remarks;

        public string Remarks
        {
          get { return remarks;}
          set { remarks=value;}
        }
    }
}
