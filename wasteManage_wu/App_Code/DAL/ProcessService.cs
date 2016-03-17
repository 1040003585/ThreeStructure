using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ProcessService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Process">Process实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Process model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc),
                new SqlParameter ("@process",model.Process),
                new SqlParameter ("@color",model.Color),
                new SqlParameter ("@clfs",model.Clfs),
                new SqlParameter ("@bz",model.Bz)
            };
           return Helper .ExecuteNonQuery ("Process_Add",param);
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
           return Helper .ExecuteNonQuery ("Process_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Process">Process实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Process model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc),
                new SqlParameter ("@process",model.Process),
                new SqlParameter ("@color",model.Color),
                new SqlParameter ("@clfs",model.Clfs),
                new SqlParameter ("@bz",model.Bz)
            };
           return Helper .ExecuteNonQuery ("Process_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Process> selectAll()
        {
            List<Process> list = new List<Process>();
            Process model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Process_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Process();
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    model.Process = dr["process"].ToString();
                    if (DBNull.Value!=dr["color"])
                        model.Color = dr["color"].ToString();
                    if (DBNull.Value!=dr["clfs"])
                        model.Clfs = dr["clfs"].ToString();
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
        /// <returns>Process实体类对象</returns>
        public Process selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",Id)
            };
            Process model = new Process();
            using (SqlDataReader dr = Helper.ExecuteReader("Process_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    model.Process = dr["process"].ToString();
                    if (DBNull.Value!=dr["color"])
                        model.Color = dr["color"].ToString();
                    if (DBNull.Value!=dr["clfs"])
                        model.Clfs = dr["clfs"].ToString();
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
        /// <returns>Process实体类对象</returns>
        public List<Process> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Process> list = new List<Process>();
            Process model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Process_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Process();
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    model.Process = dr["process"].ToString();
                    if (DBNull.Value!=dr["color"])
                        model.Color = dr["color"].ToString();
                    if (DBNull.Value!=dr["clfs"])
                        model.Clfs = dr["clfs"].ToString();
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

