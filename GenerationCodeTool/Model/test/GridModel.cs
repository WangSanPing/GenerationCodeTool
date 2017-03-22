using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerationCodeTool.Model.Test
{
    /// <summary>
    /// 列表
    /// </summary>
    public class GridModel : BaseModel
    {
        private List<FieldInfoModel> gridList;

        /// <summary>
        /// 展示数据
        /// </summary>
        public List<FieldInfoModel> GridList
        {
            get
            {
                return gridList;
            }

            set
            {
                gridList = value;
            }
        }
    }
}
