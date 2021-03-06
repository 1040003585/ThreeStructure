using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
   public class Component_wltx_typeManager
   {
        Component_wltx_typeService dal = new Component_wltx_typeService();

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Component_wltx_type">Component_wltx_type实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Component_wltx_type model)
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
        /// <param name="Component_wltx_type">Component_wltx_type实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Component_wltx_type model)
        {
            return dal.change(model);
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        public List<Component_wltx_type> selectAll()
        {
            return dal.selectAll();
        }

        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        public Component_wltx_type selectById(int Id)
        {
            return dal.selectById(Id);
        }

        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">主键Id</param>
        public List<Component_wltx_type> selectByWhere(string WhereString)
        {
            return dal.selectByWhere(WhereString);
        }

    }
}

