using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace GenerationCodeTool.Model
{
    public class FieldInfoModel
    {
        /// <summary>
        /// 字段名
        /// </summary>
        private string field;

        /// <summary>
        /// 字段展示规则
        /// </summary>
        private string fieldRule;

        /// <summary>
        /// 是否是查询条件
        /// 0:不是
        /// 1:是
        /// </summary>
        private int isSearch;

        /// <summary>
        /// 是否是查询条件
        /// 0:不是
        /// 1:是
        /// </summary>
        public int IsSearch
        {
            get
            {
                return isSearch;
            }

            set
            {
                isSearch = value;
            }
        }
        /// <summary>
        /// 字段展示规则
        /// </summary>
        public string FieldRule
        {
            get
            {
                return fieldRule;
            }

            set
            {
                fieldRule = value;
            }
        }
        /// <summary>
        /// 字段名
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
        /// <summary>
        /// 是否展示
        /// 0:不是
        /// 1:是
        /// </summary>
        private int isShow;

        /// <summary>
        /// 是否是下钻
        /// 0:不是
        /// 1:是
        /// </summary>
        private int isAnalysis;

        /// <summary>
        /// 是否展示
        /// </summary>
        public int IsShow
        {
            get
            {
                return isShow;
            }

            set
            {
                isShow = value;
            }
        }

        /// <summary>
        /// 是否是下钻
        /// 0:不是
        /// 1:是
        public int IsAnalysis
        {
            get
            {
                return isAnalysis;
            }

            set
            {
                isAnalysis = value;
            }
        }
    }
}
