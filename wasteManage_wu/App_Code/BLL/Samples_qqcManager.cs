using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
   public class Samples_qqcManager
   {
        Samples_qqcService dal = new Samples_qqcService();

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Samples_qqc">Samples_qqc实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Samples_qqc model)
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
        /// <param name="Samples_qqc">Samples_qqc实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Samples_qqc model)
        {
            return dal.change(model);
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        public List<Samples_qqc> selectAll()
        {
            return dal.selectAll();
        }

        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        public Samples_qqc selectById(int Id)
        {
            return dal.selectById(Id);
        }

        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">主键Id</param>
        public List<Samples_qqc> selectByWhere(string WhereString)
        {
            return dal.selectByWhere(WhereString);
        }

    }
}

