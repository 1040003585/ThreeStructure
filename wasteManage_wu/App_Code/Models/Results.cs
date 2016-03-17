using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Results
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
        private string profile_id;

        public string Profile_id
        {
          get { return profile_id;}
          set { profile_id=value;}
        }
        private string component_name;

        public string Component_name
        {
          get { return component_name;}
          set { component_name=value;}
        }
        private string result;

        public string Result
        {
          get { return result;}
          set { result=value;}
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
