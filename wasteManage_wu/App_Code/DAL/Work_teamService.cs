using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Work_teamService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Work_team">Work_team实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Work_team model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc)
            };
           return Helper .ExecuteNonQuery ("Work_team_Add",param);
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
           return Helper .ExecuteNonQuery ("Work_team_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Work_team">Work_team实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Work_team model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc)
            };
           return Helper .ExecuteNonQuery ("Work_team_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Work_team> selectAll()
        {
            List<Work_team> list = new List<Work_team>();
            Work_team model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Work_team_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Work_team();
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
        /// <returns>Work_team实体类对象</returns>
        public Work_team selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",Id)
            };
            Work_team model = new Work_team();
            using (SqlDataReader dr = Helper.ExecuteReader("Work_team_SelectById", param))
            {
                if (dr.Read())
                {
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
        /// <returns>Work_team实体类对象</returns>
        public List<Work_team> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Work_team> list = new List<Work_team>();
            Work_team model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Work_team_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Work_team();
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

