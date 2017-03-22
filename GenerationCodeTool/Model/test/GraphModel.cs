using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace GenerationCodeTool.Model
{
    /// <summary>
    /// 图形Model
    /// </summary>
    public class GraphModel : BaseModel
    {
        /// <summary>
        /// 标题配置
        /// </summary>
        private Title title;

        [XmlElement("Title")]
        public Title Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        /// <summary>
        /// 图表类型
        /// 1：饼图
        /// 2：柱状图
        /// </summary>
        private string graphType;

        /// <summary>
        /// 图表类型
        /// 1：饼图
        /// 2：柱状图
        public string GraphType
        {
            get
            {
                return graphType;
            }

            set
            {
                graphType = value;
            }
        }
    }
}
