using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Collector
    {
        private string bh;

        public string Bh
        {
          get { return bh;}
          set { bh=value;}
        }
        private string collector_num;

        public string Collector_num
        {
          get { return collector_num;}
          set { collector_num=value;}
        }
        private string collector_name;

        public string Collector_name
        {
          get { return collector_name;}
          set { collector_name=value;}
        }
        private string address;

        public string Address
        {
          get { return address;}
          set { address=value;}
        }
        private string telephone_no;

        public string Telephone_no
        {
          get { return telephone_no;}
          set { telephone_no=value;}
        }
        private string mail;

        public string Mail
        {
          get { return mail;}
          set { mail=value;}
        }
        private string contact_person;

        public string Contact_person
        {
          get { return contact_person;}
          set { contact_person=value;}
        }
        private string contact_phone_no;

        public string Contact_phone_no
        {
          get { return contact_phone_no;}
          set { contact_phone_no=value;}
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
        private string vehicle_num;

        public string Vehicle_num
        {
          get { return vehicle_num;}
          set { vehicle_num=value;}
        }
        private string driver_name;

        public string Driver_name
        {
          get { return driver_name;}
          set { driver_name=value;}
        }
        private string lxr;

        public string Lxr
        {
          get { return lxr;}
          set { lxr=value;}
        }
    }
}
