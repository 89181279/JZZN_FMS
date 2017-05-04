using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Dal
{
    public class FileDal : DbHelperSQL
    {
        /// <summary>
        /// 获取指定节点下面的文件
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        public DataSet GetFileMsg(int cid)
        {
            string sql = string.Format("select FileId,FileName,FileExt,FileSize,FileCreateUserId,FileCreateTime,State,FileUpdateUserId,FileUpdateTime from Files where FileCatalogId={0}", cid);
            DataSet ds = Query(sql);
            return ds;
        }
    }
}
