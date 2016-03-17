using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DtpropertiesService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Dtproperties">Dtproperties实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Dtproperties model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@objectid",model.Objectid),
                new SqlParameter ("@property",model.Property),
                new SqlParameter ("@value",model.Value),
                new SqlParameter ("@uvalue",model.Uvalue),
                new SqlParameter ("@lvalue",model.Lvalue),
                new SqlParameter ("@version",model.Version)
            };
           return Helper .ExecuteNonQuery ("Dtproperties_Add",param);
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
                new SqlParameter ("@id",Id)
            };
           return Helper .ExecuteNonQuery ("Dtproperties_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Dtproperties">Dtproperties实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Dtproperties model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@id",model.Id),
                new SqlParameter ("@objectid",model.Objectid),
                new SqlParameter ("@property",model.Property),
                new SqlParameter ("@value",model.Value),
                new SqlParameter ("@uvalue",model.Uvalue),
                new SqlParameter ("@lvalue",model.Lvalue),
                new SqlParameter ("@version",model.Version)
            };
           return Helper .ExecuteNonQuery ("Dtproperties_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Dtproperties> selectAll()
        {
            List<Dtproperties> list = new List<Dtproperties>();
            Dtproperties model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Dtproperties_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Dtproperties();
                    model.Id= Convert.ToInt32(dr["id"]);
                    if (DBNull.Value!=dr["objectid"])
                        model.Objectid= Convert.ToInt32(dr["objectid"]);
                    model.Property = dr["property"].ToString();
                    if (DBNull.Value!=dr["value"])
                        model.Value = dr["value"].ToString();
                    if (DBNull.Value!=dr["uvalue"])
                        model.Uvalue = dr["uvalue"].ToString();
                    if (DBNull.Value!=dr["lvalue"])
                        model.Lvalue = dr["lvalue"].ToString();
                    model.Version= Convert.ToInt32(dr["version"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Dtproperties实体类对象</returns>
        public Dtproperties selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@id",Id)
            };
            Dtproperties model = new Dtproperties();
            using (SqlDataReader dr = Helper.ExecuteReader("Dtproperties_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Id= Convert.ToInt32(dr["id"]);
                    if (DBNull.Value!=dr["objectid"])
                        model.Objectid= Convert.ToInt32(dr["objectid"]);
                    model.Property = dr["property"].ToString();
                    if (DBNull.Value!=dr["value"])
                        model.Value = dr["value"].ToString();
                    if (DBNull.Value!=dr["uvalue"])
                        model.Uvalue = dr["uvalue"].ToString();
                    if (DBNull.Value!=dr["lvalue"])
                        model.Lvalue = dr["lvalue"].ToString();
                    model.Version= Convert.ToInt32(dr["version"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Dtproperties实体类对象</returns>
        public List<Dtproperties> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Dtproperties> list = new List<Dtproperties>();
            Dtproperties model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Dtproperties_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Dtproperties();
                    model.Id= Convert.ToInt32(dr["id"]);
                    if (DBNull.Value!=dr["objectid"])
                        model.Objectid= Convert.ToInt32(dr["objectid"]);
                    model.Property = dr["property"].ToString();
                    if (DBNull.Value!=dr["value"])
                        model.Value = dr["value"].ToString();
                    if (DBNull.Value!=dr["uvalue"])
                        model.Uvalue = dr["uvalue"].ToString();
                    if (DBNull.Value!=dr["lvalue"])
                        model.Lvalue = dr["lvalue"].ToString();
                    model.Version= Convert.ToInt32(dr["version"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

