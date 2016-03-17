using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
   public class Finance_zzManager
   {
        Finance_zzService dal = new Finance_zzService();

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Finance_zz">Finance_zz实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Finance_zz model)
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
        /// <param name="Finance_zz">Finance_zz实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Finance_zz model)
        {
            return dal.change(model);
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        public List<Finance_zz> selectAll()
        {
            return dal.selectAll();
        }

        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        public Finance_zz selectById(int Id)
        {
            return dal.selectById(Id);
        }

        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">主键Id</param>
        public List<Finance_zz> selectByWhere(string WhereString)
        {
            return dal.selectByWhere(WhereString);
        }

    }
}

