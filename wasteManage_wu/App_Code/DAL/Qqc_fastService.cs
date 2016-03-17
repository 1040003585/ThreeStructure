using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Qqc_fastService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Qqc_fast">Qqc_fast实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Qqc_fast model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@waste_code",model.Waste_code),
                new SqlParameter ("@container_id",model.Container_id),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@edit_by",model.Edit_by),
                new SqlParameter ("@edit_date",model.Edit_date),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@is_sh",model.Is_sh),
                new SqlParameter ("@shr",model.Shr),
                new SqlParameter ("@sh_date",model.Sh_date),
                new SqlParameter ("@result",model.Result),
                new SqlParameter ("@edit_times",model.Edit_times)
            };
           return Helper .ExecuteNonQuery ("Qqc_fast_Add",param);
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
           return Helper .ExecuteNonQuery ("Qqc_fast_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Qqc_fast">Qqc_fast实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Qqc_fast model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@waste_code",model.Waste_code),
                new SqlParameter ("@container_id",model.Container_id),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@edit_by",model.Edit_by),
                new SqlParameter ("@edit_date",model.Edit_date),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@is_sh",model.Is_sh),
                new SqlParameter ("@shr",model.Shr),
                new SqlParameter ("@sh_date",model.Sh_date),
                new SqlParameter ("@result",model.Result),
                new SqlParameter ("@edit_times",model.Edit_times)
            };
           return Helper .ExecuteNonQuery ("Qqc_fast_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Qqc_fast> selectAll()
        {
            List<Qqc_fast> list = new List<Qqc_fast>();
            Qqc_fast model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Qqc_fast_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Qqc_fast();
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["waste_code"])
                        model.Waste_code = dr["waste_code"].ToString();
                    if (DBNull.Value!=dr["container_id"])
                        model.Container_id = dr["container_id"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["edit_by"])
                        model.Edit_by = dr["edit_by"].ToString();
                    if (DBNull.Value!=dr["edit_date"])
                        model.Edit_date= Convert.ToDateTime(dr["edit_date"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    model.Is_sh= Convert.ToByte(dr["is_sh"]);
                    if (DBNull.Value!=dr["shr"])
                        model.Shr = dr["shr"].ToString();
                    if (DBNull.Value!=dr["sh_date"])
                        model.Sh_date= Convert.ToDateTime(dr["sh_date"]);
                    model.Result= Convert.ToByte(dr["result"]);
                    model.Edit_times= Convert.ToByte(dr["edit_times"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Qqc_fast实体类对象</returns>
        public Qqc_fast selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Qqc_fast model = new Qqc_fast();
            using (SqlDataReader dr = Helper.ExecuteReader("Qqc_fast_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["waste_code"])
                        model.Waste_code = dr["waste_code"].ToString();
                    if (DBNull.Value!=dr["container_id"])
                        model.Container_id = dr["container_id"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["edit_by"])
                        model.Edit_by = dr["edit_by"].ToString();
                    if (DBNull.Value!=dr["edit_date"])
                        model.Edit_date= Convert.ToDateTime(dr["edit_date"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    model.Is_sh= Convert.ToByte(dr["is_sh"]);
                    if (DBNull.Value!=dr["shr"])
                        model.Shr = dr["shr"].ToString();
                    if (DBNull.Value!=dr["sh_date"])
                        model.Sh_date= Convert.ToDateTime(dr["sh_date"]);
                    model.Result= Convert.ToByte(dr["result"]);
                    model.Edit_times= Convert.ToByte(dr["edit_times"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Qqc_fast实体类对象</returns>
        public List<Qqc_fast> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Qqc_fast> list = new List<Qqc_fast>();
            Qqc_fast model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Qqc_fast_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Qqc_fast();
                    model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["waste_code"])
                        model.Waste_code = dr["waste_code"].ToString();
                    if (DBNull.Value!=dr["container_id"])
                        model.Container_id = dr["container_id"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["edit_by"])
                        model.Edit_by = dr["edit_by"].ToString();
                    if (DBNull.Value!=dr["edit_date"])
                        model.Edit_date= Convert.ToDateTime(dr["edit_date"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    model.Is_sh= Convert.ToByte(dr["is_sh"]);
                    if (DBNull.Value!=dr["shr"])
                        model.Shr = dr["shr"].ToString();
                    if (DBNull.Value!=dr["sh_date"])
                        model.Sh_date= Convert.ToDateTime(dr["sh_date"]);
                    model.Result= Convert.ToByte(dr["result"]);
                    model.Edit_times= Convert.ToByte(dr["edit_times"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

