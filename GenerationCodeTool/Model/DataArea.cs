using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace GenerationCodeTool.Model
{
    /// <summary>
    /// 数据展示区域
    /// </summary>
    public class DataArea
    {
        private int gridIsShow;

        // 列表区域是否展示
        /// <summary>
        /// 列表区域是否展示
        /// 0：否
        /// 1：是
        /// </summary>
        public int GridIsShow
        {
            get
            {
                return gridIsShow;
            }

            set
            {
                gridIsShow = value;
            }
        }

        // 图例区域是否展示
        /// <summary>
        /// 图例区域是否展示
        /// </summary>
        public int ChartIsShow
        {
            get
            {
                return chartIsShow;
            }

            set
            {
                chartIsShow = value;
            }
        }

        private int chartIsShow;

        private GridArea gridArea;

        // 列表区域
        /// <summary>
        /// 列表区域
        /// </summary>
        public GridArea GridArea
        {
            get
            {
                return gridArea;
            }

            set
            {
                gridArea = value;
            }
        }

        // 图表区域
        /// <summary>
        /// 图表区域
        /// </summary>
        public ChartArea ChartArea
        {
            get
            {
                return chartArea;
            }

            set
            {
                chartArea = value;
            }
        }


        private ChartArea chartArea;
    }
}
