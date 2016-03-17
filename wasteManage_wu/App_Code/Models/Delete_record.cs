using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Delete_record
    {
        private string delete_sql;

        public string Delete_sql
        {
          get { return delete_sql;}
          set { delete_sql=value;}
        }
        private string bh;

        public string Bh
        {
          get { return bh;}
          set { bh=value;}
        }
        private string deleted_by;

        public string Deleted_by
        {
          get { return deleted_by;}
          set { deleted_by=value;}
        }
        private DateTime delete_date;

        public DateTime Delete_date
        {
          get { return delete_date;}
          set { delete_date=value;}
        }
        private string djlx;

        public string Djlx
        {
          get { return djlx;}
          set { djlx=value;}
        }
    }
}
