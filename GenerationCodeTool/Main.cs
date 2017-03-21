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
                #region 测试数据

                PieModel pie = new PieModel();
                pie.Id = "11";
                pie.FunName = "饼图测试";
                pie.TableName = "pie_table";
                pie.DataShowType = 1;
                pie.GraphType = "pie";
                pie.Name = "我是饼图";
                pie.PieDataList = new List<PieData>();
                Random rd = new Random();
                for (int i = 0; i < 5; i++)
                {
                    PieData data = new PieData();
                    data.Name = "饼图数据" + i.ToString();
                    data.Value = rd.Next(5000).ToString();

                    pie.PieDataList.Add(data);
                }
                pie.Title = new Title();
                pie.Title.TitleText = "饼图标题";
                pie.Title.TitleSubText = "饼图子标题";
                pie.Title.X = "center";

                #endregion

                createPieXml(pie);
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
                #region 测试数据

                ColumnModel column = new ColumnModel();
                column.Id = "11";
                column.FunName = "柱状图测试";
                column.TableName = "bar_table";
                column.DataShowType = 1;
                column.Title = new Title();
                column.Title.TitleText = "柱状图标题";
                column.Title.TitleSubText = "柱状图子标题";
                column.Title.X = "center";

                column.GraphType = "bar";
                column.ColumnDataList = new List<ColumnData>();

                ColumnData data = new ColumnData();
                data.Name = "tooltips11";
                data.Type = "bar";
                data.ColumnDataDetail = new List<string>();

                ColumnData data2 = new ColumnData();
                data2.Name = "tooltips22";
                data2.Type = "bar";
                data2.ColumnDataDetail = new List<string>();

                Random rd = new Random();

                column.XAxis_data = "[";
                for (int i = 0; i < 5; i++)
                {
                    data.ColumnDataDetail.Add(rd.Next(5000).ToString());
                    data2.ColumnDataDetail.Add(rd.Next(5000).ToString());
                    column.XAxis_data += "柱状图" + i.ToString() + ",";
                }
                column.XAxis_data += "]";

                column.ColumnDataList.Add(data);
                column.ColumnDataList.Add(data2);
                #endregion

                createColumnXml(column);
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
                #region 测试数据

                GridModel grid = new GridModel();
                grid.Id = "11";
                grid.FunName = "列表测试";
                grid.TableName = "grid_table";
                grid.DataShowType = 1;
                grid.GridList = new List<FieldInfoModel>();
                for (int i = 0; i < 5; i++)
                {
                    FieldInfoModel field = new FieldInfoModel();
                    field.Field = "字段名" + i.ToString();
                    field.FieldRule = "字段展示规则" + i.ToString();
                    field.IsSearch = 1;
                    field.IsShow = 1;
                    field.IsAnalysis = 1;

                    grid.GridList.Add(field);
                }
                #endregion

                createGridXml(grid);
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
                StringReader xmlReader = Utils.XmlUtil.getStrXml(@"c:\StandardXml\Pie.xml");
                XmlSerializer xmlSer = new XmlSerializer(typeof(PieModel));
                PieModel pie = (PieModel)xmlSer.Deserialize(xmlReader);
                xmlReader.Close();
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
                StringReader xmlReader = Utils.XmlUtil.getStrXml(@"c:\StandardXml\Column.xml");
                XmlSerializer xmlSer = new XmlSerializer(typeof(ColumnModel));
                ColumnModel column = (ColumnModel)xmlSer.Deserialize(xmlReader);
                xmlReader.Close();
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
            StringReader xmlReader = Utils.XmlUtil.getStrXml(@"c:\StandardXml\grid.xml");
            XmlSerializer xmlSer = new XmlSerializer(typeof(GridModel));
            GridModel column = (GridModel)xmlSer.Deserialize(xmlReader);
            xmlReader.Close();
        }
        /// <summary>
        /// 创建饼图的Xml
        /// </summary>
        /// <param name="pie"></param>
        private void createPieXml(PieModel pie)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
                xmlDoc.AppendChild(node);
                XmlNode root = xmlDoc.CreateElement("PieModel");
                xmlDoc.AppendChild(root);
                Utils.XmlUtil.CreateNode(xmlDoc, root, nameof(pie.Id), pie.Id);
                Utils.XmlUtil.CreateNode(xmlDoc, root, nameof(pie.FunName), pie.FunName);
                Utils.XmlUtil.CreateNode(xmlDoc, root, nameof(pie.TableName), pie.TableName);
                Utils.XmlUtil.CreateNode(xmlDoc, root, nameof(pie.DataShowType), pie.DataShowType.ToString());
                Utils.XmlUtil.CreateNode(xmlDoc, root, nameof(pie.GraphType), pie.GraphType.ToString());
                Utils.XmlUtil.CreateNode(xmlDoc, root, nameof(pie.Name), pie.Name);

                XmlNode title = xmlDoc.CreateElement(nameof(pie.Title));
                root.AppendChild(title);
                Utils.XmlUtil.CreateNode(xmlDoc, title, nameof(pie.Title.TitleText), pie.Title.TitleText);
                Utils.XmlUtil.CreateNode(xmlDoc, title, nameof(pie.Title.TitleSubText), pie.Title.TitleSubText);
                Utils.XmlUtil.CreateNode(xmlDoc, title, nameof(pie.Title.X), pie.Title.X);

                XmlNode dataNode = xmlDoc.CreateElement(nameof(pie.PieDataList));
                root.AppendChild(dataNode);

                foreach (var item in pie.PieDataList)
                {
                    XmlNode itemNode = xmlDoc.CreateElement(nameof(PieData));
                    dataNode.AppendChild(itemNode);
                    Utils.XmlUtil.CreateNode(xmlDoc, itemNode, nameof(item.Name), item.Name);
                    Utils.XmlUtil.CreateNode(xmlDoc, itemNode, nameof(item.Value), item.Value);
                }

                xmlDoc.Save(@"c:\StandardXml\Pie.xml");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 创建柱状图的Xml
        /// </summary>
        /// <param name="column"></param>
        private void createColumnXml(ColumnModel column)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
                xmlDoc.AppendChild(node);
                XmlNode root = xmlDoc.CreateElement("ColumnModel");
                xmlDoc.AppendChild(root);
                Utils.XmlUtil.CreateNode(xmlDoc, root, nameof(column.Id), column.Id);
                Utils.XmlUtil.CreateNode(xmlDoc, root, nameof(column.FunName), column.FunName);
                Utils.XmlUtil.CreateNode(xmlDoc, root, nameof(column.TableName), column.TableName);
                Utils.XmlUtil.CreateNode(xmlDoc, root, nameof(column.DataShowType), column.DataShowType.ToString());
                Utils.XmlUtil.CreateNode(xmlDoc, root, nameof(column.GraphType), column.GraphType.ToString());

                XmlNode title = xmlDoc.CreateElement(nameof(column.Title));
                root.AppendChild(title);
                Utils.XmlUtil.CreateNode(xmlDoc, title, nameof(column.Title.TitleText), column.Title.TitleText);
                Utils.XmlUtil.CreateNode(xmlDoc, title, nameof(column.Title.TitleSubText), column.Title.TitleSubText);
                Utils.XmlUtil.CreateNode(xmlDoc, title, nameof(column.Title.X), column.Title.X);

                XmlNode dataNode = xmlDoc.CreateElement(nameof(column.ColumnDataList));
                root.AppendChild(dataNode);

                foreach (var ColumnData in column.ColumnDataList)
                {
                    XmlNode itemNode = xmlDoc.CreateElement(nameof(Model.ColumnData)); // ColumnData
                    dataNode.AppendChild(itemNode);
                    Utils.XmlUtil.CreateNode(xmlDoc, itemNode, nameof(ColumnData.Name), ColumnData.Name);
                    Utils.XmlUtil.CreateNode(xmlDoc, itemNode, nameof(ColumnData.Type), ColumnData.Type);
                    XmlNode columnDataDetail = xmlDoc.CreateElement(nameof(ColumnData.ColumnDataDetail)); // ColumnDataDetail
                    itemNode.AppendChild(columnDataDetail);
                    foreach (var item in ColumnData.ColumnDataDetail)
                    {
                        Utils.XmlUtil.CreateNode(xmlDoc, columnDataDetail, nameof(item), item);
                    }
                }

                xmlDoc.Save(@"c:\StandardXml\Column.xml");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 创建柱状图的Xml
        /// </summary>
        /// <param name="grid"></param>
        private void createGridXml(GridModel grid)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
                xmlDoc.AppendChild(node);
                XmlNode root = xmlDoc.CreateElement("GridModel");
                xmlDoc.AppendChild(root);
                Utils.XmlUtil.CreateNode(xmlDoc, root, nameof(grid.Id), grid.Id);
                Utils.XmlUtil.CreateNode(xmlDoc, root, nameof(grid.FunName), grid.FunName);
                Utils.XmlUtil.CreateNode(xmlDoc, root, nameof(grid.TableName), grid.TableName);
                Utils.XmlUtil.CreateNode(xmlDoc, root, nameof(grid.DataShowType), grid.DataShowType.ToString());


                XmlNode dataNode = xmlDoc.CreateElement(nameof(grid.GridList));
                root.AppendChild(dataNode);

                foreach (var gridData in grid.GridList)
                {
                    XmlNode itemNode = xmlDoc.CreateElement(nameof(FieldInfoModel)); // ColumnData
                    dataNode.AppendChild(itemNode);
                    Utils.XmlUtil.CreateNode(xmlDoc, itemNode, nameof(gridData.Field), gridData.Field);
                    Utils.XmlUtil.CreateNode(xmlDoc, itemNode, nameof(gridData.FieldRule), gridData.FieldRule);
                    Utils.XmlUtil.CreateNode(xmlDoc, itemNode, nameof(gridData.IsAnalysis), gridData.IsAnalysis.ToString());
                    Utils.XmlUtil.CreateNode(xmlDoc, itemNode, nameof(gridData.IsSearch), gridData.IsSearch.ToString());
                    Utils.XmlUtil.CreateNode(xmlDoc, itemNode, nameof(gridData.IsShow), gridData.IsShow.ToString());

                }

                xmlDoc.Save(@"c:\StandardXml\Grid.xml");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
