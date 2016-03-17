using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class TrackingService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Tracking">Tracking实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Tracking model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@container_id",model.Container_id),
                new SqlParameter ("@weight",model.Weight),
                new SqlParameter ("@date_time",model.Date_time),
                new SqlParameter ("@location_id",model.Location_id),
                new SqlParameter ("@status",model.Status),
                new SqlParameter ("@ticket_num",model.Ticket_num),
                new SqlParameter ("@yyy",model.Yyy),
                new SqlParameter ("@waste_code",model.Waste_code),
                new SqlParameter ("@dw",model.Dw),
                new SqlParameter ("@m_datetime",model.M_datetime),
                new SqlParameter ("@tre_yyy",model.Tre_yyy),
                new SqlParameter ("@m_yyy",model.M_yyy),
                new SqlParameter ("@tre_datetime",model.Tre_datetime),
                new SqlParameter ("@old_location_id",model.Old_location_id),
                new SqlParameter ("@m_weight",model.M_weight),
                new SqlParameter ("@old_status",model.Old_status),
                new SqlParameter ("@finance_flag",model.Finance_flag),
                new SqlParameter ("@tz_weight",model.Tz_weight),
                new SqlParameter ("@bz",model.Bz)
            };
           return Helper .ExecuteNonQuery ("Tracking_Add",param);
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
           return Helper .ExecuteNonQuery ("Tracking_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Tracking">Tracking实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Tracking model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@container_id",model.Container_id),
                new SqlParameter ("@weight",model.Weight),
                new SqlParameter ("@date_time",model.Date_time),
                new SqlParameter ("@location_id",model.Location_id),
                new SqlParameter ("@status",model.Status),
                new SqlParameter ("@ticket_num",model.Ticket_num),
                new SqlParameter ("@yyy",model.Yyy),
                new SqlParameter ("@waste_code",model.Waste_code),
                new SqlParameter ("@dw",model.Dw),
                new SqlParameter ("@m_datetime",model.M_datetime),
                new SqlParameter ("@tre_yyy",model.Tre_yyy),
                new SqlParameter ("@m_yyy",model.M_yyy),
                new SqlParameter ("@tre_datetime",model.Tre_datetime),
                new SqlParameter ("@old_location_id",model.Old_location_id),
                new SqlParameter ("@m_weight",model.M_weight),
                new SqlParameter ("@old_status",model.Old_status),
                new SqlParameter ("@finance_flag",model.Finance_flag),
                new SqlParameter ("@tz_weight",model.Tz_weight),
                new SqlParameter ("@bz",model.Bz)
            };
           return Helper .ExecuteNonQuery ("Tracking_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Tracking> selectAll()
        {
            List<Tracking> list = new List<Tracking>();
            Tracking model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Tracking_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Tracking();
                    model.Bh = dr["bh"].ToString();
                    model.Container_id = dr["container_id"].ToString();
                    if (DBNull.Value!=dr["weight"])
                        model.Weight= Convert.ToDecimal(dr["weight"]);
                    if (DBNull.Value!=dr["date_time"])
                        model.Date_time= Convert.ToDateTime(dr["date_time"]);
                    if (DBNull.Value!=dr["location_id"])
                        model.Location_id = dr["location_id"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                    if (DBNull.Value!=dr["ticket_num"])
                        model.Ticket_num = dr["ticket_num"].ToString();
                    if (DBNull.Value!=dr["yyy"])
                        model.Yyy = dr["yyy"].ToString();
                    if (DBNull.Value!=dr["waste_code"])
                        model.Waste_code = dr["waste_code"].ToString();
                    if (DBNull.Value!=dr["dw"])
                        model.Dw = dr["dw"].ToString();
                    if (DBNull.Value!=dr["m_datetime"])
                        model.M_datetime= Convert.ToDateTime(dr["m_datetime"]);
                    if (DBNull.Value!=dr["tre_yyy"])
                        model.Tre_yyy = dr["tre_yyy"].ToString();
                    if (DBNull.Value!=dr["m_yyy"])
                        model.M_yyy = dr["m_yyy"].ToString();
                    if (DBNull.Value!=dr["tre_datetime"])
                        model.Tre_datetime= Convert.ToDateTime(dr["tre_datetime"]);
                    if (DBNull.Value!=dr["old_location_id"])
                        model.Old_location_id = dr["old_location_id"].ToString();
                    if (DBNull.Value!=dr["m_weight"])
                        model.M_weight= Convert.ToDecimal(dr["m_weight"]);
                    if (DBNull.Value!=dr["old_status"])
                        model.Old_status = dr["old_status"].ToString();
                    if (DBNull.Value!=dr["finance_flag"])
                        model.Finance_flag = dr["finance_flag"].ToString();
                    if (DBNull.Value!=dr["tz_weight"])
                        model.Tz_weight= Convert.ToDecimal(dr["tz_weight"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Tracking实体类对象</returns>
        public Tracking selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Tracking model = new Tracking();
            using (SqlDataReader dr = Helper.ExecuteReader("Tracking_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bh = dr["bh"].ToString();
                    model.Container_id = dr["container_id"].ToString();
                    if (DBNull.Value!=dr["weight"])
                        model.Weight= Convert.ToDecimal(dr["weight"]);
                    if (DBNull.Value!=dr["date_time"])
                        model.Date_time= Convert.ToDateTime(dr["date_time"]);
                    if (DBNull.Value!=dr["location_id"])
                        model.Location_id = dr["location_id"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                    if (DBNull.Value!=dr["ticket_num"])
                        model.Ticket_num = dr["ticket_num"].ToString();
                    if (DBNull.Value!=dr["yyy"])
                        model.Yyy = dr["yyy"].ToString();
                    if (DBNull.Value!=dr["waste_code"])
                        model.Waste_code = dr["waste_code"].ToString();
                    if (DBNull.Value!=dr["dw"])
                        model.Dw = dr["dw"].ToString();
                    if (DBNull.Value!=dr["m_datetime"])
                        model.M_datetime= Convert.ToDateTime(dr["m_datetime"]);
                    if (DBNull.Value!=dr["tre_yyy"])
                        model.Tre_yyy = dr["tre_yyy"].ToString();
                    if (DBNull.Value!=dr["m_yyy"])
                        model.M_yyy = dr["m_yyy"].ToString();
                    if (DBNull.Value!=dr["tre_datetime"])
                        model.Tre_datetime= Convert.ToDateTime(dr["tre_datetime"]);
                    if (DBNull.Value!=dr["old_location_id"])
                        model.Old_location_id = dr["old_location_id"].ToString();
                    if (DBNull.Value!=dr["m_weight"])
                        model.M_weight= Convert.ToDecimal(dr["m_weight"]);
                    if (DBNull.Value!=dr["old_status"])
                        model.Old_status = dr["old_status"].ToString();
                    if (DBNull.Value!=dr["finance_flag"])
                        model.Finance_flag = dr["finance_flag"].ToString();
                    if (DBNull.Value!=dr["tz_weight"])
                        model.Tz_weight= Convert.ToDecimal(dr["tz_weight"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Tracking实体类对象</returns>
        public List<Tracking> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Tracking> list = new List<Tracking>();
            Tracking model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Tracking_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Tracking();
                    model.Bh = dr["bh"].ToString();
                    model.Container_id = dr["container_id"].ToString();
                    if (DBNull.Value!=dr["weight"])
                        model.Weight= Convert.ToDecimal(dr["weight"]);
                    if (DBNull.Value!=dr["date_time"])
                        model.Date_time= Convert.ToDateTime(dr["date_time"]);
                    if (DBNull.Value!=dr["location_id"])
                        model.Location_id = dr["location_id"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                    if (DBNull.Value!=dr["ticket_num"])
                        model.Ticket_num = dr["ticket_num"].ToString();
                    if (DBNull.Value!=dr["yyy"])
                        model.Yyy = dr["yyy"].ToString();
                    if (DBNull.Value!=dr["waste_code"])
                        model.Waste_code = dr["waste_code"].ToString();
                    if (DBNull.Value!=dr["dw"])
                        model.Dw = dr["dw"].ToString();
                    if (DBNull.Value!=dr["m_datetime"])
                        model.M_datetime= Convert.ToDateTime(dr["m_datetime"]);
                    if (DBNull.Value!=dr["tre_yyy"])
                        model.Tre_yyy = dr["tre_yyy"].ToString();
                    if (DBNull.Value!=dr["m_yyy"])
                        model.M_yyy = dr["m_yyy"].ToString();
                    if (DBNull.Value!=dr["tre_datetime"])
                        model.Tre_datetime= Convert.ToDateTime(dr["tre_datetime"]);
                    if (DBNull.Value!=dr["old_location_id"])
                        model.Old_location_id = dr["old_location_id"].ToString();
                    if (DBNull.Value!=dr["m_weight"])
                        model.M_weight= Convert.ToDecimal(dr["m_weight"]);
                    if (DBNull.Value!=dr["old_status"])
                        model.Old_status = dr["old_status"].ToString();
                    if (DBNull.Value!=dr["finance_flag"])
                        model.Finance_flag = dr["finance_flag"].ToString();
                    if (DBNull.Value!=dr["tz_weight"])
                        model.Tz_weight= Convert.ToDecimal(dr["tz_weight"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

