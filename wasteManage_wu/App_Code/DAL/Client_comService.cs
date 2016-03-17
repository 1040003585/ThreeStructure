using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Client_comService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Client_com">Client_com实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Client_com model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@mc",model.Mc),
                new SqlParameter ("@com",model.Com),
                new SqlParameter ("@pt",model.Pt),
                new SqlParameter ("@sjw",model.Sjw),
                new SqlParameter ("@tzw",model.Tzw),
                new SqlParameter ("@syw",model.Syw),
                new SqlParameter ("@is_stop",model.Is_stop)
            };
           return Helper .ExecuteNonQuery ("Client_com_Add",param);
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
                new SqlParameter ("@bm",Id)
            };
           return Helper .ExecuteNonQuery ("Client_com_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Client_com">Client_com实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Client_com model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@mc",model.Mc),
                new SqlParameter ("@com",model.Com),
                new SqlParameter ("@pt",model.Pt),
                new SqlParameter ("@sjw",model.Sjw),
                new SqlParameter ("@tzw",model.Tzw),
                new SqlParameter ("@syw",model.Syw),
                new SqlParameter ("@is_stop",model.Is_stop)
            };
           return Helper .ExecuteNonQuery ("Client_com_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Client_com> selectAll()
        {
            List<Client_com> list = new List<Client_com>();
            Client_com model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Client_com_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Client_com();
                    model.Bm= Convert.ToInt32(dr["bm"]);
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    if (DBNull.Value!=dr["com"])
                        model.Com = dr["com"].ToString();
                    if (DBNull.Value!=dr["pt"])
                        model.Pt = dr["pt"].ToString();
                    if (DBNull.Value!=dr["sjw"])
                        model.Sjw = dr["sjw"].ToString();
                    if (DBNull.Value!=dr["tzw"])
                        model.Tzw = dr["tzw"].ToString();
                    if (DBNull.Value!=dr["syw"])
                        model.Syw = dr["syw"].ToString();
                    model.Is_stop= Convert.ToByte(dr["is_stop"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Client_com实体类对象</returns>
        public Client_com selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",Id)
            };
            Client_com model = new Client_com();
            using (SqlDataReader dr = Helper.ExecuteReader("Client_com_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bm= Convert.ToInt32(dr["bm"]);
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    if (DBNull.Value!=dr["com"])
                        model.Com = dr["com"].ToString();
                    if (DBNull.Value!=dr["pt"])
                        model.Pt = dr["pt"].ToString();
                    if (DBNull.Value!=dr["sjw"])
                        model.Sjw = dr["sjw"].ToString();
                    if (DBNull.Value!=dr["tzw"])
                        model.Tzw = dr["tzw"].ToString();
                    if (DBNull.Value!=dr["syw"])
                        model.Syw = dr["syw"].ToString();
                    model.Is_stop= Convert.ToByte(dr["is_stop"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Client_com实体类对象</returns>
        public List<Client_com> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Client_com> list = new List<Client_com>();
            Client_com model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Client_com_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Client_com();
                    model.Bm= Convert.ToInt32(dr["bm"]);
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    if (DBNull.Value!=dr["com"])
                        model.Com = dr["com"].ToString();
                    if (DBNull.Value!=dr["pt"])
                        model.Pt = dr["pt"].ToString();
                    if (DBNull.Value!=dr["sjw"])
                        model.Sjw = dr["sjw"].ToString();
                    if (DBNull.Value!=dr["tzw"])
                        model.Tzw = dr["tzw"].ToString();
                    if (DBNull.Value!=dr["syw"])
                        model.Syw = dr["syw"].ToString();
                    model.Is_stop= Convert.ToByte(dr["is_stop"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

