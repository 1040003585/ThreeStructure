using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PbcatvldService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Pbcatvld">Pbcatvld实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Pbcatvld model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@pbv_name",model.Pbv_name),
                new SqlParameter ("@pbv_vald",model.Pbv_vald),
                new SqlParameter ("@pbv_type",model.Pbv_type),
                new SqlParameter ("@pbv_cntr",model.Pbv_cntr),
                new SqlParameter ("@pbv_msg",model.Pbv_msg)
            };
           return Helper .ExecuteNonQuery ("Pbcatvld_Add",param);
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
                new SqlParameter ("@pbv_name",Id)
            };
           return Helper .ExecuteNonQuery ("Pbcatvld_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Pbcatvld">Pbcatvld实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Pbcatvld model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@pbv_name",model.Pbv_name),
                new SqlParameter ("@pbv_vald",model.Pbv_vald),
                new SqlParameter ("@pbv_type",model.Pbv_type),
                new SqlParameter ("@pbv_cntr",model.Pbv_cntr),
                new SqlParameter ("@pbv_msg",model.Pbv_msg)
            };
           return Helper .ExecuteNonQuery ("Pbcatvld_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Pbcatvld> selectAll()
        {
            List<Pbcatvld> list = new List<Pbcatvld>();
            Pbcatvld model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Pbcatvld_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Pbcatvld();
                    model.Pbv_name = dr["pbv_name"].ToString();
                    model.Pbv_vald = dr["pbv_vald"].ToString();
                    model.Pbv_type= Convert.ToInt32(dr["pbv_type"]);
                    if (DBNull.Value!=dr["pbv_cntr"])
                        model.Pbv_cntr= Convert.ToInt32(dr["pbv_cntr"]);
                    if (DBNull.Value!=dr["pbv_msg"])
                        model.Pbv_msg = dr["pbv_msg"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Pbcatvld实体类对象</returns>
        public Pbcatvld selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@pbv_name",Id)
            };
            Pbcatvld model = new Pbcatvld();
            using (SqlDataReader dr = Helper.ExecuteReader("Pbcatvld_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Pbv_name = dr["pbv_name"].ToString();
                    model.Pbv_vald = dr["pbv_vald"].ToString();
                    model.Pbv_type= Convert.ToInt32(dr["pbv_type"]);
                    if (DBNull.Value!=dr["pbv_cntr"])
                        model.Pbv_cntr= Convert.ToInt32(dr["pbv_cntr"]);
                    if (DBNull.Value!=dr["pbv_msg"])
                        model.Pbv_msg = dr["pbv_msg"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Pbcatvld实体类对象</returns>
        public List<Pbcatvld> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Pbcatvld> list = new List<Pbcatvld>();
            Pbcatvld model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Pbcatvld_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Pbcatvld();
                    model.Pbv_name = dr["pbv_name"].ToString();
                    model.Pbv_vald = dr["pbv_vald"].ToString();
                    model.Pbv_type= Convert.ToInt32(dr["pbv_type"]);
                    if (DBNull.Value!=dr["pbv_cntr"])
                        model.Pbv_cntr= Convert.ToInt32(dr["pbv_cntr"]);
                    if (DBNull.Value!=dr["pbv_msg"])
                        model.Pbv_msg = dr["pbv_msg"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

