using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Catalog
    {
        /// <summary>
        /// 分类主键
        /// </summary>
        public int CatalogId { get; set; }

        /// <summary>
        /// 分类父编号
        /// </summary>
        public int CatalogParentId { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string CatalogName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CatalogCreateTime { get; set; }

        /// <summary>
        /// 分类备注
        /// </summary>
        public string CatalogRemark { get; set; }
    }
}
