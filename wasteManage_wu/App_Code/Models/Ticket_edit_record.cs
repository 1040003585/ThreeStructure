using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Ticket_edit_record
    {
        private int bm;

        public int Bm
        {
          get { return bm;}
          set { bm=value;}
        }
        private string ticket_num;

        public string Ticket_num
        {
          get { return ticket_num;}
          set { ticket_num=value;}
        }
        private string edited_by;

        public string Edited_by
        {
          get { return edited_by;}
          set { edited_by=value;}
        }
        private DateTime edit_date;

        public DateTime Edit_date
        {
          get { return edit_date;}
          set { edit_date=value;}
        }
        private int sl;

        public int Sl
        {
          get { return sl;}
          set { sl=value;}
        }
        private byte is_begian;

        public byte Is_begian
        {
          get { return is_begian;}
          set { is_begian=value;}
        }
    }
}
