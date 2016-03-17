using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Container_pcService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Container_pc">Container_pc实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Container_pc model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@container_id",model.Container_id),
                new SqlParameter ("@rq",model.Rq),
                new SqlParameter ("@import_rq",model.Import_rq),
                new SqlParameter ("@user_id",model.User_id),
                new SqlParameter ("@bz",model.Bz)
            };
           return Helper .ExecuteNonQuery ("Container_pc_Add",param);
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
                new SqlParameter ("@container_id",Id)
            };
           return Helper .ExecuteNonQuery ("Container_pc_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Container_pc">Container_pc实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Container_pc model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@container_id",model.Container_id),
                new SqlParameter ("@rq",model.Rq),
                new SqlParameter ("@import_rq",model.Import_rq),
                new SqlParameter ("@user_id",model.User_id),
                new SqlParameter ("@bz",model.Bz)
            };
           return Helper .ExecuteNonQuery ("Container_pc_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Container_pc> selectAll()
        {
            List<Container_pc> list = new List<Container_pc>();
            Container_pc model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Container_pc_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Container_pc();
                    model.Container_id = dr["container_id"].ToString();
                    if (DBNull.Value!=dr["rq"])
                        model.Rq= Convert.ToDateTime(dr["rq"]);
                    if (DBNull.Value!=dr["import_rq"])
                        model.Import_rq= Convert.ToDateTime(dr["import_rq"]);
                    if (DBNull.Value!=dr["user_id"])
                        model.User_id = dr["user_id"].ToString();
                    if (DBNull.Value!=dr["bz"])
                        model.Bz= Convert.ToByte(dr["bz"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Container_pc实体类对象</returns>
        public Container_pc selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@container_id",Id)
            };
            Container_pc model = new Container_pc();
            using (SqlDataReader dr = Helper.ExecuteReader("Container_pc_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Container_id = dr["container_id"].ToString();
                    if (DBNull.Value!=dr["rq"])
                        model.Rq= Convert.ToDateTime(dr["rq"]);
                    if (DBNull.Value!=dr["import_rq"])
                        model.Import_rq= Convert.ToDateTime(dr["import_rq"]);
                    if (DBNull.Value!=dr["user_id"])
                        model.User_id = dr["user_id"].ToString();
                    if (DBNull.Value!=dr["bz"])
                        model.Bz= Convert.ToByte(dr["bz"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Container_pc实体类对象</returns>
        public List<Container_pc> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Container_pc> list = new List<Container_pc>();
            Container_pc model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Container_pc_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Container_pc();
                    model.Container_id = dr["container_id"].ToString();
                    if (DBNull.Value!=dr["rq"])
                        model.Rq= Convert.ToDateTime(dr["rq"]);
                    if (DBNull.Value!=dr["import_rq"])
                        model.Import_rq= Convert.ToDateTime(dr["import_rq"]);
                    if (DBNull.Value!=dr["user_id"])
                        model.User_id = dr["user_id"].ToString();
                    if (DBNull.Value!=dr["bz"])
                        model.Bz= Convert.ToByte(dr["bz"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

