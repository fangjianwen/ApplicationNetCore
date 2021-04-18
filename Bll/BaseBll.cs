using Dal;
using Entity;
using System;

namespace Bll
{
    /// <summary>
    /// 数据操作类
    /// </summary>
    public class BaseBll
    {
        /// <summary>
        /// 插入一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool Add(Object model)
        {
            return BaseDal.Add(model);
        }

    }
}
