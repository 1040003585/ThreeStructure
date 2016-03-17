using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
   public class Qqc_componentManager
   {
        Qqc_componentService dal = new Qqc_componentService();

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Qqc_component">Qqc_component实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Qqc_component model)
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
        /// <param name="Qqc_component">Qqc_component实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Qqc_component model)
        {
            return dal.change(model);
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        public List<Qqc_component> selectAll()
        {
            return dal.selectAll();
        }

        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        public Qqc_component selectById(int Id)
        {
            return dal.selectById(Id);
        }

        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">主键Id</param>
        public List<Qqc_component> selectByWhere(string WhereString)
        {
            return dal.selectByWhere(WhereString);
        }

    }
}

