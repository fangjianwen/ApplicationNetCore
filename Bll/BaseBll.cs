using Dal;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Bll
{
    /// <summary>
    /// 数据操作类
    /// </summary>
    public class BaseBll
    {
        /// <summary>
        /// 新增一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool Add<T>(T model) where T : class, new()
        {
            return new BaseDal<T>().Add(model) > 0;
        }
        /// <summary>
        /// 新增一条数据返回新增的数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static T AddReturnModel<T>(T model) where T : class, new()
        {
            return new BaseDal<T>().AddReturnModel(model);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool Delete<T>(T model) where T : class, new()
        {
            return new BaseDal<T>().Delete(model)>0;
        }
        /// <summary>
        /// 根据条件删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static int Delete<T>(Expression<Func<T, bool>> delWhere) where T : class, new()
        {
            return new BaseDal<T>().Delete(delWhere);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool Update<T>(T model) where T : class, new()
        {
            return new BaseDal<T>().Update(model) > 0;
        }
        /// <summary>
        /// 更新一条数据 修改指定字段
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool Update<T>(T model, params string[] propertyNames) where T : class, new()
        {
            return new BaseDal<T>().Update(model, propertyNames) > 0;
        }
        /// <summary>
        /// 批量修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static int Update<T>(T model, Expression<Func<T, bool>> whereLambda, params string[] propertyNames) where T : class, new()
        {
            return new BaseDal<T>().Update(model, whereLambda, propertyNames);
        }
        /// <summary>
        /// 获取一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static T GetModel<T>(Expression<Func<T, bool>> whereLambda) where T : class, new()
        {
            return new BaseDal<T>().GetModel(whereLambda);
        }
        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static List<T> GetList<T>(Expression<Func<T, bool>> whereLambda) where T : class, new()
        {
            return new BaseDal<T>().GetList(whereLambda);
        }
        ///// <summary>
        ///// 根据条件查询
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public static List<T> GetList<TKey>(Expression<Func<T, bool>> whereLambda, Expression<Func<T, TKey>> orderLambda, bool isAsc = true) where T : class, new()
        //{
        //    return new BaseDal<T>().GetList(whereLambda, orderLambda, isAsc);
        //}

    }

    



}
