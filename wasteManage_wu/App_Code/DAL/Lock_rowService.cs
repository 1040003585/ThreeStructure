using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Lock_rowService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Lock_row">Lock_row实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Lock_row model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@windowname",model.Windowname),
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@username",model.Username),
                new SqlParameter ("@row",model.Row),
                new SqlParameter ("@xh",model.Xh)
            };
           return Helper .ExecuteNonQuery ("Lock_row_Add",param);
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
                new SqlParameter ("@windowname",Id)
            };
           return Helper .ExecuteNonQuery ("Lock_row_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Lock_row">Lock_row实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Lock_row model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@windowname",model.Windowname),
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@username",model.Username),
                new SqlParameter ("@row",model.Row),
                new SqlParameter ("@xh",model.Xh)
            };
           return Helper .ExecuteNonQuery ("Lock_row_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Lock_row> selectAll()
        {
            List<Lock_row> list = new List<Lock_row>();
            Lock_row model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Lock_row_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Lock_row();
                    if (DBNull.Value!=dr["windowname"])
                        model.Windowname = dr["windowname"].ToString();
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["username"])
                        model.Username = dr["username"].ToString();
                    if (DBNull.Value!=dr["row"])
                        model.Row= Convert.ToByte(dr["row"]);
                    if (DBNull.Value!=dr["xh"])
                        model.Xh= Convert.ToByte(dr["xh"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Lock_row实体类对象</returns>
        public Lock_row selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@windowname",Id)
            };
            Lock_row model = new Lock_row();
            using (SqlDataReader dr = Helper.ExecuteReader("Lock_row_SelectById", param))
            {
                if (dr.Read())
                {
                    if (DBNull.Value!=dr["windowname"])
                        model.Windowname = dr["windowname"].ToString();
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["username"])
                        model.Username = dr["username"].ToString();
                    if (DBNull.Value!=dr["row"])
                        model.Row= Convert.ToByte(dr["row"]);
                    if (DBNull.Value!=dr["xh"])
                        model.Xh= Convert.ToByte(dr["xh"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Lock_row实体类对象</returns>
        public List<Lock_row> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Lock_row> list = new List<Lock_row>();
            Lock_row model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Lock_row_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Lock_row();
                    if (DBNull.Value!=dr["windowname"])
                        model.Windowname = dr["windowname"].ToString();
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["username"])
                        model.Username = dr["username"].ToString();
                    if (DBNull.Value!=dr["row"])
                        model.Row= Convert.ToByte(dr["row"]);
                    if (DBNull.Value!=dr["xh"])
                        model.Xh= Convert.ToByte(dr["xh"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

