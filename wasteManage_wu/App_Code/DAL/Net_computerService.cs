using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Net_computerService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Net_computer">Net_computer实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Net_computer model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@computer_ip",model.Computer_ip),
                new SqlParameter ("@computer_name",model.Computer_name),
                new SqlParameter ("@is_connect",model.Is_connect),
                new SqlParameter ("@is_net",model.Is_net),
                new SqlParameter ("@computer_type",model.Computer_type)
            };
           return Helper .ExecuteNonQuery ("Net_computer_Add",param);
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
                new SqlParameter ("@computer_ip",Id)
            };
           return Helper .ExecuteNonQuery ("Net_computer_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Net_computer">Net_computer实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Net_computer model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@computer_ip",model.Computer_ip),
                new SqlParameter ("@computer_name",model.Computer_name),
                new SqlParameter ("@is_connect",model.Is_connect),
                new SqlParameter ("@is_net",model.Is_net),
                new SqlParameter ("@computer_type",model.Computer_type)
            };
           return Helper .ExecuteNonQuery ("Net_computer_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Net_computer> selectAll()
        {
            List<Net_computer> list = new List<Net_computer>();
            Net_computer model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Net_computer_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Net_computer();
                    if (DBNull.Value!=dr["computer_ip"])
                        model.Computer_ip = dr["computer_ip"].ToString();
                    if (DBNull.Value!=dr["computer_name"])
                        model.Computer_name = dr["computer_name"].ToString();
                    if (DBNull.Value!=dr["is_connect"])
                        model.Is_connect= Convert.ToByte(dr["is_connect"]);
                    if (DBNull.Value!=dr["is_net"])
                        model.Is_net = dr["is_net"].ToString();
                    if (DBNull.Value!=dr["computer_type"])
                        model.Computer_type = dr["computer_type"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Net_computer实体类对象</returns>
        public Net_computer selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@computer_ip",Id)
            };
            Net_computer model = new Net_computer();
            using (SqlDataReader dr = Helper.ExecuteReader("Net_computer_SelectById", param))
            {
                if (dr.Read())
                {
                    if (DBNull.Value!=dr["computer_ip"])
                        model.Computer_ip = dr["computer_ip"].ToString();
                    if (DBNull.Value!=dr["computer_name"])
                        model.Computer_name = dr["computer_name"].ToString();
                    if (DBNull.Value!=dr["is_connect"])
                        model.Is_connect= Convert.ToByte(dr["is_connect"]);
                    if (DBNull.Value!=dr["is_net"])
                        model.Is_net = dr["is_net"].ToString();
                    if (DBNull.Value!=dr["computer_type"])
                        model.Computer_type = dr["computer_type"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Net_computer实体类对象</returns>
        public List<Net_computer> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Net_computer> list = new List<Net_computer>();
            Net_computer model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Net_computer_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Net_computer();
                    if (DBNull.Value!=dr["computer_ip"])
                        model.Computer_ip = dr["computer_ip"].ToString();
                    if (DBNull.Value!=dr["computer_name"])
                        model.Computer_name = dr["computer_name"].ToString();
                    if (DBNull.Value!=dr["is_connect"])
                        model.Is_connect= Convert.ToByte(dr["is_connect"]);
                    if (DBNull.Value!=dr["is_net"])
                        model.Is_net = dr["is_net"].ToString();
                    if (DBNull.Value!=dr["computer_type"])
                        model.Computer_type = dr["computer_type"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

