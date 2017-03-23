using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace GenerationCodeTool.Model
{
    public class SearchArea
    {
        private List<SerachField> serachFieldList;

        public List<SerachField> SerachFieldList
        {
            get
            {
                return serachFieldList;
            }

            set
            {
                serachFieldList = value;
            }
        }
    }
}
