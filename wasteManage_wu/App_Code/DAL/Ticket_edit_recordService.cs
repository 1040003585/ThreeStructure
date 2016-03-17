using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Ticket_edit_recordService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Ticket_edit_record">Ticket_edit_record实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Ticket_edit_record model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@ticket_num",model.Ticket_num),
                new SqlParameter ("@edited_by",model.Edited_by),
                new SqlParameter ("@edit_date",model.Edit_date),
                new SqlParameter ("@sl",model.Sl),
                new SqlParameter ("@is_begian",model.Is_begian)
            };
           return Helper .ExecuteNonQuery ("Ticket_edit_record_Add",param);
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
           return Helper .ExecuteNonQuery ("Ticket_edit_record_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Ticket_edit_record">Ticket_edit_record实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Ticket_edit_record model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",model.Bm),
                new SqlParameter ("@ticket_num",model.Ticket_num),
                new SqlParameter ("@edited_by",model.Edited_by),
                new SqlParameter ("@edit_date",model.Edit_date),
                new SqlParameter ("@sl",model.Sl),
                new SqlParameter ("@is_begian",model.Is_begian)
            };
           return Helper .ExecuteNonQuery ("Ticket_edit_record_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Ticket_edit_record> selectAll()
        {
            List<Ticket_edit_record> list = new List<Ticket_edit_record>();
            Ticket_edit_record model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Ticket_edit_record_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Ticket_edit_record();
                    model.Bm= Convert.ToInt32(dr["bm"]);
                    if (DBNull.Value!=dr["ticket_num"])
                        model.Ticket_num = dr["ticket_num"].ToString();
                    if (DBNull.Value!=dr["edited_by"])
                        model.Edited_by = dr["edited_by"].ToString();
                    if (DBNull.Value!=dr["edit_date"])
                        model.Edit_date= Convert.ToDateTime(dr["edit_date"]);
                    model.Sl= Convert.ToInt32(dr["sl"]);
                    model.Is_begian= Convert.ToByte(dr["is_begian"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Ticket_edit_record实体类对象</returns>
        public Ticket_edit_record selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@bm",Id)
            };
            Ticket_edit_record model = new Ticket_edit_record();
            using (SqlDataReader dr = Helper.ExecuteReader("Ticket_edit_record_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Bm= Convert.ToInt32(dr["bm"]);
                    if (DBNull.Value!=dr["ticket_num"])
                        model.Ticket_num = dr["ticket_num"].ToString();
                    if (DBNull.Value!=dr["edited_by"])
                        model.Edited_by = dr["edited_by"].ToString();
                    if (DBNull.Value!=dr["edit_date"])
                        model.Edit_date= Convert.ToDateTime(dr["edit_date"]);
                    model.Sl= Convert.ToInt32(dr["sl"]);
                    model.Is_begian= Convert.ToByte(dr["is_begian"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Ticket_edit_record实体类对象</returns>
        public List<Ticket_edit_record> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Ticket_edit_record> list = new List<Ticket_edit_record>();
            Ticket_edit_record model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Ticket_edit_record_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Ticket_edit_record();
                    model.Bm= Convert.ToInt32(dr["bm"]);
                    if (DBNull.Value!=dr["ticket_num"])
                        model.Ticket_num = dr["ticket_num"].ToString();
                    if (DBNull.Value!=dr["edited_by"])
                        model.Edited_by = dr["edited_by"].ToString();
                    if (DBNull.Value!=dr["edit_date"])
                        model.Edit_date= Convert.ToDateTime(dr["edit_date"]);
                    model.Sl= Convert.ToInt32(dr["sl"]);
                    model.Is_begian= Convert.ToByte(dr["is_begian"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

