using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Xjyh_customerService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Xjyh_customer">Xjyh_customer实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Xjyh_customer model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc),
                new SqlParameter ("@customer_num",model.Customer_num),
                new SqlParameter ("@charging",model.Charging),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@is_sh",model.Is_sh),
                new SqlParameter ("@shr",model.Shr),
                new SqlParameter ("@sh_date",model.Sh_date),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@updated_by",model.Updated_by),
                new SqlParameter ("@update_date",model.Update_date)
            };
           return Helper .ExecuteNonQuery ("Xjyh_customer_Add",param);
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
           return Helper .ExecuteNonQuery ("Xjyh_customer_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Xjyh_customer">Xjyh_customer实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Xjyh_customer model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc),
                new SqlParameter ("@customer_num",model.Customer_num),
                new SqlParameter ("@charging",model.Charging),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@is_sh",model.Is_sh),
                new SqlParameter ("@shr",model.Shr),
                new SqlParameter ("@sh_date",model.Sh_date),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@updated_by",model.Updated_by),
                new SqlParameter ("@update_date",model.Update_date)
            };
           return Helper .ExecuteNonQuery ("Xjyh_customer_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Xjyh_customer> selectAll()
        {
            List<Xjyh_customer> list = new List<Xjyh_customer>();
            Xjyh_customer model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Xjyh_customer_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Xjyh_customer();
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["bm"])
                        model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    model.Customer_num = dr["customer_num"].ToString();
                    model.Charging= Convert.ToDecimal(dr["charging"]);
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
        /// <returns>Xjyh_customer实体类对象</returns>
        public Xjyh_customer selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Xjyh_customer model = new Xjyh_customer();
            using (SqlDataReader dr = Helper.ExecuteReader("Xjyh_customer_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["bm"])
                        model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    model.Customer_num = dr["customer_num"].ToString();
                    model.Charging= Convert.ToDecimal(dr["charging"]);
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
        /// <returns>Xjyh_customer实体类对象</returns>
        public List<Xjyh_customer> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Xjyh_customer> list = new List<Xjyh_customer>();
            Xjyh_customer model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Xjyh_customer_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Xjyh_customer();
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["bm"])
                        model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    model.Customer_num = dr["customer_num"].ToString();
                    model.Charging= Convert.ToDecimal(dr["charging"]);
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

