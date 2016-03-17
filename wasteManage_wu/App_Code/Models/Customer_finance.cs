using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Customer_finance
    {
        private string bh;

        public string Bh
        {
          get { return bh;}
          set { bh=value;}
        }
        private string bm;

        public string Bm
        {
          get { return bm;}
          set { bm=value;}
        }
        private decimal charging;

        public decimal Charging
        {
          get { return charging;}
          set { charging=value;}
        }
        private string skr;

        public string Skr
        {
          get { return skr;}
          set { skr=value;}
        }
        private DateTime sk_date;

        public DateTime Sk_date
        {
          get { return sk_date;}
          set { sk_date=value;}
        }
        private string customer_num;

        public string Customer_num
        {
          get { return customer_num;}
          set { customer_num=value;}
        }
        private string bz;

        public string Bz
        {
          get { return bz;}
          set { bz=value;}
        }
        private byte is_sh;

        public byte Is_sh
        {
          get { return is_sh;}
          set { is_sh=value;}
        }
        private string shr;

        public string Shr
        {
          get { return shr;}
          set { shr=value;}
        }
        private DateTime sh_date;

        public DateTime Sh_date
        {
          get { return sh_date;}
          set { sh_date=value;}
        }
        private string created_by;

        public string Created_by
        {
          get { return created_by;}
          set { created_by=value;}
        }
        private DateTime create_date;

        public DateTime Create_date
        {
          get { return create_date;}
          set { create_date=value;}
        }
        private string updated_by;

        public string Updated_by
        {
          get { return updated_by;}
          set { updated_by=value;}
        }
        private DateTime update_date;

        public DateTime Update_date
        {
          get { return update_date;}
          set { update_date=value;}
        }
    }
}
