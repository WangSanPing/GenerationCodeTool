using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace GenerationCodeTool.Model.Test
{
    /// <summary>
    /// 柱状图
    /// </summary>
    [XmlRoot(ElementName = "ColumnModel")]
    public class ColumnModel : GraphModel
    {

        private List<ColumnData> columnDataList;

        /// <summary>
        /// 图例数据
        /// </summary>
        public string LegendData
        {
            get
            {
                // 给title复赋值
                if (ColumnDataList != null)
                {
                    legendData = "[";
                    foreach (var item in ColumnDataList)
                    {
                        legendData += item.Name + ",";
                    }
                    legendData += "]";
                }
                return legendData;
            }
        }

        public List<ColumnData> ColumnDataList
        {
            get
            {
                return columnDataList;
            }

            set
            {
                columnDataList = value;
            }
        }

        private string legendData;


        /// <summary>
        /// 柱状标识名称
        /// </summary>
        public string XAxis_data
        {
            get
            {
                return xAxis_data;
            }

            set
            {
                xAxis_data = value;
            }
        }

        private string xAxis_data;
    }
}
