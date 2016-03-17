using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class FinanceService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Finance">Finance实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Finance model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@processing_date",model.Processing_date),
                new SqlParameter ("@ticket_num",model.Ticket_num),
                new SqlParameter ("@container_id",model.Container_id),
                new SqlParameter ("@waste_id",model.Waste_id),
                new SqlParameter ("@weight",model.Weight),
                new SqlParameter ("@charging",model.Charging),
                new SqlParameter ("@billing_id",model.Billing_id),
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@yyy",model.Yyy),
                new SqlParameter ("@zdr",model.Zdr),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@zy",model.Zy),
                new SqlParameter ("@charging_fee",model.Charging_fee),
                new SqlParameter ("@other_fee",model.Other_fee),
                new SqlParameter ("@treatment_rate",model.Treatment_rate),
                new SqlParameter ("@treatment_je",model.Treatment_je),
                new SqlParameter ("@charging_zz",model.Charging_zz),
                new SqlParameter ("@charging_yjs",model.Charging_yjs),
                new SqlParameter ("@charging_wjs",model.Charging_wjs)
            };
           return Helper .ExecuteNonQuery ("Finance_Add",param);
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
                new SqlParameter ("@processing_date",Id)
            };
           return Helper .ExecuteNonQuery ("Finance_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Finance">Finance实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Finance model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@processing_date",model.Processing_date),
                new SqlParameter ("@ticket_num",model.Ticket_num),
                new SqlParameter ("@container_id",model.Container_id),
                new SqlParameter ("@waste_id",model.Waste_id),
                new SqlParameter ("@weight",model.Weight),
                new SqlParameter ("@charging",model.Charging),
                new SqlParameter ("@billing_id",model.Billing_id),
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@yyy",model.Yyy),
                new SqlParameter ("@zdr",model.Zdr),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@zy",model.Zy),
                new SqlParameter ("@charging_fee",model.Charging_fee),
                new SqlParameter ("@other_fee",model.Other_fee),
                new SqlParameter ("@treatment_rate",model.Treatment_rate),
                new SqlParameter ("@treatment_je",model.Treatment_je),
                new SqlParameter ("@charging_zz",model.Charging_zz),
                new SqlParameter ("@charging_yjs",model.Charging_yjs),
                new SqlParameter ("@charging_wjs",model.Charging_wjs)
            };
           return Helper .ExecuteNonQuery ("Finance_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Finance> selectAll()
        {
            List<Finance> list = new List<Finance>();
            Finance model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Finance_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Finance();
                    if (DBNull.Value!=dr["processing_date"])
                        model.Processing_date= Convert.ToDateTime(dr["processing_date"]);
                    if (DBNull.Value!=dr["ticket_num"])
                        model.Ticket_num = dr["ticket_num"].ToString();
                    model.Container_id = dr["container_id"].ToString();
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["weight"])
                        model.Weight= Convert.ToDecimal(dr["weight"]);
                    if (DBNull.Value!=dr["charging"])
                        model.Charging= Convert.ToDecimal(dr["charging"]);
                    model.Billing_id = dr["billing_id"].ToString();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["yyy"])
                        model.Yyy = dr["yyy"].ToString();
                    if (DBNull.Value!=dr["zdr"])
                        model.Zdr = dr["zdr"].ToString();
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["zy"])
                        model.Zy = dr["zy"].ToString();
                    if (DBNull.Value!=dr["charging_fee"])
                        model.Charging_fee= Convert.ToDecimal(dr["charging_fee"]);
                    if (DBNull.Value!=dr["other_fee"])
                        model.Other_fee= Convert.ToDecimal(dr["other_fee"]);
                    if (DBNull.Value!=dr["treatment_rate"])
                        model.Treatment_rate= Convert.ToDecimal(dr["treatment_rate"]);
                    if (DBNull.Value!=dr["treatment_je"])
                        model.Treatment_je= Convert.ToDecimal(dr["treatment_je"]);
                    if (DBNull.Value!=dr["charging_zz"])
                        model.Charging_zz= Convert.ToDecimal(dr["charging_zz"]);
                    if (DBNull.Value!=dr["charging_yjs"])
                        model.Charging_yjs= Convert.ToDecimal(dr["charging_yjs"]);
                    if (DBNull.Value!=dr["charging_wjs"])
                        model.Charging_wjs= Convert.ToDecimal(dr["charging_wjs"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Finance实体类对象</returns>
        public Finance selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@processing_date",Id)
            };
            Finance model = new Finance();
            using (SqlDataReader dr = Helper.ExecuteReader("Finance_SelectById", param))
            {
                if (dr.Read())
                {
                    if (DBNull.Value!=dr["processing_date"])
                        model.Processing_date= Convert.ToDateTime(dr["processing_date"]);
                    if (DBNull.Value!=dr["ticket_num"])
                        model.Ticket_num = dr["ticket_num"].ToString();
                    model.Container_id = dr["container_id"].ToString();
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["weight"])
                        model.Weight= Convert.ToDecimal(dr["weight"]);
                    if (DBNull.Value!=dr["charging"])
                        model.Charging= Convert.ToDecimal(dr["charging"]);
                    model.Billing_id = dr["billing_id"].ToString();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["yyy"])
                        model.Yyy = dr["yyy"].ToString();
                    if (DBNull.Value!=dr["zdr"])
                        model.Zdr = dr["zdr"].ToString();
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["zy"])
                        model.Zy = dr["zy"].ToString();
                    if (DBNull.Value!=dr["charging_fee"])
                        model.Charging_fee= Convert.ToDecimal(dr["charging_fee"]);
                    if (DBNull.Value!=dr["other_fee"])
                        model.Other_fee= Convert.ToDecimal(dr["other_fee"]);
                    if (DBNull.Value!=dr["treatment_rate"])
                        model.Treatment_rate= Convert.ToDecimal(dr["treatment_rate"]);
                    if (DBNull.Value!=dr["treatment_je"])
                        model.Treatment_je= Convert.ToDecimal(dr["treatment_je"]);
                    if (DBNull.Value!=dr["charging_zz"])
                        model.Charging_zz= Convert.ToDecimal(dr["charging_zz"]);
                    if (DBNull.Value!=dr["charging_yjs"])
                        model.Charging_yjs= Convert.ToDecimal(dr["charging_yjs"]);
                    if (DBNull.Value!=dr["charging_wjs"])
                        model.Charging_wjs= Convert.ToDecimal(dr["charging_wjs"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Finance实体类对象</returns>
        public List<Finance> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Finance> list = new List<Finance>();
            Finance model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Finance_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Finance();
                    if (DBNull.Value!=dr["processing_date"])
                        model.Processing_date= Convert.ToDateTime(dr["processing_date"]);
                    if (DBNull.Value!=dr["ticket_num"])
                        model.Ticket_num = dr["ticket_num"].ToString();
                    model.Container_id = dr["container_id"].ToString();
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["weight"])
                        model.Weight= Convert.ToDecimal(dr["weight"]);
                    if (DBNull.Value!=dr["charging"])
                        model.Charging= Convert.ToDecimal(dr["charging"]);
                    model.Billing_id = dr["billing_id"].ToString();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["yyy"])
                        model.Yyy = dr["yyy"].ToString();
                    if (DBNull.Value!=dr["zdr"])
                        model.Zdr = dr["zdr"].ToString();
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["zy"])
                        model.Zy = dr["zy"].ToString();
                    if (DBNull.Value!=dr["charging_fee"])
                        model.Charging_fee= Convert.ToDecimal(dr["charging_fee"]);
                    if (DBNull.Value!=dr["other_fee"])
                        model.Other_fee= Convert.ToDecimal(dr["other_fee"]);
                    if (DBNull.Value!=dr["treatment_rate"])
                        model.Treatment_rate= Convert.ToDecimal(dr["treatment_rate"]);
                    if (DBNull.Value!=dr["treatment_je"])
                        model.Treatment_je= Convert.ToDecimal(dr["treatment_je"]);
                    if (DBNull.Value!=dr["charging_zz"])
                        model.Charging_zz= Convert.ToDecimal(dr["charging_zz"]);
                    if (DBNull.Value!=dr["charging_yjs"])
                        model.Charging_yjs= Convert.ToDecimal(dr["charging_yjs"]);
                    if (DBNull.Value!=dr["charging_wjs"])
                        model.Charging_wjs= Convert.ToDecimal(dr["charging_wjs"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

