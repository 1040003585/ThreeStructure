using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Container_detailService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Container_detail">Container_detail实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Container_detail model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@container_id",model.Container_id),
                new SqlParameter ("@ticket_num",model.Ticket_num),
                new SqlParameter ("@net_weight",model.Net_weight),
                new SqlParameter ("@date_time",model.Date_time),
                new SqlParameter ("@location_id",model.Location_id),
                new SqlParameter ("@status",model.Status)
            };
           return Helper .ExecuteNonQuery ("Container_detail_Add",param);
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
           return Helper .ExecuteNonQuery ("Container_detail_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Container_detail">Container_detail实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Container_detail model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@container_id",model.Container_id),
                new SqlParameter ("@ticket_num",model.Ticket_num),
                new SqlParameter ("@net_weight",model.Net_weight),
                new SqlParameter ("@date_time",model.Date_time),
                new SqlParameter ("@location_id",model.Location_id),
                new SqlParameter ("@status",model.Status)
            };
           return Helper .ExecuteNonQuery ("Container_detail_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Container_detail> selectAll()
        {
            List<Container_detail> list = new List<Container_detail>();
            Container_detail model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Container_detail_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Container_detail();
                    model.Bh = dr["bh"].ToString();
                    model.Container_id = dr["container_id"].ToString();
                    model.Ticket_num = dr["ticket_num"].ToString();
                    if (DBNull.Value!=dr["net_weight"])
                        model.Net_weight= Convert.ToDecimal(dr["net_weight"]);
                    if (DBNull.Value!=dr["date_time"])
                        model.Date_time= Convert.ToDateTime(dr["date_time"]);
                    if (DBNull.Value!=dr["location_id"])
                        model.Location_id = dr["location_id"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Container_detail实体类对象</returns>
        public Container_detail selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Container_detail model = new Container_detail();
            using (SqlDataReader dr = Helper.ExecuteReader("Container_detail_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bh = dr["bh"].ToString();
                    model.Container_id = dr["container_id"].ToString();
                    model.Ticket_num = dr["ticket_num"].ToString();
                    if (DBNull.Value!=dr["net_weight"])
                        model.Net_weight= Convert.ToDecimal(dr["net_weight"]);
                    if (DBNull.Value!=dr["date_time"])
                        model.Date_time= Convert.ToDateTime(dr["date_time"]);
                    if (DBNull.Value!=dr["location_id"])
                        model.Location_id = dr["location_id"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Container_detail实体类对象</returns>
        public List<Container_detail> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Container_detail> list = new List<Container_detail>();
            Container_detail model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Container_detail_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Container_detail();
                    model.Bh = dr["bh"].ToString();
                    model.Container_id = dr["container_id"].ToString();
                    model.Ticket_num = dr["ticket_num"].ToString();
                    if (DBNull.Value!=dr["net_weight"])
                        model.Net_weight= Convert.ToDecimal(dr["net_weight"]);
                    if (DBNull.Value!=dr["date_time"])
                        model.Date_time= Convert.ToDateTime(dr["date_time"]);
                    if (DBNull.Value!=dr["location_id"])
                        model.Location_id = dr["location_id"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

