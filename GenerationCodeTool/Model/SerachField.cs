using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerationCodeTool.Model
{
    public class SerachField
    {
        private int sourceType;

        // 来源类型 1:维度表(生成控件) 2:模型纬度字段
        /// <summary>
        /// 来源类型 1:维度表(生成控件) 2:模型纬度字段
        /// </summary>
        public int SourceType
        {
            get
            {
                return sourceType;
            }

            set
            {
                sourceType = value;
            }
        }

        private int categoryType;

        // 控件类型，1:文本 2:下拉框
        /// <summary>
        /// 控件类型，1:文本 2:下拉框
        /// </summary>
        public int CategoryType
        {
            get
            {
                return categoryType;
            }

            set
            {
                categoryType = value;
            }
        }

        private int serachType;

        // 查询方式，1:单项精确匹配 "=" 2:单项模糊匹配 "%" 3:多项匹配 "in()"
        /// <summary>
        /// 查询方式，1:单项精确匹配 "=" 2:单项模糊匹配 "%" 3:多项匹配 "in()"
        /// </summary>
        public int SerachType
        {
            get
            {
                return serachType;
            }

            set
            {
                serachType = value;
            }
        }

        private string alias;

        // 显示别名
        /// <summary>
        /// 显示别名
        /// </summary>
        public string Alias
        {
            get
            {
                return alias;
            }

            set
            {
                alias = value;
            }
        }

        private string field;

        // 模型纬度字段
        /// <summary>
        /// 模型纬度字段
        /// </summary>
        public string Field
        {
            get
            {
                return field;
            }

            set
            {
                field = value;
            }
        }

        private string length;
        // 长度
        /// <summary>
        /// 长度
        /// </summary>
        public string Length
        {
            get
            {
                return length;
            }

            set
            {
                length = value;
            }
        }

        private string width;

        // 宽度
        /// <summary>
        /// 宽度
        /// </summary>
        public string Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        private int order;

        // 排序
        /// <summary>
        /// 排序
        /// </summary>
        public int Order
        {
            get
            {
                return order;
            }

            set
            {
                order = value;
            }
        }

        // Column
        /// <summary>
        /// 所在列
        /// </summary>
        public int Column
        {
            get
            {
                return column;
            }

            set
            {
                column = value;
            }
        }

        private int column;

    }
}
