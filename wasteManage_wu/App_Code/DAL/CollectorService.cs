using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class CollectorService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Collector">Collector实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Collector model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@collector_num",model.Collector_num),
                new SqlParameter ("@collector_name",model.Collector_name),
                new SqlParameter ("@address",model.Address),
                new SqlParameter ("@telephone_no",model.Telephone_no),
                new SqlParameter ("@mail",model.Mail),
                new SqlParameter ("@contact_person",model.Contact_person),
                new SqlParameter ("@contact_phone_no",model.Contact_phone_no),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@updated_by",model.Updated_by),
                new SqlParameter ("@update_date",model.Update_date),
                new SqlParameter ("@vehicle_num",model.Vehicle_num),
                new SqlParameter ("@driver_name",model.Driver_name),
                new SqlParameter ("@lxr",model.Lxr)
            };
           return Helper .ExecuteNonQuery ("Collector_Add",param);
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
           return Helper .ExecuteNonQuery ("Collector_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Collector">Collector实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Collector model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@collector_num",model.Collector_num),
                new SqlParameter ("@collector_name",model.Collector_name),
                new SqlParameter ("@address",model.Address),
                new SqlParameter ("@telephone_no",model.Telephone_no),
                new SqlParameter ("@mail",model.Mail),
                new SqlParameter ("@contact_person",model.Contact_person),
                new SqlParameter ("@contact_phone_no",model.Contact_phone_no),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@create_date",model.Create_date),
                new SqlParameter ("@updated_by",model.Updated_by),
                new SqlParameter ("@update_date",model.Update_date),
                new SqlParameter ("@vehicle_num",model.Vehicle_num),
                new SqlParameter ("@driver_name",model.Driver_name),
                new SqlParameter ("@lxr",model.Lxr)
            };
           return Helper .ExecuteNonQuery ("Collector_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Collector> selectAll()
        {
            List<Collector> list = new List<Collector>();
            Collector model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Collector_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Collector();
                    model.Bh = dr["bh"].ToString();
                    model.Collector_num = dr["collector_num"].ToString();
                    if (DBNull.Value!=dr["collector_name"])
                        model.Collector_name = dr["collector_name"].ToString();
                    if (DBNull.Value!=dr["address"])
                        model.Address = dr["address"].ToString();
                    if (DBNull.Value!=dr["telephone_no"])
                        model.Telephone_no = dr["telephone_no"].ToString();
                    if (DBNull.Value!=dr["mail"])
                        model.Mail = dr["mail"].ToString();
                    if (DBNull.Value!=dr["contact_person"])
                        model.Contact_person = dr["contact_person"].ToString();
                    if (DBNull.Value!=dr["contact_phone_no"])
                        model.Contact_phone_no = dr["contact_phone_no"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["vehicle_num"])
                        model.Vehicle_num = dr["vehicle_num"].ToString();
                    if (DBNull.Value!=dr["driver_name"])
                        model.Driver_name = dr["driver_name"].ToString();
                    if (DBNull.Value!=dr["lxr"])
                        model.Lxr = dr["lxr"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Collector实体类对象</returns>
        public Collector selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Collector model = new Collector();
            using (SqlDataReader dr = Helper.ExecuteReader("Collector_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bh = dr["bh"].ToString();
                    model.Collector_num = dr["collector_num"].ToString();
                    if (DBNull.Value!=dr["collector_name"])
                        model.Collector_name = dr["collector_name"].ToString();
                    if (DBNull.Value!=dr["address"])
                        model.Address = dr["address"].ToString();
                    if (DBNull.Value!=dr["telephone_no"])
                        model.Telephone_no = dr["telephone_no"].ToString();
                    if (DBNull.Value!=dr["mail"])
                        model.Mail = dr["mail"].ToString();
                    if (DBNull.Value!=dr["contact_person"])
                        model.Contact_person = dr["contact_person"].ToString();
                    if (DBNull.Value!=dr["contact_phone_no"])
                        model.Contact_phone_no = dr["contact_phone_no"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["vehicle_num"])
                        model.Vehicle_num = dr["vehicle_num"].ToString();
                    if (DBNull.Value!=dr["driver_name"])
                        model.Driver_name = dr["driver_name"].ToString();
                    if (DBNull.Value!=dr["lxr"])
                        model.Lxr = dr["lxr"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Collector实体类对象</returns>
        public List<Collector> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Collector> list = new List<Collector>();
            Collector model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Collector_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Collector();
                    model.Bh = dr["bh"].ToString();
                    model.Collector_num = dr["collector_num"].ToString();
                    if (DBNull.Value!=dr["collector_name"])
                        model.Collector_name = dr["collector_name"].ToString();
                    if (DBNull.Value!=dr["address"])
                        model.Address = dr["address"].ToString();
                    if (DBNull.Value!=dr["telephone_no"])
                        model.Telephone_no = dr["telephone_no"].ToString();
                    if (DBNull.Value!=dr["mail"])
                        model.Mail = dr["mail"].ToString();
                    if (DBNull.Value!=dr["contact_person"])
                        model.Contact_person = dr["contact_person"].ToString();
                    if (DBNull.Value!=dr["contact_phone_no"])
                        model.Contact_phone_no = dr["contact_phone_no"].ToString();
                    if (DBNull.Value!=dr["created_by"])
                        model.Created_by = dr["created_by"].ToString();
                    if (DBNull.Value!=dr["create_date"])
                        model.Create_date= Convert.ToDateTime(dr["create_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["vehicle_num"])
                        model.Vehicle_num = dr["vehicle_num"].ToString();
                    if (DBNull.Value!=dr["driver_name"])
                        model.Driver_name = dr["driver_name"].ToString();
                    if (DBNull.Value!=dr["lxr"])
                        model.Lxr = dr["lxr"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

