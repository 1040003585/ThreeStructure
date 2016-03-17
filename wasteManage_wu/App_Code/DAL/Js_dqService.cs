using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Js_dqService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Js_dq">Js_dq实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Js_dq model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc),
                new SqlParameter ("@oper_type",model.Oper_type),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@is_sh",model.Is_sh),
                new SqlParameter ("@sh_date",model.Sh_date),
                new SqlParameter ("@shr",model.Shr),
                new SqlParameter ("@is_stop",model.Is_stop)
            };
           return Helper .ExecuteNonQuery ("Js_dq_Add",param);
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
           return Helper .ExecuteNonQuery ("Js_dq_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Js_dq">Js_dq实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Js_dq model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc),
                new SqlParameter ("@oper_type",model.Oper_type),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@is_sh",model.Is_sh),
                new SqlParameter ("@sh_date",model.Sh_date),
                new SqlParameter ("@shr",model.Shr),
                new SqlParameter ("@is_stop",model.Is_stop)
            };
           return Helper .ExecuteNonQuery ("Js_dq_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Js_dq> selectAll()
        {
            List<Js_dq> list = new List<Js_dq>();
            Js_dq model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Js_dq_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Js_dq();
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["bm"])
                        model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    if (DBNull.Value!=dr["oper_type"])
                        model.Oper_type = dr["oper_type"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["is_sh"])
                        model.Is_sh= Convert.ToByte(dr["is_sh"]);
                    if (DBNull.Value!=dr["sh_date"])
                        model.Sh_date= Convert.ToDateTime(dr["sh_date"]);
                    if (DBNull.Value!=dr["shr"])
                        model.Shr = dr["shr"].ToString();
                    if (DBNull.Value!=dr["is_stop"])
                        model.Is_stop= Convert.ToByte(dr["is_stop"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Js_dq实体类对象</returns>
        public Js_dq selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Js_dq model = new Js_dq();
            using (SqlDataReader dr = Helper.ExecuteReader("Js_dq_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["bm"])
                        model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    if (DBNull.Value!=dr["oper_type"])
                        model.Oper_type = dr["oper_type"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["is_sh"])
                        model.Is_sh= Convert.ToByte(dr["is_sh"]);
                    if (DBNull.Value!=dr["sh_date"])
                        model.Sh_date= Convert.ToDateTime(dr["sh_date"]);
                    if (DBNull.Value!=dr["shr"])
                        model.Shr = dr["shr"].ToString();
                    if (DBNull.Value!=dr["is_stop"])
                        model.Is_stop= Convert.ToByte(dr["is_stop"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Js_dq实体类对象</returns>
        public List<Js_dq> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Js_dq> list = new List<Js_dq>();
            Js_dq model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Js_dq_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Js_dq();
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["bm"])
                        model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    if (DBNull.Value!=dr["oper_type"])
                        model.Oper_type = dr["oper_type"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["is_sh"])
                        model.Is_sh= Convert.ToByte(dr["is_sh"]);
                    if (DBNull.Value!=dr["sh_date"])
                        model.Sh_date= Convert.ToDateTime(dr["sh_date"]);
                    if (DBNull.Value!=dr["shr"])
                        model.Shr = dr["shr"].ToString();
                    if (DBNull.Value!=dr["is_stop"])
                        model.Is_stop= Convert.ToByte(dr["is_stop"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

