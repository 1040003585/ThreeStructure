using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Qqc_fast_detailService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Qqc_fast_detail">Qqc_fast_detail实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Qqc_fast_detail model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@container_id",model.Container_id),
                new SqlParameter ("@component_id",model.Component_id),
                new SqlParameter ("@component_name",model.Component_name),
                new SqlParameter ("@result",model.Result),
                new SqlParameter ("@hgz",model.Hgz),
                new SqlParameter ("@bhgz",model.Bhgz),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@hg",model.Hg),
                new SqlParameter ("@bhg",model.Bhg),
                new SqlParameter ("@qz_result",model.Qz_result),
                new SqlParameter ("@qzbz",model.Qzbz),
                new SqlParameter ("@qz_edit",model.Qz_edit),
                new SqlParameter ("@qz_editdate",model.Qz_editdate)
            };
           return Helper .ExecuteNonQuery ("Qqc_fast_detail_Add",param);
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
           return Helper .ExecuteNonQuery ("Qqc_fast_detail_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Qqc_fast_detail">Qqc_fast_detail实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Qqc_fast_detail model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@container_id",model.Container_id),
                new SqlParameter ("@component_id",model.Component_id),
                new SqlParameter ("@component_name",model.Component_name),
                new SqlParameter ("@result",model.Result),
                new SqlParameter ("@hgz",model.Hgz),
                new SqlParameter ("@bhgz",model.Bhgz),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@hg",model.Hg),
                new SqlParameter ("@bhg",model.Bhg),
                new SqlParameter ("@qz_result",model.Qz_result),
                new SqlParameter ("@qzbz",model.Qzbz),
                new SqlParameter ("@qz_edit",model.Qz_edit),
                new SqlParameter ("@qz_editdate",model.Qz_editdate)
            };
           return Helper .ExecuteNonQuery ("Qqc_fast_detail_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Qqc_fast_detail> selectAll()
        {
            List<Qqc_fast_detail> list = new List<Qqc_fast_detail>();
            Qqc_fast_detail model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Qqc_fast_detail_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Qqc_fast_detail();
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["container_id"])
                        model.Container_id = dr["container_id"].ToString();
                    model.Component_id = dr["component_id"].ToString();
                    if (DBNull.Value!=dr["component_name"])
                        model.Component_name = dr["component_name"].ToString();
                    model.Result= Convert.ToByte(dr["result"]);
                    if (DBNull.Value!=dr["hgz"])
                        model.Hgz= Convert.ToDecimal(dr["hgz"]);
                    if (DBNull.Value!=dr["bhgz"])
                        model.Bhgz= Convert.ToDecimal(dr["bhgz"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["hg"])
                        model.Hg = dr["hg"].ToString();
                    if (DBNull.Value!=dr["bhg"])
                        model.Bhg = dr["bhg"].ToString();
                    if (DBNull.Value!=dr["qz_result"])
                        model.Qz_result= Convert.ToByte(dr["qz_result"]);
                    if (DBNull.Value!=dr["qzbz"])
                        model.Qzbz = dr["qzbz"].ToString();
                    if (DBNull.Value!=dr["qz_edit"])
                        model.Qz_edit = dr["qz_edit"].ToString();
                    if (DBNull.Value!=dr["qz_editdate"])
                        model.Qz_editdate= Convert.ToDateTime(dr["qz_editdate"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Qqc_fast_detail实体类对象</returns>
        public Qqc_fast_detail selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Qqc_fast_detail model = new Qqc_fast_detail();
            using (SqlDataReader dr = Helper.ExecuteReader("Qqc_fast_detail_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["container_id"])
                        model.Container_id = dr["container_id"].ToString();
                    model.Component_id = dr["component_id"].ToString();
                    if (DBNull.Value!=dr["component_name"])
                        model.Component_name = dr["component_name"].ToString();
                    model.Result= Convert.ToByte(dr["result"]);
                    if (DBNull.Value!=dr["hgz"])
                        model.Hgz= Convert.ToDecimal(dr["hgz"]);
                    if (DBNull.Value!=dr["bhgz"])
                        model.Bhgz= Convert.ToDecimal(dr["bhgz"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["hg"])
                        model.Hg = dr["hg"].ToString();
                    if (DBNull.Value!=dr["bhg"])
                        model.Bhg = dr["bhg"].ToString();
                    if (DBNull.Value!=dr["qz_result"])
                        model.Qz_result= Convert.ToByte(dr["qz_result"]);
                    if (DBNull.Value!=dr["qzbz"])
                        model.Qzbz = dr["qzbz"].ToString();
                    if (DBNull.Value!=dr["qz_edit"])
                        model.Qz_edit = dr["qz_edit"].ToString();
                    if (DBNull.Value!=dr["qz_editdate"])
                        model.Qz_editdate= Convert.ToDateTime(dr["qz_editdate"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Qqc_fast_detail实体类对象</returns>
        public List<Qqc_fast_detail> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Qqc_fast_detail> list = new List<Qqc_fast_detail>();
            Qqc_fast_detail model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Qqc_fast_detail_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Qqc_fast_detail();
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["container_id"])
                        model.Container_id = dr["container_id"].ToString();
                    model.Component_id = dr["component_id"].ToString();
                    if (DBNull.Value!=dr["component_name"])
                        model.Component_name = dr["component_name"].ToString();
                    model.Result= Convert.ToByte(dr["result"]);
                    if (DBNull.Value!=dr["hgz"])
                        model.Hgz= Convert.ToDecimal(dr["hgz"]);
                    if (DBNull.Value!=dr["bhgz"])
                        model.Bhgz= Convert.ToDecimal(dr["bhgz"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["hg"])
                        model.Hg = dr["hg"].ToString();
                    if (DBNull.Value!=dr["bhg"])
                        model.Bhg = dr["bhg"].ToString();
                    if (DBNull.Value!=dr["qz_result"])
                        model.Qz_result= Convert.ToByte(dr["qz_result"]);
                    if (DBNull.Value!=dr["qzbz"])
                        model.Qzbz = dr["qzbz"].ToString();
                    if (DBNull.Value!=dr["qz_edit"])
                        model.Qz_edit = dr["qz_edit"].ToString();
                    if (DBNull.Value!=dr["qz_editdate"])
                        model.Qz_editdate= Convert.ToDateTime(dr["qz_editdate"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

