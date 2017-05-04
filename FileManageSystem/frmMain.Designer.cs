namespace 文件管理系统
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.toolBarButtonInput = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonSearch = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonExit = new System.Windows.Forms.ToolBarButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuItemView = new System.Windows.Forms.MenuItem();
            this.menuItemStree = new System.Windows.Forms.MenuItem();
            this.menuItemTool = new System.Windows.Forms.MenuItem();
            this.menuItemStatus = new System.Windows.Forms.MenuItem();
            this.menuItemFunction = new System.Windows.Forms.MenuItem();
            this.menuItemUser = new System.Windows.Forms.MenuItem();
            this.menuItemInput = new System.Windows.Forms.MenuItem();
            this.menuItemSearch = new System.Windows.Forms.MenuItem();
            this.menuItemNormal = new System.Windows.Forms.MenuItem();
            this.menuItemHelp = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.menuItemHelpDoc = new System.Windows.Forms.MenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelnowtime = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.dataGridViewFile = new System.Windows.Forms.DataGridView();
            this.Collom1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFile)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar1
            // 
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButtonInput,
            this.toolBarButtonSearch,
            this.toolBarButtonExit});
            this.toolBar1.ButtonSize = new System.Drawing.Size(50, 50);
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(892, 44);
            this.toolBar1.TabIndex = 1;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // toolBarButtonInput
            // 
            this.toolBarButtonInput.ImageIndex = 2;
            this.toolBarButtonInput.Name = "toolBarButtonInput";
            this.toolBarButtonInput.Text = "上传文件";
            // 
            // toolBarButtonSearch
            // 
            this.toolBarButtonSearch.ImageIndex = 1;
            this.toolBarButtonSearch.Name = "toolBarButtonSearch";
            this.toolBarButtonSearch.Text = "查询文档";
            // 
            // toolBarButtonExit
            // 
            this.toolBarButtonExit.ImageIndex = 0;
            this.toolBarButtonExit.Name = "toolBarButtonExit";
            this.toolBarButtonExit.Text = "退出";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Exit.bmp");
            this.imageList1.Images.SetKeyName(1, "查询.bmp");
            this.imageList1.Images.SetKeyName(2, "05.PNG");
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuItemView,
            this.menuItemFunction,
            this.menuItemHelp});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemExit});
            this.menuItemFile.Text = "文件(&F)";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 0;
            this.menuItemExit.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.menuItemExit.Text = "退出";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemView
            // 
            this.menuItemView.Index = 1;
            this.menuItemView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemStree,
            this.menuItemTool,
            this.menuItemStatus});
            this.menuItemView.Text = "视图(&V)";
            // 
            // menuItemStree
            // 
            this.menuItemStree.Checked = true;
            this.menuItemStree.Index = 0;
            this.menuItemStree.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
            this.menuItemStree.Text = "目录树";
            this.menuItemStree.Click += new System.EventHandler(this.menuItemStree_Click);
            // 
            // menuItemTool
            // 
            this.menuItemTool.Checked = true;
            this.menuItemTool.Index = 1;
            this.menuItemTool.Shortcut = System.Windows.Forms.Shortcut.CtrlT;
            this.menuItemTool.Text = "工具栏";
            this.menuItemTool.Click += new System.EventHandler(this.menuItemTool_Click);
            // 
            // menuItemStatus
            // 
            this.menuItemStatus.Checked = true;
            this.menuItemStatus.Index = 2;
            this.menuItemStatus.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuItemStatus.Text = "状态栏";
            this.menuItemStatus.Click += new System.EventHandler(this.menuItemStatus_Click);
            // 
            // menuItemFunction
            // 
            this.menuItemFunction.Index = 2;
            this.menuItemFunction.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemUser,
            this.menuItemInput,
            this.menuItemSearch,
            this.menuItemNormal});
            this.menuItemFunction.Text = "系统功能(&C)";
            // 
            // menuItemUser
            // 
            this.menuItemUser.Index = 0;
            this.menuItemUser.Shortcut = System.Windows.Forms.Shortcut.CtrlU;
            this.menuItemUser.Text = "用户";
            this.menuItemUser.Click += new System.EventHandler(this.menuItemUser_Click);
            // 
            // menuItemInput
            // 
            this.menuItemInput.Index = 1;
            this.menuItemInput.Shortcut = System.Windows.Forms.Shortcut.CtrlI;
            this.menuItemInput.Text = "录入";
            this.menuItemInput.Click += new System.EventHandler(this.menuItemInput_Click);
            // 
            // menuItemSearch
            // 
            this.menuItemSearch.Index = 2;
            this.menuItemSearch.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuItemSearch.Text = "管理员查询";
            this.menuItemSearch.Click += new System.EventHandler(this.menuItemSearch_Click);
            // 
            // menuItemNormal
            // 
            this.menuItemNormal.Index = 3;
            this.menuItemNormal.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuItemNormal.Text = "普通用户查询";
            this.menuItemNormal.Click += new System.EventHandler(this.menuItemNormal_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.Index = 3;
            this.menuItemHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemAbout,
            this.menuItemHelpDoc});
            this.menuItemHelp.Text = "帮助(&H)";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 0;
            this.menuItemAbout.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.menuItemAbout.Text = "关于";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // menuItemHelpDoc
            // 
            this.menuItemHelpDoc.Index = 1;
            this.menuItemHelpDoc.Shortcut = System.Windows.Forms.Shortcut.CtrlH;
            this.menuItemHelpDoc.Text = "帮助文档";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelUser,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabelnowtime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 493);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(892, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(73, 20);
            this.toolStripStatusLabel1.Text = "当前用户:";
            // 
            // toolStripStatusLabelUser
            // 
            this.toolStripStatusLabelUser.Name = "toolStripStatusLabelUser";
            this.toolStripStatusLabelUser.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(133, 20);
            this.toolStripStatusLabel3.Text = "当前网络北京时间:";
            // 
            // toolStripStatusLabelnowtime
            // 
            this.toolStripStatusLabelnowtime.Name = "toolStripStatusLabelnowtime";
            this.toolStripStatusLabelnowtime.Size = new System.Drawing.Size(79, 20);
            this.toolStripStatusLabelnowtime.Text = "NowTime";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 449);
            this.label1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(31, 44);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1MinSize = 20;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxFile);
            this.splitContainer1.Size = new System.Drawing.Size(861, 449);
            this.splitContainer1.SplitterDistance = 183;
            this.splitContainer1.TabIndex = 7;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(179, 445);
            this.treeView1.TabIndex = 0;
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.BackColor = System.Drawing.Color.White;
            this.groupBoxFile.Controls.Add(this.dataGridViewFile);
            this.groupBoxFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFile.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxFile.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Size = new System.Drawing.Size(670, 445);
            this.groupBoxFile.TabIndex = 0;
            this.groupBoxFile.TabStop = false;
            this.groupBoxFile.Text = "我的文档共34份文档(下列文档点击右键可以进行操作)";
            // 
            // dataGridViewFile
            // 
            this.dataGridViewFile.AllowUserToAddRows = false;
            this.dataGridViewFile.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Collom1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column1,
            this.Column7,
            this.Column6,
            this.Column8});
            this.dataGridViewFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFile.Location = new System.Drawing.Point(3, 27);
            this.dataGridViewFile.Name = "dataGridViewFile";
            this.dataGridViewFile.ReadOnly = true;
            this.dataGridViewFile.RowHeadersVisible = false;
            this.dataGridViewFile.RowTemplate.Height = 23;
            this.dataGridViewFile.Size = new System.Drawing.Size(664, 415);
            this.dataGridViewFile.TabIndex = 0;
            // 
            // Collom1
            // 
            this.Collom1.DataPropertyName = "FileName";
            this.Collom1.HeaderText = "名称";
            this.Collom1.Name = "Collom1";
            this.Collom1.ReadOnly = true;
            this.Collom1.Width = 117;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FileExt";
            this.Column2.HeaderText = "类型";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FileSize";
            this.Column3.HeaderText = "大小";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FileCreateUserId";
            this.Column4.HeaderText = "创建人";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "FileCreateTime";
            this.Column5.HeaderText = "创建时间";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FileUpdateUserId";
            this.Column1.HeaderText = "修改人";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "FileUpdateTime";
            this.Column7.HeaderText = "修改时间";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "State";
            this.Column6.HeaderText = "状态";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "FileId";
            this.Column8.HeaderText = "编号";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // timerCurrentTime
            // 
            this.timerCurrentTime.Enabled = true;
            this.timerCurrentTime.Interval = 1000;
            this.timerCurrentTime.Tick += new System.EventHandler(this.timerCurrentTime_Tick);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(1, 66);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(29, 63);
            this.buttonShow.TabIndex = 8;
            this.buttonShow.Text = "显示";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.Location = new System.Drawing.Point(1, 66);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(29, 63);
            this.buttonHide.TabIndex = 9;
            this.buttonHide.Text = "隐藏";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(892, 518);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolBar1);
            this.Menu = this.mainMenu1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.ToolBarButton toolBarButtonExit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItemFile;
        private System.Windows.Forms.MenuItem menuItemView;
        private System.Windows.Forms.MenuItem menuItemFunction;
        private System.Windows.Forms.MenuItem menuItemHelp;
        private System.Windows.Forms.ToolBarButton toolBarButtonSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuItem menuItemExit;
        private System.Windows.Forms.MenuItem menuItemStree;
        private System.Windows.Forms.MenuItem menuItemTool;
        private System.Windows.Forms.MenuItem menuItemStatus;
        private System.Windows.Forms.MenuItem menuItemUser;
        private System.Windows.Forms.MenuItem menuItemInput;
        private System.Windows.Forms.MenuItem menuItemSearch;
        private System.Windows.Forms.MenuItem menuItemAbout;
        private System.Windows.Forms.MenuItem menuItemHelpDoc;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timerCurrentTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelnowtime;
        private System.Windows.Forms.ToolBarButton toolBarButtonInput;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.MenuItem menuItemNormal;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBoxFile;
        private System.Windows.Forms.DataGridView dataGridViewFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Collom1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

