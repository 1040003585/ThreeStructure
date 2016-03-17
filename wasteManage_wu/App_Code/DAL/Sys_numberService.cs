using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Sys_numberService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Sys_number">Sys_number实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Sys_number model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@type",model.Type),
                new SqlParameter ("@num",model.Num),
                new SqlParameter ("@rq",model.Rq),
                new SqlParameter ("@remarks",model.Remarks)
            };
           return Helper .ExecuteNonQuery ("Sys_number_Add",param);
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
                new SqlParameter ("@type",Id)
            };
           return Helper .ExecuteNonQuery ("Sys_number_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Sys_number">Sys_number实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Sys_number model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@type",model.Type),
                new SqlParameter ("@num",model.Num),
                new SqlParameter ("@rq",model.Rq),
                new SqlParameter ("@remarks",model.Remarks)
            };
           return Helper .ExecuteNonQuery ("Sys_number_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Sys_number> selectAll()
        {
            List<Sys_number> list = new List<Sys_number>();
            Sys_number model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Sys_number_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Sys_number();
                    model.Type = dr["type"].ToString();
                    if (DBNull.Value!=dr["num"])
                        model.Num= Convert.ToInt32(dr["num"]);
                    if (DBNull.Value!=dr["rq"])
                        model.Rq= Convert.ToDateTime(dr["rq"]);
                    if (DBNull.Value!=dr["remarks"])
                        model.Remarks = dr["remarks"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Sys_number实体类对象</returns>
        public Sys_number selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@type",Id)
            };
            Sys_number model = new Sys_number();
            using (SqlDataReader dr = Helper.ExecuteReader("Sys_number_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Type = dr["type"].ToString();
                    if (DBNull.Value!=dr["num"])
                        model.Num= Convert.ToInt32(dr["num"]);
                    if (DBNull.Value!=dr["rq"])
                        model.Rq= Convert.ToDateTime(dr["rq"]);
                    if (DBNull.Value!=dr["remarks"])
                        model.Remarks = dr["remarks"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Sys_number实体类对象</returns>
        public List<Sys_number> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Sys_number> list = new List<Sys_number>();
            Sys_number model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Sys_number_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Sys_number();
                    model.Type = dr["type"].ToString();
                    if (DBNull.Value!=dr["num"])
                        model.Num= Convert.ToInt32(dr["num"]);
                    if (DBNull.Value!=dr["rq"])
                        model.Rq= Convert.ToDateTime(dr["rq"]);
                    if (DBNull.Value!=dr["remarks"])
                        model.Remarks = dr["remarks"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

