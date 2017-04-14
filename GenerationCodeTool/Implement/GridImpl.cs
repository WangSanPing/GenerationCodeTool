using GenerationCodeTool.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenerationCodeTool.Model;
using System.IO;
using System.Windows.Forms;
using Utils;

namespace GenerationCodeTool.Implement
{
    public class GridImpl : IModule
    {
        #region 属性

        private GeneralPropertyModel _GeneralPropertyModel;

        public GeneralPropertyModel GeneralPropertyModel
        {
            get
            {
                return _GeneralPropertyModel;
            }

            set
            {
                _GeneralPropertyModel = value;
            }
        }

        #endregion 属性

        #region 构造函数

        public GridImpl()
        {

        }

        #endregion 构造函数

        #region 方法

        public void Init(GeneralPropertyModel data)
        {
            this.GeneralPropertyModel = data;
            this.CreateView();
            //this.CreateController();
            //this.CreateViewModel();
            //this.CreateModel();
            //this.CreateStore();
        }

        #endregion 方法

        #region IModule接口实现

        public void CreateView()
        {
            try
            {
                string path = this.GeneralPropertyModel.Path + "//" + this.GeneralPropertyModel.MoudleName + ".js";
                StringBuilder sb = new StringBuilder();

#warning 待完成
                string className = DefaultSetting._AppName +
                                   "view".toPointString();


                sb.Append("text".toExtDefineString("CisdaSysteClientApp.view.test.generategrid.GenerateGrid".toSingleString()));
                string sbsss = sb.ToString();
                string texxxx = "dsadasd".toBraceString();

                FileHelper.CreateFile(path, sb.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        public void CreateController()
        {
            throw new NotImplementedException();
        }

        public void CreateModel()
        {
            throw new NotImplementedException();
        }

        public void CreateStore()
        {
            throw new NotImplementedException();
        }

        public void CreateViewModel()
        {
            throw new NotImplementedException();
        }

        #endregion IModule接口实现
    }
}
