using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Qqc_templateService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Qqc_template">Qqc_template实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Qqc_template model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@temp_id",model.Temp_id),
                new SqlParameter ("@name",model.Name),
                new SqlParameter ("@sequence_no",model.Sequence_no)
            };
           return Helper .ExecuteNonQuery ("Qqc_template_Add",param);
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
           return Helper .ExecuteNonQuery ("Qqc_template_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Qqc_template">Qqc_template实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Qqc_template model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@temp_id",model.Temp_id),
                new SqlParameter ("@name",model.Name),
                new SqlParameter ("@sequence_no",model.Sequence_no)
            };
           return Helper .ExecuteNonQuery ("Qqc_template_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Qqc_template> selectAll()
        {
            List<Qqc_template> list = new List<Qqc_template>();
            Qqc_template model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Qqc_template_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Qqc_template();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Temp_id = dr["temp_id"].ToString();
                    if (DBNull.Value!=dr["name"])
                        model.Name = dr["name"].ToString();
                    if (DBNull.Value!=dr["sequence_no"])
                        model.Sequence_no = dr["sequence_no"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Qqc_template实体类对象</returns>
        public Qqc_template selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Qqc_template model = new Qqc_template();
            using (SqlDataReader dr = Helper.ExecuteReader("Qqc_template_SelectById", param))
            {
                if (dr.Read())
                {
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Temp_id = dr["temp_id"].ToString();
                    if (DBNull.Value!=dr["name"])
                        model.Name = dr["name"].ToString();
                    if (DBNull.Value!=dr["sequence_no"])
                        model.Sequence_no = dr["sequence_no"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Qqc_template实体类对象</returns>
        public List<Qqc_template> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Qqc_template> list = new List<Qqc_template>();
            Qqc_template model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Qqc_template_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Qqc_template();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Temp_id = dr["temp_id"].ToString();
                    if (DBNull.Value!=dr["name"])
                        model.Name = dr["name"].ToString();
                    if (DBNull.Value!=dr["sequence_no"])
                        model.Sequence_no = dr["sequence_no"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

