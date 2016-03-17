using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Samples_detailService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Samples_detail">Samples_detail实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Samples_detail model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@sample_id",model.Sample_id),
                new SqlParameter ("@component_id",model.Component_id),
                new SqlParameter ("@component_name",model.Component_name),
                new SqlParameter ("@limit",model.Limit),
                new SqlParameter ("@limit_jc",model.Limit_jc),
                new SqlParameter ("@kzzb_hight",model.Kzzb_hight),
                new SqlParameter ("@kzzb_row",model.Kzzb_row),
                new SqlParameter ("@kzjg",model.Kzjg),
                new SqlParameter ("@sss",model.Sss),
                new SqlParameter ("@edit_reason",model.Edit_reason),
                new SqlParameter ("@edit_times",model.Edit_times),
                new SqlParameter ("@dw",model.Dw),
                new SqlParameter ("@edit_by",model.Edit_by),
                new SqlParameter ("@edit_date",model.Edit_date),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@status",model.Status),
                new SqlParameter ("@jc_result",model.Jc_result),
                new SqlParameter ("@bzr",model.Bzr),
                new SqlParameter ("@bz_date",model.Bz_date),
                new SqlParameter ("@lock",model.Lock),
                new SqlParameter ("@user_name",model.User_name),
                new SqlParameter ("@is_bz",model.Is_bz),
                new SqlParameter ("@is_decimal",model.Is_decimal),
                new SqlParameter ("@del_by",model.Del_by),
                new SqlParameter ("@del_rq",model.Del_rq),
                new SqlParameter ("@del_bz",model.Del_bz)
            };
           return Helper .ExecuteNonQuery ("Samples_detail_Add",param);
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
           return Helper .ExecuteNonQuery ("Samples_detail_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Samples_detail">Samples_detail实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Samples_detail model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@sample_id",model.Sample_id),
                new SqlParameter ("@component_id",model.Component_id),
                new SqlParameter ("@component_name",model.Component_name),
                new SqlParameter ("@limit",model.Limit),
                new SqlParameter ("@limit_jc",model.Limit_jc),
                new SqlParameter ("@kzzb_hight",model.Kzzb_hight),
                new SqlParameter ("@kzzb_row",model.Kzzb_row),
                new SqlParameter ("@kzjg",model.Kzjg),
                new SqlParameter ("@sss",model.Sss),
                new SqlParameter ("@edit_reason",model.Edit_reason),
                new SqlParameter ("@edit_times",model.Edit_times),
                new SqlParameter ("@dw",model.Dw),
                new SqlParameter ("@edit_by",model.Edit_by),
                new SqlParameter ("@edit_date",model.Edit_date),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@status",model.Status),
                new SqlParameter ("@jc_result",model.Jc_result),
                new SqlParameter ("@bzr",model.Bzr),
                new SqlParameter ("@bz_date",model.Bz_date),
                new SqlParameter ("@lock",model.Lock),
                new SqlParameter ("@user_name",model.User_name),
                new SqlParameter ("@is_bz",model.Is_bz),
                new SqlParameter ("@is_decimal",model.Is_decimal),
                new SqlParameter ("@del_by",model.Del_by),
                new SqlParameter ("@del_rq",model.Del_rq),
                new SqlParameter ("@del_bz",model.Del_bz)
            };
           return Helper .ExecuteNonQuery ("Samples_detail_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Samples_detail> selectAll()
        {
            List<Samples_detail> list = new List<Samples_detail>();
            Samples_detail model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Samples_detail_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Samples_detail();
                    model.Bh = dr["bh"].ToString();
                    model.Sample_id = dr["sample_id"].ToString();
                    model.Component_id = dr["component_id"].ToString();
                    if (DBNull.Value!=dr["component_name"])
                        model.Component_name = dr["component_name"].ToString();
                    if (DBNull.Value!=dr["limit"])
                        model.Limit= Convert.ToDecimal(dr["limit"]);
                    if (DBNull.Value!=dr["limit_jc"])
                        model.Limit_jc= Convert.ToDecimal(dr["limit_jc"]);
                    if (DBNull.Value!=dr["kzzb_hight"])
                        model.Kzzb_hight= Convert.ToDecimal(dr["kzzb_hight"]);
                    if (DBNull.Value!=dr["kzzb_row"])
                        model.Kzzb_row= Convert.ToDecimal(dr["kzzb_row"]);
                    if (DBNull.Value!=dr["kzjg"])
                        model.Kzjg= Convert.ToDecimal(dr["kzjg"]);
                    if (DBNull.Value!=dr["sss"])
                        model.Sss = dr["sss"].ToString();
                    if (DBNull.Value!=dr["edit_reason"])
                        model.Edit_reason = dr["edit_reason"].ToString();
                    if (DBNull.Value!=dr["edit_times"])
                        model.Edit_times= Convert.ToByte(dr["edit_times"]);
                    if (DBNull.Value!=dr["dw"])
                        model.Dw = dr["dw"].ToString();
                    if (DBNull.Value!=dr["edit_by"])
                        model.Edit_by = dr["edit_by"].ToString();
                    if (DBNull.Value!=dr["edit_date"])
                        model.Edit_date= Convert.ToDateTime(dr["edit_date"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status= Convert.ToByte(dr["status"]);
                    if (DBNull.Value!=dr["jc_result"])
                        model.Jc_result = dr["jc_result"].ToString();
                    if (DBNull.Value!=dr["bzr"])
                        model.Bzr = dr["bzr"].ToString();
                    if (DBNull.Value!=dr["bz_date"])
                        model.Bz_date= Convert.ToDateTime(dr["bz_date"]);
                    if (DBNull.Value!=dr["lock"])
                        model.Lock= Convert.ToByte(dr["lock"]);
                    if (DBNull.Value!=dr["user_name"])
                        model.User_name = dr["user_name"].ToString();
                    if (DBNull.Value!=dr["is_bz"])
                        model.Is_bz= Convert.ToByte(dr["is_bz"]);
                    if (DBNull.Value!=dr["is_decimal"])
                        model.Is_decimal= Convert.ToByte(dr["is_decimal"]);
                    if (DBNull.Value!=dr["del_by"])
                        model.Del_by = dr["del_by"].ToString();
                    if (DBNull.Value!=dr["del_rq"])
                        model.Del_rq= Convert.ToDateTime(dr["del_rq"]);
                    if (DBNull.Value!=dr["del_bz"])
                        model.Del_bz = dr["del_bz"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Samples_detail实体类对象</returns>
        public Samples_detail selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Samples_detail model = new Samples_detail();
            using (SqlDataReader dr = Helper.ExecuteReader("Samples_detail_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bh = dr["bh"].ToString();
                    model.Sample_id = dr["sample_id"].ToString();
                    model.Component_id = dr["component_id"].ToString();
                    if (DBNull.Value!=dr["component_name"])
                        model.Component_name = dr["component_name"].ToString();
                    if (DBNull.Value!=dr["limit"])
                        model.Limit= Convert.ToDecimal(dr["limit"]);
                    if (DBNull.Value!=dr["limit_jc"])
                        model.Limit_jc= Convert.ToDecimal(dr["limit_jc"]);
                    if (DBNull.Value!=dr["kzzb_hight"])
                        model.Kzzb_hight= Convert.ToDecimal(dr["kzzb_hight"]);
                    if (DBNull.Value!=dr["kzzb_row"])
                        model.Kzzb_row= Convert.ToDecimal(dr["kzzb_row"]);
                    if (DBNull.Value!=dr["kzjg"])
                        model.Kzjg= Convert.ToDecimal(dr["kzjg"]);
                    if (DBNull.Value!=dr["sss"])
                        model.Sss = dr["sss"].ToString();
                    if (DBNull.Value!=dr["edit_reason"])
                        model.Edit_reason = dr["edit_reason"].ToString();
                    if (DBNull.Value!=dr["edit_times"])
                        model.Edit_times= Convert.ToByte(dr["edit_times"]);
                    if (DBNull.Value!=dr["dw"])
                        model.Dw = dr["dw"].ToString();
                    if (DBNull.Value!=dr["edit_by"])
                        model.Edit_by = dr["edit_by"].ToString();
                    if (DBNull.Value!=dr["edit_date"])
                        model.Edit_date= Convert.ToDateTime(dr["edit_date"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status= Convert.ToByte(dr["status"]);
                    if (DBNull.Value!=dr["jc_result"])
                        model.Jc_result = dr["jc_result"].ToString();
                    if (DBNull.Value!=dr["bzr"])
                        model.Bzr = dr["bzr"].ToString();
                    if (DBNull.Value!=dr["bz_date"])
                        model.Bz_date= Convert.ToDateTime(dr["bz_date"]);
                    if (DBNull.Value!=dr["lock"])
                        model.Lock= Convert.ToByte(dr["lock"]);
                    if (DBNull.Value!=dr["user_name"])
                        model.User_name = dr["user_name"].ToString();
                    if (DBNull.Value!=dr["is_bz"])
                        model.Is_bz= Convert.ToByte(dr["is_bz"]);
                    if (DBNull.Value!=dr["is_decimal"])
                        model.Is_decimal= Convert.ToByte(dr["is_decimal"]);
                    if (DBNull.Value!=dr["del_by"])
                        model.Del_by = dr["del_by"].ToString();
                    if (DBNull.Value!=dr["del_rq"])
                        model.Del_rq= Convert.ToDateTime(dr["del_rq"]);
                    if (DBNull.Value!=dr["del_bz"])
                        model.Del_bz = dr["del_bz"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Samples_detail实体类对象</returns>
        public List<Samples_detail> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Samples_detail> list = new List<Samples_detail>();
            Samples_detail model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Samples_detail_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Samples_detail();
                    model.Bh = dr["bh"].ToString();
                    model.Sample_id = dr["sample_id"].ToString();
                    model.Component_id = dr["component_id"].ToString();
                    if (DBNull.Value!=dr["component_name"])
                        model.Component_name = dr["component_name"].ToString();
                    if (DBNull.Value!=dr["limit"])
                        model.Limit= Convert.ToDecimal(dr["limit"]);
                    if (DBNull.Value!=dr["limit_jc"])
                        model.Limit_jc= Convert.ToDecimal(dr["limit_jc"]);
                    if (DBNull.Value!=dr["kzzb_hight"])
                        model.Kzzb_hight= Convert.ToDecimal(dr["kzzb_hight"]);
                    if (DBNull.Value!=dr["kzzb_row"])
                        model.Kzzb_row= Convert.ToDecimal(dr["kzzb_row"]);
                    if (DBNull.Value!=dr["kzjg"])
                        model.Kzjg= Convert.ToDecimal(dr["kzjg"]);
                    if (DBNull.Value!=dr["sss"])
                        model.Sss = dr["sss"].ToString();
                    if (DBNull.Value!=dr["edit_reason"])
                        model.Edit_reason = dr["edit_reason"].ToString();
                    if (DBNull.Value!=dr["edit_times"])
                        model.Edit_times= Convert.ToByte(dr["edit_times"]);
                    if (DBNull.Value!=dr["dw"])
                        model.Dw = dr["dw"].ToString();
                    if (DBNull.Value!=dr["edit_by"])
                        model.Edit_by = dr["edit_by"].ToString();
                    if (DBNull.Value!=dr["edit_date"])
                        model.Edit_date= Convert.ToDateTime(dr["edit_date"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status= Convert.ToByte(dr["status"]);
                    if (DBNull.Value!=dr["jc_result"])
                        model.Jc_result = dr["jc_result"].ToString();
                    if (DBNull.Value!=dr["bzr"])
                        model.Bzr = dr["bzr"].ToString();
                    if (DBNull.Value!=dr["bz_date"])
                        model.Bz_date= Convert.ToDateTime(dr["bz_date"]);
                    if (DBNull.Value!=dr["lock"])
                        model.Lock= Convert.ToByte(dr["lock"]);
                    if (DBNull.Value!=dr["user_name"])
                        model.User_name = dr["user_name"].ToString();
                    if (DBNull.Value!=dr["is_bz"])
                        model.Is_bz= Convert.ToByte(dr["is_bz"]);
                    if (DBNull.Value!=dr["is_decimal"])
                        model.Is_decimal= Convert.ToByte(dr["is_decimal"]);
                    if (DBNull.Value!=dr["del_by"])
                        model.Del_by = dr["del_by"].ToString();
                    if (DBNull.Value!=dr["del_rq"])
                        model.Del_rq= Convert.ToDateTime(dr["del_rq"]);
                    if (DBNull.Value!=dr["del_bz"])
                        model.Del_bz = dr["del_bz"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

