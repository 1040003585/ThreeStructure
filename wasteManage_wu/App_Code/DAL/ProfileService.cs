using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ProfileService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Profile">Profile实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Profile model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@profile_id",model.Profile_id),
                new SqlParameter ("@profile_name",model.Profile_name),
                new SqlParameter ("@component_id",model.Component_id),
                new SqlParameter ("@stutas",model.Stutas),
                new SqlParameter ("@xh",model.Xh)
            };
           return Helper .ExecuteNonQuery ("Profile_Add",param);
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
           return Helper .ExecuteNonQuery ("Profile_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Profile">Profile实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Profile model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@profile_id",model.Profile_id),
                new SqlParameter ("@profile_name",model.Profile_name),
                new SqlParameter ("@component_id",model.Component_id),
                new SqlParameter ("@stutas",model.Stutas),
                new SqlParameter ("@xh",model.Xh)
            };
           return Helper .ExecuteNonQuery ("Profile_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Profile> selectAll()
        {
            List<Profile> list = new List<Profile>();
            Profile model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Profile_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Profile();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Profile_id = dr["profile_id"].ToString();
                    if (DBNull.Value!=dr["profile_name"])
                        model.Profile_name = dr["profile_name"].ToString();
                    model.Component_id = dr["component_id"].ToString();
                    if (DBNull.Value!=dr["stutas"])
                        model.Stutas= Convert.ToByte(dr["stutas"]);
                    if (DBNull.Value!=dr["xh"])
                        model.Xh= Convert.ToInt32(dr["xh"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Profile实体类对象</returns>
        public Profile selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Profile model = new Profile();
            using (SqlDataReader dr = Helper.ExecuteReader("Profile_SelectById", param))
            {
                if (dr.Read())
                {
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Profile_id = dr["profile_id"].ToString();
                    if (DBNull.Value!=dr["profile_name"])
                        model.Profile_name = dr["profile_name"].ToString();
                    model.Component_id = dr["component_id"].ToString();
                    if (DBNull.Value!=dr["stutas"])
                        model.Stutas= Convert.ToByte(dr["stutas"]);
                    if (DBNull.Value!=dr["xh"])
                        model.Xh= Convert.ToInt32(dr["xh"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Profile实体类对象</returns>
        public List<Profile> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Profile> list = new List<Profile>();
            Profile model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Profile_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Profile();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.Profile_id = dr["profile_id"].ToString();
                    if (DBNull.Value!=dr["profile_name"])
                        model.Profile_name = dr["profile_name"].ToString();
                    model.Component_id = dr["component_id"].ToString();
                    if (DBNull.Value!=dr["stutas"])
                        model.Stutas= Convert.ToByte(dr["stutas"]);
                    if (DBNull.Value!=dr["xh"])
                        model.Xh= Convert.ToInt32(dr["xh"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

