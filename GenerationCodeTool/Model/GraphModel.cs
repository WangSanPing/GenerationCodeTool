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
    public class GraphModel
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

        private int isShowTitle;

        /// <summary>
        /// 是否需要展示标题
        /// </summary>
        public int IsShowTitle
        {
            get
            {
                return isShowTitle;
            }

            set
            {
                isShowTitle = value;
            }
        }
    }
}
