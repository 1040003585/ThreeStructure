using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Delete_recordService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Delete_record">Delete_record实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Delete_record model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@delete_sql",model.Delete_sql),
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@deleted_by",model.Deleted_by),
                new SqlParameter ("@delete_date",model.Delete_date),
                new SqlParameter ("@djlx",model.Djlx)
            };
           return Helper .ExecuteNonQuery ("Delete_record_Add",param);
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
                new SqlParameter ("@delete_sql",Id)
            };
           return Helper .ExecuteNonQuery ("Delete_record_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Delete_record">Delete_record实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Delete_record model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@delete_sql",model.Delete_sql),
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@deleted_by",model.Deleted_by),
                new SqlParameter ("@delete_date",model.Delete_date),
                new SqlParameter ("@djlx",model.Djlx)
            };
           return Helper .ExecuteNonQuery ("Delete_record_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Delete_record> selectAll()
        {
            List<Delete_record> list = new List<Delete_record>();
            Delete_record model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Delete_record_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Delete_record();
                    if (DBNull.Value!=dr["delete_sql"])
                        model.Delete_sql = dr["delete_sql"].ToString();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["deleted_by"])
                        model.Deleted_by = dr["deleted_by"].ToString();
                    if (DBNull.Value!=dr["delete_date"])
                        model.Delete_date= Convert.ToDateTime(dr["delete_date"]);
                    if (DBNull.Value!=dr["djlx"])
                        model.Djlx = dr["djlx"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Delete_record实体类对象</returns>
        public Delete_record selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@delete_sql",Id)
            };
            Delete_record model = new Delete_record();
            using (SqlDataReader dr = Helper.ExecuteReader("Delete_record_SelectById", param))
            {
                if (dr.Read())
                {
                    if (DBNull.Value!=dr["delete_sql"])
                        model.Delete_sql = dr["delete_sql"].ToString();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["deleted_by"])
                        model.Deleted_by = dr["deleted_by"].ToString();
                    if (DBNull.Value!=dr["delete_date"])
                        model.Delete_date= Convert.ToDateTime(dr["delete_date"]);
                    if (DBNull.Value!=dr["djlx"])
                        model.Djlx = dr["djlx"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Delete_record实体类对象</returns>
        public List<Delete_record> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Delete_record> list = new List<Delete_record>();
            Delete_record model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Delete_record_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Delete_record();
                    if (DBNull.Value!=dr["delete_sql"])
                        model.Delete_sql = dr["delete_sql"].ToString();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["deleted_by"])
                        model.Deleted_by = dr["deleted_by"].ToString();
                    if (DBNull.Value!=dr["delete_date"])
                        model.Delete_date= Convert.ToDateTime(dr["delete_date"]);
                    if (DBNull.Value!=dr["djlx"])
                        model.Djlx = dr["djlx"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

