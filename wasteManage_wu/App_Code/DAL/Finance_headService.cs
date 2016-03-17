using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Finance_headService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Finance_head">Finance_head实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Finance_head model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@billing_id",model.Billing_id),
                new SqlParameter ("@ticket_num",model.Ticket_num),
                new SqlParameter ("@waste_id",model.Waste_id),
                new SqlParameter ("@collector_num",model.Collector_num),
                new SqlParameter ("@charging",model.Charging),
                new SqlParameter ("@weight",model.Weight),
                new SqlParameter ("@customer_num",model.Customer_num),
                new SqlParameter ("@processing_date",model.Processing_date),
                new SqlParameter ("@yyy",model.Yyy),
                new SqlParameter ("@zdr",model.Zdr),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@zy",model.Zy),
                new SqlParameter ("@old_billing",model.Old_billing),
                new SqlParameter ("@zh",model.Zh),
                new SqlParameter ("@charging_js",model.Charging_js),
                new SqlParameter ("@charging_yj",model.Charging_yj),
                new SqlParameter ("@charging_ye",model.Charging_ye),
                new SqlParameter ("@ml",model.Ml),
                new SqlParameter ("@js_date1",model.Js_date1),
                new SqlParameter ("@js_date2",model.Js_date2)
            };
           return Helper .ExecuteNonQuery ("Finance_head_Add",param);
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
           return Helper .ExecuteNonQuery ("Finance_head_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Finance_head">Finance_head实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Finance_head model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@billing_id",model.Billing_id),
                new SqlParameter ("@ticket_num",model.Ticket_num),
                new SqlParameter ("@waste_id",model.Waste_id),
                new SqlParameter ("@collector_num",model.Collector_num),
                new SqlParameter ("@charging",model.Charging),
                new SqlParameter ("@weight",model.Weight),
                new SqlParameter ("@customer_num",model.Customer_num),
                new SqlParameter ("@processing_date",model.Processing_date),
                new SqlParameter ("@yyy",model.Yyy),
                new SqlParameter ("@zdr",model.Zdr),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@zy",model.Zy),
                new SqlParameter ("@old_billing",model.Old_billing),
                new SqlParameter ("@zh",model.Zh),
                new SqlParameter ("@charging_js",model.Charging_js),
                new SqlParameter ("@charging_yj",model.Charging_yj),
                new SqlParameter ("@charging_ye",model.Charging_ye),
                new SqlParameter ("@ml",model.Ml),
                new SqlParameter ("@js_date1",model.Js_date1),
                new SqlParameter ("@js_date2",model.Js_date2)
            };
           return Helper .ExecuteNonQuery ("Finance_head_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Finance_head> selectAll()
        {
            List<Finance_head> list = new List<Finance_head>();
            Finance_head model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Finance_head_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Finance_head();
                    model.Bh = dr["bh"].ToString();
                    model.Billing_id = dr["billing_id"].ToString();
                    if (DBNull.Value!=dr["ticket_num"])
                        model.Ticket_num = dr["ticket_num"].ToString();
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["collector_num"])
                        model.Collector_num = dr["collector_num"].ToString();
                    model.Charging= Convert.ToDecimal(dr["charging"]);
                    model.Weight= Convert.ToDecimal(dr["weight"]);
                    if (DBNull.Value!=dr["customer_num"])
                        model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["processing_date"])
                        model.Processing_date= Convert.ToDateTime(dr["processing_date"]);
                    if (DBNull.Value!=dr["yyy"])
                        model.Yyy = dr["yyy"].ToString();
                    if (DBNull.Value!=dr["zdr"])
                        model.Zdr = dr["zdr"].ToString();
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["zy"])
                        model.Zy = dr["zy"].ToString();
                    if (DBNull.Value!=dr["old_billing"])
                        model.Old_billing = dr["old_billing"].ToString();
                    if (DBNull.Value!=dr["zh"])
                        model.Zh = dr["zh"].ToString();
                    if (DBNull.Value!=dr["charging_js"])
                        model.Charging_js= Convert.ToDecimal(dr["charging_js"]);
                    if (DBNull.Value!=dr["charging_yj"])
                        model.Charging_yj= Convert.ToDecimal(dr["charging_yj"]);
                    if (DBNull.Value!=dr["charging_ye"])
                        model.Charging_ye= Convert.ToDecimal(dr["charging_ye"]);
                    if (DBNull.Value!=dr["ml"])
                        model.Ml= Convert.ToDecimal(dr["ml"]);
                    if (DBNull.Value!=dr["js_date1"])
                        model.Js_date1= Convert.ToDateTime(dr["js_date1"]);
                    if (DBNull.Value!=dr["js_date2"])
                        model.Js_date2= Convert.ToDateTime(dr["js_date2"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Finance_head实体类对象</returns>
        public Finance_head selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Finance_head model = new Finance_head();
            using (SqlDataReader dr = Helper.ExecuteReader("Finance_head_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bh = dr["bh"].ToString();
                    model.Billing_id = dr["billing_id"].ToString();
                    if (DBNull.Value!=dr["ticket_num"])
                        model.Ticket_num = dr["ticket_num"].ToString();
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["collector_num"])
                        model.Collector_num = dr["collector_num"].ToString();
                    model.Charging= Convert.ToDecimal(dr["charging"]);
                    model.Weight= Convert.ToDecimal(dr["weight"]);
                    if (DBNull.Value!=dr["customer_num"])
                        model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["processing_date"])
                        model.Processing_date= Convert.ToDateTime(dr["processing_date"]);
                    if (DBNull.Value!=dr["yyy"])
                        model.Yyy = dr["yyy"].ToString();
                    if (DBNull.Value!=dr["zdr"])
                        model.Zdr = dr["zdr"].ToString();
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["zy"])
                        model.Zy = dr["zy"].ToString();
                    if (DBNull.Value!=dr["old_billing"])
                        model.Old_billing = dr["old_billing"].ToString();
                    if (DBNull.Value!=dr["zh"])
                        model.Zh = dr["zh"].ToString();
                    if (DBNull.Value!=dr["charging_js"])
                        model.Charging_js= Convert.ToDecimal(dr["charging_js"]);
                    if (DBNull.Value!=dr["charging_yj"])
                        model.Charging_yj= Convert.ToDecimal(dr["charging_yj"]);
                    if (DBNull.Value!=dr["charging_ye"])
                        model.Charging_ye= Convert.ToDecimal(dr["charging_ye"]);
                    if (DBNull.Value!=dr["ml"])
                        model.Ml= Convert.ToDecimal(dr["ml"]);
                    if (DBNull.Value!=dr["js_date1"])
                        model.Js_date1= Convert.ToDateTime(dr["js_date1"]);
                    if (DBNull.Value!=dr["js_date2"])
                        model.Js_date2= Convert.ToDateTime(dr["js_date2"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Finance_head实体类对象</returns>
        public List<Finance_head> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Finance_head> list = new List<Finance_head>();
            Finance_head model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Finance_head_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Finance_head();
                    model.Bh = dr["bh"].ToString();
                    model.Billing_id = dr["billing_id"].ToString();
                    if (DBNull.Value!=dr["ticket_num"])
                        model.Ticket_num = dr["ticket_num"].ToString();
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["collector_num"])
                        model.Collector_num = dr["collector_num"].ToString();
                    model.Charging= Convert.ToDecimal(dr["charging"]);
                    model.Weight= Convert.ToDecimal(dr["weight"]);
                    if (DBNull.Value!=dr["customer_num"])
                        model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["processing_date"])
                        model.Processing_date= Convert.ToDateTime(dr["processing_date"]);
                    if (DBNull.Value!=dr["yyy"])
                        model.Yyy = dr["yyy"].ToString();
                    if (DBNull.Value!=dr["zdr"])
                        model.Zdr = dr["zdr"].ToString();
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["zy"])
                        model.Zy = dr["zy"].ToString();
                    if (DBNull.Value!=dr["old_billing"])
                        model.Old_billing = dr["old_billing"].ToString();
                    if (DBNull.Value!=dr["zh"])
                        model.Zh = dr["zh"].ToString();
                    if (DBNull.Value!=dr["charging_js"])
                        model.Charging_js= Convert.ToDecimal(dr["charging_js"]);
                    if (DBNull.Value!=dr["charging_yj"])
                        model.Charging_yj= Convert.ToDecimal(dr["charging_yj"]);
                    if (DBNull.Value!=dr["charging_ye"])
                        model.Charging_ye= Convert.ToDecimal(dr["charging_ye"]);
                    if (DBNull.Value!=dr["ml"])
                        model.Ml= Convert.ToDecimal(dr["ml"]);
                    if (DBNull.Value!=dr["js_date1"])
                        model.Js_date1= Convert.ToDateTime(dr["js_date1"]);
                    if (DBNull.Value!=dr["js_date2"])
                        model.Js_date2= Convert.ToDateTime(dr["js_date2"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

