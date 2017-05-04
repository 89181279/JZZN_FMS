using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 文件管理系统
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
           // this.DialogResult = DialogResult.OK;
        }

        internal void Show(System.Threading.Tasks.Task t)
        {
            t.Start();
            this.ShowDialog();
        }
    }
}
