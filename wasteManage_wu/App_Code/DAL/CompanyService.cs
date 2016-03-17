using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class CompanyService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Company">Company实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Company model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@company_name",model.Company_name),
                new SqlParameter ("@company_bh",model.Company_bh),
                new SqlParameter ("@address",model.Address),
                new SqlParameter ("@tel",model.Tel),
                new SqlParameter ("@fax",model.Fax),
                new SqlParameter ("@qq",model.Qq),
                new SqlParameter ("@e_mail",model.E_mail),
                new SqlParameter ("@mail",model.Mail),
                new SqlParameter ("@corporation",model.Corporation),
                new SqlParameter ("@licence",model.Licence),
                new SqlParameter ("@fzr",model.Fzr),
                new SqlParameter ("@rq",model.Rq),
                new SqlParameter ("@jsjl",model.Jsjl),
                new SqlParameter ("@cjzg",model.Cjzg),
                new SqlParameter ("@n1",model.N1),
                new SqlParameter ("@n2",model.N2),
                new SqlParameter ("@n3",model.N3),
                new SqlParameter ("@qx",model.Qx)
            };
           return Helper .ExecuteNonQuery ("Company_Add",param);
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
                new SqlParameter ("@company_name",Id)
            };
           return Helper .ExecuteNonQuery ("Company_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Company">Company实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Company model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@company_name",model.Company_name),
                new SqlParameter ("@company_bh",model.Company_bh),
                new SqlParameter ("@address",model.Address),
                new SqlParameter ("@tel",model.Tel),
                new SqlParameter ("@fax",model.Fax),
                new SqlParameter ("@qq",model.Qq),
                new SqlParameter ("@e_mail",model.E_mail),
                new SqlParameter ("@mail",model.Mail),
                new SqlParameter ("@corporation",model.Corporation),
                new SqlParameter ("@licence",model.Licence),
                new SqlParameter ("@fzr",model.Fzr),
                new SqlParameter ("@rq",model.Rq),
                new SqlParameter ("@jsjl",model.Jsjl),
                new SqlParameter ("@cjzg",model.Cjzg),
                new SqlParameter ("@n1",model.N1),
                new SqlParameter ("@n2",model.N2),
                new SqlParameter ("@n3",model.N3),
                new SqlParameter ("@qx",model.Qx)
            };
           return Helper .ExecuteNonQuery ("Company_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Company> selectAll()
        {
            List<Company> list = new List<Company>();
            Company model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Company_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Company();
                    if (DBNull.Value!=dr["company_name"])
                        model.Company_name = dr["company_name"].ToString();
                    if (DBNull.Value!=dr["company_bh"])
                        model.Company_bh = dr["company_bh"].ToString();
                    if (DBNull.Value!=dr["address"])
                        model.Address = dr["address"].ToString();
                    if (DBNull.Value!=dr["tel"])
                        model.Tel = dr["tel"].ToString();
                    if (DBNull.Value!=dr["fax"])
                        model.Fax = dr["fax"].ToString();
                    if (DBNull.Value!=dr["qq"])
                        model.Qq= Convert.ToInt32(dr["qq"]);
                    if (DBNull.Value!=dr["e_mail"])
                        model.E_mail = dr["e_mail"].ToString();
                    if (DBNull.Value!=dr["mail"])
                        model.Mail = dr["mail"].ToString();
                    if (DBNull.Value!=dr["corporation"])
                        model.Corporation = dr["corporation"].ToString();
                    if (DBNull.Value!=dr["licence"])
                        model.Licence = dr["licence"].ToString();
                    if (DBNull.Value!=dr["fzr"])
                        model.Fzr = dr["fzr"].ToString();
                    if (DBNull.Value!=dr["rq"])
                        model.Rq= Convert.ToDateTime(dr["rq"]);
                    if (DBNull.Value!=dr["jsjl"])
                        model.Jsjl = dr["jsjl"].ToString();
                    if (DBNull.Value!=dr["cjzg"])
                        model.Cjzg = dr["cjzg"].ToString();
                    if (DBNull.Value!=dr["n1"])
                        model.N1 = dr["n1"].ToString();
                    if (DBNull.Value!=dr["n2"])
                        model.N2 = dr["n2"].ToString();
                    if (DBNull.Value!=dr["n3"])
                        model.N3 = dr["n3"].ToString();
                    if (DBNull.Value!=dr["qx"])
                        model.Qx = dr["qx"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Company实体类对象</returns>
        public Company selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@company_name",Id)
            };
            Company model = new Company();
            using (SqlDataReader dr = Helper.ExecuteReader("Company_SelectById", param))
            {
                if (dr.Read())
                {
                    if (DBNull.Value!=dr["company_name"])
                        model.Company_name = dr["company_name"].ToString();
                    if (DBNull.Value!=dr["company_bh"])
                        model.Company_bh = dr["company_bh"].ToString();
                    if (DBNull.Value!=dr["address"])
                        model.Address = dr["address"].ToString();
                    if (DBNull.Value!=dr["tel"])
                        model.Tel = dr["tel"].ToString();
                    if (DBNull.Value!=dr["fax"])
                        model.Fax = dr["fax"].ToString();
                    if (DBNull.Value!=dr["qq"])
                        model.Qq= Convert.ToInt32(dr["qq"]);
                    if (DBNull.Value!=dr["e_mail"])
                        model.E_mail = dr["e_mail"].ToString();
                    if (DBNull.Value!=dr["mail"])
                        model.Mail = dr["mail"].ToString();
                    if (DBNull.Value!=dr["corporation"])
                        model.Corporation = dr["corporation"].ToString();
                    if (DBNull.Value!=dr["licence"])
                        model.Licence = dr["licence"].ToString();
                    if (DBNull.Value!=dr["fzr"])
                        model.Fzr = dr["fzr"].ToString();
                    if (DBNull.Value!=dr["rq"])
                        model.Rq= Convert.ToDateTime(dr["rq"]);
                    if (DBNull.Value!=dr["jsjl"])
                        model.Jsjl = dr["jsjl"].ToString();
                    if (DBNull.Value!=dr["cjzg"])
                        model.Cjzg = dr["cjzg"].ToString();
                    if (DBNull.Value!=dr["n1"])
                        model.N1 = dr["n1"].ToString();
                    if (DBNull.Value!=dr["n2"])
                        model.N2 = dr["n2"].ToString();
                    if (DBNull.Value!=dr["n3"])
                        model.N3 = dr["n3"].ToString();
                    if (DBNull.Value!=dr["qx"])
                        model.Qx = dr["qx"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Company实体类对象</returns>
        public List<Company> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Company> list = new List<Company>();
            Company model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Company_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Company();
                    if (DBNull.Value!=dr["company_name"])
                        model.Company_name = dr["company_name"].ToString();
                    if (DBNull.Value!=dr["company_bh"])
                        model.Company_bh = dr["company_bh"].ToString();
                    if (DBNull.Value!=dr["address"])
                        model.Address = dr["address"].ToString();
                    if (DBNull.Value!=dr["tel"])
                        model.Tel = dr["tel"].ToString();
                    if (DBNull.Value!=dr["fax"])
                        model.Fax = dr["fax"].ToString();
                    if (DBNull.Value!=dr["qq"])
                        model.Qq= Convert.ToInt32(dr["qq"]);
                    if (DBNull.Value!=dr["e_mail"])
                        model.E_mail = dr["e_mail"].ToString();
                    if (DBNull.Value!=dr["mail"])
                        model.Mail = dr["mail"].ToString();
                    if (DBNull.Value!=dr["corporation"])
                        model.Corporation = dr["corporation"].ToString();
                    if (DBNull.Value!=dr["licence"])
                        model.Licence = dr["licence"].ToString();
                    if (DBNull.Value!=dr["fzr"])
                        model.Fzr = dr["fzr"].ToString();
                    if (DBNull.Value!=dr["rq"])
                        model.Rq= Convert.ToDateTime(dr["rq"]);
                    if (DBNull.Value!=dr["jsjl"])
                        model.Jsjl = dr["jsjl"].ToString();
                    if (DBNull.Value!=dr["cjzg"])
                        model.Cjzg = dr["cjzg"].ToString();
                    if (DBNull.Value!=dr["n1"])
                        model.N1 = dr["n1"].ToString();
                    if (DBNull.Value!=dr["n2"])
                        model.N2 = dr["n2"].ToString();
                    if (DBNull.Value!=dr["n3"])
                        model.N3 = dr["n3"].ToString();
                    if (DBNull.Value!=dr["qx"])
                        model.Qx = dr["qx"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

