using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerationCodeTool
{
    /// <summary>
    /// 默认配置参数
    /// </summary>
    public static class DefaultSetting
    {
        #region View

        /// <summary>
        /// 默认文件夹名 GenerationJS
        /// </summary>
        public const string _Path = "\\GenerationJS";

        /// <summary>
        /// 项目名 CisdaSysteClientApp
        /// </summary>
        public const string _AppName = "CisdaSysteClientApp";

        /// <summary>
        /// 表格继承 Fm.base.Grid
        /// </summary>
        public const string _ExtendGrid = "extend";

        /// <summary>
        /// 引用 requires
        /// </summary>
        public const string _Requires = "requires";

        /// <summary>
        /// controller
        /// </summary>
        public const string _Controller = "controller";

        /// <summary>
        /// viewModel
        /// </summary>
        public const string _ViewModel = "viewModel";

        /// <summary>
        /// isPage
        /// </summary>
        public const string _IsPage = "isPage";

        /// <summary>
        /// store
        /// </summary>
        public const string _Store = "store";

        /// <summary>
        /// selection
        /// </summary>
        public const string _Selection = "selection";

        /// <summary>
        /// tbar
        /// </summary>
        public const string _Tbar = "tbar";

        /// <summary>
        /// xtype
        /// </summary>
        public const string _Xtype = "xtype";

        /// <summary>
        /// padding
        /// </summary>
        public const string _Padding = "padding";

        /// <summary>
        /// width
        /// </summary>
        public const string _Width = "width";

        /// <summary>
        /// defaults
        /// </summary>
        public const string _Defaults = "defaults";

        /// <summary>
        /// labelAlign
        /// </summary>
        public const string _LabelAlign = "labelAlign";

        /// <summary>
        /// margin
        /// </summary>
        public const string _Margin = "margin";

        /// <summary>
        /// items
        /// </summary>
        public const string _Items = "items";

        /// <summary>
        /// columns
        /// </summary>
        public const string _Columns = "columns";

        /// <summary>
        /// text
        /// </summary>
        public const string _Text = "text";

        /// <summary>
        /// dataIndex
        /// </summary>
        public const string _DataIndex = "dataIndex";

        /// <summary>
        /// align
        /// </summary>
        public const string _Align = "align";

        /// <summary>
        /// renderer
        /// </summary>
        public const string _Renderer = "renderer";

        /// <summary>
        /// flex
        /// </summary>
        public const string _Flex = "flex";

        #endregion View

        #region Controller

        #endregion Controller

        #region Model

        #endregion Model

        #region Enum

        public enum IsShow
        {
            NO = 0,
            YES
        }

        #endregion
    }
}
