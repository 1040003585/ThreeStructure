using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Samples_matterService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Samples_matter">Samples_matter实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Samples_matter model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc)
            };
           return Helper .ExecuteNonQuery ("Samples_matter_Add",param);
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
           return Helper .ExecuteNonQuery ("Samples_matter_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Samples_matter">Samples_matter实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Samples_matter model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc)
            };
           return Helper .ExecuteNonQuery ("Samples_matter_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Samples_matter> selectAll()
        {
            List<Samples_matter> list = new List<Samples_matter>();
            Samples_matter model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Samples_matter_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Samples_matter();
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
        /// <returns>Samples_matter实体类对象</returns>
        public Samples_matter selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",Id)
            };
            Samples_matter model = new Samples_matter();
            using (SqlDataReader dr = Helper.ExecuteReader("Samples_matter_SelectById", param))
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
        /// <returns>Samples_matter实体类对象</returns>
        public List<Samples_matter> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Samples_matter> list = new List<Samples_matter>();
            Samples_matter model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Samples_matter_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Samples_matter();
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

