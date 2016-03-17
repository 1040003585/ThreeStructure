using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PbcattblService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Pbcattbl">Pbcattbl实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Pbcattbl model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@pbt_tnam",model.Pbt_tnam),
                new SqlParameter ("@pbt_tid",model.Pbt_tid),
                new SqlParameter ("@pbt_ownr",model.Pbt_ownr),
                new SqlParameter ("@pbd_fhgt",model.Pbd_fhgt),
                new SqlParameter ("@pbd_fwgt",model.Pbd_fwgt),
                new SqlParameter ("@pbd_fitl",model.Pbd_fitl),
                new SqlParameter ("@pbd_funl",model.Pbd_funl),
                new SqlParameter ("@pbd_fchr",model.Pbd_fchr),
                new SqlParameter ("@pbd_fptc",model.Pbd_fptc),
                new SqlParameter ("@pbd_ffce",model.Pbd_ffce),
                new SqlParameter ("@pbh_fhgt",model.Pbh_fhgt),
                new SqlParameter ("@pbh_fwgt",model.Pbh_fwgt),
                new SqlParameter ("@pbh_fitl",model.Pbh_fitl),
                new SqlParameter ("@pbh_funl",model.Pbh_funl),
                new SqlParameter ("@pbh_fchr",model.Pbh_fchr),
                new SqlParameter ("@pbh_fptc",model.Pbh_fptc),
                new SqlParameter ("@pbh_ffce",model.Pbh_ffce),
                new SqlParameter ("@pbl_fhgt",model.Pbl_fhgt),
                new SqlParameter ("@pbl_fwgt",model.Pbl_fwgt),
                new SqlParameter ("@pbl_fitl",model.Pbl_fitl),
                new SqlParameter ("@pbl_funl",model.Pbl_funl),
                new SqlParameter ("@pbl_fchr",model.Pbl_fchr),
                new SqlParameter ("@pbl_fptc",model.Pbl_fptc),
                new SqlParameter ("@pbl_ffce",model.Pbl_ffce),
                new SqlParameter ("@pbt_cmnt",model.Pbt_cmnt)
            };
           return Helper .ExecuteNonQuery ("Pbcattbl_Add",param);
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
                new SqlParameter ("@pbt_tnam",Id)
            };
           return Helper .ExecuteNonQuery ("Pbcattbl_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Pbcattbl">Pbcattbl实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Pbcattbl model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@pbt_tnam",model.Pbt_tnam),
                new SqlParameter ("@pbt_tid",model.Pbt_tid),
                new SqlParameter ("@pbt_ownr",model.Pbt_ownr),
                new SqlParameter ("@pbd_fhgt",model.Pbd_fhgt),
                new SqlParameter ("@pbd_fwgt",model.Pbd_fwgt),
                new SqlParameter ("@pbd_fitl",model.Pbd_fitl),
                new SqlParameter ("@pbd_funl",model.Pbd_funl),
                new SqlParameter ("@pbd_fchr",model.Pbd_fchr),
                new SqlParameter ("@pbd_fptc",model.Pbd_fptc),
                new SqlParameter ("@pbd_ffce",model.Pbd_ffce),
                new SqlParameter ("@pbh_fhgt",model.Pbh_fhgt),
                new SqlParameter ("@pbh_fwgt",model.Pbh_fwgt),
                new SqlParameter ("@pbh_fitl",model.Pbh_fitl),
                new SqlParameter ("@pbh_funl",model.Pbh_funl),
                new SqlParameter ("@pbh_fchr",model.Pbh_fchr),
                new SqlParameter ("@pbh_fptc",model.Pbh_fptc),
                new SqlParameter ("@pbh_ffce",model.Pbh_ffce),
                new SqlParameter ("@pbl_fhgt",model.Pbl_fhgt),
                new SqlParameter ("@pbl_fwgt",model.Pbl_fwgt),
                new SqlParameter ("@pbl_fitl",model.Pbl_fitl),
                new SqlParameter ("@pbl_funl",model.Pbl_funl),
                new SqlParameter ("@pbl_fchr",model.Pbl_fchr),
                new SqlParameter ("@pbl_fptc",model.Pbl_fptc),
                new SqlParameter ("@pbl_ffce",model.Pbl_ffce),
                new SqlParameter ("@pbt_cmnt",model.Pbt_cmnt)
            };
           return Helper .ExecuteNonQuery ("Pbcattbl_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Pbcattbl> selectAll()
        {
            List<Pbcattbl> list = new List<Pbcattbl>();
            Pbcattbl model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Pbcattbl_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Pbcattbl();
                    if (DBNull.Value!=dr["pbt_tnam"])
                        model.Pbt_tnam = dr["pbt_tnam"].ToString();
                    if (DBNull.Value!=dr["pbt_tid"])
                        model.Pbt_tid= Convert.ToInt32(dr["pbt_tid"]);
                    if (DBNull.Value!=dr["pbt_ownr"])
                        model.Pbt_ownr = dr["pbt_ownr"].ToString();
                    if (DBNull.Value!=dr["pbd_fhgt"])
                        model.Pbd_fhgt= Convert.ToInt32(dr["pbd_fhgt"]);
                    if (DBNull.Value!=dr["pbd_fwgt"])
                        model.Pbd_fwgt= Convert.ToInt32(dr["pbd_fwgt"]);
                    if (DBNull.Value!=dr["pbd_fitl"])
                        model.Pbd_fitl = dr["pbd_fitl"].ToString();
                    if (DBNull.Value!=dr["pbd_funl"])
                        model.Pbd_funl = dr["pbd_funl"].ToString();
                    if (DBNull.Value!=dr["pbd_fchr"])
                        model.Pbd_fchr= Convert.ToInt32(dr["pbd_fchr"]);
                    if (DBNull.Value!=dr["pbd_fptc"])
                        model.Pbd_fptc= Convert.ToInt32(dr["pbd_fptc"]);
                    if (DBNull.Value!=dr["pbd_ffce"])
                        model.Pbd_ffce = dr["pbd_ffce"].ToString();
                    if (DBNull.Value!=dr["pbh_fhgt"])
                        model.Pbh_fhgt= Convert.ToInt32(dr["pbh_fhgt"]);
                    if (DBNull.Value!=dr["pbh_fwgt"])
                        model.Pbh_fwgt= Convert.ToInt32(dr["pbh_fwgt"]);
                    if (DBNull.Value!=dr["pbh_fitl"])
                        model.Pbh_fitl = dr["pbh_fitl"].ToString();
                    if (DBNull.Value!=dr["pbh_funl"])
                        model.Pbh_funl = dr["pbh_funl"].ToString();
                    if (DBNull.Value!=dr["pbh_fchr"])
                        model.Pbh_fchr= Convert.ToInt32(dr["pbh_fchr"]);
                    if (DBNull.Value!=dr["pbh_fptc"])
                        model.Pbh_fptc= Convert.ToInt32(dr["pbh_fptc"]);
                    if (DBNull.Value!=dr["pbh_ffce"])
                        model.Pbh_ffce = dr["pbh_ffce"].ToString();
                    if (DBNull.Value!=dr["pbl_fhgt"])
                        model.Pbl_fhgt= Convert.ToInt32(dr["pbl_fhgt"]);
                    if (DBNull.Value!=dr["pbl_fwgt"])
                        model.Pbl_fwgt= Convert.ToInt32(dr["pbl_fwgt"]);
                    if (DBNull.Value!=dr["pbl_fitl"])
                        model.Pbl_fitl = dr["pbl_fitl"].ToString();
                    if (DBNull.Value!=dr["pbl_funl"])
                        model.Pbl_funl = dr["pbl_funl"].ToString();
                    if (DBNull.Value!=dr["pbl_fchr"])
                        model.Pbl_fchr= Convert.ToInt32(dr["pbl_fchr"]);
                    if (DBNull.Value!=dr["pbl_fptc"])
                        model.Pbl_fptc= Convert.ToInt32(dr["pbl_fptc"]);
                    if (DBNull.Value!=dr["pbl_ffce"])
                        model.Pbl_ffce = dr["pbl_ffce"].ToString();
                    if (DBNull.Value!=dr["pbt_cmnt"])
                        model.Pbt_cmnt = dr["pbt_cmnt"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Pbcattbl实体类对象</returns>
        public Pbcattbl selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@pbt_tnam",Id)
            };
            Pbcattbl model = new Pbcattbl();
            using (SqlDataReader dr = Helper.ExecuteReader("Pbcattbl_SelectById", param))
            {
                if (dr.Read())
                {
                    if (DBNull.Value!=dr["pbt_tnam"])
                        model.Pbt_tnam = dr["pbt_tnam"].ToString();
                    if (DBNull.Value!=dr["pbt_tid"])
                        model.Pbt_tid= Convert.ToInt32(dr["pbt_tid"]);
                    if (DBNull.Value!=dr["pbt_ownr"])
                        model.Pbt_ownr = dr["pbt_ownr"].ToString();
                    if (DBNull.Value!=dr["pbd_fhgt"])
                        model.Pbd_fhgt= Convert.ToInt32(dr["pbd_fhgt"]);
                    if (DBNull.Value!=dr["pbd_fwgt"])
                        model.Pbd_fwgt= Convert.ToInt32(dr["pbd_fwgt"]);
                    if (DBNull.Value!=dr["pbd_fitl"])
                        model.Pbd_fitl = dr["pbd_fitl"].ToString();
                    if (DBNull.Value!=dr["pbd_funl"])
                        model.Pbd_funl = dr["pbd_funl"].ToString();
                    if (DBNull.Value!=dr["pbd_fchr"])
                        model.Pbd_fchr= Convert.ToInt32(dr["pbd_fchr"]);
                    if (DBNull.Value!=dr["pbd_fptc"])
                        model.Pbd_fptc= Convert.ToInt32(dr["pbd_fptc"]);
                    if (DBNull.Value!=dr["pbd_ffce"])
                        model.Pbd_ffce = dr["pbd_ffce"].ToString();
                    if (DBNull.Value!=dr["pbh_fhgt"])
                        model.Pbh_fhgt= Convert.ToInt32(dr["pbh_fhgt"]);
                    if (DBNull.Value!=dr["pbh_fwgt"])
                        model.Pbh_fwgt= Convert.ToInt32(dr["pbh_fwgt"]);
                    if (DBNull.Value!=dr["pbh_fitl"])
                        model.Pbh_fitl = dr["pbh_fitl"].ToString();
                    if (DBNull.Value!=dr["pbh_funl"])
                        model.Pbh_funl = dr["pbh_funl"].ToString();
                    if (DBNull.Value!=dr["pbh_fchr"])
                        model.Pbh_fchr= Convert.ToInt32(dr["pbh_fchr"]);
                    if (DBNull.Value!=dr["pbh_fptc"])
                        model.Pbh_fptc= Convert.ToInt32(dr["pbh_fptc"]);
                    if (DBNull.Value!=dr["pbh_ffce"])
                        model.Pbh_ffce = dr["pbh_ffce"].ToString();
                    if (DBNull.Value!=dr["pbl_fhgt"])
                        model.Pbl_fhgt= Convert.ToInt32(dr["pbl_fhgt"]);
                    if (DBNull.Value!=dr["pbl_fwgt"])
                        model.Pbl_fwgt= Convert.ToInt32(dr["pbl_fwgt"]);
                    if (DBNull.Value!=dr["pbl_fitl"])
                        model.Pbl_fitl = dr["pbl_fitl"].ToString();
                    if (DBNull.Value!=dr["pbl_funl"])
                        model.Pbl_funl = dr["pbl_funl"].ToString();
                    if (DBNull.Value!=dr["pbl_fchr"])
                        model.Pbl_fchr= Convert.ToInt32(dr["pbl_fchr"]);
                    if (DBNull.Value!=dr["pbl_fptc"])
                        model.Pbl_fptc= Convert.ToInt32(dr["pbl_fptc"]);
                    if (DBNull.Value!=dr["pbl_ffce"])
                        model.Pbl_ffce = dr["pbl_ffce"].ToString();
                    if (DBNull.Value!=dr["pbt_cmnt"])
                        model.Pbt_cmnt = dr["pbt_cmnt"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Pbcattbl实体类对象</returns>
        public List<Pbcattbl> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Pbcattbl> list = new List<Pbcattbl>();
            Pbcattbl model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Pbcattbl_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Pbcattbl();
                    if (DBNull.Value!=dr["pbt_tnam"])
                        model.Pbt_tnam = dr["pbt_tnam"].ToString();
                    if (DBNull.Value!=dr["pbt_tid"])
                        model.Pbt_tid= Convert.ToInt32(dr["pbt_tid"]);
                    if (DBNull.Value!=dr["pbt_ownr"])
                        model.Pbt_ownr = dr["pbt_ownr"].ToString();
                    if (DBNull.Value!=dr["pbd_fhgt"])
                        model.Pbd_fhgt= Convert.ToInt32(dr["pbd_fhgt"]);
                    if (DBNull.Value!=dr["pbd_fwgt"])
                        model.Pbd_fwgt= Convert.ToInt32(dr["pbd_fwgt"]);
                    if (DBNull.Value!=dr["pbd_fitl"])
                        model.Pbd_fitl = dr["pbd_fitl"].ToString();
                    if (DBNull.Value!=dr["pbd_funl"])
                        model.Pbd_funl = dr["pbd_funl"].ToString();
                    if (DBNull.Value!=dr["pbd_fchr"])
                        model.Pbd_fchr= Convert.ToInt32(dr["pbd_fchr"]);
                    if (DBNull.Value!=dr["pbd_fptc"])
                        model.Pbd_fptc= Convert.ToInt32(dr["pbd_fptc"]);
                    if (DBNull.Value!=dr["pbd_ffce"])
                        model.Pbd_ffce = dr["pbd_ffce"].ToString();
                    if (DBNull.Value!=dr["pbh_fhgt"])
                        model.Pbh_fhgt= Convert.ToInt32(dr["pbh_fhgt"]);
                    if (DBNull.Value!=dr["pbh_fwgt"])
                        model.Pbh_fwgt= Convert.ToInt32(dr["pbh_fwgt"]);
                    if (DBNull.Value!=dr["pbh_fitl"])
                        model.Pbh_fitl = dr["pbh_fitl"].ToString();
                    if (DBNull.Value!=dr["pbh_funl"])
                        model.Pbh_funl = dr["pbh_funl"].ToString();
                    if (DBNull.Value!=dr["pbh_fchr"])
                        model.Pbh_fchr= Convert.ToInt32(dr["pbh_fchr"]);
                    if (DBNull.Value!=dr["pbh_fptc"])
                        model.Pbh_fptc= Convert.ToInt32(dr["pbh_fptc"]);
                    if (DBNull.Value!=dr["pbh_ffce"])
                        model.Pbh_ffce = dr["pbh_ffce"].ToString();
                    if (DBNull.Value!=dr["pbl_fhgt"])
                        model.Pbl_fhgt= Convert.ToInt32(dr["pbl_fhgt"]);
                    if (DBNull.Value!=dr["pbl_fwgt"])
                        model.Pbl_fwgt= Convert.ToInt32(dr["pbl_fwgt"]);
                    if (DBNull.Value!=dr["pbl_fitl"])
                        model.Pbl_fitl = dr["pbl_fitl"].ToString();
                    if (DBNull.Value!=dr["pbl_funl"])
                        model.Pbl_funl = dr["pbl_funl"].ToString();
                    if (DBNull.Value!=dr["pbl_fchr"])
                        model.Pbl_fchr= Convert.ToInt32(dr["pbl_fchr"]);
                    if (DBNull.Value!=dr["pbl_fptc"])
                        model.Pbl_fptc= Convert.ToInt32(dr["pbl_fptc"]);
                    if (DBNull.Value!=dr["pbl_ffce"])
                        model.Pbl_ffce = dr["pbl_ffce"].ToString();
                    if (DBNull.Value!=dr["pbt_cmnt"])
                        model.Pbt_cmnt = dr["pbt_cmnt"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

