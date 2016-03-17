using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Component_wltx_typeService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Component_wltx_type">Component_wltx_type实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Component_wltx_type model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@component_type",model.Component_type),
                new SqlParameter ("@mc",model.Mc)
            };
           return Helper .ExecuteNonQuery ("Component_wltx_type_Add",param);
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
           return Helper .ExecuteNonQuery ("Component_wltx_type_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Component_wltx_type">Component_wltx_type实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Component_wltx_type model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@component_type",model.Component_type),
                new SqlParameter ("@mc",model.Mc)
            };
           return Helper .ExecuteNonQuery ("Component_wltx_type_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Component_wltx_type> selectAll()
        {
            List<Component_wltx_type> list = new List<Component_wltx_type>();
            Component_wltx_type model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Component_wltx_type_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Component_wltx_type();
                    model.Bh= Convert.ToInt32(dr["bh"]);
                    if (DBNull.Value!=dr["component_type"])
                        model.Component_type = dr["component_type"].ToString();
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
        /// <returns>Component_wltx_type实体类对象</returns>
        public Component_wltx_type selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Component_wltx_type model = new Component_wltx_type();
            using (SqlDataReader dr = Helper.ExecuteReader("Component_wltx_type_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bh= Convert.ToInt32(dr["bh"]);
                    if (DBNull.Value!=dr["component_type"])
                        model.Component_type = dr["component_type"].ToString();
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
        /// <returns>Component_wltx_type实体类对象</returns>
        public List<Component_wltx_type> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Component_wltx_type> list = new List<Component_wltx_type>();
            Component_wltx_type model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Component_wltx_type_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Component_wltx_type();
                    model.Bh= Convert.ToInt32(dr["bh"]);
                    if (DBNull.Value!=dr["component_type"])
                        model.Component_type = dr["component_type"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

