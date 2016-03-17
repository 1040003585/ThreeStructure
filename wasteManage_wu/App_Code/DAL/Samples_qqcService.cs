using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Samples_qqcService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Samples_qqc">Samples_qqc实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Samples_qqc model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@sample_id",model.Sample_id),
                new SqlParameter ("@waste_id",model.Waste_id),
                new SqlParameter ("@result",model.Result),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@qqc_yyy",model.Qqc_yyy),
                new SqlParameter ("@status",model.Status),
                new SqlParameter ("@qqc_date",model.Qqc_date),
                new SqlParameter ("@customer_num",model.Customer_num),
                new SqlParameter ("@waste_code",model.Waste_code)
            };
           return Helper .ExecuteNonQuery ("Samples_qqc_Add",param);
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
           return Helper .ExecuteNonQuery ("Samples_qqc_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Samples_qqc">Samples_qqc实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Samples_qqc model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@sample_id",model.Sample_id),
                new SqlParameter ("@waste_id",model.Waste_id),
                new SqlParameter ("@result",model.Result),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@qqc_yyy",model.Qqc_yyy),
                new SqlParameter ("@status",model.Status),
                new SqlParameter ("@qqc_date",model.Qqc_date),
                new SqlParameter ("@customer_num",model.Customer_num),
                new SqlParameter ("@waste_code",model.Waste_code)
            };
           return Helper .ExecuteNonQuery ("Samples_qqc_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Samples_qqc> selectAll()
        {
            List<Samples_qqc> list = new List<Samples_qqc>();
            Samples_qqc model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Samples_qqc_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Samples_qqc();
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["sample_id"])
                        model.Sample_id = dr["sample_id"].ToString();
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    model.Result= Convert.ToByte(dr["result"]);
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["qqc_yyy"])
                        model.Qqc_yyy = dr["qqc_yyy"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                    if (DBNull.Value!=dr["qqc_date"])
                        model.Qqc_date= Convert.ToDateTime(dr["qqc_date"]);
                    if (DBNull.Value!=dr["customer_num"])
                        model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["waste_code"])
                        model.Waste_code = dr["waste_code"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Samples_qqc实体类对象</returns>
        public Samples_qqc selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Samples_qqc model = new Samples_qqc();
            using (SqlDataReader dr = Helper.ExecuteReader("Samples_qqc_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["sample_id"])
                        model.Sample_id = dr["sample_id"].ToString();
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    model.Result= Convert.ToByte(dr["result"]);
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["qqc_yyy"])
                        model.Qqc_yyy = dr["qqc_yyy"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                    if (DBNull.Value!=dr["qqc_date"])
                        model.Qqc_date= Convert.ToDateTime(dr["qqc_date"]);
                    if (DBNull.Value!=dr["customer_num"])
                        model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["waste_code"])
                        model.Waste_code = dr["waste_code"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Samples_qqc实体类对象</returns>
        public List<Samples_qqc> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Samples_qqc> list = new List<Samples_qqc>();
            Samples_qqc model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Samples_qqc_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Samples_qqc();
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["sample_id"])
                        model.Sample_id = dr["sample_id"].ToString();
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    model.Result= Convert.ToByte(dr["result"]);
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["qqc_yyy"])
                        model.Qqc_yyy = dr["qqc_yyy"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                    if (DBNull.Value!=dr["qqc_date"])
                        model.Qqc_date= Convert.ToDateTime(dr["qqc_date"]);
                    if (DBNull.Value!=dr["customer_num"])
                        model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["waste_code"])
                        model.Waste_code = dr["waste_code"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

