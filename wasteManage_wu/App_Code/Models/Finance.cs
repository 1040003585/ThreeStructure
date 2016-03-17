using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Finance
    {
        private DateTime processing_date;

        public DateTime Processing_date
        {
          get { return processing_date;}
          set { processing_date=value;}
        }
        private string ticket_num;

        public string Ticket_num
        {
          get { return ticket_num;}
          set { ticket_num=value;}
        }
        private string container_id;

        public string Container_id
        {
          get { return container_id;}
          set { container_id=value;}
        }
        private string waste_id;

        public string Waste_id
        {
          get { return waste_id;}
          set { waste_id=value;}
        }
        private decimal weight;

        public decimal Weight
        {
          get { return weight;}
          set { weight=value;}
        }
        private decimal charging;

        public decimal Charging
        {
          get { return charging;}
          set { charging=value;}
        }
        private string billing_id;

        public string Billing_id
        {
          get { return billing_id;}
          set { billing_id=value;}
        }
        private string bh;

        public string Bh
        {
          get { return bh;}
          set { bh=value;}
        }
        private string yyy;

        public string Yyy
        {
          get { return yyy;}
          set { yyy=value;}
        }
        private string zdr;

        public string Zdr
        {
          get { return zdr;}
          set { zdr=value;}
        }
        private string bz;

        public string Bz
        {
          get { return bz;}
          set { bz=value;}
        }
        private string zy;

        public string Zy
        {
          get { return zy;}
          set { zy=value;}
        }
        private decimal charging_fee;

        public decimal Charging_fee
        {
          get { return charging_fee;}
          set { charging_fee=value;}
        }
        private decimal other_fee;

        public decimal Other_fee
        {
          get { return other_fee;}
          set { other_fee=value;}
        }
        private decimal treatment_rate;

        public decimal Treatment_rate
        {
          get { return treatment_rate;}
          set { treatment_rate=value;}
        }
        private decimal treatment_je;

        public decimal Treatment_je
        {
          get { return treatment_je;}
          set { treatment_je=value;}
        }
        private decimal charging_zz;

        public decimal Charging_zz
        {
          get { return charging_zz;}
          set { charging_zz=value;}
        }
        private decimal charging_yjs;

        public decimal Charging_yjs
        {
          get { return charging_yjs;}
          set { charging_yjs=value;}
        }
        private decimal charging_wjs;

        public decimal Charging_wjs
        {
          get { return charging_wjs;}
          set { charging_wjs=value;}
        }
    }
}
