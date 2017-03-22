using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace GenerationCodeTool.Model
{
    public class PieData
    {
        private string value;

        // 要展示的字段
        /// <summary>
        /// 要展示的字段
        /// </summary>
        public string Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        // 展示的名称
        /// <summary>
        /// 展示的名称
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

        private string name;
    }
}
