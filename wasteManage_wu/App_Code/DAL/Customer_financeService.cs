using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Customer_financeService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Customer_finance">Customer_finance实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Customer_finance model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@charging",model.Charging),
                new SqlParameter ("@skr",model.Skr),
                new SqlParameter ("@sk_date",model.Sk_date),
                new SqlParameter ("@customer_num",model.Customer_num),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@is_sh",model.Is_sh),
                new SqlParameter ("@shr",model.Shr),
                new SqlParameter ("@sh_date",model.Sh_date),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@updated_by",model.Updated_by),
                new SqlParameter ("@update_date",model.Update_date)
            };
           return Helper .ExecuteNonQuery ("Customer_finance_Add",param);
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
           return Helper .ExecuteNonQuery ("Customer_finance_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Customer_finance">Customer_finance实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Customer_finance model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@charging",model.Charging),
                new SqlParameter ("@skr",model.Skr),
                new SqlParameter ("@sk_date",model.Sk_date),
                new SqlParameter ("@customer_num",model.Customer_num),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@is_sh",model.Is_sh),
                new SqlParameter ("@shr",model.Shr),
                new SqlParameter ("@sh_date",model.Sh_date),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@updated_by",model.Updated_by),
                new SqlParameter ("@update_date",model.Update_date)
            };
           return Helper .ExecuteNonQuery ("Customer_finance_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Customer_finance> selectAll()
        {
            List<Customer_finance> list = new List<Customer_finance>();
            Customer_finance model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Customer_finance_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Customer_finance();
                    model.Bh = dr["bh"].ToString();
                    model.Bm = dr["bm"].ToString();
                    model.Charging= Convert.ToDecimal(dr["charging"]);
                    if (DBNull.Value!=dr["skr"])
                        model.Skr = dr["skr"].ToString();
                    if (DBNull.Value!=dr["sk_date"])
                        model.Sk_date= Convert.ToDateTime(dr["sk_date"]);
                    if (DBNull.Value!=dr["customer_num"])
                        model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    model.Is_sh= Convert.ToByte(dr["is_sh"]);
                    if (DBNull.Value!=dr["shr"])
                        model.Shr = dr["shr"].ToString();
                    if (DBNull.Value!=dr["sh_date"])
                        model.Sh_date= Convert.ToDateTime(dr["sh_date"]);
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Customer_finance实体类对象</returns>
        public Customer_finance selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Customer_finance model = new Customer_finance();
            using (SqlDataReader dr = Helper.ExecuteReader("Customer_finance_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bh = dr["bh"].ToString();
                    model.Bm = dr["bm"].ToString();
                    model.Charging= Convert.ToDecimal(dr["charging"]);
                    if (DBNull.Value!=dr["skr"])
                        model.Skr = dr["skr"].ToString();
                    if (DBNull.Value!=dr["sk_date"])
                        model.Sk_date= Convert.ToDateTime(dr["sk_date"]);
                    if (DBNull.Value!=dr["customer_num"])
                        model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    model.Is_sh= Convert.ToByte(dr["is_sh"]);
                    if (DBNull.Value!=dr["shr"])
                        model.Shr = dr["shr"].ToString();
                    if (DBNull.Value!=dr["sh_date"])
                        model.Sh_date= Convert.ToDateTime(dr["sh_date"]);
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Customer_finance实体类对象</returns>
        public List<Customer_finance> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Customer_finance> list = new List<Customer_finance>();
            Customer_finance model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Customer_finance_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Customer_finance();
                    model.Bh = dr["bh"].ToString();
                    model.Bm = dr["bm"].ToString();
                    model.Charging= Convert.ToDecimal(dr["charging"]);
                    if (DBNull.Value!=dr["skr"])
                        model.Skr = dr["skr"].ToString();
                    if (DBNull.Value!=dr["sk_date"])
                        model.Sk_date= Convert.ToDateTime(dr["sk_date"]);
                    if (DBNull.Value!=dr["customer_num"])
                        model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    model.Is_sh= Convert.ToByte(dr["is_sh"]);
                    if (DBNull.Value!=dr["shr"])
                        model.Shr = dr["shr"].ToString();
                    if (DBNull.Value!=dr["sh_date"])
                        model.Sh_date= Convert.ToDateTime(dr["sh_date"]);
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

