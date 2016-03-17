using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
   public class Lock_rowManager
   {
        Lock_rowService dal = new Lock_rowService();

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Lock_row">Lock_row实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Lock_row model)
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
        /// <param name="Lock_row">Lock_row实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Lock_row model)
        {
            return dal.change(model);
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        public List<Lock_row> selectAll()
        {
            return dal.selectAll();
        }

        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        public Lock_row selectById(int Id)
        {
            return dal.selectById(Id);
        }

        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">主键Id</param>
        public List<Lock_row> selectByWhere(string WhereString)
        {
            return dal.selectByWhere(WhereString);
        }

    }
}

