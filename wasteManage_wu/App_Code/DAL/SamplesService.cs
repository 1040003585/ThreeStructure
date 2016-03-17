using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SamplesService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Samples">Samples实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Samples model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@sample_id",model.Sample_id),
                new SqlParameter ("@status",model.Status),
                new SqlParameter ("@userstamp",model.Userstamp),
                new SqlParameter ("@sample_date",model.Sample_date),
                new SqlParameter ("@request_id",model.Request_id),
                new SqlParameter ("@js_date",model.Js_date),
                new SqlParameter ("@sent_to",model.Sent_to),
                new SqlParameter ("@sample_type",model.Sample_type),
                new SqlParameter ("@process_waste",model.Process_waste),
                new SqlParameter ("@customer_num",model.Customer_num),
                new SqlParameter ("@customer_name",model.Customer_name),
                new SqlParameter ("@customer_adress",model.Customer_adress),
                new SqlParameter ("@facitily_colcation",model.Facitily_colcation),
                new SqlParameter ("@waste_id",model.Waste_id),
                new SqlParameter ("@test_date1",model.Test_date1),
                new SqlParameter ("@test_date2",model.Test_date2),
                new SqlParameter ("@result",model.Result),
                new SqlParameter ("@profile_id",model.Profile_id),
                new SqlParameter ("@update_date",model.Update_date),
                new SqlParameter ("@updated_by",model.Updated_by),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@is_ok",model.Is_ok),
                new SqlParameter ("@is_print",model.Is_print),
                new SqlParameter ("@qqc",model.Qqc),
                new SqlParameter ("@yp_name",model.Yp_name),
                new SqlParameter ("@yp_fl",model.Yp_fl),
                new SqlParameter ("@yp_ly",model.Yp_ly),
                new SqlParameter ("@yp_wz",model.Yp_wz),
                new SqlParameter ("@yp_person",model.Yp_person),
                new SqlParameter ("@sq_date",model.Sq_date),
                new SqlParameter ("@sq_person",model.Sq_person),
                new SqlParameter ("@completes_date",model.Completes_date),
                new SqlParameter ("@yp_ms",model.Yp_ms),
                new SqlParameter ("@js_person",model.Js_person),
                new SqlParameter ("@shr",model.Shr),
                new SqlParameter ("@sh_date",model.Sh_date),
                new SqlParameter ("@del_by",model.Del_by),
                new SqlParameter ("@del_rq",model.Del_rq),
                new SqlParameter ("@del_bz",model.Del_bz)
            };
           return Helper .ExecuteNonQuery ("Samples_Add",param);
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
           return Helper .ExecuteNonQuery ("Samples_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Samples">Samples实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Samples model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@sample_id",model.Sample_id),
                new SqlParameter ("@status",model.Status),
                new SqlParameter ("@userstamp",model.Userstamp),
                new SqlParameter ("@sample_date",model.Sample_date),
                new SqlParameter ("@request_id",model.Request_id),
                new SqlParameter ("@js_date",model.Js_date),
                new SqlParameter ("@sent_to",model.Sent_to),
                new SqlParameter ("@sample_type",model.Sample_type),
                new SqlParameter ("@process_waste",model.Process_waste),
                new SqlParameter ("@customer_num",model.Customer_num),
                new SqlParameter ("@customer_name",model.Customer_name),
                new SqlParameter ("@customer_adress",model.Customer_adress),
                new SqlParameter ("@facitily_colcation",model.Facitily_colcation),
                new SqlParameter ("@waste_id",model.Waste_id),
                new SqlParameter ("@test_date1",model.Test_date1),
                new SqlParameter ("@test_date2",model.Test_date2),
                new SqlParameter ("@result",model.Result),
                new SqlParameter ("@profile_id",model.Profile_id),
                new SqlParameter ("@update_date",model.Update_date),
                new SqlParameter ("@updated_by",model.Updated_by),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@is_ok",model.Is_ok),
                new SqlParameter ("@is_print",model.Is_print),
                new SqlParameter ("@qqc",model.Qqc),
                new SqlParameter ("@yp_name",model.Yp_name),
                new SqlParameter ("@yp_fl",model.Yp_fl),
                new SqlParameter ("@yp_ly",model.Yp_ly),
                new SqlParameter ("@yp_wz",model.Yp_wz),
                new SqlParameter ("@yp_person",model.Yp_person),
                new SqlParameter ("@sq_date",model.Sq_date),
                new SqlParameter ("@sq_person",model.Sq_person),
                new SqlParameter ("@completes_date",model.Completes_date),
                new SqlParameter ("@yp_ms",model.Yp_ms),
                new SqlParameter ("@js_person",model.Js_person),
                new SqlParameter ("@shr",model.Shr),
                new SqlParameter ("@sh_date",model.Sh_date),
                new SqlParameter ("@del_by",model.Del_by),
                new SqlParameter ("@del_rq",model.Del_rq),
                new SqlParameter ("@del_bz",model.Del_bz)
            };
           return Helper .ExecuteNonQuery ("Samples_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Samples> selectAll()
        {
            List<Samples> list = new List<Samples>();
            Samples model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Samples_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Samples();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Sample_id = dr["sample_id"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                    if (DBNull.Value!=dr["userstamp"])
                        model.Userstamp = dr["userstamp"].ToString();
                    if (DBNull.Value!=dr["sample_date"])
                        model.Sample_date= Convert.ToDateTime(dr["sample_date"]);
                    if (DBNull.Value!=dr["request_id"])
                        model.Request_id = dr["request_id"].ToString();
                    if (DBNull.Value!=dr["js_date"])
                        model.Js_date= Convert.ToDateTime(dr["js_date"]);
                    if (DBNull.Value!=dr["sent_to"])
                        model.Sent_to = dr["sent_to"].ToString();
                    if (DBNull.Value!=dr["sample_type"])
                        model.Sample_type = dr["sample_type"].ToString();
                    if (DBNull.Value!=dr["process_waste"])
                        model.Process_waste = dr["process_waste"].ToString();
                    if (DBNull.Value!=dr["customer_num"])
                        model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["customer_name"])
                        model.Customer_name = dr["customer_name"].ToString();
                    if (DBNull.Value!=dr["customer_adress"])
                        model.Customer_adress = dr["customer_adress"].ToString();
                    if (DBNull.Value!=dr["facitily_colcation"])
                        model.Facitily_colcation = dr["facitily_colcation"].ToString();
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["test_date1"])
                        model.Test_date1= Convert.ToDateTime(dr["test_date1"]);
                    if (DBNull.Value!=dr["test_date2"])
                        model.Test_date2= Convert.ToDateTime(dr["test_date2"]);
                    if (DBNull.Value!=dr["result"])
                        model.Result = dr["result"].ToString();
                    if (DBNull.Value!=dr["profile_id"])
                        model.Profile_id = dr["profile_id"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["is_ok"])
                        model.Is_ok= Convert.ToByte(dr["is_ok"]);
                    if (DBNull.Value!=dr["is_print"])
                        model.Is_print= Convert.ToByte(dr["is_print"]);
                    if (DBNull.Value!=dr["qqc"])
                        model.Qqc= Convert.ToByte(dr["qqc"]);
                    if (DBNull.Value!=dr["yp_name"])
                        model.Yp_name = dr["yp_name"].ToString();
                    if (DBNull.Value!=dr["yp_fl"])
                        model.Yp_fl = dr["yp_fl"].ToString();
                    if (DBNull.Value!=dr["yp_ly"])
                        model.Yp_ly = dr["yp_ly"].ToString();
                    if (DBNull.Value!=dr["yp_wz"])
                        model.Yp_wz = dr["yp_wz"].ToString();
                    if (DBNull.Value!=dr["yp_person"])
                        model.Yp_person = dr["yp_person"].ToString();
                    if (DBNull.Value!=dr["sq_date"])
                        model.Sq_date= Convert.ToDateTime(dr["sq_date"]);
                    if (DBNull.Value!=dr["sq_person"])
                        model.Sq_person = dr["sq_person"].ToString();
                    if (DBNull.Value!=dr["completes_date"])
                        model.Completes_date= Convert.ToDateTime(dr["completes_date"]);
                    if (DBNull.Value!=dr["yp_ms"])
                        model.Yp_ms = dr["yp_ms"].ToString();
                    if (DBNull.Value!=dr["js_person"])
                        model.Js_person = dr["js_person"].ToString();
                    if (DBNull.Value!=dr["shr"])
                        model.Shr = dr["shr"].ToString();
                    if (DBNull.Value!=dr["sh_date"])
                        model.Sh_date= Convert.ToDateTime(dr["sh_date"]);
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
        /// <returns>Samples实体类对象</returns>
        public Samples selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Samples model = new Samples();
            using (SqlDataReader dr = Helper.ExecuteReader("Samples_SelectById", param))
            {
                if (dr.Read())
                {
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Sample_id = dr["sample_id"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                    if (DBNull.Value!=dr["userstamp"])
                        model.Userstamp = dr["userstamp"].ToString();
                    if (DBNull.Value!=dr["sample_date"])
                        model.Sample_date= Convert.ToDateTime(dr["sample_date"]);
                    if (DBNull.Value!=dr["request_id"])
                        model.Request_id = dr["request_id"].ToString();
                    if (DBNull.Value!=dr["js_date"])
                        model.Js_date= Convert.ToDateTime(dr["js_date"]);
                    if (DBNull.Value!=dr["sent_to"])
                        model.Sent_to = dr["sent_to"].ToString();
                    if (DBNull.Value!=dr["sample_type"])
                        model.Sample_type = dr["sample_type"].ToString();
                    if (DBNull.Value!=dr["process_waste"])
                        model.Process_waste = dr["process_waste"].ToString();
                    if (DBNull.Value!=dr["customer_num"])
                        model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["customer_name"])
                        model.Customer_name = dr["customer_name"].ToString();
                    if (DBNull.Value!=dr["customer_adress"])
                        model.Customer_adress = dr["customer_adress"].ToString();
                    if (DBNull.Value!=dr["facitily_colcation"])
                        model.Facitily_colcation = dr["facitily_colcation"].ToString();
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["test_date1"])
                        model.Test_date1= Convert.ToDateTime(dr["test_date1"]);
                    if (DBNull.Value!=dr["test_date2"])
                        model.Test_date2= Convert.ToDateTime(dr["test_date2"]);
                    if (DBNull.Value!=dr["result"])
                        model.Result = dr["result"].ToString();
                    if (DBNull.Value!=dr["profile_id"])
                        model.Profile_id = dr["profile_id"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["is_ok"])
                        model.Is_ok= Convert.ToByte(dr["is_ok"]);
                    if (DBNull.Value!=dr["is_print"])
                        model.Is_print= Convert.ToByte(dr["is_print"]);
                    if (DBNull.Value!=dr["qqc"])
                        model.Qqc= Convert.ToByte(dr["qqc"]);
                    if (DBNull.Value!=dr["yp_name"])
                        model.Yp_name = dr["yp_name"].ToString();
                    if (DBNull.Value!=dr["yp_fl"])
                        model.Yp_fl = dr["yp_fl"].ToString();
                    if (DBNull.Value!=dr["yp_ly"])
                        model.Yp_ly = dr["yp_ly"].ToString();
                    if (DBNull.Value!=dr["yp_wz"])
                        model.Yp_wz = dr["yp_wz"].ToString();
                    if (DBNull.Value!=dr["yp_person"])
                        model.Yp_person = dr["yp_person"].ToString();
                    if (DBNull.Value!=dr["sq_date"])
                        model.Sq_date= Convert.ToDateTime(dr["sq_date"]);
                    if (DBNull.Value!=dr["sq_person"])
                        model.Sq_person = dr["sq_person"].ToString();
                    if (DBNull.Value!=dr["completes_date"])
                        model.Completes_date= Convert.ToDateTime(dr["completes_date"]);
                    if (DBNull.Value!=dr["yp_ms"])
                        model.Yp_ms = dr["yp_ms"].ToString();
                    if (DBNull.Value!=dr["js_person"])
                        model.Js_person = dr["js_person"].ToString();
                    if (DBNull.Value!=dr["shr"])
                        model.Shr = dr["shr"].ToString();
                    if (DBNull.Value!=dr["sh_date"])
                        model.Sh_date= Convert.ToDateTime(dr["sh_date"]);
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
        /// <returns>Samples实体类对象</returns>
        public List<Samples> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Samples> list = new List<Samples>();
            Samples model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Samples_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Samples();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Sample_id = dr["sample_id"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                    if (DBNull.Value!=dr["userstamp"])
                        model.Userstamp = dr["userstamp"].ToString();
                    if (DBNull.Value!=dr["sample_date"])
                        model.Sample_date= Convert.ToDateTime(dr["sample_date"]);
                    if (DBNull.Value!=dr["request_id"])
                        model.Request_id = dr["request_id"].ToString();
                    if (DBNull.Value!=dr["js_date"])
                        model.Js_date= Convert.ToDateTime(dr["js_date"]);
                    if (DBNull.Value!=dr["sent_to"])
                        model.Sent_to = dr["sent_to"].ToString();
                    if (DBNull.Value!=dr["sample_type"])
                        model.Sample_type = dr["sample_type"].ToString();
                    if (DBNull.Value!=dr["process_waste"])
                        model.Process_waste = dr["process_waste"].ToString();
                    if (DBNull.Value!=dr["customer_num"])
                        model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["customer_name"])
                        model.Customer_name = dr["customer_name"].ToString();
                    if (DBNull.Value!=dr["customer_adress"])
                        model.Customer_adress = dr["customer_adress"].ToString();
                    if (DBNull.Value!=dr["facitily_colcation"])
                        model.Facitily_colcation = dr["facitily_colcation"].ToString();
                    if (DBNull.Value!=dr["waste_id"])
                        model.Waste_id = dr["waste_id"].ToString();
                    if (DBNull.Value!=dr["test_date1"])
                        model.Test_date1= Convert.ToDateTime(dr["test_date1"]);
                    if (DBNull.Value!=dr["test_date2"])
                        model.Test_date2= Convert.ToDateTime(dr["test_date2"]);
                    if (DBNull.Value!=dr["result"])
                        model.Result = dr["result"].ToString();
                    if (DBNull.Value!=dr["profile_id"])
                        model.Profile_id = dr["profile_id"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["is_ok"])
                        model.Is_ok= Convert.ToByte(dr["is_ok"]);
                    if (DBNull.Value!=dr["is_print"])
                        model.Is_print= Convert.ToByte(dr["is_print"]);
                    if (DBNull.Value!=dr["qqc"])
                        model.Qqc= Convert.ToByte(dr["qqc"]);
                    if (DBNull.Value!=dr["yp_name"])
                        model.Yp_name = dr["yp_name"].ToString();
                    if (DBNull.Value!=dr["yp_fl"])
                        model.Yp_fl = dr["yp_fl"].ToString();
                    if (DBNull.Value!=dr["yp_ly"])
                        model.Yp_ly = dr["yp_ly"].ToString();
                    if (DBNull.Value!=dr["yp_wz"])
                        model.Yp_wz = dr["yp_wz"].ToString();
                    if (DBNull.Value!=dr["yp_person"])
                        model.Yp_person = dr["yp_person"].ToString();
                    if (DBNull.Value!=dr["sq_date"])
                        model.Sq_date= Convert.ToDateTime(dr["sq_date"]);
                    if (DBNull.Value!=dr["sq_person"])
                        model.Sq_person = dr["sq_person"].ToString();
                    if (DBNull.Value!=dr["completes_date"])
                        model.Completes_date= Convert.ToDateTime(dr["completes_date"]);
                    if (DBNull.Value!=dr["yp_ms"])
                        model.Yp_ms = dr["yp_ms"].ToString();
                    if (DBNull.Value!=dr["js_person"])
                        model.Js_person = dr["js_person"].ToString();
                    if (DBNull.Value!=dr["shr"])
                        model.Shr = dr["shr"].ToString();
                    if (DBNull.Value!=dr["sh_date"])
                        model.Sh_date= Convert.ToDateTime(dr["sh_date"]);
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

