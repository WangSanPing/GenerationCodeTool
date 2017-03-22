using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace GenerationCodeTool.Model.Test
{
    public class ColumnData
    {
        /// <summary>
        /// 柱状名称
        /// </summary>
        private string name;

        /// <summary>
        /// 柱状名称
        /// (鼠标指向时tooltips显示的名称)
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        private List<string> columnDataDetail;

        [XmlArrayItem("item")]
        /// <summary>
        /// 要展示的数据
        /// </summary>
        public List<string> ColumnDataDetail
        {
            get
            {
                return columnDataDetail;
            }

            set
            {
                columnDataDetail = value;
            }
        }


        /// <summary>
        /// 柱状类型
        /// </summary>
        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        private string type;
    }
}
