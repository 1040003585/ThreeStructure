using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Color_groupService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Color_group">Color_group实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Color_group model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc),
                new SqlParameter ("@color_id",model.Color_id),
                new SqlParameter ("@status",model.Status)
            };
           return Helper .ExecuteNonQuery ("Color_group_Add",param);
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
           return Helper .ExecuteNonQuery ("Color_group_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Color_group">Color_group实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Color_group model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc),
                new SqlParameter ("@color_id",model.Color_id),
                new SqlParameter ("@status",model.Status)
            };
           return Helper .ExecuteNonQuery ("Color_group_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Color_group> selectAll()
        {
            List<Color_group> list = new List<Color_group>();
            Color_group model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Color_group_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Color_group();
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    model.Color_id = dr["color_id"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status= Convert.ToByte(dr["status"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Color_group实体类对象</returns>
        public Color_group selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",Id)
            };
            Color_group model = new Color_group();
            using (SqlDataReader dr = Helper.ExecuteReader("Color_group_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    model.Color_id = dr["color_id"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status= Convert.ToByte(dr["status"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Color_group实体类对象</returns>
        public List<Color_group> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Color_group> list = new List<Color_group>();
            Color_group model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Color_group_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Color_group();
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    model.Color_id = dr["color_id"].ToString();
                    if (DBNull.Value!=dr["status"])
                        model.Status= Convert.ToByte(dr["status"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

