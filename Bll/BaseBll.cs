using Dal;
using Entity;
using System;
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
        /// 获取一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static T GetModel<T>(Expression<Func<T, bool>> whereLambda) where T : class, new()
        {
            return new BaseDal<T>().GetModel(whereLambda);
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

    }
}
