using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Foot_status
    {
        private string win;

        public string Win
        {
          get { return win;}
          set { win=value;}
        }
        private int clear_win;

        public int Clear_win
        {
          get { return clear_win;}
          set { clear_win=value;}
        }
        private int exit_win;

        public int Exit_win
        {
          get { return exit_win;}
          set { exit_win=value;}
        }
    }
}
