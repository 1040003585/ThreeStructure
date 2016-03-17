using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Wast_user
    {
        private string bh;

        public string Bh
        {
          get { return bh;}
          set { bh=value;}
        }
        private string user_id;

        public string User_id
        {
          get { return user_id;}
          set { user_id=value;}
        }
        private string user_name;

        public string User_name
        {
          get { return user_name;}
          set { user_name=value;}
        }
        private string group_id;

        public string Group_id
        {
          get { return group_id;}
          set { group_id=value;}
        }
        private string password;

        public string Password
        {
          get { return password;}
          set { password=value;}
        }
        private string pass_check;

        public string Pass_check
        {
          get { return pass_check;}
          set { pass_check=value;}
        }
        private int status;

        public int Status
        {
          get { return status;}
          set { status=value;}
        }
        private DateTime last_in;

        public DateTime Last_in
        {
          get { return last_in;}
          set { last_in=value;}
        }
        private int is_pos;

        public int Is_pos
        {
          get { return is_pos;}
          set { is_pos=value;}
        }
        private byte client_lr;

        public byte Client_lr
        {
          get { return client_lr;}
          set { client_lr=value;}
        }
    }
}
