using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Wast_emplyeeService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Wast_emplyee">Wast_emplyee实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Wast_emplyee model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc),
                new SqlParameter ("@bm_bm",model.Bm_bm),
                new SqlParameter ("@sex",model.Sex),
                new SqlParameter ("@tel",model.Tel),
                new SqlParameter ("@birthday",model.Birthday),
                new SqlParameter ("@id_card",model.Id_card),
                new SqlParameter ("@remark",model.Remark),
                new SqlParameter ("@is_jbr",model.Is_jbr),
                new SqlParameter ("@is_czy",model.Is_czy),
                new SqlParameter ("@rq_last_save_n",model.Rq_last_save_n),
                new SqlParameter ("@jg",model.Jg),
                new SqlParameter ("@mz",model.Mz),
                new SqlParameter ("@xl",model.Xl),
                new SqlParameter ("@zc",model.Zc),
                new SqlParameter ("@is_married",model.Is_married),
                new SqlParameter ("@dz",model.Dz),
                new SqlParameter ("@zzmm",model.Zzmm),
                new SqlParameter ("@birthday_nl",model.Birthday_nl),
                new SqlParameter ("@dz_home",model.Dz_home),
                new SqlParameter ("@mobile",model.Mobile),
                new SqlParameter ("@qq",model.Qq),
                new SqlParameter ("@msn",model.Msn),
                new SqlParameter ("@email",model.Email),
                new SqlParameter ("@rq_hire",model.Rq_hire),
                new SqlParameter ("@is_stop",model.Is_stop),
                new SqlParameter ("@rq_fire",model.Rq_fire),
                new SqlParameter ("@yy_fire",model.Yy_fire)
            };
           return Helper .ExecuteNonQuery ("Wast_emplyee_Add",param);
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
           return Helper .ExecuteNonQuery ("Wast_emplyee_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Wast_emplyee">Wast_emplyee实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Wast_emplyee model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc),
                new SqlParameter ("@bm_bm",model.Bm_bm),
                new SqlParameter ("@sex",model.Sex),
                new SqlParameter ("@tel",model.Tel),
                new SqlParameter ("@birthday",model.Birthday),
                new SqlParameter ("@id_card",model.Id_card),
                new SqlParameter ("@remark",model.Remark),
                new SqlParameter ("@is_jbr",model.Is_jbr),
                new SqlParameter ("@is_czy",model.Is_czy),
                new SqlParameter ("@rq_last_save_n",model.Rq_last_save_n),
                new SqlParameter ("@jg",model.Jg),
                new SqlParameter ("@mz",model.Mz),
                new SqlParameter ("@xl",model.Xl),
                new SqlParameter ("@zc",model.Zc),
                new SqlParameter ("@is_married",model.Is_married),
                new SqlParameter ("@dz",model.Dz),
                new SqlParameter ("@zzmm",model.Zzmm),
                new SqlParameter ("@birthday_nl",model.Birthday_nl),
                new SqlParameter ("@dz_home",model.Dz_home),
                new SqlParameter ("@mobile",model.Mobile),
                new SqlParameter ("@qq",model.Qq),
                new SqlParameter ("@msn",model.Msn),
                new SqlParameter ("@email",model.Email),
                new SqlParameter ("@rq_hire",model.Rq_hire),
                new SqlParameter ("@is_stop",model.Is_stop),
                new SqlParameter ("@rq_fire",model.Rq_fire),
                new SqlParameter ("@yy_fire",model.Yy_fire)
            };
           return Helper .ExecuteNonQuery ("Wast_emplyee_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Wast_emplyee> selectAll()
        {
            List<Wast_emplyee> list = new List<Wast_emplyee>();
            Wast_emplyee model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Wast_emplyee_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Wast_emplyee();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    if (DBNull.Value!=dr["bm_bm"])
                        model.Bm_bm = dr["bm_bm"].ToString();
                    if (DBNull.Value!=dr["sex"])
                        model.Sex = dr["sex"].ToString();
                    if (DBNull.Value!=dr["tel"])
                        model.Tel = dr["tel"].ToString();
                    if (DBNull.Value!=dr["birthday"])
                        model.Birthday= Convert.ToDateTime(dr["birthday"]);
                    if (DBNull.Value!=dr["id_card"])
                        model.Id_card = dr["id_card"].ToString();
                    if (DBNull.Value!=dr["remark"])
                        model.Remark = dr["remark"].ToString();
                    if (DBNull.Value!=dr["is_jbr"])
                        model.Is_jbr= Convert.ToByte(dr["is_jbr"]);
                    if (DBNull.Value!=dr["is_czy"])
                        model.Is_czy= Convert.ToByte(dr["is_czy"]);
                    if (DBNull.Value!=dr["rq_last_save_n"])
                        model.Rq_last_save_n= Convert.ToInt32(dr["rq_last_save_n"]);
                    if (DBNull.Value!=dr["jg"])
                        model.Jg = dr["jg"].ToString();
                    if (DBNull.Value!=dr["mz"])
                        model.Mz = dr["mz"].ToString();
                    if (DBNull.Value!=dr["xl"])
                        model.Xl = dr["xl"].ToString();
                    if (DBNull.Value!=dr["zc"])
                        model.Zc = dr["zc"].ToString();
                    if (DBNull.Value!=dr["is_married"])
                        model.Is_married= Convert.ToByte(dr["is_married"]);
                    if (DBNull.Value!=dr["dz"])
                        model.Dz = dr["dz"].ToString();
                    if (DBNull.Value!=dr["zzmm"])
                        model.Zzmm = dr["zzmm"].ToString();
                    if (DBNull.Value!=dr["birthday_nl"])
                        model.Birthday_nl = dr["birthday_nl"].ToString();
                    if (DBNull.Value!=dr["dz_home"])
                        model.Dz_home = dr["dz_home"].ToString();
                    if (DBNull.Value!=dr["mobile"])
                        model.Mobile = dr["mobile"].ToString();
                    if (DBNull.Value!=dr["qq"])
                        model.Qq = dr["qq"].ToString();
                    if (DBNull.Value!=dr["msn"])
                        model.Msn = dr["msn"].ToString();
                    if (DBNull.Value!=dr["email"])
                        model.Email = dr["email"].ToString();
                    if (DBNull.Value!=dr["rq_hire"])
                        model.Rq_hire= Convert.ToDateTime(dr["rq_hire"]);
                    if (DBNull.Value!=dr["is_stop"])
                        model.Is_stop= Convert.ToByte(dr["is_stop"]);
                    if (DBNull.Value!=dr["rq_fire"])
                        model.Rq_fire= Convert.ToDateTime(dr["rq_fire"]);
                    if (DBNull.Value!=dr["yy_fire"])
                        model.Yy_fire = dr["yy_fire"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Wast_emplyee实体类对象</returns>
        public Wast_emplyee selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Wast_emplyee model = new Wast_emplyee();
            using (SqlDataReader dr = Helper.ExecuteReader("Wast_emplyee_SelectById", param))
            {
                if (dr.Read())
                {
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    if (DBNull.Value!=dr["bm_bm"])
                        model.Bm_bm = dr["bm_bm"].ToString();
                    if (DBNull.Value!=dr["sex"])
                        model.Sex = dr["sex"].ToString();
                    if (DBNull.Value!=dr["tel"])
                        model.Tel = dr["tel"].ToString();
                    if (DBNull.Value!=dr["birthday"])
                        model.Birthday= Convert.ToDateTime(dr["birthday"]);
                    if (DBNull.Value!=dr["id_card"])
                        model.Id_card = dr["id_card"].ToString();
                    if (DBNull.Value!=dr["remark"])
                        model.Remark = dr["remark"].ToString();
                    if (DBNull.Value!=dr["is_jbr"])
                        model.Is_jbr= Convert.ToByte(dr["is_jbr"]);
                    if (DBNull.Value!=dr["is_czy"])
                        model.Is_czy= Convert.ToByte(dr["is_czy"]);
                    if (DBNull.Value!=dr["rq_last_save_n"])
                        model.Rq_last_save_n= Convert.ToInt32(dr["rq_last_save_n"]);
                    if (DBNull.Value!=dr["jg"])
                        model.Jg = dr["jg"].ToString();
                    if (DBNull.Value!=dr["mz"])
                        model.Mz = dr["mz"].ToString();
                    if (DBNull.Value!=dr["xl"])
                        model.Xl = dr["xl"].ToString();
                    if (DBNull.Value!=dr["zc"])
                        model.Zc = dr["zc"].ToString();
                    if (DBNull.Value!=dr["is_married"])
                        model.Is_married= Convert.ToByte(dr["is_married"]);
                    if (DBNull.Value!=dr["dz"])
                        model.Dz = dr["dz"].ToString();
                    if (DBNull.Value!=dr["zzmm"])
                        model.Zzmm = dr["zzmm"].ToString();
                    if (DBNull.Value!=dr["birthday_nl"])
                        model.Birthday_nl = dr["birthday_nl"].ToString();
                    if (DBNull.Value!=dr["dz_home"])
                        model.Dz_home = dr["dz_home"].ToString();
                    if (DBNull.Value!=dr["mobile"])
                        model.Mobile = dr["mobile"].ToString();
                    if (DBNull.Value!=dr["qq"])
                        model.Qq = dr["qq"].ToString();
                    if (DBNull.Value!=dr["msn"])
                        model.Msn = dr["msn"].ToString();
                    if (DBNull.Value!=dr["email"])
                        model.Email = dr["email"].ToString();
                    if (DBNull.Value!=dr["rq_hire"])
                        model.Rq_hire= Convert.ToDateTime(dr["rq_hire"]);
                    if (DBNull.Value!=dr["is_stop"])
                        model.Is_stop= Convert.ToByte(dr["is_stop"]);
                    if (DBNull.Value!=dr["rq_fire"])
                        model.Rq_fire= Convert.ToDateTime(dr["rq_fire"]);
                    if (DBNull.Value!=dr["yy_fire"])
                        model.Yy_fire = dr["yy_fire"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Wast_emplyee实体类对象</returns>
        public List<Wast_emplyee> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Wast_emplyee> list = new List<Wast_emplyee>();
            Wast_emplyee model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Wast_emplyee_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Wast_emplyee();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    if (DBNull.Value!=dr["bm_bm"])
                        model.Bm_bm = dr["bm_bm"].ToString();
                    if (DBNull.Value!=dr["sex"])
                        model.Sex = dr["sex"].ToString();
                    if (DBNull.Value!=dr["tel"])
                        model.Tel = dr["tel"].ToString();
                    if (DBNull.Value!=dr["birthday"])
                        model.Birthday= Convert.ToDateTime(dr["birthday"]);
                    if (DBNull.Value!=dr["id_card"])
                        model.Id_card = dr["id_card"].ToString();
                    if (DBNull.Value!=dr["remark"])
                        model.Remark = dr["remark"].ToString();
                    if (DBNull.Value!=dr["is_jbr"])
                        model.Is_jbr= Convert.ToByte(dr["is_jbr"]);
                    if (DBNull.Value!=dr["is_czy"])
                        model.Is_czy= Convert.ToByte(dr["is_czy"]);
                    if (DBNull.Value!=dr["rq_last_save_n"])
                        model.Rq_last_save_n= Convert.ToInt32(dr["rq_last_save_n"]);
                    if (DBNull.Value!=dr["jg"])
                        model.Jg = dr["jg"].ToString();
                    if (DBNull.Value!=dr["mz"])
                        model.Mz = dr["mz"].ToString();
                    if (DBNull.Value!=dr["xl"])
                        model.Xl = dr["xl"].ToString();
                    if (DBNull.Value!=dr["zc"])
                        model.Zc = dr["zc"].ToString();
                    if (DBNull.Value!=dr["is_married"])
                        model.Is_married= Convert.ToByte(dr["is_married"]);
                    if (DBNull.Value!=dr["dz"])
                        model.Dz = dr["dz"].ToString();
                    if (DBNull.Value!=dr["zzmm"])
                        model.Zzmm = dr["zzmm"].ToString();
                    if (DBNull.Value!=dr["birthday_nl"])
                        model.Birthday_nl = dr["birthday_nl"].ToString();
                    if (DBNull.Value!=dr["dz_home"])
                        model.Dz_home = dr["dz_home"].ToString();
                    if (DBNull.Value!=dr["mobile"])
                        model.Mobile = dr["mobile"].ToString();
                    if (DBNull.Value!=dr["qq"])
                        model.Qq = dr["qq"].ToString();
                    if (DBNull.Value!=dr["msn"])
                        model.Msn = dr["msn"].ToString();
                    if (DBNull.Value!=dr["email"])
                        model.Email = dr["email"].ToString();
                    if (DBNull.Value!=dr["rq_hire"])
                        model.Rq_hire= Convert.ToDateTime(dr["rq_hire"]);
                    if (DBNull.Value!=dr["is_stop"])
                        model.Is_stop= Convert.ToByte(dr["is_stop"]);
                    if (DBNull.Value!=dr["rq_fire"])
                        model.Rq_fire= Convert.ToDateTime(dr["rq_fire"]);
                    if (DBNull.Value!=dr["yy_fire"])
                        model.Yy_fire = dr["yy_fire"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

