using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Mgr_user_groupService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Mgr_user_group">Mgr_user_group实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Mgr_user_group model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@group_id",model.Group_id),
                new SqlParameter ("@group_name",model.Group_name),
                new SqlParameter ("@is_pos",model.Is_pos),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@grant_menu",model.Grant_menu),
                new SqlParameter ("@grant_control",model.Grant_control),
                new SqlParameter ("@grant_other",model.Grant_other),
                new SqlParameter ("@grant_pos",model.Grant_pos),
                new SqlParameter ("@sss_id",model.Sss_id),
                new SqlParameter ("@sss",model.Sss)
            };
           return Helper .ExecuteNonQuery ("Mgr_user_group_Add",param);
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
                new SqlParameter ("@group_id",Id)
            };
           return Helper .ExecuteNonQuery ("Mgr_user_group_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Mgr_user_group">Mgr_user_group实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Mgr_user_group model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@group_id",model.Group_id),
                new SqlParameter ("@group_name",model.Group_name),
                new SqlParameter ("@is_pos",model.Is_pos),
                new SqlParameter ("@bz",model.Bz),
                new SqlParameter ("@grant_menu",model.Grant_menu),
                new SqlParameter ("@grant_control",model.Grant_control),
                new SqlParameter ("@grant_other",model.Grant_other),
                new SqlParameter ("@grant_pos",model.Grant_pos),
                new SqlParameter ("@sss_id",model.Sss_id),
                new SqlParameter ("@sss",model.Sss)
            };
           return Helper .ExecuteNonQuery ("Mgr_user_group_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Mgr_user_group> selectAll()
        {
            List<Mgr_user_group> list = new List<Mgr_user_group>();
            Mgr_user_group model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Mgr_user_group_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Mgr_user_group();
                    model.Group_id = dr["group_id"].ToString();
                    if (DBNull.Value!=dr["group_name"])
                        model.Group_name = dr["group_name"].ToString();
                    if (DBNull.Value!=dr["is_pos"])
                        model.Is_pos= Convert.ToInt32(dr["is_pos"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["grant_menu"])
                        model.Grant_menu = dr["grant_menu"].ToString();
                    if (DBNull.Value!=dr["grant_control"])
                        model.Grant_control = dr["grant_control"].ToString();
                    if (DBNull.Value!=dr["grant_other"])
                        model.Grant_other = dr["grant_other"].ToString();
                    if (DBNull.Value!=dr["grant_pos"])
                        model.Grant_pos = dr["grant_pos"].ToString();
                    if (DBNull.Value!=dr["sss_id"])
                        model.Sss_id = dr["sss_id"].ToString();
                    if (DBNull.Value!=dr["sss"])
                        model.Sss = dr["sss"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Mgr_user_group实体类对象</returns>
        public Mgr_user_group selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@group_id",Id)
            };
            Mgr_user_group model = new Mgr_user_group();
            using (SqlDataReader dr = Helper.ExecuteReader("Mgr_user_group_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Group_id = dr["group_id"].ToString();
                    if (DBNull.Value!=dr["group_name"])
                        model.Group_name = dr["group_name"].ToString();
                    if (DBNull.Value!=dr["is_pos"])
                        model.Is_pos= Convert.ToInt32(dr["is_pos"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["grant_menu"])
                        model.Grant_menu = dr["grant_menu"].ToString();
                    if (DBNull.Value!=dr["grant_control"])
                        model.Grant_control = dr["grant_control"].ToString();
                    if (DBNull.Value!=dr["grant_other"])
                        model.Grant_other = dr["grant_other"].ToString();
                    if (DBNull.Value!=dr["grant_pos"])
                        model.Grant_pos = dr["grant_pos"].ToString();
                    if (DBNull.Value!=dr["sss_id"])
                        model.Sss_id = dr["sss_id"].ToString();
                    if (DBNull.Value!=dr["sss"])
                        model.Sss = dr["sss"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Mgr_user_group实体类对象</returns>
        public List<Mgr_user_group> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Mgr_user_group> list = new List<Mgr_user_group>();
            Mgr_user_group model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Mgr_user_group_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Mgr_user_group();
                    model.Group_id = dr["group_id"].ToString();
                    if (DBNull.Value!=dr["group_name"])
                        model.Group_name = dr["group_name"].ToString();
                    if (DBNull.Value!=dr["is_pos"])
                        model.Is_pos= Convert.ToInt32(dr["is_pos"]);
                    if (DBNull.Value!=dr["bz"])
                        model.Bz = dr["bz"].ToString();
                    if (DBNull.Value!=dr["grant_menu"])
                        model.Grant_menu = dr["grant_menu"].ToString();
                    if (DBNull.Value!=dr["grant_control"])
                        model.Grant_control = dr["grant_control"].ToString();
                    if (DBNull.Value!=dr["grant_other"])
                        model.Grant_other = dr["grant_other"].ToString();
                    if (DBNull.Value!=dr["grant_pos"])
                        model.Grant_pos = dr["grant_pos"].ToString();
                    if (DBNull.Value!=dr["sss_id"])
                        model.Sss_id = dr["sss_id"].ToString();
                    if (DBNull.Value!=dr["sss"])
                        model.Sss = dr["sss"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

