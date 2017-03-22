using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerationCodeTool.Model
{
    public class GenerationModel
    {
        private string id;

        // ID
        /// <summary>
        /// ID
        /// </summary>
        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        private string funName;

        // 模块名
        /// <summary>
        /// 模块名
        /// </summary>
        public string FunName
        {
            get
            {
                return funName;
            }

            set
            {
                funName = value;
            }
        }

        private string tableName;

        // 数据模型表名
        /// <summary>
        /// 数据模型表名
        /// </summary>
        public string TableName
        {
            get
            {
                return tableName;
            }

            set
            {
                tableName = value;
            }
        }

        private SearchArea searchArea;

        // 查询区域
        /// <summary>
        /// 查询区域
        /// </summary>
        public SearchArea SearchAreas
        {
            get
            {
                return searchArea;
            }

            set
            {
                searchArea = value;
            }
        }

        // 数据展示区域
        /// <summary>
        /// 数据展示区域
        /// </summary>
        public DataArea DataArea
        {
            get
            {
                return dataArea;
            }

            set
            {
                dataArea = value;
            }
        }

        private DataArea dataArea;
    }
}
