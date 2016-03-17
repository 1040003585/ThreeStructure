using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Waste_unsh_record
    {
        private int bm;

        public int Bm
        {
          get { return bm;}
          set { bm=value;}
        }
        private string waste_id;

        public string Waste_id
        {
          get { return waste_id;}
          set { waste_id=value;}
        }
        private string unsh_by;

        public string Unsh_by
        {
          get { return unsh_by;}
          set { unsh_by=value;}
        }
        private DateTime unsh_date;

        public DateTime Unsh_date
        {
          get { return unsh_date;}
          set { unsh_date=value;}
        }
        private string bz;

        public string Bz
        {
          get { return bz;}
          set { bz=value;}
        }
        private string remark;

        public string Remark
        {
          get { return remark;}
          set { remark=value;}
        }
    }
}
