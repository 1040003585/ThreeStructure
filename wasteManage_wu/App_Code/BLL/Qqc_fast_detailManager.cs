using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
   public class Qqc_fast_detailManager
   {
        Qqc_fast_detailService dal = new Qqc_fast_detailService();

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Qqc_fast_detail">Qqc_fast_detail实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Qqc_fast_detail model)
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
        /// <param name="Qqc_fast_detail">Qqc_fast_detail实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Qqc_fast_detail model)
        {
            return dal.change(model);
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        public List<Qqc_fast_detail> selectAll()
        {
            return dal.selectAll();
        }

        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        public Qqc_fast_detail selectById(int Id)
        {
            return dal.selectById(Id);
        }

        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">主键Id</param>
        public List<Qqc_fast_detail> selectByWhere(string WhereString)
        {
            return dal.selectByWhere(WhereString);
        }

    }
}

