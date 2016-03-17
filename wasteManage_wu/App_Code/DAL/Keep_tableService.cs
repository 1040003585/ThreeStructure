using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Keep_tableService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Keep_table">Keep_table实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Keep_table model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@num",model.Num)
            };
           return Helper .ExecuteNonQuery ("Keep_table_Add",param);
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
                new SqlParameter ("@num",Id)
            };
           return Helper .ExecuteNonQuery ("Keep_table_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Keep_table">Keep_table实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Keep_table model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@num",model.Num)
            };
           return Helper .ExecuteNonQuery ("Keep_table_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Keep_table> selectAll()
        {
            List<Keep_table> list = new List<Keep_table>();
            Keep_table model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Keep_table_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Keep_table();
                    if (DBNull.Value!=dr["num"])
                        model.Num= Convert.ToInt32(dr["num"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Keep_table实体类对象</returns>
        public Keep_table selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@num",Id)
            };
            Keep_table model = new Keep_table();
            using (SqlDataReader dr = Helper.ExecuteReader("Keep_table_SelectById", param))
            {
                if (dr.Read())
                {
                    if (DBNull.Value!=dr["num"])
                        model.Num= Convert.ToInt32(dr["num"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Keep_table实体类对象</returns>
        public List<Keep_table> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Keep_table> list = new List<Keep_table>();
            Keep_table model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Keep_table_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Keep_table();
                    if (DBNull.Value!=dr["num"])
                        model.Num= Convert.ToInt32(dr["num"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

