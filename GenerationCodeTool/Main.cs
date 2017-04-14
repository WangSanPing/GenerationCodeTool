using CIS.Utils.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GenerationCodeTool.Model;
using System.Xml;
using System.Reflection;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Collections;
using GenerationCodeTool.InterFace;
using GenerationCodeTool.Implement;

namespace GenerationCodeTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.init();
        }

        /// <summary>
        /// 初始化方法
        /// </summary>
        private void init()
        {
            //this.txtSave.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + DefaultSetting._Path;
            this.txtSave.Text = "C:\\MyGeneration" + DefaultSetting._Path;

        }

        /// <summary>
        /// 数据库链接测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            object count = OracleHelper.GetSingle("select count(1) from SYS_USER t");

            MessageBox.Show(count.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                #region 校验

                if (string.IsNullOrWhiteSpace(this.txtSave.Text))
                {
                    MessageBox.Show("保存路径不能为空！");
                    return;
                }

                if (string.IsNullOrWhiteSpace(this.txtSelect.Text))
                {
                    MessageBox.Show("请选择XML文件！");
                    return;
                }

                if (!File.Exists(this.txtSelect.Text))
                {
                    MessageBox.Show("选择的XML文件不存在！");
                    return;
                }


#if DEBUG
                this.txtModule.Text = string.IsNullOrWhiteSpace(this.txtModule.Text) ? "generation" : this.txtModule.Text;
                this.txtPrimaryPath.Text = string.IsNullOrWhiteSpace(this.txtPrimaryPath.Text) ? "generation" : this.txtPrimaryPath.Text;
#endif

                if (string.IsNullOrWhiteSpace(this.txtPrimaryPath.Text))
                {
                    MessageBox.Show("一级名称不能为空！");
                    return;
                }

                if (string.IsNullOrWhiteSpace(this.txtModule.Text))
                {
                    MessageBox.Show("模块名不能为空！");
                    return;
                }

                #endregion

                // 序列化XML
                StringReader xmlReader = Utils.XmlUtil.getStrXml(this.txtSelect.Text);
                XmlSerializer xmlSer = new XmlSerializer(typeof(GenerationModel));
                GenerationModel generationModel = (GenerationModel)xmlSer.Deserialize(xmlReader);
                xmlReader.Close();

                if (generationModel == null)
                {
                    MessageBox.Show("序列化XML文件存在问题，请检查格式!");
                    return;
                }
                IModule module;

                if (generationModel.DataArea.GridIsShow == (int)DefaultSetting.IsShow.YES
                    && generationModel.DataArea.ChartIsShow == (int)DefaultSetting.IsShow.NO)
                {
                    // 新建一个只有列表的模块
                    module = new GridImpl();
                }
                else
                {
                    module = new GridImpl();
                }
                GeneralPropertyModel generalPropertyModel = new GeneralPropertyModel();
                generalPropertyModel.GenerationModel = generationModel;
                generalPropertyModel.Path = this.txtSave.Text;
                generalPropertyModel.MoudleName = this.txtModule.Text;
                module.Init(generalPropertyModel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 选择文件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    this.txtSave.Text = folder.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 选择路径按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "XML文件 (*.xml)|*.xml";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.txtSelect.Text = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
