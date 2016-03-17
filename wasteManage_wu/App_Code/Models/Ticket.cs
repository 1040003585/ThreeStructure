using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Ticket
    {
        private string bh;

        public string Bh
        {
          get { return bh;}
          set { bh=value;}
        }
        private string ticket_num;

        public string Ticket_num
        {
          get { return ticket_num;}
          set { ticket_num=value;}
        }
        private string customer_num;

        public string Customer_num
        {
          get { return customer_num;}
          set { customer_num=value;}
        }
        private string waste_id;

        public string Waste_id
        {
          get { return waste_id;}
          set { waste_id=value;}
        }
        private string collector_num;

        public string Collector_num
        {
          get { return collector_num;}
          set { collector_num=value;}
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
        private DateTime delivery_date;

        public DateTime Delivery_date
        {
          get { return delivery_date;}
          set { delivery_date=value;}
        }
        private string start_point;

        public string Start_point
        {
          get { return start_point;}
          set { start_point=value;}
        }
        private string end_point;

        public string End_point
        {
          get { return end_point;}
          set { end_point=value;}
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
        private decimal total_weight;

        public decimal Total_weight
        {
          get { return total_weight;}
          set { total_weight=value;}
        }
        private int sl;

        public int Sl
        {
          get { return sl;}
          set { sl=value;}
        }
        private string fyr;

        public string Fyr
        {
          get { return fyr;}
          set { fyr=value;}
        }
        private string move_to;

        public string Move_to
        {
          get { return move_to;}
          set { move_to=value;}
        }
        private DateTime rq_yc;

        public DateTime Rq_yc
        {
          get { return rq_yc;}
          set { rq_yc=value;}
        }
        private DateTime rq_ys;

        public DateTime Rq_ys
        {
          get { return rq_ys;}
          set { rq_ys=value;}
        }
        private string fzr;

        public string Fzr
        {
          get { return fzr;}
          set { fzr=value;}
        }
        private DateTime rq_js;

        public DateTime Rq_js
        {
          get { return rq_js;}
          set { rq_js=value;}
        }
        private string cyr;

        public string Cyr
        {
          get { return cyr;}
          set { cyr=value;}
        }
        private string year_yc;

        public string Year_yc
        {
          get { return year_yc;}
          set { year_yc=value;}
        }
        private string month_yc;

        public string Month_yc
        {
          get { return month_yc;}
          set { month_yc=value;}
        }
        private string day_yc;

        public string Day_yc
        {
          get { return day_yc;}
          set { day_yc=value;}
        }
        private string year_ys;

        public string Year_ys
        {
          get { return year_ys;}
          set { year_ys=value;}
        }
        private string month_ys;

        public string Month_ys
        {
          get { return month_ys;}
          set { month_ys=value;}
        }
        private string day_ys;

        public string Day_ys
        {
          get { return day_ys;}
          set { day_ys=value;}
        }
        private string year_js;

        public string Year_js
        {
          get { return year_js;}
          set { year_js=value;}
        }
        private string month_js;

        public string Month_js
        {
          get { return month_js;}
          set { month_js=value;}
        }
        private string day_js;

        public string Day_js
        {
          get { return day_js;}
          set { day_js=value;}
        }
        private string status;

        public string Status
        {
          get { return status;}
          set { status=value;}
        }
        private byte is_cell;

        public byte Is_cell
        {
          get { return is_cell;}
          set { is_cell=value;}
        }
        private byte is_print;

        public byte Is_print
        {
          get { return is_print;}
          set { is_print=value;}
        }
        private string barcode;

        public string Barcode
        {
          get { return barcode;}
          set { barcode=value;}
        }
        private int bar_sl;

        public int Bar_sl
        {
          get { return bar_sl;}
          set { bar_sl=value;}
        }
        private int sl_zf;

        public int Sl_zf
        {
          get { return sl_zf;}
          set { sl_zf=value;}
        }
        private int sl_js;

        public int Sl_js
        {
          get { return sl_js;}
          set { sl_js=value;}
        }
        private string dw;

        public string Dw
        {
          get { return dw;}
          set { dw=value;}
        }
        private string waste_code;

        public string Waste_code
        {
          get { return waste_code;}
          set { waste_code=value;}
        }
        private decimal charging_fee;

        public decimal Charging_fee
        {
          get { return charging_fee;}
          set { charging_fee=value;}
        }
        private decimal treatment_rate;

        public decimal Treatment_rate
        {
          get { return treatment_rate;}
          set { treatment_rate=value;}
        }
        private decimal other_fee;

        public decimal Other_fee
        {
          get { return other_fee;}
          set { other_fee=value;}
        }
        private string order_num;

        public string Order_num
        {
          get { return order_num;}
          set { order_num=value;}
        }
        private string ht_bm;

        public string Ht_bm
        {
          get { return ht_bm;}
          set { ht_bm=value;}
        }
        private string ys_tel;

        public string Ys_tel
        {
          get { return ys_tel;}
          set { ys_tel=value;}
        }
        private string ys_address;

        public string Ys_address
        {
          get { return ys_address;}
          set { ys_address=value;}
        }
        private string ys_mail;

        public string Ys_mail
        {
          get { return ys_mail;}
          set { ys_mail=value;}
        }
        private decimal charging_zz;

        public decimal Charging_zz
        {
          get { return charging_zz;}
          set { charging_zz=value;}
        }
        private decimal charging_js;

        public decimal Charging_js
        {
          get { return charging_js;}
          set { charging_js=value;}
        }
        private decimal charging_ye;

        public decimal Charging_ye
        {
          get { return charging_ye;}
          set { charging_ye=value;}
        }
        private byte finance_flag;

        public byte Finance_flag
        {
          get { return finance_flag;}
          set { finance_flag=value;}
        }
        private byte lock;

        public byte Lock
        {
          get { return lock;}
          set { lock=value;}
        }
        private string ys_lxr;

        public string Ys_lxr
        {
          get { return ys_lxr;}
          set { ys_lxr=value;}
        }
        private DateTime htq1;

        public DateTime Htq1
        {
          get { return htq1;}
          set { htq1=value;}
        }
        private DateTime htq2;

        public DateTime Htq2
        {
          get { return htq2;}
          set { htq2=value;}
        }
    }
}
