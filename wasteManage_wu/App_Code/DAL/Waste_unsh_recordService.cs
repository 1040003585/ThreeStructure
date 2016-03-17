using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Waste_unsh_recordService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Waste_unsh_record">Waste_unsh_record实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Waste_unsh_record model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@waste_id",model.Waste_id),
                new SqlParameter ("@unsh_by",model.Unsh_by),
                new SqlParameter ("@unsh_date",model.Unsh_date),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@remark",model.Remark)
            };
           return Helper .ExecuteNonQuery ("Waste_unsh_record_Add",param);
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
           return Helper .ExecuteNonQuery ("Waste_unsh_record_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Waste_unsh_record">Waste_unsh_record实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Waste_unsh_record model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@waste_id",model.Waste_id),
                new SqlParameter ("@unsh_by",model.Unsh_by),
                new SqlParameter ("@unsh_date",model.Unsh_date),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@remark",model.Remark)
            };
           return Helper .ExecuteNonQuery ("Waste_unsh_record_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Waste_unsh_record> selectAll()
        {
            List<Waste_unsh_record> list = new List<Waste_unsh_record>();
            Waste_unsh_record model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Waste_unsh_record_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Waste_unsh_record();
                    model.Bm= Convert.ToInt32(dr["bm"]);
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["unsh_by"])
                        model.Unsh_by = dr["unsh_by"].ToString();
                    if (DBNull.Value!=dr["unsh_date"])
                        model.Unsh_date= Convert.ToDateTime(dr["unsh_date"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["remark"])
                        model.Remark = dr["remark"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Waste_unsh_record实体类对象</returns>
        public Waste_unsh_record selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",Id)
            };
            Waste_unsh_record model = new Waste_unsh_record();
            using (SqlDataReader dr = Helper.ExecuteReader("Waste_unsh_record_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bm= Convert.ToInt32(dr["bm"]);
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["unsh_by"])
                        model.Unsh_by = dr["unsh_by"].ToString();
                    if (DBNull.Value!=dr["unsh_date"])
                        model.Unsh_date= Convert.ToDateTime(dr["unsh_date"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["remark"])
                        model.Remark = dr["remark"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Waste_unsh_record实体类对象</returns>
        public List<Waste_unsh_record> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Waste_unsh_record> list = new List<Waste_unsh_record>();
            Waste_unsh_record model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Waste_unsh_record_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Waste_unsh_record();
                    model.Bm= Convert.ToInt32(dr["bm"]);
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["unsh_by"])
                        model.Unsh_by = dr["unsh_by"].ToString();
                    if (DBNull.Value!=dr["unsh_date"])
                        model.Unsh_date= Convert.ToDateTime(dr["unsh_date"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["remark"])
                        model.Remark = dr["remark"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

