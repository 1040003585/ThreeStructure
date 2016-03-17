using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Mgr_user_group
    {
        private string group_id;

        public string Group_id
        {
          get { return group_id;}
          set { group_id=value;}
        }
        private string group_name;

        public string Group_name
        {
          get { return group_name;}
          set { group_name=value;}
        }
        private int is_pos;

        public int Is_pos
        {
          get { return is_pos;}
          set { is_pos=value;}
        }
        private string bz;

        public string Bz
        {
          get { return bz;}
          set { bz=value;}
        }
        private string grant_menu;

        public string Grant_menu
        {
          get { return grant_menu;}
          set { grant_menu=value;}
        }
        private string grant_control;

        public string Grant_control
        {
          get { return grant_control;}
          set { grant_control=value;}
        }
        private string grant_other;

        public string Grant_other
        {
          get { return grant_other;}
          set { grant_other=value;}
        }
        private string grant_pos;

        public string Grant_pos
        {
          get { return grant_pos;}
          set { grant_pos=value;}
        }
        private string sss_id;

        public string Sss_id
        {
          get { return sss_id;}
          set { sss_id=value;}
        }
        private string sss;

        public string Sss
        {
          get { return sss;}
          set { sss=value;}
        }
    }
}
