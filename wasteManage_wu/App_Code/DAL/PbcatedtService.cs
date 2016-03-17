using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PbcatedtService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Pbcatedt">Pbcatedt实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Pbcatedt model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@pbe_name",model.Pbe_name),
                new SqlParameter ("@pbe_edit",model.Pbe_edit),
                new SqlParameter ("@pbe_type",model.Pbe_type),
                new SqlParameter ("@pbe_cntr",model.Pbe_cntr),
                new SqlParameter ("@pbe_seqn",model.Pbe_seqn),
                new SqlParameter ("@pbe_flag",model.Pbe_flag),
                new SqlParameter ("@pbe_work",model.Pbe_work)
            };
           return Helper .ExecuteNonQuery ("Pbcatedt_Add",param);
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
                new SqlParameter ("@pbe_name",Id)
            };
           return Helper .ExecuteNonQuery ("Pbcatedt_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Pbcatedt">Pbcatedt实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Pbcatedt model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@pbe_name",model.Pbe_name),
                new SqlParameter ("@pbe_edit",model.Pbe_edit),
                new SqlParameter ("@pbe_type",model.Pbe_type),
                new SqlParameter ("@pbe_cntr",model.Pbe_cntr),
                new SqlParameter ("@pbe_seqn",model.Pbe_seqn),
                new SqlParameter ("@pbe_flag",model.Pbe_flag),
                new SqlParameter ("@pbe_work",model.Pbe_work)
            };
           return Helper .ExecuteNonQuery ("Pbcatedt_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Pbcatedt> selectAll()
        {
            List<Pbcatedt> list = new List<Pbcatedt>();
            Pbcatedt model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Pbcatedt_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Pbcatedt();
                    model.Pbe_name = dr["pbe_name"].ToString();
                    if (DBNull.Value!=dr["pbe_edit"])
                        model.Pbe_edit = dr["pbe_edit"].ToString();
                    model.Pbe_type= Convert.ToInt32(dr["pbe_type"]);
                    if (DBNull.Value!=dr["pbe_cntr"])
                        model.Pbe_cntr= Convert.ToInt32(dr["pbe_cntr"]);
                    model.Pbe_seqn= Convert.ToInt32(dr["pbe_seqn"]);
                    if (DBNull.Value!=dr["pbe_flag"])
                        model.Pbe_flag= Convert.ToInt32(dr["pbe_flag"]);
                    if (DBNull.Value!=dr["pbe_work"])
                        model.Pbe_work = dr["pbe_work"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Pbcatedt实体类对象</returns>
        public Pbcatedt selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@pbe_name",Id)
            };
            Pbcatedt model = new Pbcatedt();
            using (SqlDataReader dr = Helper.ExecuteReader("Pbcatedt_SelectById", param))
            {
                if (dr.Read())
                {
                    model.Pbe_name = dr["pbe_name"].ToString();
                    if (DBNull.Value!=dr["pbe_edit"])
                        model.Pbe_edit = dr["pbe_edit"].ToString();
                    model.Pbe_type= Convert.ToInt32(dr["pbe_type"]);
                    if (DBNull.Value!=dr["pbe_cntr"])
                        model.Pbe_cntr= Convert.ToInt32(dr["pbe_cntr"]);
                    model.Pbe_seqn= Convert.ToInt32(dr["pbe_seqn"]);
                    if (DBNull.Value!=dr["pbe_flag"])
                        model.Pbe_flag= Convert.ToInt32(dr["pbe_flag"]);
                    if (DBNull.Value!=dr["pbe_work"])
                        model.Pbe_work = dr["pbe_work"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Pbcatedt实体类对象</returns>
        public List<Pbcatedt> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Pbcatedt> list = new List<Pbcatedt>();
            Pbcatedt model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Pbcatedt_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Pbcatedt();
                    model.Pbe_name = dr["pbe_name"].ToString();
                    if (DBNull.Value!=dr["pbe_edit"])
                        model.Pbe_edit = dr["pbe_edit"].ToString();
                    model.Pbe_type= Convert.ToInt32(dr["pbe_type"]);
                    if (DBNull.Value!=dr["pbe_cntr"])
                        model.Pbe_cntr= Convert.ToInt32(dr["pbe_cntr"]);
                    model.Pbe_seqn= Convert.ToInt32(dr["pbe_seqn"]);
                    if (DBNull.Value!=dr["pbe_flag"])
                        model.Pbe_flag= Convert.ToInt32(dr["pbe_flag"]);
                    if (DBNull.Value!=dr["pbe_work"])
                        model.Pbe_work = dr["pbe_work"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

