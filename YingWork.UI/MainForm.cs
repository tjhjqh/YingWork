using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YingWork.Data.Model.Config;

namespace YingWork.UI
{
    public partial class MainForm : Form
    {
        private readonly AppConfig _appConfig;

        public MainForm(AppConfig appConfig)
        {
            InitializeComponent();
            _appConfig = appConfig;
        }
        private void ToolStripMenuItem_SignIn_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

    }
}
