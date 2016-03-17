using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
   public class Foot_statusManager
   {
        Foot_statusService dal = new Foot_statusService();

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Foot_status">Foot_status实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Foot_status model)
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
        /// <param name="Foot_status">Foot_status实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Foot_status model)
        {
            return dal.change(model);
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        public List<Foot_status> selectAll()
        {
            return dal.selectAll();
        }

        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        public Foot_status selectById(int Id)
        {
            return dal.selectById(Id);
        }

        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">主键Id</param>
        public List<Foot_status> selectByWhere(string WhereString)
        {
            return dal.selectByWhere(WhereString);
        }

    }
}

