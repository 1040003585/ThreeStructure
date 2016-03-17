using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Billing
    {
        private string bh;

        public string Bh
        {
          get { return bh;}
          set { bh=value;}
        }
        private string billing_id;

        public string Billing_id
        {
          get { return billing_id;}
          set { billing_id=value;}
        }
        private DateTime billing_date;

        public DateTime Billing_date
        {
          get { return billing_date;}
          set { billing_date=value;}
        }
        private string status;

        public string Status
        {
          get { return status;}
          set { status=value;}
        }
    }
}
