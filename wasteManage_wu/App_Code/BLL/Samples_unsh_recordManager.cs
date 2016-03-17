using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
   public class Samples_unsh_recordManager
   {
        Samples_unsh_recordService dal = new Samples_unsh_recordService();

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Samples_unsh_record">Samples_unsh_record实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Samples_unsh_record model)
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
        /// <param name="Samples_unsh_record">Samples_unsh_record实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Samples_unsh_record model)
        {
            return dal.change(model);
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        public List<Samples_unsh_record> selectAll()
        {
            return dal.selectAll();
        }

        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        public Samples_unsh_record selectById(int Id)
        {
            return dal.selectById(Id);
        }

        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">主键Id</param>
        public List<Samples_unsh_record> selectByWhere(string WhereString)
        {
            return dal.selectByWhere(WhereString);
        }

    }
}

