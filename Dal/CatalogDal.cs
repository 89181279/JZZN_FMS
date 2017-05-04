using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Dal
{
    public class CatalogDal : DbHelperSQL
    {
        /// <summary>
        /// 获取目录树
        /// </summary>
        /// <returns></returns>
        public DataSet GetCatalogMsg(int pid) {
            string sql = string.Format("select * from Catalog where CatalogParentId={0}", pid);
            DataSet ds = Query(sql);
            return ds;
        }
    }
}
