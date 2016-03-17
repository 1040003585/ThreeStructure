using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Qqc_componentService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Qqc_component">Qqc_component实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Qqc_component model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@component_id",model.Component_id),
                new SqlParameter ("@component_name",model.Component_name),
                new SqlParameter ("@limit",model.Limit),
                new SqlParameter ("@dw",model.Dw),
                new SqlParameter ("@jb_hight",model.Jb_hight),
                new SqlParameter ("@jb_low",model.Jb_low),
                new SqlParameter ("@limit_jc",model.Limit_jc),
                new SqlParameter ("@group_ss",model.Group_ss),
                new SqlParameter ("@edit_times",model.Edit_times),
                new SqlParameter ("@edit_date",model.Edit_date),
                new SqlParameter ("@edit_reason",model.Edit_reason),
                new SqlParameter ("@bz",model.Bz)
            };
           return Helper .ExecuteNonQuery ("Qqc_component_Add",param);
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
           return Helper .ExecuteNonQuery ("Qqc_component_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Qqc_component">Qqc_component实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Qqc_component model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@component_id",model.Component_id),
                new SqlParameter ("@component_name",model.Component_name),
                new SqlParameter ("@limit",model.Limit),
                new SqlParameter ("@dw",model.Dw),
                new SqlParameter ("@jb_hight",model.Jb_hight),
                new SqlParameter ("@jb_low",model.Jb_low),
                new SqlParameter ("@limit_jc",model.Limit_jc),
                new SqlParameter ("@group_ss",model.Group_ss),
                new SqlParameter ("@edit_times",model.Edit_times),
                new SqlParameter ("@edit_date",model.Edit_date),
                new SqlParameter ("@edit_reason",model.Edit_reason),
                new SqlParameter ("@bz",model.Bz)
            };
           return Helper .ExecuteNonQuery ("Qqc_component_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Qqc_component> selectAll()
        {
            List<Qqc_component> list = new List<Qqc_component>();
            Qqc_component model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Qqc_component_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Qqc_component();
                    model.Bh = dr["bh"].ToString();
                    model.Component_id = dr["component_id"].ToString();
                    if (DBNull.Value!=dr["component_name"])
                        model.Component_name = dr["component_name"].ToString();
                    if (DBNull.Value!=dr["limit"])
                        model.Limit= Convert.ToDecimal(dr["limit"]);
                    if (DBNull.Value!=dr["dw"])
                        model.Dw = dr["dw"].ToString();
                    if (DBNull.Value!=dr["jb_hight"])
                        model.Jb_hight= Convert.ToDecimal(dr["jb_hight"]);
                    if (DBNull.Value!=dr["jb_low"])
                        model.Jb_low= Convert.ToDecimal(dr["jb_low"]);
                    if (DBNull.Value!=dr["limit_jc"])
                        model.Limit_jc= Convert.ToDecimal(dr["limit_jc"]);
                    if (DBNull.Value!=dr["group_ss"])
                        model.Group_ss = dr["group_ss"].ToString();
                    if (DBNull.Value!=dr["edit_times"])
                        model.Edit_times= Convert.ToInt32(dr["edit_times"]);
                    if (DBNull.Value!=dr["edit_date"])
                        model.Edit_date= Convert.ToDateTime(dr["edit_date"]);
                    if (DBNull.Value!=dr["edit_reason"])
                        model.Edit_reason = dr["edit_reason"].ToString();
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Qqc_component实体类对象</returns>
        public Qqc_component selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Qqc_component model = new Qqc_component();
            using (SqlDataReader dr = Helper.ExecuteReader("Qqc_component_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bh = dr["bh"].ToString();
                    model.Component_id = dr["component_id"].ToString();
                    if (DBNull.Value!=dr["component_name"])
                        model.Component_name = dr["component_name"].ToString();
                    if (DBNull.Value!=dr["limit"])
                        model.Limit= Convert.ToDecimal(dr["limit"]);
                    if (DBNull.Value!=dr["dw"])
                        model.Dw = dr["dw"].ToString();
                    if (DBNull.Value!=dr["jb_hight"])
                        model.Jb_hight= Convert.ToDecimal(dr["jb_hight"]);
                    if (DBNull.Value!=dr["jb_low"])
                        model.Jb_low= Convert.ToDecimal(dr["jb_low"]);
                    if (DBNull.Value!=dr["limit_jc"])
                        model.Limit_jc= Convert.ToDecimal(dr["limit_jc"]);
                    if (DBNull.Value!=dr["group_ss"])
                        model.Group_ss = dr["group_ss"].ToString();
                    if (DBNull.Value!=dr["edit_times"])
                        model.Edit_times= Convert.ToInt32(dr["edit_times"]);
                    if (DBNull.Value!=dr["edit_date"])
                        model.Edit_date= Convert.ToDateTime(dr["edit_date"]);
                    if (DBNull.Value!=dr["edit_reason"])
                        model.Edit_reason = dr["edit_reason"].ToString();
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Qqc_component实体类对象</returns>
        public List<Qqc_component> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Qqc_component> list = new List<Qqc_component>();
            Qqc_component model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Qqc_component_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Qqc_component();
                    model.Bh = dr["bh"].ToString();
                    model.Component_id = dr["component_id"].ToString();
                    if (DBNull.Value!=dr["component_name"])
                        model.Component_name = dr["component_name"].ToString();
                    if (DBNull.Value!=dr["limit"])
                        model.Limit= Convert.ToDecimal(dr["limit"]);
                    if (DBNull.Value!=dr["dw"])
                        model.Dw = dr["dw"].ToString();
                    if (DBNull.Value!=dr["jb_hight"])
                        model.Jb_hight= Convert.ToDecimal(dr["jb_hight"]);
                    if (DBNull.Value!=dr["jb_low"])
                        model.Jb_low= Convert.ToDecimal(dr["jb_low"]);
                    if (DBNull.Value!=dr["limit_jc"])
                        model.Limit_jc= Convert.ToDecimal(dr["limit_jc"]);
                    if (DBNull.Value!=dr["group_ss"])
                        model.Group_ss = dr["group_ss"].ToString();
                    if (DBNull.Value!=dr["edit_times"])
                        model.Edit_times= Convert.ToInt32(dr["edit_times"]);
                    if (DBNull.Value!=dr["edit_date"])
                        model.Edit_date= Convert.ToDateTime(dr["edit_date"]);
                    if (DBNull.Value!=dr["edit_reason"])
                        model.Edit_reason = dr["edit_reason"].ToString();
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

