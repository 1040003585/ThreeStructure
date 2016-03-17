using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class QqcService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Qqc">Qqc实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Qqc model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@waste_id",model.Waste_id),
                new SqlParameter ("@temp_id",model.Temp_id),
                new SqlParameter ("@sequence_no",model.Sequence_no),
                new SqlParameter ("@result",model.Result),
                new SqlParameter ("@component_id",model.Component_id),
                new SqlParameter ("@component_name",model.Component_name),
                new SqlParameter ("@container_id",model.Container_id),
                new SqlParameter ("@status",model.Status),
                new SqlParameter ("@hgz",model.Hgz),
                new SqlParameter ("@bhgz",model.Bhgz),
                new SqlParameter ("@hg",model.Hg),
                new SqlParameter ("@bhg",model.Bhg)
            };
           return Helper .ExecuteNonQuery ("Qqc_Add",param);
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
           return Helper .ExecuteNonQuery ("Qqc_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Qqc">Qqc实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Qqc model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@waste_id",model.Waste_id),
                new SqlParameter ("@temp_id",model.Temp_id),
                new SqlParameter ("@sequence_no",model.Sequence_no),
                new SqlParameter ("@result",model.Result),
                new SqlParameter ("@component_id",model.Component_id),
                new SqlParameter ("@component_name",model.Component_name),
                new SqlParameter ("@container_id",model.Container_id),
                new SqlParameter ("@status",model.Status),
                new SqlParameter ("@hgz",model.Hgz),
                new SqlParameter ("@bhgz",model.Bhgz),
                new SqlParameter ("@hg",model.Hg),
                new SqlParameter ("@bhg",model.Bhg)
            };
           return Helper .ExecuteNonQuery ("Qqc_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Qqc> selectAll()
        {
            List<Qqc> list = new List<Qqc>();
            Qqc model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Qqc_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Qqc();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Waste_id = dr["waste_id"].ToString();
                    model.Temp_id = dr["temp_id"].ToString();
                    if (DBNull.Value!=dr["sequence_no"])
                        model.Sequence_no = dr["sequence_no"].ToString();
                    if (DBNull.Value!=dr["result"])
                        model.Result = dr["result"].ToString();
                    if (DBNull.Value!=dr["component_id"])
                        model.Component_id = dr["component_id"].ToString();
                    if (DBNull.Value!=dr["component_name"])
                        model.Component_name = dr["component_name"].ToString();
                    if (DBNull.Value!=dr["container_id"])
                        model.Container_id = dr["container_id"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status= Convert.ToByte(dr["status"]);
                    if (DBNull.Value!=dr["hgz"])
                        model.Hgz= Convert.ToDecimal(dr["hgz"]);
                    if (DBNull.Value!=dr["bhgz"])
                        model.Bhgz= Convert.ToDecimal(dr["bhgz"]);
                    if (DBNull.Value!=dr["hg"])
                        model.Hg = dr["hg"].ToString();
                    if (DBNull.Value!=dr["bhg"])
                        model.Bhg = dr["bhg"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Qqc实体类对象</returns>
        public Qqc selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Qqc model = new Qqc();
            using (SqlDataReader dr = Helper.ExecuteReader("Qqc_SelectById", param))
            {
                if (dr.Read())
                {
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Waste_id = dr["waste_id"].ToString();
                    model.Temp_id = dr["temp_id"].ToString();
                    if (DBNull.Value!=dr["sequence_no"])
                        model.Sequence_no = dr["sequence_no"].ToString();
                    if (DBNull.Value!=dr["result"])
                        model.Result = dr["result"].ToString();
                    if (DBNull.Value!=dr["component_id"])
                        model.Component_id = dr["component_id"].ToString();
                    if (DBNull.Value!=dr["component_name"])
                        model.Component_name = dr["component_name"].ToString();
                    if (DBNull.Value!=dr["container_id"])
                        model.Container_id = dr["container_id"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status= Convert.ToByte(dr["status"]);
                    if (DBNull.Value!=dr["hgz"])
                        model.Hgz= Convert.ToDecimal(dr["hgz"]);
                    if (DBNull.Value!=dr["bhgz"])
                        model.Bhgz= Convert.ToDecimal(dr["bhgz"]);
                    if (DBNull.Value!=dr["hg"])
                        model.Hg = dr["hg"].ToString();
                    if (DBNull.Value!=dr["bhg"])
                        model.Bhg = dr["bhg"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Qqc实体类对象</returns>
        public List<Qqc> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Qqc> list = new List<Qqc>();
            Qqc model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Qqc_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Qqc();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Waste_id = dr["waste_id"].ToString();
                    model.Temp_id = dr["temp_id"].ToString();
                    if (DBNull.Value!=dr["sequence_no"])
                        model.Sequence_no = dr["sequence_no"].ToString();
                    if (DBNull.Value!=dr["result"])
                        model.Result = dr["result"].ToString();
                    if (DBNull.Value!=dr["component_id"])
                        model.Component_id = dr["component_id"].ToString();
                    if (DBNull.Value!=dr["component_name"])
                        model.Component_name = dr["component_name"].ToString();
                    if (DBNull.Value!=dr["container_id"])
                        model.Container_id = dr["container_id"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status= Convert.ToByte(dr["status"]);
                    if (DBNull.Value!=dr["hgz"])
                        model.Hgz= Convert.ToDecimal(dr["hgz"]);
                    if (DBNull.Value!=dr["bhgz"])
                        model.Bhgz= Convert.ToDecimal(dr["bhgz"]);
                    if (DBNull.Value!=dr["hg"])
                        model.Hg = dr["hg"].ToString();
                    if (DBNull.Value!=dr["bhg"])
                        model.Bhg = dr["bhg"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

