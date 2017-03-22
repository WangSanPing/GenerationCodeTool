using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace GenerationCodeTool.Model
{
    public class GridArea
    {
        private List<FieldInfoModel> fieldInfoList;

        /// <summary>
        /// 列表区域
        /// </summary>
        [XmlArrayItem("FieldInfoModel")]
        public List<FieldInfoModel> FieldInfoList
        {
            get
            {
                return fieldInfoList;
            }

            set
            {
                fieldInfoList = value;
            }
        }
    }
}
