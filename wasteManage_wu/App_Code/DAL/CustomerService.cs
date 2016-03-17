using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class CustomerService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Customer">Customer实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Customer model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@customer_num",model.Customer_num),
                new SqlParameter ("@customer_name",model.Customer_name),
                new SqlParameter ("@bm_dqfl",model.Bm_dqfl),
                new SqlParameter ("@address",model.Address),
                new SqlParameter ("@telephone_no",model.Telephone_no),
                new SqlParameter ("@mail",model.Mail),
                new SqlParameter ("@contact_person",model.Contact_person),
                new SqlParameter ("@contact_phone_no",model.Contact_phone_no),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@created_date",model.Created_date),
                new SqlParameter ("@updated_by",model.Updated_by),
                new SqlParameter ("@update_date",model.Update_date),
                new SqlParameter ("@status",model.Status),
                new SqlParameter ("@sales_person",model.Sales_person),
                new SqlParameter ("@fzr_dz",model.Fzr_dz),
                new SqlParameter ("@fax",model.Fax),
                new SqlParameter ("@fzr",model.Fzr),
                new SqlParameter ("@fzr_tel",model.Fzr_tel),
                new SqlParameter ("@fzr_dy",model.Fzr_dy),
                new SqlParameter ("@bak_pay",model.Bak_pay),
                new SqlParameter ("@bak_dress",model.Bak_dress),
                new SqlParameter ("@date_bak",model.Date_bak),
                new SqlParameter ("@fkqx",model.Fkqx),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@customer_tel",model.Customer_tel)
            };
           return Helper .ExecuteNonQuery ("Customer_Add",param);
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
           return Helper .ExecuteNonQuery ("Customer_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Customer">Customer实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Customer model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@customer_num",model.Customer_num),
                new SqlParameter ("@customer_name",model.Customer_name),
                new SqlParameter ("@bm_dqfl",model.Bm_dqfl),
                new SqlParameter ("@address",model.Address),
                new SqlParameter ("@telephone_no",model.Telephone_no),
                new SqlParameter ("@mail",model.Mail),
                new SqlParameter ("@contact_person",model.Contact_person),
                new SqlParameter ("@contact_phone_no",model.Contact_phone_no),
                new SqlParameter ("@created_by",model.Created_by),
                new SqlParameter ("@created_date",model.Created_date),
                new SqlParameter ("@updated_by",model.Updated_by),
                new SqlParameter ("@update_date",model.Update_date),
                new SqlParameter ("@status",model.Status),
                new SqlParameter ("@sales_person",model.Sales_person),
                new SqlParameter ("@fzr_dz",model.Fzr_dz),
                new SqlParameter ("@fax",model.Fax),
                new SqlParameter ("@fzr",model.Fzr),
                new SqlParameter ("@fzr_tel",model.Fzr_tel),
                new SqlParameter ("@fzr_dy",model.Fzr_dy),
                new SqlParameter ("@bak_pay",model.Bak_pay),
                new SqlParameter ("@bak_dress",model.Bak_dress),
                new SqlParameter ("@date_bak",model.Date_bak),
                new SqlParameter ("@fkqx",model.Fkqx),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@customer_tel",model.Customer_tel)
            };
           return Helper .ExecuteNonQuery ("Customer_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Customer> selectAll()
        {
            List<Customer> list = new List<Customer>();
            Customer model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Customer_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Customer();
                    model.Bh = dr["bh"].ToString();
                    model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["customer_name"])
                        model.Customer_name = dr["customer_name"].ToString();
                    if (DBNull.Value!=dr["bm_dqfl"])
                        model.Bm_dqfl = dr["bm_dqfl"].ToString();
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
                    if (DBNull.Value!=dr["created_date"])
                        model.Created_date= Convert.ToDateTime(dr["created_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                    if (DBNull.Value!=dr["sales_person"])
                        model.Sales_person = dr["sales_person"].ToString();
                    if (DBNull.Value!=dr["fzr_dz"])
                        model.Fzr_dz = dr["fzr_dz"].ToString();
                    if (DBNull.Value!=dr["fax"])
                        model.Fax = dr["fax"].ToString();
                    if (DBNull.Value!=dr["fzr"])
                        model.Fzr = dr["fzr"].ToString();
                    if (DBNull.Value!=dr["fzr_tel"])
                        model.Fzr_tel = dr["fzr_tel"].ToString();
                    if (DBNull.Value!=dr["fzr_dy"])
                        model.Fzr_dy = dr["fzr_dy"].ToString();
                    if (DBNull.Value!=dr["bak_pay"])
                        model.Bak_pay = dr["bak_pay"].ToString();
                    if (DBNull.Value!=dr["bak_dress"])
                        model.Bak_dress = dr["bak_dress"].ToString();
                    if (DBNull.Value!=dr["date_bak"])
                        model.Date_bak= Convert.ToDateTime(dr["date_bak"]);
                    if (DBNull.Value!=dr["fkqx"])
                        model.Fkqx = dr["fkqx"].ToString();
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["customer_tel"])
                        model.Customer_tel = dr["customer_tel"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Customer实体类对象</returns>
        public Customer selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Customer model = new Customer();
            using (SqlDataReader dr = Helper.ExecuteReader("Customer_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bh = dr["bh"].ToString();
                    model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["customer_name"])
                        model.Customer_name = dr["customer_name"].ToString();
                    if (DBNull.Value!=dr["bm_dqfl"])
                        model.Bm_dqfl = dr["bm_dqfl"].ToString();
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
                    if (DBNull.Value!=dr["created_date"])
                        model.Created_date= Convert.ToDateTime(dr["created_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                    if (DBNull.Value!=dr["sales_person"])
                        model.Sales_person = dr["sales_person"].ToString();
                    if (DBNull.Value!=dr["fzr_dz"])
                        model.Fzr_dz = dr["fzr_dz"].ToString();
                    if (DBNull.Value!=dr["fax"])
                        model.Fax = dr["fax"].ToString();
                    if (DBNull.Value!=dr["fzr"])
                        model.Fzr = dr["fzr"].ToString();
                    if (DBNull.Value!=dr["fzr_tel"])
                        model.Fzr_tel = dr["fzr_tel"].ToString();
                    if (DBNull.Value!=dr["fzr_dy"])
                        model.Fzr_dy = dr["fzr_dy"].ToString();
                    if (DBNull.Value!=dr["bak_pay"])
                        model.Bak_pay = dr["bak_pay"].ToString();
                    if (DBNull.Value!=dr["bak_dress"])
                        model.Bak_dress = dr["bak_dress"].ToString();
                    if (DBNull.Value!=dr["date_bak"])
                        model.Date_bak= Convert.ToDateTime(dr["date_bak"]);
                    if (DBNull.Value!=dr["fkqx"])
                        model.Fkqx = dr["fkqx"].ToString();
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["customer_tel"])
                        model.Customer_tel = dr["customer_tel"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Customer实体类对象</returns>
        public List<Customer> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Customer> list = new List<Customer>();
            Customer model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Customer_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Customer();
                    model.Bh = dr["bh"].ToString();
                    model.Customer_num = dr["customer_num"].ToString();
                    if (DBNull.Value!=dr["customer_name"])
                        model.Customer_name = dr["customer_name"].ToString();
                    if (DBNull.Value!=dr["bm_dqfl"])
                        model.Bm_dqfl = dr["bm_dqfl"].ToString();
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
                    if (DBNull.Value!=dr["created_date"])
                        model.Created_date= Convert.ToDateTime(dr["created_date"]);
                    if (DBNull.Value!=dr["updated_by"])
                        model.Updated_by = dr["updated_by"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["status"])
                        model.Status = dr["status"].ToString();
                    if (DBNull.Value!=dr["sales_person"])
                        model.Sales_person = dr["sales_person"].ToString();
                    if (DBNull.Value!=dr["fzr_dz"])
                        model.Fzr_dz = dr["fzr_dz"].ToString();
                    if (DBNull.Value!=dr["fax"])
                        model.Fax = dr["fax"].ToString();
                    if (DBNull.Value!=dr["fzr"])
                        model.Fzr = dr["fzr"].ToString();
                    if (DBNull.Value!=dr["fzr_tel"])
                        model.Fzr_tel = dr["fzr_tel"].ToString();
                    if (DBNull.Value!=dr["fzr_dy"])
                        model.Fzr_dy = dr["fzr_dy"].ToString();
                    if (DBNull.Value!=dr["bak_pay"])
                        model.Bak_pay = dr["bak_pay"].ToString();
                    if (DBNull.Value!=dr["bak_dress"])
                        model.Bak_dress = dr["bak_dress"].ToString();
                    if (DBNull.Value!=dr["date_bak"])
                        model.Date_bak= Convert.ToDateTime(dr["date_bak"]);
                    if (DBNull.Value!=dr["fkqx"])
                        model.Fkqx = dr["fkqx"].ToString();
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["customer_tel"])
                        model.Customer_tel = dr["customer_tel"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

