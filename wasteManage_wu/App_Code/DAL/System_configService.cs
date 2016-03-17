using System;
using System.Collections.Generic;
using Models;
using DBHelp;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class System_configService
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="System_config">System_config实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(System_config model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@dbver",model.Dbver),
                new SqlParameter ("@update_date",model.Update_date),
                new SqlParameter ("@exit_backup",model.Exit_backup),
                new SqlParameter ("@check_status",model.Check_status),
                new SqlParameter ("@is_cal",model.Is_cal),
                new SqlParameter ("@backup_dir",model.Backup_dir),
                new SqlParameter ("@waste_n",model.Waste_n),
                new SqlParameter ("@edit_sh",model.Edit_sh),
                new SqlParameter ("@sample_bh",model.Sample_bh),
                new SqlParameter ("@c1",model.C1),
                new SqlParameter ("@c2",model.C2),
                new SqlParameter ("@c3",model.C3),
                new SqlParameter ("@c4",model.C4),
                new SqlParameter ("@c5",model.C5),
                new SqlParameter ("@com",model.Com),
                new SqlParameter ("@pt",model.Pt),
                new SqlParameter ("@sjw",model.Sjw),
                new SqlParameter ("@tzw",model.Tzw),
                new SqlParameter ("@xyw",model.Xyw),
                new SqlParameter ("@ftp_server",model.Ftp_server),
                new SqlParameter ("@ftp_com",model.Ftp_com),
                new SqlParameter ("@ftp_user",model.Ftp_user),
                new SqlParameter ("@ftp_password",model.Ftp_password),
                new SqlParameter ("@BBH",model.BBH),
                new SqlParameter ("@times",model.Times)
            };
           return Helper .ExecuteNonQuery ("System_config_Add",param);
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
                new SqlParameter ("@dbver",Id)
            };
           return Helper .ExecuteNonQuery ("System_config_Delete",param);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="System_config">System_config实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(System_config model)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@dbver",model.Dbver),
                new SqlParameter ("@update_date",model.Update_date),
                new SqlParameter ("@exit_backup",model.Exit_backup),
                new SqlParameter ("@check_status",model.Check_status),
                new SqlParameter ("@is_cal",model.Is_cal),
                new SqlParameter ("@backup_dir",model.Backup_dir),
                new SqlParameter ("@waste_n",model.Waste_n),
                new SqlParameter ("@edit_sh",model.Edit_sh),
                new SqlParameter ("@sample_bh",model.Sample_bh),
                new SqlParameter ("@c1",model.C1),
                new SqlParameter ("@c2",model.C2),
                new SqlParameter ("@c3",model.C3),
                new SqlParameter ("@c4",model.C4),
                new SqlParameter ("@c5",model.C5),
                new SqlParameter ("@com",model.Com),
                new SqlParameter ("@pt",model.Pt),
                new SqlParameter ("@sjw",model.Sjw),
                new SqlParameter ("@tzw",model.Tzw),
                new SqlParameter ("@xyw",model.Xyw),
                new SqlParameter ("@ftp_server",model.Ftp_server),
                new SqlParameter ("@ftp_com",model.Ftp_com),
                new SqlParameter ("@ftp_user",model.Ftp_user),
                new SqlParameter ("@ftp_password",model.Ftp_password),
                new SqlParameter ("@BBH",model.BBH),
                new SqlParameter ("@times",model.Times)
            };
           return Helper .ExecuteNonQuery ("System_config_Change",param);
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>list集合</returns>
        public List<System_config> selectAll()
        {
            List<System_config> list = new List<System_config>();
            System_config model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("System_config_SelectAll", null))
            {
                while (dr.Read())
                {
                    model = new System_config();
                    if (DBNull.Value!=dr["dbver"])
                        model.Dbver = dr["dbver"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["exit_backup"])
                        model.Exit_backup= Convert.ToByte(dr["exit_backup"]);
                    if (DBNull.Value!=dr["check_status"])
                        model.Check_status = dr["check_status"].ToString();
                    if (DBNull.Value!=dr["is_cal"])
                        model.Is_cal= Convert.ToByte(dr["is_cal"]);
                    if (DBNull.Value!=dr["backup_dir"])
                        model.Backup_dir = dr["backup_dir"].ToString();
                    if (DBNull.Value!=dr["waste_n"])
                        model.Waste_n= Convert.ToByte(dr["waste_n"]);
                    if (DBNull.Value!=dr["edit_sh"])
                        model.Edit_sh= Convert.ToByte(dr["edit_sh"]);
                    if (DBNull.Value!=dr["sample_bh"])
                        model.Sample_bh= Convert.ToByte(dr["sample_bh"]);
                    if (DBNull.Value!=dr["c1"])
                        model.C1= Convert.ToByte(dr["c1"]);
                    if (DBNull.Value!=dr["c2"])
                        model.C2= Convert.ToByte(dr["c2"]);
                    if (DBNull.Value!=dr["c3"])
                        model.C3= Convert.ToByte(dr["c3"]);
                    if (DBNull.Value!=dr["c4"])
                        model.C4= Convert.ToByte(dr["c4"]);
                    if (DBNull.Value!=dr["c5"])
                        model.C5= Convert.ToByte(dr["c5"]);
                    if (DBNull.Value!=dr["com"])
                        model.Com = dr["com"].ToString();
                    if (DBNull.Value!=dr["pt"])
                        model.Pt = dr["pt"].ToString();
                    if (DBNull.Value!=dr["sjw"])
                        model.Sjw = dr["sjw"].ToString();
                    if (DBNull.Value!=dr["tzw"])
                        model.Tzw = dr["tzw"].ToString();
                    if (DBNull.Value!=dr["xyw"])
                        model.Xyw = dr["xyw"].ToString();
                    if (DBNull.Value!=dr["ftp_server"])
                        model.Ftp_server = dr["ftp_server"].ToString();
                    if (DBNull.Value!=dr["ftp_com"])
                        model.Ftp_com = dr["ftp_com"].ToString();
                    if (DBNull.Value!=dr["ftp_user"])
                        model.Ftp_user = dr["ftp_user"].ToString();
                    if (DBNull.Value!=dr["ftp_password"])
                        model.Ftp_password = dr["ftp_password"].ToString();
                    if (DBNull.Value!=dr["BBH"])
                        model.BBH = dr["BBH"].ToString();
                    if (DBNull.Value!=dr["times"])
                        model.Times= Convert.ToByte(dr["times"]);
                    list.Add(model);
                }
            }
            return list;
        }
        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>System_config实体类对象</returns>
        public System_config selectById(int Id)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@dbver",Id)
            };
            System_config model = new System_config();
            using (SqlDataReader dr = Helper.ExecuteReader("System_config_SelectById", param))
            {
                if (dr.Read())
                {
                    if (DBNull.Value!=dr["dbver"])
                        model.Dbver = dr["dbver"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["exit_backup"])
                        model.Exit_backup= Convert.ToByte(dr["exit_backup"]);
                    if (DBNull.Value!=dr["check_status"])
                        model.Check_status = dr["check_status"].ToString();
                    if (DBNull.Value!=dr["is_cal"])
                        model.Is_cal= Convert.ToByte(dr["is_cal"]);
                    if (DBNull.Value!=dr["backup_dir"])
                        model.Backup_dir = dr["backup_dir"].ToString();
                    if (DBNull.Value!=dr["waste_n"])
                        model.Waste_n= Convert.ToByte(dr["waste_n"]);
                    if (DBNull.Value!=dr["edit_sh"])
                        model.Edit_sh= Convert.ToByte(dr["edit_sh"]);
                    if (DBNull.Value!=dr["sample_bh"])
                        model.Sample_bh= Convert.ToByte(dr["sample_bh"]);
                    if (DBNull.Value!=dr["c1"])
                        model.C1= Convert.ToByte(dr["c1"]);
                    if (DBNull.Value!=dr["c2"])
                        model.C2= Convert.ToByte(dr["c2"]);
                    if (DBNull.Value!=dr["c3"])
                        model.C3= Convert.ToByte(dr["c3"]);
                    if (DBNull.Value!=dr["c4"])
                        model.C4= Convert.ToByte(dr["c4"]);
                    if (DBNull.Value!=dr["c5"])
                        model.C5= Convert.ToByte(dr["c5"]);
                    if (DBNull.Value!=dr["com"])
                        model.Com = dr["com"].ToString();
                    if (DBNull.Value!=dr["pt"])
                        model.Pt = dr["pt"].ToString();
                    if (DBNull.Value!=dr["sjw"])
                        model.Sjw = dr["sjw"].ToString();
                    if (DBNull.Value!=dr["tzw"])
                        model.Tzw = dr["tzw"].ToString();
                    if (DBNull.Value!=dr["xyw"])
                        model.Xyw = dr["xyw"].ToString();
                    if (DBNull.Value!=dr["ftp_server"])
                        model.Ftp_server = dr["ftp_server"].ToString();
                    if (DBNull.Value!=dr["ftp_com"])
                        model.Ftp_com = dr["ftp_com"].ToString();
                    if (DBNull.Value!=dr["ftp_user"])
                        model.Ftp_user = dr["ftp_user"].ToString();
                    if (DBNull.Value!=dr["ftp_password"])
                        model.Ftp_password = dr["ftp_password"].ToString();
                    if (DBNull.Value!=dr["BBH"])
                        model.BBH = dr["BBH"].ToString();
                    if (DBNull.Value!=dr["times"])
                        model.Times= Convert.ToByte(dr["times"]);
                }
            }
            return model;
        }
        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">查询条件</param>
        /// <returns>System_config实体类对象</returns>
        public List<System_config> selectByWhere(string WhereString)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter ("@where",WhereString)
            };
            List<System_config> list = new List<System_config>();
            System_config model = null;
            using (SqlDataReader dr = Helper.ExecuteReader("System_config_SelectByWhere", param))
            {
                while (dr.Read())
                {
                    model = new System_config();
                    if (DBNull.Value!=dr["dbver"])
                        model.Dbver = dr["dbver"].ToString();
                    if (DBNull.Value!=dr["update_date"])
                        model.Update_date= Convert.ToDateTime(dr["update_date"]);
                    if (DBNull.Value!=dr["exit_backup"])
                        model.Exit_backup= Convert.ToByte(dr["exit_backup"]);
                    if (DBNull.Value!=dr["check_status"])
                        model.Check_status = dr["check_status"].ToString();
                    if (DBNull.Value!=dr["is_cal"])
                        model.Is_cal= Convert.ToByte(dr["is_cal"]);
                    if (DBNull.Value!=dr["backup_dir"])
                        model.Backup_dir = dr["backup_dir"].ToString();
                    if (DBNull.Value!=dr["waste_n"])
                        model.Waste_n= Convert.ToByte(dr["waste_n"]);
                    if (DBNull.Value!=dr["edit_sh"])
                        model.Edit_sh= Convert.ToByte(dr["edit_sh"]);
                    if (DBNull.Value!=dr["sample_bh"])
                        model.Sample_bh= Convert.ToByte(dr["sample_bh"]);
                    if (DBNull.Value!=dr["c1"])
                        model.C1= Convert.ToByte(dr["c1"]);
                    if (DBNull.Value!=dr["c2"])
                        model.C2= Convert.ToByte(dr["c2"]);
                    if (DBNull.Value!=dr["c3"])
                        model.C3= Convert.ToByte(dr["c3"]);
                    if (DBNull.Value!=dr["c4"])
                        model.C4= Convert.ToByte(dr["c4"]);
                    if (DBNull.Value!=dr["c5"])
                        model.C5= Convert.ToByte(dr["c5"]);
                    if (DBNull.Value!=dr["com"])
                        model.Com = dr["com"].ToString();
                    if (DBNull.Value!=dr["pt"])
                        model.Pt = dr["pt"].ToString();
                    if (DBNull.Value!=dr["sjw"])
                        model.Sjw = dr["sjw"].ToString();
                    if (DBNull.Value!=dr["tzw"])
                        model.Tzw = dr["tzw"].ToString();
                    if (DBNull.Value!=dr["xyw"])
                        model.Xyw = dr["xyw"].ToString();
                    if (DBNull.Value!=dr["ftp_server"])
                        model.Ftp_server = dr["ftp_server"].ToString();
                    if (DBNull.Value!=dr["ftp_com"])
                        model.Ftp_com = dr["ftp_com"].ToString();
                    if (DBNull.Value!=dr["ftp_user"])
                        model.Ftp_user = dr["ftp_user"].ToString();
                    if (DBNull.Value!=dr["ftp_password"])
                        model.Ftp_password = dr["ftp_password"].ToString();
                    if (DBNull.Value!=dr["BBH"])
                        model.BBH = dr["BBH"].ToString();
                    if (DBNull.Value!=dr["times"])
                        model.Times= Convert.ToByte(dr["times"]);
                    list.Add(model);
                }
            }
            return list;
        }
    }
}

