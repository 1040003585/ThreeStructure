using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ColorService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Color">Color实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Color model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc)
            };
           return Helper .ExecuteNonQuery ("Color_Add",param);
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
           return Helper .ExecuteNonQuery ("Color_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Color">Color实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Color model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@mc",model.Mc)
            };
           return Helper .ExecuteNonQuery ("Color_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Color> selectAll()
        {
            List<Color> list = new List<Color>();
            Color model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Color_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Color();
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Color实体类对象</returns>
        public Color selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",Id)
            };
            Color model = new Color();
            using (SqlDataReader dr = Helper.ExecuteReader("Color_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Color实体类对象</returns>
        public List<Color> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Color> list = new List<Color>();
            Color model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Color_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Color();
                    model.Bm = dr["bm"].ToString();
                    if (DBNull.Value!=dr["mc"])
                        model.Mc = dr["mc"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

