using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace GenerationCodeTool.Model
{
    /// <summary>
    /// 饼图
    /// </summary>
    [XmlRoot(ElementName = "PieModel")]
    public class PieModel : GraphModel
    {
        private string titleData;

        /// <summary>
        /// 标题数据
        /// </summary>
        public string TitleData
        {
            get
            {

                // 给title复赋值
                if (PieDataList != null)
                {
                    titleData = "[";
                    foreach (var item in PieDataList)
                    {
                        titleData += item.Name + ",";
                    }
                    titleData += "]";
                }
                return titleData;
            }
        }

        /// <summary>
        /// 图表名称
        /// (鼠标指向时tooltips显示的名称)
        /// </summary>
        private string name;

        /// <summary>
        /// 图表名称
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

        /// <summary>
        /// 数据
        /// </summary>
        //[XmlElement(typeof(List<PieData>))]
        public List<PieData> PieDataList
        {
            get
            {
                return pieData;
            }

            set
            {
                pieData = value;

            }
        }

        private List<PieData> pieData;
    }
}
