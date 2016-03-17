using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class HazardService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Hazard">Hazard实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Hazard model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc),
                new SqlParameter ("@poto",model.Poto),
                new SqlParameter ("@saft",model.Saft),
                new SqlParameter ("@wxqk",model.Wxqk),
                new SqlParameter ("@ms",model.Ms)
            };
           return Helper .ExecuteNonQuery ("Hazard_Add",param);
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
           return Helper .ExecuteNonQuery ("Hazard_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Hazard">Hazard实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Hazard model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc),
                new SqlParameter ("@poto",model.Poto),
                new SqlParameter ("@saft",model.Saft),
                new SqlParameter ("@wxqk",model.Wxqk),
                new SqlParameter ("@ms",model.Ms)
            };
           return Helper .ExecuteNonQuery ("Hazard_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Hazard> selectAll()
        {
            List<Hazard> list = new List<Hazard>();
            Hazard model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Hazard_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Hazard();
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    if (DBNull.Value!=dr["poto"])
                        model.Poto = dr["poto"].ToString();
                    if (DBNull.Value!=dr["saft"])
                        model.Saft = dr["saft"].ToString();
                    if (DBNull.Value!=dr["wxqk"])
                        model.Wxqk = dr["wxqk"].ToString();
                    if (DBNull.Value!=dr["ms"])
                        model.Ms = dr["ms"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Hazard实体类对象</returns>
        public Hazard selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",Id)
            };
            Hazard model = new Hazard();
            using (SqlDataReader dr = Helper.ExecuteReader("Hazard_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    if (DBNull.Value!=dr["poto"])
                        model.Poto = dr["poto"].ToString();
                    if (DBNull.Value!=dr["saft"])
                        model.Saft = dr["saft"].ToString();
                    if (DBNull.Value!=dr["wxqk"])
                        model.Wxqk = dr["wxqk"].ToString();
                    if (DBNull.Value!=dr["ms"])
                        model.Ms = dr["ms"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Hazard实体类对象</returns>
        public List<Hazard> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Hazard> list = new List<Hazard>();
            Hazard model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Hazard_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Hazard();
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    if (DBNull.Value!=dr["poto"])
                        model.Poto = dr["poto"].ToString();
                    if (DBNull.Value!=dr["saft"])
                        model.Saft = dr["saft"].ToString();
                    if (DBNull.Value!=dr["wxqk"])
                        model.Wxqk = dr["wxqk"].ToString();
                    if (DBNull.Value!=dr["ms"])
                        model.Ms = dr["ms"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

