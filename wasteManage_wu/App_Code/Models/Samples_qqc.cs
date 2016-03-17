using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Samples_qqc
    {
        private string bh;

        public string Bh
        {
          get { return bh;}
          set { bh=value;}
        }
        private string sample_id;

        public string Sample_id
        {
          get { return sample_id;}
          set { sample_id=value;}
        }
        private string waste_id;

        public string Waste_id
        {
          get { return waste_id;}
          set { waste_id=value;}
        }
        private byte result;

        public byte Result
        {
          get { return result;}
          set { result=value;}
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
        private string qqc_yyy;

        public string Qqc_yyy
        {
          get { return qqc_yyy;}
          set { qqc_yyy=value;}
        }
        private string status;

        public string Status
        {
          get { return status;}
          set { status=value;}
        }
        private DateTime qqc_date;

        public DateTime Qqc_date
        {
          get { return qqc_date;}
          set { qqc_date=value;}
        }
        private string customer_num;

        public string Customer_num
        {
          get { return customer_num;}
          set { customer_num=value;}
        }
        private string waste_code;

        public string Waste_code
        {
          get { return waste_code;}
          set { waste_code=value;}
        }
    }
}
