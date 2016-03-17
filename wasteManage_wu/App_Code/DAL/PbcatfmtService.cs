using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PbcatfmtService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Pbcatfmt">Pbcatfmt实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Pbcatfmt model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@pbf_name",model.Pbf_name),
                new SqlParameter ("@pbf_frmt",model.Pbf_frmt),
                new SqlParameter ("@pbf_type",model.Pbf_type),
                new SqlParameter ("@pbf_cntr",model.Pbf_cntr)
            };
           return Helper .ExecuteNonQuery ("Pbcatfmt_Add",param);
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
                new SqlParameter ("@pbf_name",Id)
            };
           return Helper .ExecuteNonQuery ("Pbcatfmt_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Pbcatfmt">Pbcatfmt实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Pbcatfmt model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@pbf_name",model.Pbf_name),
                new SqlParameter ("@pbf_frmt",model.Pbf_frmt),
                new SqlParameter ("@pbf_type",model.Pbf_type),
                new SqlParameter ("@pbf_cntr",model.Pbf_cntr)
            };
           return Helper .ExecuteNonQuery ("Pbcatfmt_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Pbcatfmt> selectAll()
        {
            List<Pbcatfmt> list = new List<Pbcatfmt>();
            Pbcatfmt model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Pbcatfmt_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Pbcatfmt();
                    model.Pbf_name = dr["pbf_name"].ToString();
                    model.Pbf_frmt = dr["pbf_frmt"].ToString();
                    model.Pbf_type= Convert.ToInt32(dr["pbf_type"]);
                    if (DBNull.Value!=dr["pbf_cntr"])
                        model.Pbf_cntr= Convert.ToInt32(dr["pbf_cntr"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Pbcatfmt实体类对象</returns>
        public Pbcatfmt selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@pbf_name",Id)
            };
            Pbcatfmt model = new Pbcatfmt();
            using (SqlDataReader dr = Helper.ExecuteReader("Pbcatfmt_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Pbf_name = dr["pbf_name"].ToString();
                    model.Pbf_frmt = dr["pbf_frmt"].ToString();
                    model.Pbf_type= Convert.ToInt32(dr["pbf_type"]);
                    if (DBNull.Value!=dr["pbf_cntr"])
                        model.Pbf_cntr= Convert.ToInt32(dr["pbf_cntr"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Pbcatfmt实体类对象</returns>
        public List<Pbcatfmt> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Pbcatfmt> list = new List<Pbcatfmt>();
            Pbcatfmt model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Pbcatfmt_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Pbcatfmt();
                    model.Pbf_name = dr["pbf_name"].ToString();
                    model.Pbf_frmt = dr["pbf_frmt"].ToString();
                    model.Pbf_type= Convert.ToInt32(dr["pbf_type"]);
                    if (DBNull.Value!=dr["pbf_cntr"])
                        model.Pbf_cntr= Convert.ToInt32(dr["pbf_cntr"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

