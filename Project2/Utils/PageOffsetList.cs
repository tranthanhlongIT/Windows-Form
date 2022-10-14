using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Utils
{
    class PageOffsetList : System.ComponentModel.IListSource
    {
        private int totalItem;
        private int pageSize;

        public bool ContainsListCollection { get; protected set; }

        public PageOffsetList(int totalItem, int pageSize)
        {
            this.totalItem = totalItem;
            this.pageSize = pageSize;
        }

        public System.Collections.IList GetList()
        {
            // Return a list of page offsets based on "totalRecords" and "pageSize"
            var pageOffsets = new List<int>();
            for (int offset = 0; offset < totalItem; offset += pageSize)
                pageOffsets.Add(offset);
            return pageOffsets;
        }
    }
}
