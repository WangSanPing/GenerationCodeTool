using GenerationCodeTool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerationCodeTool.InterFace
{
    interface IModule
    {
        /// <summary>
        /// 初始化方法
        /// </summary>
        /// <param name="generalModel">通用类</param>
        void Init(GeneralPropertyModel generalModel);
        
        void CreateView();
        void CreateController();
        void CreateViewModel();
        void CreateStore();
        void CreateModel();
    }
}
