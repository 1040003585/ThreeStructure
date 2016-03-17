using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Bmfl_dqService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Bmfl_dq">Bmfl_dq实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Bmfl_dq model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc),
                new SqlParameter ("@js",model.Js),
                new SqlParameter ("@bm_1",model.Bm_1),
                new SqlParameter ("@bm_2",model.Bm_2),
                new SqlParameter ("@bm_3",model.Bm_3),
                new SqlParameter ("@bm_4",model.Bm_4)
            };
           return Helper .ExecuteNonQuery ("Bmfl_dq_Add",param);
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
           return Helper .ExecuteNonQuery ("Bmfl_dq_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Bmfl_dq">Bmfl_dq实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Bmfl_dq model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc),
                new SqlParameter ("@js",model.Js),
                new SqlParameter ("@bm_1",model.Bm_1),
                new SqlParameter ("@bm_2",model.Bm_2),
                new SqlParameter ("@bm_3",model.Bm_3),
                new SqlParameter ("@bm_4",model.Bm_4)
            };
           return Helper .ExecuteNonQuery ("Bmfl_dq_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Bmfl_dq> selectAll()
        {
            List<Bmfl_dq> list = new List<Bmfl_dq>();
            Bmfl_dq model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Bmfl_dq_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Bmfl_dq();
                    model.Bh = dr["bh"].ToString();
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    if (DBNull.Value!=dr["js"])
                        model.Js= Convert.ToInt32(dr["js"]);
                    if (DBNull.Value!=dr["bm_1"])
                        model.Bm_1 = dr["bm_1"].ToString();
                    if (DBNull.Value!=dr["bm_2"])
                        model.Bm_2 = dr["bm_2"].ToString();
                    if (DBNull.Value!=dr["bm_3"])
                        model.Bm_3 = dr["bm_3"].ToString();
                    if (DBNull.Value!=dr["bm_4"])
                        model.Bm_4 = dr["bm_4"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Bmfl_dq实体类对象</returns>
        public Bmfl_dq selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Bmfl_dq model = new Bmfl_dq();
            using (SqlDataReader dr = Helper.ExecuteReader("Bmfl_dq_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bh = dr["bh"].ToString();
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    if (DBNull.Value!=dr["js"])
                        model.Js= Convert.ToInt32(dr["js"]);
                    if (DBNull.Value!=dr["bm_1"])
                        model.Bm_1 = dr["bm_1"].ToString();
                    if (DBNull.Value!=dr["bm_2"])
                        model.Bm_2 = dr["bm_2"].ToString();
                    if (DBNull.Value!=dr["bm_3"])
                        model.Bm_3 = dr["bm_3"].ToString();
                    if (DBNull.Value!=dr["bm_4"])
                        model.Bm_4 = dr["bm_4"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Bmfl_dq实体类对象</returns>
        public List<Bmfl_dq> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Bmfl_dq> list = new List<Bmfl_dq>();
            Bmfl_dq model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Bmfl_dq_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Bmfl_dq();
                    model.Bh = dr["bh"].ToString();
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    if (DBNull.Value!=dr["js"])
                        model.Js= Convert.ToInt32(dr["js"]);
                    if (DBNull.Value!=dr["bm_1"])
                        model.Bm_1 = dr["bm_1"].ToString();
                    if (DBNull.Value!=dr["bm_2"])
                        model.Bm_2 = dr["bm_2"].ToString();
                    if (DBNull.Value!=dr["bm_3"])
                        model.Bm_3 = dr["bm_3"].ToString();
                    if (DBNull.Value!=dr["bm_4"])
                        model.Bm_4 = dr["bm_4"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

