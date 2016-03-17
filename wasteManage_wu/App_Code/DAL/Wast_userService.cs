using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Wast_userService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Wast_user">Wast_user实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Wast_user model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@user_id",model.User_id),
                new SqlParameter ("@user_name",model.User_name),
                new SqlParameter ("@group_id",model.Group_id),
                new SqlParameter ("@password",model.Password),
                new SqlParameter ("@pass_check",model.Pass_check),
                new SqlParameter ("@status",model.Status),
                new SqlParameter ("@last_in",model.Last_in),
                new SqlParameter ("@is_pos",model.Is_pos),
                new SqlParameter ("@client_lr",model.Client_lr)
            };
           return Helper .ExecuteNonQuery ("Wast_user_Add",param);
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
           return Helper .ExecuteNonQuery ("Wast_user_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Wast_user">Wast_user实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Wast_user model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",model.Bh),
                new SqlParameter ("@user_id",model.User_id),
                new SqlParameter ("@user_name",model.User_name),
                new SqlParameter ("@group_id",model.Group_id),
                new SqlParameter ("@password",model.Password),
                new SqlParameter ("@pass_check",model.Pass_check),
                new SqlParameter ("@status",model.Status),
                new SqlParameter ("@last_in",model.Last_in),
                new SqlParameter ("@is_pos",model.Is_pos),
                new SqlParameter ("@client_lr",model.Client_lr)
            };
           return Helper .ExecuteNonQuery ("Wast_user_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Wast_user> selectAll()
        {
            List<Wast_user> list = new List<Wast_user>();
            Wast_user model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Wast_user_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Wast_user();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.User_id = dr["user_id"].ToString();
                    if (DBNull.Value!=dr["user_name"])
                        model.User_name = dr["user_name"].ToString();
                    if (DBNull.Value!=dr["group_id"])
                        model.Group_id = dr["group_id"].ToString();
                    if (DBNull.Value!=dr["password"])
                        model.Password = dr["password"].ToString();
                    if (DBNull.Value!=dr["pass_check"])
                        model.Pass_check = dr["pass_check"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status= Convert.ToInt32(dr["status"]);
                    if (DBNull.Value!=dr["last_in"])
                        model.Last_in= Convert.ToDateTime(dr["last_in"]);
                    if (DBNull.Value!=dr["is_pos"])
                        model.Is_pos= Convert.ToInt32(dr["is_pos"]);
                    if (DBNull.Value!=dr["client_lr"])
                        model.Client_lr= Convert.ToByte(dr["client_lr"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Wast_user实体类对象</returns>
        public Wast_user selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bh",Id)
            };
            Wast_user model = new Wast_user();
            using (SqlDataReader dr = Helper.ExecuteReader("Wast_user_SelectById", param))
            {
                if (dr.Read())
                {
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.User_id = dr["user_id"].ToString();
                    if (DBNull.Value!=dr["user_name"])
                        model.User_name = dr["user_name"].ToString();
                    if (DBNull.Value!=dr["group_id"])
                        model.Group_id = dr["group_id"].ToString();
                    if (DBNull.Value!=dr["password"])
                        model.Password = dr["password"].ToString();
                    if (DBNull.Value!=dr["pass_check"])
                        model.Pass_check = dr["pass_check"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status= Convert.ToInt32(dr["status"]);
                    if (DBNull.Value!=dr["last_in"])
                        model.Last_in= Convert.ToDateTime(dr["last_in"]);
                    if (DBNull.Value!=dr["is_pos"])
                        model.Is_pos= Convert.ToInt32(dr["is_pos"]);
                    if (DBNull.Value!=dr["client_lr"])
                        model.Client_lr= Convert.ToByte(dr["client_lr"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Wast_user实体类对象</returns>
        public List<Wast_user> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Wast_user> list = new List<Wast_user>();
            Wast_user model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Wast_user_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Wast_user();
                    if (DBNull.Value!=dr["bh"])
                        model.Bh = dr["bh"].ToString();
                    model.User_id = dr["user_id"].ToString();
                    if (DBNull.Value!=dr["user_name"])
                        model.User_name = dr["user_name"].ToString();
                    if (DBNull.Value!=dr["group_id"])
                        model.Group_id = dr["group_id"].ToString();
                    if (DBNull.Value!=dr["password"])
                        model.Password = dr["password"].ToString();
                    if (DBNull.Value!=dr["pass_check"])
                        model.Pass_check = dr["pass_check"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status= Convert.ToInt32(dr["status"]);
                    if (DBNull.Value!=dr["last_in"])
                        model.Last_in= Convert.ToDateTime(dr["last_in"]);
                    if (DBNull.Value!=dr["is_pos"])
                        model.Is_pos= Convert.ToInt32(dr["is_pos"]);
                    if (DBNull.Value!=dr["client_lr"])
                        model.Client_lr= Convert.ToByte(dr["client_lr"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

