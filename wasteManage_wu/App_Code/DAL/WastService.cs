using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class WastService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Wast">Wast实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Wast model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@customer_num",model.Customer_num),
                new SqlParameter ("@waste_id",model.Waste_id),
                new SqlParameter ("@sample_id",model.Sample_id),
                new SqlParameter ("@waste_name",model.Waste_name),
                new SqlParameter ("@waste_code",model.Waste_code),
                new SqlParameter ("@process_code",model.Process_code),
                new SqlParameter ("@hazard_code",model.Hazard_code),
                new SqlParameter ("@treatment_flow",model.Treatment_flow),
                new SqlParameter ("@treatment_rate",model.Treatment_rate),
                new SqlParameter ("@sample_date",model.Sample_date),
                new SqlParameter ("@approval_date",model.Approval_date),
                new SqlParameter ("@approved_by",model.Approved_by),
                new SqlParameter ("@remark",model.Remark),
                new SqlParameter ("@precaution",model.Precaution),
                new SqlParameter ("@ytd_vol",model.Ytd_vol),
                new SqlParameter ("@atc_vol",model.Atc_vol),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@updated_by",model.Updated_by),
                new SqlParameter ("@update_date",model.Update_date),
                new SqlParameter ("@other_fee",model.Other_fee),
                new SqlParameter ("@charging_fee",model.Charging_fee),
                new SqlParameter ("@treatment_1",model.Treatment_1),
                new SqlParameter ("@treatment_2",model.Treatment_2),
                new SqlParameter ("@treatment_3",model.Treatment_3),
                new SqlParameter ("@treatment_4",model.Treatment_4),
                new SqlParameter ("@treatment_other",model.Treatment_other),
                new SqlParameter ("@type_1",model.Type_1),
                new SqlParameter ("@type_2",model.Type_2),
                new SqlParameter ("@type_3",model.Type_3),
                new SqlParameter ("@type_4",model.Type_4),
                new SqlParameter ("@type_5",model.Type_5),
                new SqlParameter ("@type_other",model.Type_other),
                new SqlParameter ("@xt_1",model.Xt_1),
                new SqlParameter ("@xt_2",model.Xt_2),
                new SqlParameter ("@xt_3",model.Xt_3),
                new SqlParameter ("@out_1",model.Out_1),
                new SqlParameter ("@out_2",model.Out_2),
                new SqlParameter ("@out_3",model.Out_3),
                new SqlParameter ("@bzfs",model.Bzfs),
                new SqlParameter ("@zycf",model.Zycf),
                new SqlParameter ("@stutas",model.Stutas),
                new SqlParameter ("@ht_bm",model.Ht_bm),
                new SqlParameter ("@color",model.Color),
                new SqlParameter ("@is_cy",model.Is_cy),
                new SqlParameter ("@fwcs_bh",model.Fwcs_bh),
                new SqlParameter ("@sc_fzr",model.Sc_fzr),
                new SqlParameter ("@zx_bh",model.Zx_bh),
                new SqlParameter ("@xt_4",model.Xt_4),
                new SqlParameter ("@cf_1",model.Cf_1),
                new SqlParameter ("@cf_2",model.Cf_2),
                new SqlParameter ("@cf_3",model.Cf_3),
                new SqlParameter ("@cf_4",model.Cf_4),
                new SqlParameter ("@cf_5",model.Cf_5),
                new SqlParameter ("@cf_6",model.Cf_6),
                new SqlParameter ("@cf_7",model.Cf_7),
                new SqlParameter ("@cf_8",model.Cf_8),
                new SqlParameter ("@jy_1",model.Jy_1),
                new SqlParameter ("@jy_2",model.Jy_2),
                new SqlParameter ("@reason",model.Reason),
                new SqlParameter ("@waste_bzfs",model.Waste_bzfs),
                new SqlParameter ("@waste_ysfs",model.Waste_ysfs),
                new SqlParameter ("@unsh",model.Unsh),
                new SqlParameter ("@unshr",model.Unshr),
                new SqlParameter ("@unshrq",model.Unshrq)
            };
           return Helper .ExecuteNonQuery ("Wast_Add",param);
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
           return Helper .ExecuteNonQuery ("Wast_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Wast">Wast实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Wast model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@customer_num",model.Customer_num),
                new SqlParameter ("@waste_id",model.Waste_id),
                new SqlParameter ("@sample_id",model.Sample_id),
                new SqlParameter ("@waste_name",model.Waste_name),
                new SqlParameter ("@waste_code",model.Waste_code),
                new SqlParameter ("@process_code",model.Process_code),
                new SqlParameter ("@hazard_code",model.Hazard_code),
                new SqlParameter ("@treatment_flow",model.Treatment_flow),
                new SqlParameter ("@treatment_rate",model.Treatment_rate),
                new SqlParameter ("@sample_date",model.Sample_date),
                new SqlParameter ("@approval_date",model.Approval_date),
                new SqlParameter ("@approved_by",model.Approved_by),
                new SqlParameter ("@remark",model.Remark),
                new SqlParameter ("@precaution",model.Precaution),
                new SqlParameter ("@ytd_vol",model.Ytd_vol),
                new SqlParameter ("@atc_vol",model.Atc_vol),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@updated_by",model.Updated_by),
                new SqlParameter ("@update_date",model.Update_date),
                new SqlParameter ("@other_fee",model.Other_fee),
                new SqlParameter ("@charging_fee",model.Charging_fee),
                new SqlParameter ("@treatment_1",model.Treatment_1),
                new SqlParameter ("@treatment_2",model.Treatment_2),
                new SqlParameter ("@treatment_3",model.Treatment_3),
                new SqlParameter ("@treatment_4",model.Treatment_4),
                new SqlParameter ("@treatment_other",model.Treatment_other),
                new SqlParameter ("@type_1",model.Type_1),
                new SqlParameter ("@type_2",model.Type_2),
                new SqlParameter ("@type_3",model.Type_3),
                new SqlParameter ("@type_4",model.Type_4),
                new SqlParameter ("@type_5",model.Type_5),
                new SqlParameter ("@type_other",model.Type_other),
                new SqlParameter ("@xt_1",model.Xt_1),
                new SqlParameter ("@xt_2",model.Xt_2),
                new SqlParameter ("@xt_3",model.Xt_3),
                new SqlParameter ("@out_1",model.Out_1),
                new SqlParameter ("@out_2",model.Out_2),
                new SqlParameter ("@out_3",model.Out_3),
                new SqlParameter ("@bzfs",model.Bzfs),
                new SqlParameter ("@zycf",model.Zycf),
                new SqlParameter ("@stutas",model.Stutas),
                new SqlParameter ("@ht_bm",model.Ht_bm),
                new SqlParameter ("@color",model.Color),
                new SqlParameter ("@is_cy",model.Is_cy),
                new SqlParameter ("@fwcs_bh",model.Fwcs_bh),
                new SqlParameter ("@sc_fzr",model.Sc_fzr),
                new SqlParameter ("@zx_bh",model.Zx_bh),
                new SqlParameter ("@xt_4",model.Xt_4),
                new SqlParameter ("@cf_1",model.Cf_1),
                new SqlParameter ("@cf_2",model.Cf_2),
                new SqlParameter ("@cf_3",model.Cf_3),
                new SqlParameter ("@cf_4",model.Cf_4),
                new SqlParameter ("@cf_5",model.Cf_5),
                new SqlParameter ("@cf_6",model.Cf_6),
                new SqlParameter ("@cf_7",model.Cf_7),
                new SqlParameter ("@cf_8",model.Cf_8),
                new SqlParameter ("@jy_1",model.Jy_1),
                new SqlParameter ("@jy_2",model.Jy_2),
                new SqlParameter ("@reason",model.Reason),
                new SqlParameter ("@waste_bzfs",model.Waste_bzfs),
                new SqlParameter ("@waste_ysfs",model.Waste_ysfs),
                new SqlParameter ("@unsh",model.Unsh),
                new SqlParameter ("@unshr",model.Unshr),
                new SqlParameter ("@unshrq",model.Unshrq)
            };
           return Helper .ExecuteNonQuery ("Wast_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Wast> selectAll()
        {
            List<Wast> list = new List<Wast>();
            Wast model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Wast_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Wast();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Customer_num = dr["customer_num"].ToString();
                    model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["sample_id"])
                        model.Sample_id = dr["sample_id"].ToString();
                    if (DBNull.Value!=dr["waste_name"])
                        model.Waste_name = dr["waste_name"].ToString();
                    if (DBNull.Value!=dr["waste_code"])
                        model.Waste_code = dr["waste_code"].ToString();
                    if (DBNull.Value!=dr["process_code"])
                        model.Process_code = dr["process_code"].ToString();
                    if (DBNull.Value!=dr["hazard_code"])
                        model.Hazard_code = dr["hazard_code"].ToString();
                    if (DBNull.Value!=dr["treatment_flow"])
                        model.Treatment_flow = dr["treatment_flow"].ToString();
                    if (DBNull.Value!=dr["treatment_rate"])
                        model.Treatment_rate= Convert.ToDecimal(dr["treatment_rate"]);
                    if (DBNull.Value!=dr["sample_date"])
                        model.Sample_date= Convert.ToDateTime(dr["sample_date"]);
                    if (DBNull.Value!=dr["approval_date"])
                        model.Approval_date= Convert.ToDateTime(dr["approval_date"]);
                    if (DBNull.Value!=dr["approved_by"])
                        model.Approved_by = dr["approved_by"].ToString();
                    if (DBNull.Value!=dr["remark"])
                        model.Remark = dr["remark"].ToString();
                    if (DBNull.Value!=dr["precaution"])
                        model.Precaution = dr["precaution"].ToString();
                    if (DBNull.Value!=dr["ytd_vol"])
                        model.Ytd_vol= Convert.ToDecimal(dr["ytd_vol"]);
                    if (DBNull.Value!=dr["atc_vol"])
                        model.Atc_vol= Convert.ToDecimal(dr["atc_vol"]);
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["other_fee"])
                        model.Other_fee= Convert.ToDecimal(dr["other_fee"]);
                    if (DBNull.Value!=dr["charging_fee"])
                        model.Charging_fee= Convert.ToDecimal(dr["charging_fee"]);
                    if (DBNull.Value!=dr["treatment_1"])
                        model.Treatment_1= Convert.ToByte(dr["treatment_1"]);
                    if (DBNull.Value!=dr["treatment_2"])
                        model.Treatment_2= Convert.ToByte(dr["treatment_2"]);
                    if (DBNull.Value!=dr["treatment_3"])
                        model.Treatment_3= Convert.ToByte(dr["treatment_3"]);
                    if (DBNull.Value!=dr["treatment_4"])
                        model.Treatment_4= Convert.ToByte(dr["treatment_4"]);
                    if (DBNull.Value!=dr["treatment_other"])
                        model.Treatment_other= Convert.ToByte(dr["treatment_other"]);
                    if (DBNull.Value!=dr["type_1"])
                        model.Type_1= Convert.ToByte(dr["type_1"]);
                    if (DBNull.Value!=dr["type_2"])
                        model.Type_2= Convert.ToByte(dr["type_2"]);
                    if (DBNull.Value!=dr["type_3"])
                        model.Type_3= Convert.ToByte(dr["type_3"]);
                    if (DBNull.Value!=dr["type_4"])
                        model.Type_4= Convert.ToByte(dr["type_4"]);
                    if (DBNull.Value!=dr["type_5"])
                        model.Type_5= Convert.ToByte(dr["type_5"]);
                    if (DBNull.Value!=dr["type_other"])
                        model.Type_other= Convert.ToByte(dr["type_other"]);
                    if (DBNull.Value!=dr["xt_1"])
                        model.Xt_1= Convert.ToByte(dr["xt_1"]);
                    if (DBNull.Value!=dr["xt_2"])
                        model.Xt_2= Convert.ToByte(dr["xt_2"]);
                    if (DBNull.Value!=dr["xt_3"])
                        model.Xt_3= Convert.ToByte(dr["xt_3"]);
                    if (DBNull.Value!=dr["out_1"])
                        model.Out_1= Convert.ToByte(dr["out_1"]);
                    if (DBNull.Value!=dr["out_2"])
                        model.Out_2= Convert.ToByte(dr["out_2"]);
                    if (DBNull.Value!=dr["out_3"])
                        model.Out_3= Convert.ToByte(dr["out_3"]);
                    if (DBNull.Value!=dr["bzfs"])
                        model.Bzfs = dr["bzfs"].ToString();
                    if (DBNull.Value!=dr["zycf"])
                        model.Zycf = dr["zycf"].ToString();
                    if (DBNull.Value!=dr["stutas"])
                        model.Stutas = dr["stutas"].ToString();
                    if (DBNull.Value!=dr["ht_bm"])
                        model.Ht_bm = dr["ht_bm"].ToString();
                    if (DBNull.Value!=dr["color"])
                        model.Color = dr["color"].ToString();
                    if (DBNull.Value!=dr["is_cy"])
                        model.Is_cy= Convert.ToByte(dr["is_cy"]);
                    if (DBNull.Value!=dr["fwcs_bh"])
                        model.Fwcs_bh = dr["fwcs_bh"].ToString();
                    if (DBNull.Value!=dr["sc_fzr"])
                        model.Sc_fzr = dr["sc_fzr"].ToString();
                    if (DBNull.Value!=dr["zx_bh"])
                        model.Zx_bh = dr["zx_bh"].ToString();
                    if (DBNull.Value!=dr["xt_4"])
                        model.Xt_4= Convert.ToByte(dr["xt_4"]);
                    if (DBNull.Value!=dr["cf_1"])
                        model.Cf_1= Convert.ToByte(dr["cf_1"]);
                    if (DBNull.Value!=dr["cf_2"])
                        model.Cf_2= Convert.ToByte(dr["cf_2"]);
                    if (DBNull.Value!=dr["cf_3"])
                        model.Cf_3= Convert.ToByte(dr["cf_3"]);
                    if (DBNull.Value!=dr["cf_4"])
                        model.Cf_4= Convert.ToByte(dr["cf_4"]);
                    if (DBNull.Value!=dr["cf_5"])
                        model.Cf_5= Convert.ToByte(dr["cf_5"]);
                    if (DBNull.Value!=dr["cf_6"])
                        model.Cf_6= Convert.ToByte(dr["cf_6"]);
                    if (DBNull.Value!=dr["cf_7"])
                        model.Cf_7= Convert.ToByte(dr["cf_7"]);
                    if (DBNull.Value!=dr["cf_8"])
                        model.Cf_8= Convert.ToByte(dr["cf_8"]);
                    if (DBNull.Value!=dr["jy_1"])
                        model.Jy_1= Convert.ToByte(dr["jy_1"]);
                    if (DBNull.Value!=dr["jy_2"])
                        model.Jy_2= Convert.ToByte(dr["jy_2"]);
                    if (DBNull.Value!=dr["reason"])
                        model.Reason = dr["reason"].ToString();
                    if (DBNull.Value!=dr["waste_bzfs"])
                        model.Waste_bzfs = dr["waste_bzfs"].ToString();
                    if (DBNull.Value!=dr["waste_ysfs"])
                        model.Waste_ysfs = dr["waste_ysfs"].ToString();
                    if (DBNull.Value!=dr["unsh"])
                        model.Unsh= Convert.ToByte(dr["unsh"]);
                    if (DBNull.Value!=dr["unshr"])
                        model.Unshr = dr["unshr"].ToString();
                    if (DBNull.Value!=dr["unshrq"])
                        model.Unshrq= Convert.ToDateTime(dr["unshrq"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Wast实体类对象</returns>
        public Wast selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Wast model = new Wast();
            using (SqlDataReader dr = Helper.ExecuteReader("Wast_SelectById", param))
            {
                if (dr.Read())
                {
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Customer_num = dr["customer_num"].ToString();
                    model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["sample_id"])
                        model.Sample_id = dr["sample_id"].ToString();
                    if (DBNull.Value!=dr["waste_name"])
                        model.Waste_name = dr["waste_name"].ToString();
                    if (DBNull.Value!=dr["waste_code"])
                        model.Waste_code = dr["waste_code"].ToString();
                    if (DBNull.Value!=dr["process_code"])
                        model.Process_code = dr["process_code"].ToString();
                    if (DBNull.Value!=dr["hazard_code"])
                        model.Hazard_code = dr["hazard_code"].ToString();
                    if (DBNull.Value!=dr["treatment_flow"])
                        model.Treatment_flow = dr["treatment_flow"].ToString();
                    if (DBNull.Value!=dr["treatment_rate"])
                        model.Treatment_rate= Convert.ToDecimal(dr["treatment_rate"]);
                    if (DBNull.Value!=dr["sample_date"])
                        model.Sample_date= Convert.ToDateTime(dr["sample_date"]);
                    if (DBNull.Value!=dr["approval_date"])
                        model.Approval_date= Convert.ToDateTime(dr["approval_date"]);
                    if (DBNull.Value!=dr["approved_by"])
                        model.Approved_by = dr["approved_by"].ToString();
                    if (DBNull.Value!=dr["remark"])
                        model.Remark = dr["remark"].ToString();
                    if (DBNull.Value!=dr["precaution"])
                        model.Precaution = dr["precaution"].ToString();
                    if (DBNull.Value!=dr["ytd_vol"])
                        model.Ytd_vol= Convert.ToDecimal(dr["ytd_vol"]);
                    if (DBNull.Value!=dr["atc_vol"])
                        model.Atc_vol= Convert.ToDecimal(dr["atc_vol"]);
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["other_fee"])
                        model.Other_fee= Convert.ToDecimal(dr["other_fee"]);
                    if (DBNull.Value!=dr["charging_fee"])
                        model.Charging_fee= Convert.ToDecimal(dr["charging_fee"]);
                    if (DBNull.Value!=dr["treatment_1"])
                        model.Treatment_1= Convert.ToByte(dr["treatment_1"]);
                    if (DBNull.Value!=dr["treatment_2"])
                        model.Treatment_2= Convert.ToByte(dr["treatment_2"]);
                    if (DBNull.Value!=dr["treatment_3"])
                        model.Treatment_3= Convert.ToByte(dr["treatment_3"]);
                    if (DBNull.Value!=dr["treatment_4"])
                        model.Treatment_4= Convert.ToByte(dr["treatment_4"]);
                    if (DBNull.Value!=dr["treatment_other"])
                        model.Treatment_other= Convert.ToByte(dr["treatment_other"]);
                    if (DBNull.Value!=dr["type_1"])
                        model.Type_1= Convert.ToByte(dr["type_1"]);
                    if (DBNull.Value!=dr["type_2"])
                        model.Type_2= Convert.ToByte(dr["type_2"]);
                    if (DBNull.Value!=dr["type_3"])
                        model.Type_3= Convert.ToByte(dr["type_3"]);
                    if (DBNull.Value!=dr["type_4"])
                        model.Type_4= Convert.ToByte(dr["type_4"]);
                    if (DBNull.Value!=dr["type_5"])
                        model.Type_5= Convert.ToByte(dr["type_5"]);
                    if (DBNull.Value!=dr["type_other"])
                        model.Type_other= Convert.ToByte(dr["type_other"]);
                    if (DBNull.Value!=dr["xt_1"])
                        model.Xt_1= Convert.ToByte(dr["xt_1"]);
                    if (DBNull.Value!=dr["xt_2"])
                        model.Xt_2= Convert.ToByte(dr["xt_2"]);
                    if (DBNull.Value!=dr["xt_3"])
                        model.Xt_3= Convert.ToByte(dr["xt_3"]);
                    if (DBNull.Value!=dr["out_1"])
                        model.Out_1= Convert.ToByte(dr["out_1"]);
                    if (DBNull.Value!=dr["out_2"])
                        model.Out_2= Convert.ToByte(dr["out_2"]);
                    if (DBNull.Value!=dr["out_3"])
                        model.Out_3= Convert.ToByte(dr["out_3"]);
                    if (DBNull.Value!=dr["bzfs"])
                        model.Bzfs = dr["bzfs"].ToString();
                    if (DBNull.Value!=dr["zycf"])
                        model.Zycf = dr["zycf"].ToString();
                    if (DBNull.Value!=dr["stutas"])
                        model.Stutas = dr["stutas"].ToString();
                    if (DBNull.Value!=dr["ht_bm"])
                        model.Ht_bm = dr["ht_bm"].ToString();
                    if (DBNull.Value!=dr["color"])
                        model.Color = dr["color"].ToString();
                    if (DBNull.Value!=dr["is_cy"])
                        model.Is_cy= Convert.ToByte(dr["is_cy"]);
                    if (DBNull.Value!=dr["fwcs_bh"])
                        model.Fwcs_bh = dr["fwcs_bh"].ToString();
                    if (DBNull.Value!=dr["sc_fzr"])
                        model.Sc_fzr = dr["sc_fzr"].ToString();
                    if (DBNull.Value!=dr["zx_bh"])
                        model.Zx_bh = dr["zx_bh"].ToString();
                    if (DBNull.Value!=dr["xt_4"])
                        model.Xt_4= Convert.ToByte(dr["xt_4"]);
                    if (DBNull.Value!=dr["cf_1"])
                        model.Cf_1= Convert.ToByte(dr["cf_1"]);
                    if (DBNull.Value!=dr["cf_2"])
                        model.Cf_2= Convert.ToByte(dr["cf_2"]);
                    if (DBNull.Value!=dr["cf_3"])
                        model.Cf_3= Convert.ToByte(dr["cf_3"]);
                    if (DBNull.Value!=dr["cf_4"])
                        model.Cf_4= Convert.ToByte(dr["cf_4"]);
                    if (DBNull.Value!=dr["cf_5"])
                        model.Cf_5= Convert.ToByte(dr["cf_5"]);
                    if (DBNull.Value!=dr["cf_6"])
                        model.Cf_6= Convert.ToByte(dr["cf_6"]);
                    if (DBNull.Value!=dr["cf_7"])
                        model.Cf_7= Convert.ToByte(dr["cf_7"]);
                    if (DBNull.Value!=dr["cf_8"])
                        model.Cf_8= Convert.ToByte(dr["cf_8"]);
                    if (DBNull.Value!=dr["jy_1"])
                        model.Jy_1= Convert.ToByte(dr["jy_1"]);
                    if (DBNull.Value!=dr["jy_2"])
                        model.Jy_2= Convert.ToByte(dr["jy_2"]);
                    if (DBNull.Value!=dr["reason"])
                        model.Reason = dr["reason"].ToString();
                    if (DBNull.Value!=dr["waste_bzfs"])
                        model.Waste_bzfs = dr["waste_bzfs"].ToString();
                    if (DBNull.Value!=dr["waste_ysfs"])
                        model.Waste_ysfs = dr["waste_ysfs"].ToString();
                    if (DBNull.Value!=dr["unsh"])
                        model.Unsh= Convert.ToByte(dr["unsh"]);
                    if (DBNull.Value!=dr["unshr"])
                        model.Unshr = dr["unshr"].ToString();
                    if (DBNull.Value!=dr["unshrq"])
                        model.Unshrq= Convert.ToDateTime(dr["unshrq"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Wast实体类对象</returns>
        public List<Wast> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Wast> list = new List<Wast>();
            Wast model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Wast_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Wast();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Customer_num = dr["customer_num"].ToString();
                    model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["sample_id"])
                        model.Sample_id = dr["sample_id"].ToString();
                    if (DBNull.Value!=dr["waste_name"])
                        model.Waste_name = dr["waste_name"].ToString();
                    if (DBNull.Value!=dr["waste_code"])
                        model.Waste_code = dr["waste_code"].ToString();
                    if (DBNull.Value!=dr["process_code"])
                        model.Process_code = dr["process_code"].ToString();
                    if (DBNull.Value!=dr["hazard_code"])
                        model.Hazard_code = dr["hazard_code"].ToString();
                    if (DBNull.Value!=dr["treatment_flow"])
                        model.Treatment_flow = dr["treatment_flow"].ToString();
                    if (DBNull.Value!=dr["treatment_rate"])
                        model.Treatment_rate= Convert.ToDecimal(dr["treatment_rate"]);
                    if (DBNull.Value!=dr["sample_date"])
                        model.Sample_date= Convert.ToDateTime(dr["sample_date"]);
                    if (DBNull.Value!=dr["approval_date"])
                        model.Approval_date= Convert.ToDateTime(dr["approval_date"]);
                    if (DBNull.Value!=dr["approved_by"])
                        model.Approved_by = dr["approved_by"].ToString();
                    if (DBNull.Value!=dr["remark"])
                        model.Remark = dr["remark"].ToString();
                    if (DBNull.Value!=dr["precaution"])
                        model.Precaution = dr["precaution"].ToString();
                    if (DBNull.Value!=dr["ytd_vol"])
                        model.Ytd_vol= Convert.ToDecimal(dr["ytd_vol"]);
                    if (DBNull.Value!=dr["atc_vol"])
                        model.Atc_vol= Convert.ToDecimal(dr["atc_vol"]);
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["other_fee"])
                        model.Other_fee= Convert.ToDecimal(dr["other_fee"]);
                    if (DBNull.Value!=dr["charging_fee"])
                        model.Charging_fee= Convert.ToDecimal(dr["charging_fee"]);
                    if (DBNull.Value!=dr["treatment_1"])
                        model.Treatment_1= Convert.ToByte(dr["treatment_1"]);
                    if (DBNull.Value!=dr["treatment_2"])
                        model.Treatment_2= Convert.ToByte(dr["treatment_2"]);
                    if (DBNull.Value!=dr["treatment_3"])
                        model.Treatment_3= Convert.ToByte(dr["treatment_3"]);
                    if (DBNull.Value!=dr["treatment_4"])
                        model.Treatment_4= Convert.ToByte(dr["treatment_4"]);
                    if (DBNull.Value!=dr["treatment_other"])
                        model.Treatment_other= Convert.ToByte(dr["treatment_other"]);
                    if (DBNull.Value!=dr["type_1"])
                        model.Type_1= Convert.ToByte(dr["type_1"]);
                    if (DBNull.Value!=dr["type_2"])
                        model.Type_2= Convert.ToByte(dr["type_2"]);
                    if (DBNull.Value!=dr["type_3"])
                        model.Type_3= Convert.ToByte(dr["type_3"]);
                    if (DBNull.Value!=dr["type_4"])
                        model.Type_4= Convert.ToByte(dr["type_4"]);
                    if (DBNull.Value!=dr["type_5"])
                        model.Type_5= Convert.ToByte(dr["type_5"]);
                    if (DBNull.Value!=dr["type_other"])
                        model.Type_other= Convert.ToByte(dr["type_other"]);
                    if (DBNull.Value!=dr["xt_1"])
                        model.Xt_1= Convert.ToByte(dr["xt_1"]);
                    if (DBNull.Value!=dr["xt_2"])
                        model.Xt_2= Convert.ToByte(dr["xt_2"]);
                    if (DBNull.Value!=dr["xt_3"])
                        model.Xt_3= Convert.ToByte(dr["xt_3"]);
                    if (DBNull.Value!=dr["out_1"])
                        model.Out_1= Convert.ToByte(dr["out_1"]);
                    if (DBNull.Value!=dr["out_2"])
                        model.Out_2= Convert.ToByte(dr["out_2"]);
                    if (DBNull.Value!=dr["out_3"])
                        model.Out_3= Convert.ToByte(dr["out_3"]);
                    if (DBNull.Value!=dr["bzfs"])
                        model.Bzfs = dr["bzfs"].ToString();
                    if (DBNull.Value!=dr["zycf"])
                        model.Zycf = dr["zycf"].ToString();
                    if (DBNull.Value!=dr["stutas"])
                        model.Stutas = dr["stutas"].ToString();
                    if (DBNull.Value!=dr["ht_bm"])
                        model.Ht_bm = dr["ht_bm"].ToString();
                    if (DBNull.Value!=dr["color"])
                        model.Color = dr["color"].ToString();
                    if (DBNull.Value!=dr["is_cy"])
                        model.Is_cy= Convert.ToByte(dr["is_cy"]);
                    if (DBNull.Value!=dr["fwcs_bh"])
                        model.Fwcs_bh = dr["fwcs_bh"].ToString();
                    if (DBNull.Value!=dr["sc_fzr"])
                        model.Sc_fzr = dr["sc_fzr"].ToString();
                    if (DBNull.Value!=dr["zx_bh"])
                        model.Zx_bh = dr["zx_bh"].ToString();
                    if (DBNull.Value!=dr["xt_4"])
                        model.Xt_4= Convert.ToByte(dr["xt_4"]);
                    if (DBNull.Value!=dr["cf_1"])
                        model.Cf_1= Convert.ToByte(dr["cf_1"]);
                    if (DBNull.Value!=dr["cf_2"])
                        model.Cf_2= Convert.ToByte(dr["cf_2"]);
                    if (DBNull.Value!=dr["cf_3"])
                        model.Cf_3= Convert.ToByte(dr["cf_3"]);
                    if (DBNull.Value!=dr["cf_4"])
                        model.Cf_4= Convert.ToByte(dr["cf_4"]);
                    if (DBNull.Value!=dr["cf_5"])
                        model.Cf_5= Convert.ToByte(dr["cf_5"]);
                    if (DBNull.Value!=dr["cf_6"])
                        model.Cf_6= Convert.ToByte(dr["cf_6"]);
                    if (DBNull.Value!=dr["cf_7"])
                        model.Cf_7= Convert.ToByte(dr["cf_7"]);
                    if (DBNull.Value!=dr["cf_8"])
                        model.Cf_8= Convert.ToByte(dr["cf_8"]);
                    if (DBNull.Value!=dr["jy_1"])
                        model.Jy_1= Convert.ToByte(dr["jy_1"]);
                    if (DBNull.Value!=dr["jy_2"])
                        model.Jy_2= Convert.ToByte(dr["jy_2"]);
                    if (DBNull.Value!=dr["reason"])
                        model.Reason = dr["reason"].ToString();
                    if (DBNull.Value!=dr["waste_bzfs"])
                        model.Waste_bzfs = dr["waste_bzfs"].ToString();
                    if (DBNull.Value!=dr["waste_ysfs"])
                        model.Waste_ysfs = dr["waste_ysfs"].ToString();
                    if (DBNull.Value!=dr["unsh"])
                        model.Unsh= Convert.ToByte(dr["unsh"]);
                    if (DBNull.Value!=dr["unshr"])
                        model.Unshr = dr["unshr"].ToString();
                    if (DBNull.Value!=dr["unshrq"])
                        model.Unshrq= Convert.ToDateTime(dr["unshrq"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

