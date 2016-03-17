using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class XjyhService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Xjyh">Xjyh实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Xjyh model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc),
                new SqlParameter ("@init_je",model.Init_je),
                new SqlParameter ("@je",model.Je),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@is_sh",model.Is_sh),
                new SqlParameter ("@shr",model.Shr),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@updated_by",model.Updated_by),
                new SqlParameter ("@update_date",model.Update_date),
                new SqlParameter ("@dress",model.Dress)
            };
           return Helper .ExecuteNonQuery ("Xjyh_Add",param);
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
           return Helper .ExecuteNonQuery ("Xjyh_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Xjyh">Xjyh实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Xjyh model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc),
                new SqlParameter ("@init_je",model.Init_je),
                new SqlParameter ("@je",model.Je),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@is_sh",model.Is_sh),
                new SqlParameter ("@shr",model.Shr),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@updated_by",model.Updated_by),
                new SqlParameter ("@update_date",model.Update_date),
                new SqlParameter ("@dress",model.Dress)
            };
           return Helper .ExecuteNonQuery ("Xjyh_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Xjyh> selectAll()
        {
            List<Xjyh> list = new List<Xjyh>();
            Xjyh model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Xjyh_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Xjyh();
                    model.Bh = dr["bh"].ToString();
                    model.Bm = dr["bm"].ToString();
                    model.Mc = dr["mc"].ToString();
                    model.Init_je= Convert.ToDecimal(dr["init_je"]);
                    model.Je= Convert.ToDecimal(dr["je"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    model.Is_sh= Convert.ToByte(dr["is_sh"]);
                    if (DBNull.Value!=dr["shr"])
                        model.Shr = dr["shr"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["dress"])
                        model.Dress = dr["dress"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Xjyh实体类对象</returns>
        public Xjyh selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Xjyh model = new Xjyh();
            using (SqlDataReader dr = Helper.ExecuteReader("Xjyh_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bh = dr["bh"].ToString();
                    model.Bm = dr["bm"].ToString();
                    model.Mc = dr["mc"].ToString();
                    model.Init_je= Convert.ToDecimal(dr["init_je"]);
                    model.Je= Convert.ToDecimal(dr["je"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    model.Is_sh= Convert.ToByte(dr["is_sh"]);
                    if (DBNull.Value!=dr["shr"])
                        model.Shr = dr["shr"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["dress"])
                        model.Dress = dr["dress"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Xjyh实体类对象</returns>
        public List<Xjyh> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Xjyh> list = new List<Xjyh>();
            Xjyh model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Xjyh_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Xjyh();
                    model.Bh = dr["bh"].ToString();
                    model.Bm = dr["bm"].ToString();
                    model.Mc = dr["mc"].ToString();
                    model.Init_je= Convert.ToDecimal(dr["init_je"]);
                    model.Je= Convert.ToDecimal(dr["je"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    model.Is_sh= Convert.ToByte(dr["is_sh"]);
                    if (DBNull.Value!=dr["shr"])
                        model.Shr = dr["shr"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["dress"])
                        model.Dress = dr["dress"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

