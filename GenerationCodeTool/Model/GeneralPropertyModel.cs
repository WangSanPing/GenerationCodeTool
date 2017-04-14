using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerationCodeTool.Model
{
    /// <summary>
    /// 通用类
    /// 包含所有创建模块的条件属性
    /// </summary>
    public class GeneralPropertyModel
    {

        private string _Path;

        private string _MoudleName;

        private GenerationModel _GenerationModel;

        private string _PrimaryPathName;

        /// <summary>
        /// 数据XML
        /// </summary>
        public GenerationModel GenerationModel
        {
            get
            {
                return _GenerationModel;
            }

            set
            {
                _GenerationModel = value;
            }
        }

        /// <summary>
        /// 要保存的路径
        /// </summary>
        public string Path
        {
            get
            {
                return _Path;
            }

            set
            {
                _Path = value;
            }
        }

        /// <summary>
        /// 要保存的模块名称
        /// </summary>
        public string MoudleName
        {
            get
            {
                return _MoudleName;
            }

            set
            {
                _MoudleName = value;
            }
        }

        /// <summary>
        /// 一级名称
        /// </summary>
        public string PrimaryPathName
        {
            get
            {
                return _PrimaryPathName;
            }

            set
            {
                _PrimaryPathName = value;
            }
        }
    }
}
