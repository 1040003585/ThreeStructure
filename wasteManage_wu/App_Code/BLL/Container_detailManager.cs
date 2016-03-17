using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
   public class Container_detailManager
   {
        Container_detailService dal = new Container_detailService();

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Container_detail">Container_detail实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Container_detail model)
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
        /// <param name="Container_detail">Container_detail实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Container_detail model)
        {
            return dal.change(model);
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        public List<Container_detail> selectAll()
        {
            return dal.selectAll();
        }

        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        public Container_detail selectById(int Id)
        {
            return dal.selectById(Id);
        }

        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">主键Id</param>
        public List<Container_detail> selectByWhere(string WhereString)
        {
            return dal.selectByWhere(WhereString);
        }

    }
}

