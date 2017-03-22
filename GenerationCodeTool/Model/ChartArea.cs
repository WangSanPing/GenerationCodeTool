using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerationCodeTool.Model
{
    public class ChartArea
    {
      
        private string chartType;

        // 图例类型，pie:饼图，bar:柱状图
        /// <summary>
        /// 图例类型，pie:饼图，bar:柱状图
        /// </summary>
        public string ChartType
        {
            get
            {
                return chartType;
            }

            set
            {
                chartType = value;
            }
        }

        // 饼图数据
        /// <summary>
        /// 饼图数据
        /// </summary>
        public PieModel PieModel
        {
            get
            {
                return pieModel;
            }

            set
            {
                pieModel = value;
            }
        }

        private PieModel pieModel;

    }
}
