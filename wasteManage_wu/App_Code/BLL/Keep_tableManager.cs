using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
   public class Keep_tableManager
   {
        Keep_tableService dal = new Keep_tableService();

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Keep_table">Keep_table实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Keep_table model)
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
        /// <param name="Keep_table">Keep_table实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Keep_table model)
        {
            return dal.change(model);
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        public List<Keep_table> selectAll()
        {
            return dal.selectAll();
        }

        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        public Keep_table selectById(int Id)
        {
            return dal.selectById(Id);
        }

        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">主键Id</param>
        public List<Keep_table> selectByWhere(string WhereString)
        {
            return dal.selectByWhere(WhereString);
        }

    }
}

