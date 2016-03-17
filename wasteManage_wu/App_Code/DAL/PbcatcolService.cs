using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PbcatcolService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Pbcatcol">Pbcatcol实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Pbcatcol model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@pbc_tnam",model.Pbc_tnam),
                new SqlParameter ("@pbc_tid",model.Pbc_tid),
                new SqlParameter ("@pbc_ownr",model.Pbc_ownr),
                new SqlParameter ("@pbc_cnam",model.Pbc_cnam),
                new SqlParameter ("@pbc_cid",model.Pbc_cid),
                new SqlParameter ("@pbc_labl",model.Pbc_labl),
                new SqlParameter ("@pbc_lpos",model.Pbc_lpos),
                new SqlParameter ("@pbc_hdr",model.Pbc_hdr),
                new SqlParameter ("@pbc_hpos",model.Pbc_hpos),
                new SqlParameter ("@pbc_jtfy",model.Pbc_jtfy),
                new SqlParameter ("@pbc_mask",model.Pbc_mask),
                new SqlParameter ("@pbc_case",model.Pbc_case),
                new SqlParameter ("@pbc_hght",model.Pbc_hght),
                new SqlParameter ("@pbc_wdth",model.Pbc_wdth),
                new SqlParameter ("@pbc_ptrn",model.Pbc_ptrn),
                new SqlParameter ("@pbc_bmap",model.Pbc_bmap),
                new SqlParameter ("@pbc_init",model.Pbc_init),
                new SqlParameter ("@pbc_cmnt",model.Pbc_cmnt),
                new SqlParameter ("@pbc_edit",model.Pbc_edit),
                new SqlParameter ("@pbc_tag",model.Pbc_tag)
            };
           return Helper .ExecuteNonQuery ("Pbcatcol_Add",param);
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
                new SqlParameter ("@pbc_tnam",Id)
            };
           return Helper .ExecuteNonQuery ("Pbcatcol_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Pbcatcol">Pbcatcol实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Pbcatcol model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@pbc_tnam",model.Pbc_tnam),
                new SqlParameter ("@pbc_tid",model.Pbc_tid),
                new SqlParameter ("@pbc_ownr",model.Pbc_ownr),
                new SqlParameter ("@pbc_cnam",model.Pbc_cnam),
                new SqlParameter ("@pbc_cid",model.Pbc_cid),
                new SqlParameter ("@pbc_labl",model.Pbc_labl),
                new SqlParameter ("@pbc_lpos",model.Pbc_lpos),
                new SqlParameter ("@pbc_hdr",model.Pbc_hdr),
                new SqlParameter ("@pbc_hpos",model.Pbc_hpos),
                new SqlParameter ("@pbc_jtfy",model.Pbc_jtfy),
                new SqlParameter ("@pbc_mask",model.Pbc_mask),
                new SqlParameter ("@pbc_case",model.Pbc_case),
                new SqlParameter ("@pbc_hght",model.Pbc_hght),
                new SqlParameter ("@pbc_wdth",model.Pbc_wdth),
                new SqlParameter ("@pbc_ptrn",model.Pbc_ptrn),
                new SqlParameter ("@pbc_bmap",model.Pbc_bmap),
                new SqlParameter ("@pbc_init",model.Pbc_init),
                new SqlParameter ("@pbc_cmnt",model.Pbc_cmnt),
                new SqlParameter ("@pbc_edit",model.Pbc_edit),
                new SqlParameter ("@pbc_tag",model.Pbc_tag)
            };
           return Helper .ExecuteNonQuery ("Pbcatcol_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<Pbcatcol> selectAll()
        {
            List<Pbcatcol> list = new List<Pbcatcol>();
            Pbcatcol model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Pbcatcol_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new Pbcatcol();
                    if (DBNull.Value!=dr["pbc_tnam"])
                        model.Pbc_tnam = dr["pbc_tnam"].ToString();
                    if (DBNull.Value!=dr["pbc_tid"])
                        model.Pbc_tid= Convert.ToInt32(dr["pbc_tid"]);
                    if (DBNull.Value!=dr["pbc_ownr"])
                        model.Pbc_ownr = dr["pbc_ownr"].ToString();
                    if (DBNull.Value!=dr["pbc_cnam"])
                        model.Pbc_cnam = dr["pbc_cnam"].ToString();
                    if (DBNull.Value!=dr["pbc_cid"])
                        model.Pbc_cid= Convert.ToInt32(dr["pbc_cid"]);
                    if (DBNull.Value!=dr["pbc_labl"])
                        model.Pbc_labl = dr["pbc_labl"].ToString();
                    if (DBNull.Value!=dr["pbc_lpos"])
                        model.Pbc_lpos= Convert.ToInt32(dr["pbc_lpos"]);
                    if (DBNull.Value!=dr["pbc_hdr"])
                        model.Pbc_hdr = dr["pbc_hdr"].ToString();
                    if (DBNull.Value!=dr["pbc_hpos"])
                        model.Pbc_hpos= Convert.ToInt32(dr["pbc_hpos"]);
                    if (DBNull.Value!=dr["pbc_jtfy"])
                        model.Pbc_jtfy= Convert.ToInt32(dr["pbc_jtfy"]);
                    if (DBNull.Value!=dr["pbc_mask"])
                        model.Pbc_mask = dr["pbc_mask"].ToString();
                    if (DBNull.Value!=dr["pbc_case"])
                        model.Pbc_case= Convert.ToInt32(dr["pbc_case"]);
                    if (DBNull.Value!=dr["pbc_hght"])
                        model.Pbc_hght= Convert.ToInt32(dr["pbc_hght"]);
                    if (DBNull.Value!=dr["pbc_wdth"])
                        model.Pbc_wdth= Convert.ToInt32(dr["pbc_wdth"]);
                    if (DBNull.Value!=dr["pbc_ptrn"])
                        model.Pbc_ptrn = dr["pbc_ptrn"].ToString();
                    if (DBNull.Value!=dr["pbc_bmap"])
                        model.Pbc_bmap = dr["pbc_bmap"].ToString();
                    if (DBNull.Value!=dr["pbc_init"])
                        model.Pbc_init = dr["pbc_init"].ToString();
                    if (DBNull.Value!=dr["pbc_cmnt"])
                        model.Pbc_cmnt = dr["pbc_cmnt"].ToString();
                    if (DBNull.Value!=dr["pbc_edit"])
                        model.Pbc_edit = dr["pbc_edit"].ToString();
                    if (DBNull.Value!=dr["pbc_tag"])
                        model.Pbc_tag = dr["pbc_tag"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>Pbcatcol实体类对象</returns>
        public Pbcatcol selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@pbc_tnam",Id)
            };
            Pbcatcol model = new Pbcatcol();
            using (SqlDataReader dr = Helper.ExecuteReader("Pbcatcol_SelectById", param))
            {
                if (dr.Read())
                {
                    if (DBNull.Value!=dr["pbc_tnam"])
                        model.Pbc_tnam = dr["pbc_tnam"].ToString();
                    if (DBNull.Value!=dr["pbc_tid"])
                        model.Pbc_tid= Convert.ToInt32(dr["pbc_tid"]);
                    if (DBNull.Value!=dr["pbc_ownr"])
                        model.Pbc_ownr = dr["pbc_ownr"].ToString();
                    if (DBNull.Value!=dr["pbc_cnam"])
                        model.Pbc_cnam = dr["pbc_cnam"].ToString();
                    if (DBNull.Value!=dr["pbc_cid"])
                        model.Pbc_cid= Convert.ToInt32(dr["pbc_cid"]);
                    if (DBNull.Value!=dr["pbc_labl"])
                        model.Pbc_labl = dr["pbc_labl"].ToString();
                    if (DBNull.Value!=dr["pbc_lpos"])
                        model.Pbc_lpos= Convert.ToInt32(dr["pbc_lpos"]);
                    if (DBNull.Value!=dr["pbc_hdr"])
                        model.Pbc_hdr = dr["pbc_hdr"].ToString();
                    if (DBNull.Value!=dr["pbc_hpos"])
                        model.Pbc_hpos= Convert.ToInt32(dr["pbc_hpos"]);
                    if (DBNull.Value!=dr["pbc_jtfy"])
                        model.Pbc_jtfy= Convert.ToInt32(dr["pbc_jtfy"]);
                    if (DBNull.Value!=dr["pbc_mask"])
                        model.Pbc_mask = dr["pbc_mask"].ToString();
                    if (DBNull.Value!=dr["pbc_case"])
                        model.Pbc_case= Convert.ToInt32(dr["pbc_case"]);
                    if (DBNull.Value!=dr["pbc_hght"])
                        model.Pbc_hght= Convert.ToInt32(dr["pbc_hght"]);
                    if (DBNull.Value!=dr["pbc_wdth"])
                        model.Pbc_wdth= Convert.ToInt32(dr["pbc_wdth"]);
                    if (DBNull.Value!=dr["pbc_ptrn"])
                        model.Pbc_ptrn = dr["pbc_ptrn"].ToString();
                    if (DBNull.Value!=dr["pbc_bmap"])
                        model.Pbc_bmap = dr["pbc_bmap"].ToString();
                    if (DBNull.Value!=dr["pbc_init"])
                        model.Pbc_init = dr["pbc_init"].ToString();
                    if (DBNull.Value!=dr["pbc_cmnt"])
                        model.Pbc_cmnt = dr["pbc_cmnt"].ToString();
                    if (DBNull.Value!=dr["pbc_edit"])
                        model.Pbc_edit = dr["pbc_edit"].ToString();
                    if (DBNull.Value!=dr["pbc_tag"])
                        model.Pbc_tag = dr["pbc_tag"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>Pbcatcol实体类对象</returns>
        public List<Pbcatcol> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<Pbcatcol> list = new List<Pbcatcol>();
            Pbcatcol model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("Pbcatcol_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new Pbcatcol();
                    if (DBNull.Value!=dr["pbc_tnam"])
                        model.Pbc_tnam = dr["pbc_tnam"].ToString();
                    if (DBNull.Value!=dr["pbc_tid"])
                        model.Pbc_tid= Convert.ToInt32(dr["pbc_tid"]);
                    if (DBNull.Value!=dr["pbc_ownr"])
                        model.Pbc_ownr = dr["pbc_ownr"].ToString();
                    if (DBNull.Value!=dr["pbc_cnam"])
                        model.Pbc_cnam = dr["pbc_cnam"].ToString();
                    if (DBNull.Value!=dr["pbc_cid"])
                        model.Pbc_cid= Convert.ToInt32(dr["pbc_cid"]);
                    if (DBNull.Value!=dr["pbc_labl"])
                        model.Pbc_labl = dr["pbc_labl"].ToString();
                    if (DBNull.Value!=dr["pbc_lpos"])
                        model.Pbc_lpos= Convert.ToInt32(dr["pbc_lpos"]);
                    if (DBNull.Value!=dr["pbc_hdr"])
                        model.Pbc_hdr = dr["pbc_hdr"].ToString();
                    if (DBNull.Value!=dr["pbc_hpos"])
                        model.Pbc_hpos= Convert.ToInt32(dr["pbc_hpos"]);
                    if (DBNull.Value!=dr["pbc_jtfy"])
                        model.Pbc_jtfy= Convert.ToInt32(dr["pbc_jtfy"]);
                    if (DBNull.Value!=dr["pbc_mask"])
                        model.Pbc_mask = dr["pbc_mask"].ToString();
                    if (DBNull.Value!=dr["pbc_case"])
                        model.Pbc_case= Convert.ToInt32(dr["pbc_case"]);
                    if (DBNull.Value!=dr["pbc_hght"])
                        model.Pbc_hght= Convert.ToInt32(dr["pbc_hght"]);
                    if (DBNull.Value!=dr["pbc_wdth"])
                        model.Pbc_wdth= Convert.ToInt32(dr["pbc_wdth"]);
                    if (DBNull.Value!=dr["pbc_ptrn"])
                        model.Pbc_ptrn = dr["pbc_ptrn"].ToString();
                    if (DBNull.Value!=dr["pbc_bmap"])
                        model.Pbc_bmap = dr["pbc_bmap"].ToString();
                    if (DBNull.Value!=dr["pbc_init"])
                        model.Pbc_init = dr["pbc_init"].ToString();
                    if (DBNull.Value!=dr["pbc_cmnt"])
                        model.Pbc_cmnt = dr["pbc_cmnt"].ToString();
                    if (DBNull.Value!=dr["pbc_edit"])
                        model.Pbc_edit = dr["pbc_edit"].ToString();
                    if (DBNull.Value!=dr["pbc_tag"])
                        model.Pbc_tag = dr["pbc_tag"].ToString();
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

