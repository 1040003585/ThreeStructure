using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Container_detail
    {
        private string bh;

        public string Bh
        {
          get { return bh;}
          set { bh=value;}
        }
        private string container_id;

        public string Container_id
        {
          get { return container_id;}
          set { container_id=value;}
        }
        private string ticket_num;

        public string Ticket_num
        {
          get { return ticket_num;}
          set { ticket_num=value;}
        }
        private decimal net_weight;

        public decimal Net_weight
        {
          get { return net_weight;}
          set { net_weight=value;}
        }
        private DateTime date_time;

        public DateTime Date_time
        {
          get { return date_time;}
          set { date_time=value;}
        }
        private string location_id;

        public string Location_id
        {
          get { return location_id;}
          set { location_id=value;}
        }
        private string status;

        public string Status
        {
          get { return status;}
          set { status=value;}
        }
    }
}
