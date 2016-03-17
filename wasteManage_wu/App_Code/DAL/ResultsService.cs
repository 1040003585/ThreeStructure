using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ResultsService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Results">Results实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Results model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@sample_id",model.Sample_id),
                new SqlParameter ("@profile_id",model.Profile_id),
                new SqlParameter ("@component_name",model.Component_name),
                new SqlParameter ("@result",model.Result),
                new SqlParameter ("@updated_by",model.Updated_by),
                new SqlParameter ("@update_date",model.Update_date)
            };
           return Helper .ExecuteNonQuery ("Results_Add",param);
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
           return Helper .ExecuteNonQuery ("Results_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Results">Results实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Results model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@sample_id",model.Sample_id),
                new SqlParameter ("@profile_id",model.Profile_id),
                new SqlParameter ("@component_name",model.Component_name),
                new SqlParameter ("@result",model.Result),
                new SqlParameter ("@updated_by",model.Updated_by),
                new SqlParameter ("@update_date",model.Update_date)
            };
           return Helper .ExecuteNonQuery ("Results_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Results> selectAll()
        {
            List<Results> list = new List<Results>();
            Results model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Results_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Results();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Sample_id = dr["sample_id"].ToString();
                    model.Profile_id = dr["profile_id"].ToString();
                    if (DBNull.Value!=dr["component_name"])
                        model.Component_name = dr["component_name"].ToString();
                    if (DBNull.Value!=dr["result"])
                        model.Result = dr["result"].ToString();
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Results实体类对象</returns>
        public Results selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Results model = new Results();
            using (SqlDataReader dr = Helper.ExecuteReader("Results_SelectById", param))
            {
                if (dr.Read())
                {
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Sample_id = dr["sample_id"].ToString();
                    model.Profile_id = dr["profile_id"].ToString();
                    if (DBNull.Value!=dr["component_name"])
                        model.Component_name = dr["component_name"].ToString();
                    if (DBNull.Value!=dr["result"])
                        model.Result = dr["result"].ToString();
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Results实体类对象</returns>
        public List<Results> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Results> list = new List<Results>();
            Results model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Results_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Results();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Sample_id = dr["sample_id"].ToString();
                    model.Profile_id = dr["profile_id"].ToString();
                    if (DBNull.Value!=dr["component_name"])
                        model.Component_name = dr["component_name"].ToString();
                    if (DBNull.Value!=dr["result"])
                        model.Result = dr["result"].ToString();
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

