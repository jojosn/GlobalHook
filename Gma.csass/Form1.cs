using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gma.UserActivityMonitor;

namespace Gma.csass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HookManager.KeyUp += HookManager_KeyUp;
        }

        private void HookManager_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
