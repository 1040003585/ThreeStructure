using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
   public class Mgr_user_groupManager
   {
        Mgr_user_groupService dal = new Mgr_user_groupService();

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Mgr_user_group">Mgr_user_group实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Mgr_user_group model)
        {
            return dal.add(model);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool delete(int Id)
        {
            return dal.delete(Id);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Mgr_user_group">Mgr_user_group实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Mgr_user_group model)
        {
            return dal.change(model);
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        public List<Mgr_user_group> selectAll()
        {
            return dal.selectAll();
        }

        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        public Mgr_user_group selectById(int Id)
        {
            return dal.selectById(Id);
        }

        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">主键Id</param>
        public List<Mgr_user_group> selectByWhere(string WhereString)
        {
            return dal.selectByWhere(WhereString);
        }

    }
}

