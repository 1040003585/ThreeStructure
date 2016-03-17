using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Samples_unsh_recordService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Samples_unsh_record">Samples_unsh_record实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Samples_unsh_record model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@samples_id",model.Samples_id),
                new SqlParameter ("@unsh_by",model.Unsh_by),
                new SqlParameter ("@unsh_date",model.Unsh_date),
                new SqlParameter ("@bz",model.Bz)
            };
           return Helper .ExecuteNonQuery ("Samples_unsh_record_Add",param);
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
                new SqlParameter ("@bm",Id)
            };
           return Helper .ExecuteNonQuery ("Samples_unsh_record_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Samples_unsh_record">Samples_unsh_record实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Samples_unsh_record model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@samples_id",model.Samples_id),
                new SqlParameter ("@unsh_by",model.Unsh_by),
                new SqlParameter ("@unsh_date",model.Unsh_date),
                new SqlParameter ("@bz",model.Bz)
            };
           return Helper .ExecuteNonQuery ("Samples_unsh_record_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Samples_unsh_record> selectAll()
        {
            List<Samples_unsh_record> list = new List<Samples_unsh_record>();
            Samples_unsh_record model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Samples_unsh_record_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Samples_unsh_record();
                    model.Bm= Convert.ToInt32(dr["bm"]);
                    if (DBNull.Value!=dr["samples_id"])
                        model.Samples_id = dr["samples_id"].ToString();
                    if (DBNull.Value!=dr["unsh_by"])
                        model.Unsh_by = dr["unsh_by"].ToString();
                    if (DBNull.Value!=dr["unsh_date"])
                        model.Unsh_date= Convert.ToDateTime(dr["unsh_date"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Samples_unsh_record实体类对象</returns>
        public Samples_unsh_record selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",Id)
            };
            Samples_unsh_record model = new Samples_unsh_record();
            using (SqlDataReader dr = Helper.ExecuteReader("Samples_unsh_record_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bm= Convert.ToInt32(dr["bm"]);
                    if (DBNull.Value!=dr["samples_id"])
                        model.Samples_id = dr["samples_id"].ToString();
                    if (DBNull.Value!=dr["unsh_by"])
                        model.Unsh_by = dr["unsh_by"].ToString();
                    if (DBNull.Value!=dr["unsh_date"])
                        model.Unsh_date= Convert.ToDateTime(dr["unsh_date"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Samples_unsh_record实体类对象</returns>
        public List<Samples_unsh_record> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Samples_unsh_record> list = new List<Samples_unsh_record>();
            Samples_unsh_record model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Samples_unsh_record_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Samples_unsh_record();
                    model.Bm= Convert.ToInt32(dr["bm"]);
                    if (DBNull.Value!=dr["samples_id"])
                        model.Samples_id = dr["samples_id"].ToString();
                    if (DBNull.Value!=dr["unsh_by"])
                        model.Unsh_by = dr["unsh_by"].ToString();
                    if (DBNull.Value!=dr["unsh_date"])
                        model.Unsh_date= Convert.ToDateTime(dr["unsh_date"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

