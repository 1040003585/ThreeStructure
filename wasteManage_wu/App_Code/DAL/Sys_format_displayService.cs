using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Sys_format_displayService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Sys_format_display">Sys_format_display实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Sys_format_display model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@win_name",model.Win_name),
                new SqlParameter ("@dw_name",model.Dw_name),
                new SqlParameter ("@col_no",model.Col_no),
                new SqlParameter ("@col_name",model.Col_name),
                new SqlParameter ("@xh",model.Xh),
                new SqlParameter ("@display_name",model.Display_name),
                new SqlParameter ("@col_width",model.Col_width),
                new SqlParameter ("@col_x",model.Col_x),
                new SqlParameter ("@is_display",model.Is_display),
                new SqlParameter ("@is_edit",model.Is_edit),
                new SqlParameter ("@is_edit_sys",model.Is_edit_sys)
            };
           return Helper .ExecuteNonQuery ("Sys_format_display_Add",param);
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
                new SqlParameter ("@win_name",Id)
            };
           return Helper .ExecuteNonQuery ("Sys_format_display_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Sys_format_display">Sys_format_display实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Sys_format_display model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@win_name",model.Win_name),
                new SqlParameter ("@dw_name",model.Dw_name),
                new SqlParameter ("@col_no",model.Col_no),
                new SqlParameter ("@col_name",model.Col_name),
                new SqlParameter ("@xh",model.Xh),
                new SqlParameter ("@display_name",model.Display_name),
                new SqlParameter ("@col_width",model.Col_width),
                new SqlParameter ("@col_x",model.Col_x),
                new SqlParameter ("@is_display",model.Is_display),
                new SqlParameter ("@is_edit",model.Is_edit),
                new SqlParameter ("@is_edit_sys",model.Is_edit_sys)
            };
           return Helper .ExecuteNonQuery ("Sys_format_display_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Sys_format_display> selectAll()
        {
            List<Sys_format_display> list = new List<Sys_format_display>();
            Sys_format_display model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Sys_format_display_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Sys_format_display();
                    model.Win_name = dr["win_name"].ToString();
                    model.Dw_name = dr["dw_name"].ToString();
                    model.Col_no = dr["col_no"].ToString();
                    model.Col_name = dr["col_name"].ToString();
                    model.Xh= Convert.ToInt32(dr["xh"]);
                    model.Display_name = dr["display_name"].ToString();
                    model.Col_width= Convert.ToInt32(dr["col_width"]);
                    model.Col_x= Convert.ToSingle(dr["col_x"]);
                    model.Is_display= Convert.ToInt32(dr["is_display"]);
                    model.Is_edit= Convert.ToInt32(dr["is_edit"]);
                    model.Is_edit_sys= Convert.ToInt32(dr["is_edit_sys"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Sys_format_display实体类对象</returns>
        public Sys_format_display selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@win_name",Id)
            };
            Sys_format_display model = new Sys_format_display();
            using (SqlDataReader dr = Helper.ExecuteReader("Sys_format_display_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Win_name = dr["win_name"].ToString();
                    model.Dw_name = dr["dw_name"].ToString();
                    model.Col_no = dr["col_no"].ToString();
                    model.Col_name = dr["col_name"].ToString();
                    model.Xh= Convert.ToInt32(dr["xh"]);
                    model.Display_name = dr["display_name"].ToString();
                    model.Col_width= Convert.ToInt32(dr["col_width"]);
                    model.Col_x= Convert.ToSingle(dr["col_x"]);
                    model.Is_display= Convert.ToInt32(dr["is_display"]);
                    model.Is_edit= Convert.ToInt32(dr["is_edit"]);
                    model.Is_edit_sys= Convert.ToInt32(dr["is_edit_sys"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Sys_format_display实体类对象</returns>
        public List<Sys_format_display> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Sys_format_display> list = new List<Sys_format_display>();
            Sys_format_display model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Sys_format_display_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Sys_format_display();
                    model.Win_name = dr["win_name"].ToString();
                    model.Dw_name = dr["dw_name"].ToString();
                    model.Col_no = dr["col_no"].ToString();
                    model.Col_name = dr["col_name"].ToString();
                    model.Xh= Convert.ToInt32(dr["xh"]);
                    model.Display_name = dr["display_name"].ToString();
                    model.Col_width= Convert.ToInt32(dr["col_width"]);
                    model.Col_x= Convert.ToSingle(dr["col_x"]);
                    model.Is_display= Convert.ToInt32(dr["is_display"]);
                    model.Is_edit= Convert.ToInt32(dr["is_edit"]);
                    model.Is_edit_sys= Convert.ToInt32(dr["is_edit_sys"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

