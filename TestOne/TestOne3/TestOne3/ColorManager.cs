using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
   public class ColorManager
   {
        ColorService dal = new ColorService();

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="Color">Color实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool add(Color model)
        {
            return dal.add(model);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool delete(string Id)
        {
            return dal.delete(Id);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Color">Color实体对象</param>
        /// <returns>bool值,判断是否操作成功</returns>
        public bool change(Color model)
        {
            return dal.change(model);
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        public List<Color> selectAll()
        {
            return dal.selectAll();
        }

        /// <summary>
        /// 通过Id查询
        /// </summary>
        /// <param name="Id">主键Id</param>
        public Color selectById(int Id)
        {
            return dal.selectById(Id);
        }

        /// <summary>
        /// 通过条件查询
        /// </summary>
        /// <param name="WhereString">主键Id</param>
        public List<Color> selectByWhere(string WhereString)
        {
            return dal.selectByWhere(WhereString);
        }

   
   
    }
}

