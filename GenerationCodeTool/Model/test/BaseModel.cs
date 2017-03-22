using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace GenerationCodeTool.Model
{
    /// <summary>
    /// 基类
    /// </summary>
    public class BaseModel
    {

        /// <summary>
        /// id
        /// </summary>
        private string id;

        /// <summary>
        /// 功能名
        /// </summary>
        private string funName;

        /// <summary>
        /// 表名
        /// </summary>
        private string tableName;


        /// <summary>
        /// 数据展示类型
        /// 1:列表
        /// 2:图形
        /// </summary>
        private int dataShowType;

        /// <summary>
        /// 数据展示类型
        /// 1:列表
        /// 2:图形
        public int DataShowType
        {
            get
            {
                return dataShowType;
            }

            set
            {
                dataShowType = value;
            }
        }

        /// <summary>
        /// 表名
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
        /// <summary>
        /// 功能名
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
        /// <summary>
        /// id
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
    }
}
