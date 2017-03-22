using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerationCodeTool.Model.Test
{
    /* 
  Licensed under the Apache License, Version 2.0

  http://www.apache.org/licenses/LICENSE-2.0
  */
    using System;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    namespace Xml2CSharp
    {

        public class ItemModel
        {
            public string Item { get; set; }
        }

        public class ColumnDataDetail
        {
            public List<ItemModel> ItemModel { get; set; }
        }

        public class ColumnData
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public ColumnDataDetail ColumnDataDetail { get; set; }
        }

        public class ColumnDataList
        {
            public List<ColumnData> ColumnData { get; set; }
        }

        public class ColumnModel
        {
            public string Id { get; set; }
            public string FunName { get; set; }
            public string TableName { get; set; }
            public string DataShowType { get; set; }
            public string GraphType { get; set; }
            public Title Title { get; set; }
            public ColumnDataList ColumnDataList { get; set; }
        }

    }

}
