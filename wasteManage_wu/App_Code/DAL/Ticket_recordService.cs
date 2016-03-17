using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Ticket_recordService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Ticket_record">Ticket_record实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Ticket_record model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@ticket_num",model.Ticket_num),
                new SqlParameter ("@customer_num",model.Customer_num),
                new SqlParameter ("@waste_id",model.Waste_id),
                new SqlParameter ("@collector_num",model.Collector_num),
                new SqlParameter ("@vehicle_num",model.Vehicle_num),
                new SqlParameter ("@driver_name",model.Driver_name),
                new SqlParameter ("@delivery_date",model.Delivery_date),
                new SqlParameter ("@start_point",model.Start_point),
                new SqlParameter ("@end_point",model.End_point),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@updated_by",model.Updated_by),
                new SqlParameter ("@update_date",model.Update_date),
                new SqlParameter ("@total_weight",model.Total_weight),
                new SqlParameter ("@sl",model.Sl),
                new SqlParameter ("@fyr",model.Fyr),
                new SqlParameter ("@move_to",model.Move_to),
                new SqlParameter ("@rq_yc",model.Rq_yc),
                new SqlParameter ("@rq_ys",model.Rq_ys),
                new SqlParameter ("@fzr",model.Fzr),
                new SqlParameter ("@rq_js",model.Rq_js),
                new SqlParameter ("@cyr",model.Cyr),
                new SqlParameter ("@year_yc",model.Year_yc),
                new SqlParameter ("@month_yc",model.Month_yc),
                new SqlParameter ("@day_yc",model.Day_yc),
                new SqlParameter ("@year_ys",model.Year_ys),
                new SqlParameter ("@month_ys",model.Month_ys),
                new SqlParameter ("@day_ys",model.Day_ys),
                new SqlParameter ("@year_js",model.Year_js),
                new SqlParameter ("@month_js",model.Month_js),
                new SqlParameter ("@day_js",model.Day_js),
                new SqlParameter ("@status",model.Status),
                new SqlParameter ("@is_cell",model.Is_cell),
                new SqlParameter ("@is_print",model.Is_print),
                new SqlParameter ("@barcode",model.Barcode),
                new SqlParameter ("@bar_sl",model.Bar_sl)
            };
           return Helper .ExecuteNonQuery ("Ticket_record_Add",param);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool delete(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
           return Helper .ExecuteNonQuery ("Ticket_record_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Ticket_record">Ticket_record实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Ticket_record model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@ticket_num",model.Ticket_num),
                new SqlParameter ("@customer_num",model.Customer_num),
                new SqlParameter ("@waste_id",model.Waste_id),
                new SqlParameter ("@collector_num",model.Collector_num),
                new SqlParameter ("@vehicle_num",model.Vehicle_num),
                new SqlParameter ("@driver_name",model.Driver_name),
                new SqlParameter ("@delivery_date",model.Delivery_date),
                new SqlParameter ("@start_point",model.Start_point),
                new SqlParameter ("@end_point",model.End_point),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@updated_by",model.Updated_by),
                new SqlParameter ("@update_date",model.Update_date),
                new SqlParameter ("@total_weight",model.Total_weight),
                new SqlParameter ("@sl",model.Sl),
                new SqlParameter ("@fyr",model.Fyr),
                new SqlParameter ("@move_to",model.Move_to),
                new SqlParameter ("@rq_yc",model.Rq_yc),
                new SqlParameter ("@rq_ys",model.Rq_ys),
                new SqlParameter ("@fzr",model.Fzr),
                new SqlParameter ("@rq_js",model.Rq_js),
                new SqlParameter ("@cyr",model.Cyr),
                new SqlParameter ("@year_yc",model.Year_yc),
                new SqlParameter ("@month_yc",model.Month_yc),
                new SqlParameter ("@day_yc",model.Day_yc),
                new SqlParameter ("@year_ys",model.Year_ys),
                new SqlParameter ("@month_ys",model.Month_ys),
                new SqlParameter ("@day_ys",model.Day_ys),
                new SqlParameter ("@year_js",model.Year_js),
                new SqlParameter ("@month_js",model.Month_js),
                new SqlParameter ("@day_js",model.Day_js),
                new SqlParameter ("@status",model.Status),
                new SqlParameter ("@is_cell",model.Is_cell),
                new SqlParameter ("@is_print",model.Is_print),
                new SqlParameter ("@barcode",model.Barcode),
                new SqlParameter ("@bar_sl",model.Bar_sl)
            };
           return Helper .ExecuteNonQuery ("Ticket_record_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Ticket_record> selectAll()
        {
            List<Ticket_record> list = new List<Ticket_record>();
            Ticket_record model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Ticket_record_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Ticket_record();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Ticket_num = dr["ticket_num"].ToString();
                    if (DBNull.Value!=dr["customer_num"])
                        model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["collector_num"])
                        model.Collector_num = dr["collector_num"].ToString();
                    if (DBNull.Value!=dr["vehicle_num"])
                        model.Vehicle_num = dr["vehicle_num"].ToString();
                    if (DBNull.Value!=dr["driver_name"])
                        model.Driver_name = dr["driver_name"].ToString();
                    if (DBNull.Value!=dr["delivery_date"])
                        model.Delivery_date= Convert.ToDateTime(dr["delivery_date"]);
                    if (DBNull.Value!=dr["start_point"])
                        model.Start_point = dr["start_point"].ToString();
                    if (DBNull.Value!=dr["end_point"])
                        model.End_point = dr["end_point"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["total_weight"])
                        model.Total_weight= Convert.ToDecimal(dr["total_weight"]);
                    if (DBNull.Value!=dr["sl"])
                        model.Sl= Convert.ToInt32(dr["sl"]);
                    if (DBNull.Value!=dr["fyr"])
                        model.Fyr = dr["fyr"].ToString();
                    if (DBNull.Value!=dr["move_to"])
                        model.Move_to = dr["move_to"].ToString();
                    if (DBNull.Value!=dr["rq_yc"])
                        model.Rq_yc= Convert.ToDateTime(dr["rq_yc"]);
                    if (DBNull.Value!=dr["rq_ys"])
                        model.Rq_ys= Convert.ToDateTime(dr["rq_ys"]);
                    if (DBNull.Value!=dr["fzr"])
                        model.Fzr = dr["fzr"].ToString();
                    if (DBNull.Value!=dr["rq_js"])
                        model.Rq_js= Convert.ToDateTime(dr["rq_js"]);
                    if (DBNull.Value!=dr["cyr"])
                        model.Cyr = dr["cyr"].ToString();
                    if (DBNull.Value!=dr["year_yc"])
                        model.Year_yc = dr["year_yc"].ToString();
                    if (DBNull.Value!=dr["month_yc"])
                        model.Month_yc = dr["month_yc"].ToString();
                    if (DBNull.Value!=dr["day_yc"])
                        model.Day_yc = dr["day_yc"].ToString();
                    if (DBNull.Value!=dr["year_ys"])
                        model.Year_ys = dr["year_ys"].ToString();
                    if (DBNull.Value!=dr["month_ys"])
                        model.Month_ys = dr["month_ys"].ToString();
                    if (DBNull.Value!=dr["day_ys"])
                        model.Day_ys = dr["day_ys"].ToString();
                    if (DBNull.Value!=dr["year_js"])
                        model.Year_js = dr["year_js"].ToString();
                    if (DBNull.Value!=dr["month_js"])
                        model.Month_js = dr["month_js"].ToString();
                    if (DBNull.Value!=dr["day_js"])
                        model.Day_js = dr["day_js"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                    if (DBNull.Value!=dr["is_cell"])
                        model.Is_cell= Convert.ToByte(dr["is_cell"]);
                    if (DBNull.Value!=dr["is_print"])
                        model.Is_print= Convert.ToByte(dr["is_print"]);
                    if (DBNull.Value!=dr["barcode"])
                        model.Barcode = dr["barcode"].ToString();
                    if (DBNull.Value!=dr["bar_sl"])
                        model.Bar_sl= Convert.ToInt32(dr["bar_sl"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Ticket_record实体类对象</returns>
        public Ticket_record selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Ticket_record model = new Ticket_record();
            using (SqlDataReader dr = Helper.ExecuteReader("Ticket_record_SelectById", param))
            {
                if (dr.Read())
                {
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Ticket_num = dr["ticket_num"].ToString();
                    if (DBNull.Value!=dr["customer_num"])
                        model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["collector_num"])
                        model.Collector_num = dr["collector_num"].ToString();
                    if (DBNull.Value!=dr["vehicle_num"])
                        model.Vehicle_num = dr["vehicle_num"].ToString();
                    if (DBNull.Value!=dr["driver_name"])
                        model.Driver_name = dr["driver_name"].ToString();
                    if (DBNull.Value!=dr["delivery_date"])
                        model.Delivery_date= Convert.ToDateTime(dr["delivery_date"]);
                    if (DBNull.Value!=dr["start_point"])
                        model.Start_point = dr["start_point"].ToString();
                    if (DBNull.Value!=dr["end_point"])
                        model.End_point = dr["end_point"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["total_weight"])
                        model.Total_weight= Convert.ToDecimal(dr["total_weight"]);
                    if (DBNull.Value!=dr["sl"])
                        model.Sl= Convert.ToInt32(dr["sl"]);
                    if (DBNull.Value!=dr["fyr"])
                        model.Fyr = dr["fyr"].ToString();
                    if (DBNull.Value!=dr["move_to"])
                        model.Move_to = dr["move_to"].ToString();
                    if (DBNull.Value!=dr["rq_yc"])
                        model.Rq_yc= Convert.ToDateTime(dr["rq_yc"]);
                    if (DBNull.Value!=dr["rq_ys"])
                        model.Rq_ys= Convert.ToDateTime(dr["rq_ys"]);
                    if (DBNull.Value!=dr["fzr"])
                        model.Fzr = dr["fzr"].ToString();
                    if (DBNull.Value!=dr["rq_js"])
                        model.Rq_js= Convert.ToDateTime(dr["rq_js"]);
                    if (DBNull.Value!=dr["cyr"])
                        model.Cyr = dr["cyr"].ToString();
                    if (DBNull.Value!=dr["year_yc"])
                        model.Year_yc = dr["year_yc"].ToString();
                    if (DBNull.Value!=dr["month_yc"])
                        model.Month_yc = dr["month_yc"].ToString();
                    if (DBNull.Value!=dr["day_yc"])
                        model.Day_yc = dr["day_yc"].ToString();
                    if (DBNull.Value!=dr["year_ys"])
                        model.Year_ys = dr["year_ys"].ToString();
                    if (DBNull.Value!=dr["month_ys"])
                        model.Month_ys = dr["month_ys"].ToString();
                    if (DBNull.Value!=dr["day_ys"])
                        model.Day_ys = dr["day_ys"].ToString();
                    if (DBNull.Value!=dr["year_js"])
                        model.Year_js = dr["year_js"].ToString();
                    if (DBNull.Value!=dr["month_js"])
                        model.Month_js = dr["month_js"].ToString();
                    if (DBNull.Value!=dr["day_js"])
                        model.Day_js = dr["day_js"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                    if (DBNull.Value!=dr["is_cell"])
                        model.Is_cell= Convert.ToByte(dr["is_cell"]);
                    if (DBNull.Value!=dr["is_print"])
                        model.Is_print= Convert.ToByte(dr["is_print"]);
                    if (DBNull.Value!=dr["barcode"])
                        model.Barcode = dr["barcode"].ToString();
                    if (DBNull.Value!=dr["bar_sl"])
                        model.Bar_sl= Convert.ToInt32(dr["bar_sl"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Ticket_record实体类对象</returns>
        public List<Ticket_record> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Ticket_record> list = new List<Ticket_record>();
            Ticket_record model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Ticket_record_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Ticket_record();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Ticket_num = dr["ticket_num"].ToString();
                    if (DBNull.Value!=dr["customer_num"])
                        model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["collector_num"])
                        model.Collector_num = dr["collector_num"].ToString();
                    if (DBNull.Value!=dr["vehicle_num"])
                        model.Vehicle_num = dr["vehicle_num"].ToString();
                    if (DBNull.Value!=dr["driver_name"])
                        model.Driver_name = dr["driver_name"].ToString();
                    if (DBNull.Value!=dr["delivery_date"])
                        model.Delivery_date= Convert.ToDateTime(dr["delivery_date"]);
                    if (DBNull.Value!=dr["start_point"])
                        model.Start_point = dr["start_point"].ToString();
                    if (DBNull.Value!=dr["end_point"])
                        model.End_point = dr["end_point"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["total_weight"])
                        model.Total_weight= Convert.ToDecimal(dr["total_weight"]);
                    if (DBNull.Value!=dr["sl"])
                        model.Sl= Convert.ToInt32(dr["sl"]);
                    if (DBNull.Value!=dr["fyr"])
                        model.Fyr = dr["fyr"].ToString();
                    if (DBNull.Value!=dr["move_to"])
                        model.Move_to = dr["move_to"].ToString();
                    if (DBNull.Value!=dr["rq_yc"])
                        model.Rq_yc= Convert.ToDateTime(dr["rq_yc"]);
                    if (DBNull.Value!=dr["rq_ys"])
                        model.Rq_ys= Convert.ToDateTime(dr["rq_ys"]);
                    if (DBNull.Value!=dr["fzr"])
                        model.Fzr = dr["fzr"].ToString();
                    if (DBNull.Value!=dr["rq_js"])
                        model.Rq_js= Convert.ToDateTime(dr["rq_js"]);
                    if (DBNull.Value!=dr["cyr"])
                        model.Cyr = dr["cyr"].ToString();
                    if (DBNull.Value!=dr["year_yc"])
                        model.Year_yc = dr["year_yc"].ToString();
                    if (DBNull.Value!=dr["month_yc"])
                        model.Month_yc = dr["month_yc"].ToString();
                    if (DBNull.Value!=dr["day_yc"])
                        model.Day_yc = dr["day_yc"].ToString();
                    if (DBNull.Value!=dr["year_ys"])
                        model.Year_ys = dr["year_ys"].ToString();
                    if (DBNull.Value!=dr["month_ys"])
                        model.Month_ys = dr["month_ys"].ToString();
                    if (DBNull.Value!=dr["day_ys"])
                        model.Day_ys = dr["day_ys"].ToString();
                    if (DBNull.Value!=dr["year_js"])
                        model.Year_js = dr["year_js"].ToString();
                    if (DBNull.Value!=dr["month_js"])
                        model.Month_js = dr["month_js"].ToString();
                    if (DBNull.Value!=dr["day_js"])
                        model.Day_js = dr["day_js"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                    if (DBNull.Value!=dr["is_cell"])
                        model.Is_cell= Convert.ToByte(dr["is_cell"]);
                    if (DBNull.Value!=dr["is_print"])
                        model.Is_print= Convert.ToByte(dr["is_print"]);
                    if (DBNull.Value!=dr["barcode"])
                        model.Barcode = dr["barcode"].ToString();
                    if (DBNull.Value!=dr["bar_sl"])
                        model.Bar_sl= Convert.ToInt32(dr["bar_sl"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

