using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Samples_reasonService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Samples_reason">Samples_reason实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Samples_reason model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@sample_id",model.Sample_id),
                new SqlParameter ("@component_id",model.Component_id),
                new SqlParameter ("@component_name",model.Component_name),
                new SqlParameter ("@result",model.Result),
                new SqlParameter ("@reason",model.Reason),
                new SqlParameter ("@edit_name",model.Edit_name),
                new SqlParameter ("@edit_date",model.Edit_date),
                new SqlParameter ("@jc_result",model.Jc_result),
                new SqlParameter ("@resut",model.Resut)
            };
           return Helper .ExecuteNonQuery ("Samples_reason_Add",param);
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
           return Helper .ExecuteNonQuery ("Samples_reason_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Samples_reason">Samples_reason实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Samples_reason model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@sample_id",model.Sample_id),
                new SqlParameter ("@component_id",model.Component_id),
                new SqlParameter ("@component_name",model.Component_name),
                new SqlParameter ("@result",model.Result),
                new SqlParameter ("@reason",model.Reason),
                new SqlParameter ("@edit_name",model.Edit_name),
                new SqlParameter ("@edit_date",model.Edit_date),
                new SqlParameter ("@jc_result",model.Jc_result),
                new SqlParameter ("@resut",model.Resut)
            };
           return Helper .ExecuteNonQuery ("Samples_reason_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Samples_reason> selectAll()
        {
            List<Samples_reason> list = new List<Samples_reason>();
            Samples_reason model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Samples_reason_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Samples_reason();
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["sample_id"])
                        model.Sample_id = dr["sample_id"].ToString();
                    if (DBNull.Value!=dr["component_id"])
                        model.Component_id = dr["component_id"].ToString();
                    if (DBNull.Value!=dr["component_name"])
                        model.Component_name = dr["component_name"].ToString();
                    model.Result= Convert.ToByte(dr["result"]);
                    if (DBNull.Value!=dr["reason"])
                        model.Reason = dr["reason"].ToString();
                    if (DBNull.Value!=dr["edit_name"])
                        model.Edit_name = dr["edit_name"].ToString();
                    if (DBNull.Value!=dr["edit_date"])
                        model.Edit_date= Convert.ToDateTime(dr["edit_date"]);
                    if (DBNull.Value!=dr["jc_result"])
                        model.Jc_result= Convert.ToDecimal(dr["jc_result"]);
                    if (DBNull.Value!=dr["resut"])
                        model.Resut = dr["resut"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Samples_reason实体类对象</returns>
        public Samples_reason selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Samples_reason model = new Samples_reason();
            using (SqlDataReader dr = Helper.ExecuteReader("Samples_reason_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["sample_id"])
                        model.Sample_id = dr["sample_id"].ToString();
                    if (DBNull.Value!=dr["component_id"])
                        model.Component_id = dr["component_id"].ToString();
                    if (DBNull.Value!=dr["component_name"])
                        model.Component_name = dr["component_name"].ToString();
                    model.Result= Convert.ToByte(dr["result"]);
                    if (DBNull.Value!=dr["reason"])
                        model.Reason = dr["reason"].ToString();
                    if (DBNull.Value!=dr["edit_name"])
                        model.Edit_name = dr["edit_name"].ToString();
                    if (DBNull.Value!=dr["edit_date"])
                        model.Edit_date= Convert.ToDateTime(dr["edit_date"]);
                    if (DBNull.Value!=dr["jc_result"])
                        model.Jc_result= Convert.ToDecimal(dr["jc_result"]);
                    if (DBNull.Value!=dr["resut"])
                        model.Resut = dr["resut"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Samples_reason实体类对象</returns>
        public List<Samples_reason> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Samples_reason> list = new List<Samples_reason>();
            Samples_reason model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Samples_reason_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Samples_reason();
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["sample_id"])
                        model.Sample_id = dr["sample_id"].ToString();
                    if (DBNull.Value!=dr["component_id"])
                        model.Component_id = dr["component_id"].ToString();
                    if (DBNull.Value!=dr["component_name"])
                        model.Component_name = dr["component_name"].ToString();
                    model.Result= Convert.ToByte(dr["result"]);
                    if (DBNull.Value!=dr["reason"])
                        model.Reason = dr["reason"].ToString();
                    if (DBNull.Value!=dr["edit_name"])
                        model.Edit_name = dr["edit_name"].ToString();
                    if (DBNull.Value!=dr["edit_date"])
                        model.Edit_date= Convert.ToDateTime(dr["edit_date"]);
                    if (DBNull.Value!=dr["jc_result"])
                        model.Jc_result= Convert.ToDecimal(dr["jc_result"]);
                    if (DBNull.Value!=dr["resut"])
                        model.Resut = dr["resut"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

