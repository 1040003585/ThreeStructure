using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BillingService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Billing">Billing实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Billing model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@billing_id",model.Billing_id),
                new SqlParameter ("@billing_date",model.Billing_date),
                new SqlParameter ("@status",model.Status)
            };

           
           return Helper.ExecuteNonQuery ("Billing_Add",param);
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
           return Helper .ExecuteNonQuery ("Billing_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Billing">Billing实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Billing model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@billing_id",model.Billing_id),
                new SqlParameter ("@billing_date",model.Billing_date),
                new SqlParameter ("@status",model.Status)
            };
           return Helper .ExecuteNonQuery ("Billing_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Billing> selectAll()
        {
            List<Billing> list = new List<Billing>();
            Billing model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Billing_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Billing();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Billing_id = dr["billing_id"].ToString();
                    if (DBNull.Value!=dr["billing_date"])
                        model.Billing_date= Convert.ToDateTime(dr["billing_date"]);
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Billing实体类对象</returns>
        public Billing selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Billing model = new Billing();
            using (SqlDataReader dr = Helper.ExecuteReader("Billing_SelectById", param))
            {
                if (dr.Read())
                {
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Billing_id = dr["billing_id"].ToString();
                    if (DBNull.Value!=dr["billing_date"])
                        model.Billing_date= Convert.ToDateTime(dr["billing_date"]);
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Billing实体类对象</returns>
        public List<Billing> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Billing> list = new List<Billing>();
            Billing model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Billing_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Billing();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Billing_id = dr["billing_id"].ToString();
                    if (DBNull.Value!=dr["billing_date"])
                        model.Billing_date= Convert.ToDateTime(dr["billing_date"]);
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

