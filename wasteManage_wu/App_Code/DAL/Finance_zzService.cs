using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Finance_zzService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Finance_zz">Finance_zz实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Finance_zz model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@ticket_num",model.Ticket_num),
                new SqlParameter ("@billing_id",model.Billing_id),
                new SqlParameter ("@customer_num",model.Customer_num),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@waste_id",model.Waste_id),
                new SqlParameter ("@collector_num",model.Collector_num),
                new SqlParameter ("@charging_all",model.Charging_all),
                new SqlParameter ("@zr",model.Zr),
                new SqlParameter ("@charging_js",model.Charging_js),
                new SqlParameter ("@charging_ye",model.Charging_ye),
                new SqlParameter ("@sl",model.Sl),
                new SqlParameter ("@js_sl",model.Js_sl),
                new SqlParameter ("@zf_sl",model.Zf_sl),
                new SqlParameter ("@weight",model.Weight),
                new SqlParameter ("@js_weight",model.Js_weight),
                new SqlParameter ("@yyy",model.Yyy),
                new SqlParameter ("@created_by",model.Created_by)
            };
           return Helper .ExecuteNonQuery ("Finance_zz_Add",param);
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
           return Helper .ExecuteNonQuery ("Finance_zz_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Finance_zz">Finance_zz实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Finance_zz model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@ticket_num",model.Ticket_num),
                new SqlParameter ("@billing_id",model.Billing_id),
                new SqlParameter ("@customer_num",model.Customer_num),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@waste_id",model.Waste_id),
                new SqlParameter ("@collector_num",model.Collector_num),
                new SqlParameter ("@charging_all",model.Charging_all),
                new SqlParameter ("@zr",model.Zr),
                new SqlParameter ("@charging_js",model.Charging_js),
                new SqlParameter ("@charging_ye",model.Charging_ye),
                new SqlParameter ("@sl",model.Sl),
                new SqlParameter ("@js_sl",model.Js_sl),
                new SqlParameter ("@zf_sl",model.Zf_sl),
                new SqlParameter ("@weight",model.Weight),
                new SqlParameter ("@js_weight",model.Js_weight),
                new SqlParameter ("@yyy",model.Yyy),
                new SqlParameter ("@created_by",model.Created_by)
            };
           return Helper .ExecuteNonQuery ("Finance_zz_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Finance_zz> selectAll()
        {
            List<Finance_zz> list = new List<Finance_zz>();
            Finance_zz model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Finance_zz_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Finance_zz();
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["ticket_num"])
                        model.Ticket_num = dr["ticket_num"].ToString();
                    if (DBNull.Value!=dr["billing_id"])
                        model.Billing_id = dr["billing_id"].ToString();
                    model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["collector_num"])
                        model.Collector_num = dr["collector_num"].ToString();
                    model.Charging_all= Convert.ToDecimal(dr["charging_all"]);
                    model.Zr= Convert.ToDecimal(dr["zr"]);
                    model.Charging_js= Convert.ToDecimal(dr["charging_js"]);
                    model.Charging_ye= Convert.ToDecimal(dr["charging_ye"]);
                    model.Sl= Convert.ToInt32(dr["sl"]);
                    model.Js_sl= Convert.ToInt32(dr["js_sl"]);
                    model.Zf_sl= Convert.ToInt32(dr["zf_sl"]);
                    model.Weight= Convert.ToDecimal(dr["weight"]);
                    model.Js_weight= Convert.ToDecimal(dr["js_weight"]);
                    if (DBNull.Value!=dr["yyy"])
                        model.Yyy = dr["yyy"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Finance_zz实体类对象</returns>
        public Finance_zz selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Finance_zz model = new Finance_zz();
            using (SqlDataReader dr = Helper.ExecuteReader("Finance_zz_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["ticket_num"])
                        model.Ticket_num = dr["ticket_num"].ToString();
                    if (DBNull.Value!=dr["billing_id"])
                        model.Billing_id = dr["billing_id"].ToString();
                    model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["collector_num"])
                        model.Collector_num = dr["collector_num"].ToString();
                    model.Charging_all= Convert.ToDecimal(dr["charging_all"]);
                    model.Zr= Convert.ToDecimal(dr["zr"]);
                    model.Charging_js= Convert.ToDecimal(dr["charging_js"]);
                    model.Charging_ye= Convert.ToDecimal(dr["charging_ye"]);
                    model.Sl= Convert.ToInt32(dr["sl"]);
                    model.Js_sl= Convert.ToInt32(dr["js_sl"]);
                    model.Zf_sl= Convert.ToInt32(dr["zf_sl"]);
                    model.Weight= Convert.ToDecimal(dr["weight"]);
                    model.Js_weight= Convert.ToDecimal(dr["js_weight"]);
                    if (DBNull.Value!=dr["yyy"])
                        model.Yyy = dr["yyy"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Finance_zz实体类对象</returns>
        public List<Finance_zz> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Finance_zz> list = new List<Finance_zz>();
            Finance_zz model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Finance_zz_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Finance_zz();
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["ticket_num"])
                        model.Ticket_num = dr["ticket_num"].ToString();
                    if (DBNull.Value!=dr["billing_id"])
                        model.Billing_id = dr["billing_id"].ToString();
                    model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["collector_num"])
                        model.Collector_num = dr["collector_num"].ToString();
                    model.Charging_all= Convert.ToDecimal(dr["charging_all"]);
                    model.Zr= Convert.ToDecimal(dr["zr"]);
                    model.Charging_js= Convert.ToDecimal(dr["charging_js"]);
                    model.Charging_ye= Convert.ToDecimal(dr["charging_ye"]);
                    model.Sl= Convert.ToInt32(dr["sl"]);
                    model.Js_sl= Convert.ToInt32(dr["js_sl"]);
                    model.Zf_sl= Convert.ToInt32(dr["zf_sl"]);
                    model.Weight= Convert.ToDecimal(dr["weight"]);
                    model.Js_weight= Convert.ToDecimal(dr["js_weight"]);
                    if (DBNull.Value!=dr["yyy"])
                        model.Yyy = dr["yyy"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

