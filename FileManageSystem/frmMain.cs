using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Dal;
using System.Collections;
using System.IO;
using System.Threading.Tasks;
namespace 文件管理系统
{
    public partial class frmMain : Form
    {
        #region 防止闪动
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion

        frmLoading frmloading = new frmLoading();
        /// <summary>
        /// 初始化
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 开始加载，判断用户权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            CreateTree();
        }

        private void CreateTree()
        {
            try
            {
                TreeNode node = new TreeNode();             //定义根节点
                node.Name = "1";                            //将类Model的各个属性赋值给根节点
                node.Text = "文件管理系统";
                treeView1.Nodes.Add(node);                  //将节点node作为treeView1的根节点
                cTree(node, node.Name);                     //调用另一个方法为根节点添加其他
                treeView1.NodeMouseClick += (s, e) => {
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        Task t = new Task(delegate()
                        {
                            Thread.Sleep(1000);                     //便于演示，开启1秒延时
                            var catalogid = (string)e.Node.Name;
                            if (catalogid != null)
                            {
                                //加载文件数据
                                DataTable dtfile = new FileDal().GetFileMsg(Convert.ToInt32(catalogid)).Tables[0];
                                if (dtfile != null && dtfile.Rows.Count > 0)
                                {
                                    this.Invoke((MethodInvoker)delegate() { this.dataGridViewFile.DataSource = dtfile; });
                                }
                                this.Invoke((MethodInvoker)delegate() { 
                                    this.groupBoxFile.Text = "[" + e.Node.Text + "]" + "共" + dtfile.Rows.Count + "份文档(下列文档点击右键可以进行操作)"; 
                                });
                            }
                            this.Invoke((MethodInvoker)delegate()
                            {
                                frmloading.Hide();
                            });
                        });
                        t.Start();
                        frmloading.ShowDialog();
                    }
                };
                treeView1.ExpandAll(); //展开所有节点
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        private void cTree(TreeNode node, string p)
        {
            DataTable dt = new CatalogDal().GetCatalogMsg(Convert.ToInt32(p)).Tables[0];
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)//历遍所有子节点，赋值并添加
                {
                    TreeNode n = new TreeNode();
                    n.Name = row["CatalogId"].ToString();
                    n.Text = row["CatalogName"].ToString();
                    n.Tag = row["CatalogParentId"].ToString();

                    node.Nodes.Add(n);
                    cTree(n, n.Name); //用递归的方法添加完整的树节点
                }
            }
        }

        /// <summary>
        /// 查询工具栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 系统菜单查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemSearch_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// toolBar各事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            switch (e.Button.Text)
            {
                case "上传文件":
                    AddFile();
                    break;
                case "查询文档":
                   
                    break;
                case "退出":
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        private void AddFile()
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    //StreamReader mySr = new StreamReader(file, UnicodeEncoding.GetEncoding("GB2312"));
                    //mySr.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// 退出系统菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 网络时间计时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCurrentTime_Tick(object sender, EventArgs e)
        {
            //toolStripStatusLabelnowtime.Text = GetServerDateTime().ToString();
        }
        /// <summary>
        /// sidebar用户事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sideBarPanelItemUser_Click(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// 退出系统自定义事件
        /// </summary>
        /// <param name="e"></param>

        protected override void OnClosing(CancelEventArgs e)
        {

        }
        /// <summary>
        /// sidebar隐藏按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHide_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Visible = false;
            splitContainer1.Panel2.Dock = DockStyle.Fill;
            buttonHide.Visible = false;
            buttonShow.Visible = true;
        }
        /// <summary>
        /// sidebar显示按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShow_Click(object sender, EventArgs e)
        {

            splitContainer1.Panel1.Visible = true;
            splitContainer1.Panel2.Dock = DockStyle.None;
            buttonShow.Visible = false;
            buttonHide.Visible = true;
        }
        /// <summary>
        /// sidebar管理员查询事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sideBarPanelItemSearch_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// sidebarSub关于事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItemAbout_Click(object sender, EventArgs e)
        {


        }
        /// <summary>
        /// sidebar调用普通用户查询界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sideBarPanelItemNormal_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 隐藏或显示SideBar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemStree_Click(object sender, EventArgs e)
        {
            if (menuItemStree.Checked == false)
            {
                menuItemStree.Checked = true;
                splitContainer1.Panel1.Visible = true;
                splitContainer1.Panel2.Dock = DockStyle.Right;
                buttonHide.Visible = true;
                buttonShow.Visible = false;

            }
            else
            {
                menuItemStree.Checked = false;
                splitContainer1.Panel1.Visible = false;
                splitContainer1.Panel2.Dock = DockStyle.Left;
                splitContainer1.Panel2.Dock = DockStyle.Top;
                buttonHide.Visible = false;
                buttonShow.Visible = true;
            }
        }
        /// <summary>
        /// 隐藏或显示工具栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemTool_Click(object sender, EventArgs e)
        {
            if (menuItemTool.Checked == false)
            {
                menuItemTool.Checked = true;
                toolBar1.Visible = true;
            }
            else
            {
                menuItemTool.Checked = false;
                toolBar1.Visible = false;
            }
        }
        /// <summary>
        /// 隐藏或显示状态栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemStatus_Click(object sender, EventArgs e)
        {
            if (menuItemStatus.Checked == false)
            {
                menuItemStatus.Checked = true;
                statusStrip1.Visible = true;
            }
            else
            {
                menuItemStatus.Checked = false;
                statusStrip1.Visible = false;
            }
        }
        /// <summary>
        /// 菜单调用用户界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemUser_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// 菜单调用录入界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemInput_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 菜单调用普通用户查询界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemNormal_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 菜单调用关于界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemAbout_Click(object sender, EventArgs e)
        {


        }

        private void sideBarPanelItemOut_Click(object sender, EventArgs e)
        {

        }


    }
}
