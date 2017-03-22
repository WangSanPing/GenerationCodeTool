using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace GenerationCodeTool.Model
{
    /// <summary>
    /// 配置项 title
    /// </summary>
    public class Title
    {

        public Title() { }

        public Title(string titleSubText, string titleText, string x)
        {
            this.titleSubText = titleSubText;
            this.titleText = titleText;
            this.x = x;
        }

        /// <summary>
        /// 图表子标题
        /// </summary>
        private string titleSubText;
        /// <summary>
        /// 图表子标题
        /// </summary>
        [XmlElement(ElementName = "TitleSubText")]
        public string TitleSubText
        {
            get
            {
                return titleSubText;
            }

            set
            {
                titleSubText = value;
            }
        }

        /// <summary>
        /// 图表标题
        /// </summary>
        private string titleText;

        /// <summary>
        /// 图表标题
        /// </summary>
        [XmlElement(ElementName = "TitleText")]
        public string TitleText
        {
            get
            {
                return titleText;
            }

            set
            {
                titleText = value;
            }
        }

        /// <summary>
        /// 在图中的位置
        /// </summary>
        private string x;

        /// <summary>
        /// 在图中的位置
        /// center
        /// left
        /// right
        /// </summary>
        [XmlElement(ElementName = "X")]
        public string X
        {
            get
            {
                if (x != null ||
                    x.Equals("center") ||
                    x.Equals("left") ||
                    x.Equals("right"))
                {
                    return x;
                }
                else
                {
                    return x = "center";
                }
            }

            set
            {
                x = value;
            }
        }
    }
}
