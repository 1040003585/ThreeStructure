using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Foot_statusService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Foot_status">Foot_status实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Foot_status model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@win",model.Win),
                new SqlParameter ("@clear_win",model.Clear_win),
                new SqlParameter ("@exit_win",model.Exit_win)
            };
           return Helper .ExecuteNonQuery ("Foot_status_Add",param);
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
                new SqlParameter ("@win",Id)
            };
           return Helper .ExecuteNonQuery ("Foot_status_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Foot_status">Foot_status实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Foot_status model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@win",model.Win),
                new SqlParameter ("@clear_win",model.Clear_win),
                new SqlParameter ("@exit_win",model.Exit_win)
            };
           return Helper .ExecuteNonQuery ("Foot_status_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Foot_status> selectAll()
        {
            List<Foot_status> list = new List<Foot_status>();
            Foot_status model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Foot_status_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Foot_status();
                    model.Win = dr["win"].ToString();
                    if (DBNull.Value!=dr["clear_win"])
                        model.Clear_win= Convert.ToInt32(dr["clear_win"]);
                    if (DBNull.Value!=dr["exit_win"])
                        model.Exit_win= Convert.ToInt32(dr["exit_win"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Foot_status实体类对象</returns>
        public Foot_status selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@win",Id)
            };
            Foot_status model = new Foot_status();
            using (SqlDataReader dr = Helper.ExecuteReader("Foot_status_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Win = dr["win"].ToString();
                    if (DBNull.Value!=dr["clear_win"])
                        model.Clear_win= Convert.ToInt32(dr["clear_win"]);
                    if (DBNull.Value!=dr["exit_win"])
                        model.Exit_win= Convert.ToInt32(dr["exit_win"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Foot_status实体类对象</returns>
        public List<Foot_status> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Foot_status> list = new List<Foot_status>();
            Foot_status model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Foot_status_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Foot_status();
                    model.Win = dr["win"].ToString();
                    if (DBNull.Value!=dr["clear_win"])
                        model.Clear_win= Convert.ToInt32(dr["clear_win"]);
                    if (DBNull.Value!=dr["exit_win"])
                        model.Exit_win= Convert.ToInt32(dr["exit_win"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

