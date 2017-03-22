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

namespace GenerationCodeTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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

        /// <summary>
        /// 饼图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPie_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 柱状图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColumn_Click(object sender, EventArgs e)
        {
            try
            {
  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGrid_Click(object sender, EventArgs e)
        {
            try
            {
 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 饼图读取xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 柱状图读取xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadColumn_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 列表读取xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadGrid_Click(object sender, EventArgs e)
        {

        }

    }
}
