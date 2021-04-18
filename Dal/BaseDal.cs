using Entity;
using System;

namespace Dal
{
    /// <summary>
    /// 数据操作基类
    /// </summary>
    public class BaseDal
    {
        /// <summary>
        /// 插入一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool Add(object model)
        {
            using (AppDbContext db = new AppDbContext())
            {
                db.Add(model);
               return db.SaveChanges()>0;
            }
            return false;
        }

    }
}
