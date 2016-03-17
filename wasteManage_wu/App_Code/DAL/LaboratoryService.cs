using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class LaboratoryService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Laboratory">Laboratory实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Laboratory model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc)
            };
           return Helper .ExecuteNonQuery ("Laboratory_Add",param);
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
           return Helper .ExecuteNonQuery ("Laboratory_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Laboratory">Laboratory实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Laboratory model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc)
            };
           return Helper .ExecuteNonQuery ("Laboratory_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Laboratory> selectAll()
        {
            List<Laboratory> list = new List<Laboratory>();
            Laboratory model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Laboratory_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Laboratory();
                    model.Bh = dr["bh"].ToString();
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Laboratory实体类对象</returns>
        public Laboratory selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Laboratory model = new Laboratory();
            using (SqlDataReader dr = Helper.ExecuteReader("Laboratory_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bh = dr["bh"].ToString();
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Laboratory实体类对象</returns>
        public List<Laboratory> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Laboratory> list = new List<Laboratory>();
            Laboratory model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Laboratory_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Laboratory();
                    model.Bh = dr["bh"].ToString();
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

