using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Net_computer
    {
        private string computer_ip;

        public string Computer_ip
        {
          get { return computer_ip;}
          set { computer_ip=value;}
        }
        private string computer_name;

        public string Computer_name
        {
          get { return computer_name;}
          set { computer_name=value;}
        }
        private byte is_connect;

        public byte Is_connect
        {
          get { return is_connect;}
          set { is_connect=value;}
        }
        private string is_net;

        public string Is_net
        {
          get { return is_net;}
          set { is_net=value;}
        }
        private string computer_type;

        public string Computer_type
        {
          get { return computer_type;}
          set { computer_type=value;}
        }
    }
}
