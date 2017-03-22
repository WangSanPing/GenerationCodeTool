using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerationCodeTool.Model
{
    public class SearchArea
    {
        List<SerachField> serachField;

        public List<SerachField> SerachField
        {
            get
            {
                return serachField;
            }

            set
            {
                serachField = value;
            }
        }
    }
}
