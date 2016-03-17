using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Sys_format_display
    {
        private string win_name;

        public string Win_name
        {
          get { return win_name;}
          set { win_name=value;}
        }
        private string dw_name;

        public string Dw_name
        {
          get { return dw_name;}
          set { dw_name=value;}
        }
        private string col_no;

        public string Col_no
        {
          get { return col_no;}
          set { col_no=value;}
        }
        private string col_name;

        public string Col_name
        {
          get { return col_name;}
          set { col_name=value;}
        }
        private int xh;

        public int Xh
        {
          get { return xh;}
          set { xh=value;}
        }
        private string display_name;

        public string Display_name
        {
          get { return display_name;}
          set { display_name=value;}
        }
        private int col_width;

        public int Col_width
        {
          get { return col_width;}
          set { col_width=value;}
        }
        private Single col_x;

        public Single Col_x
        {
          get { return col_x;}
          set { col_x=value;}
        }
        private int is_display;

        public int Is_display
        {
          get { return is_display;}
          set { is_display=value;}
        }
        private int is_edit;

        public int Is_edit
        {
          get { return is_edit;}
          set { is_edit=value;}
        }
        private int is_edit_sys;

        public int Is_edit_sys
        {
          get { return is_edit_sys;}
          set { is_edit_sys=value;}
        }
    }
}
