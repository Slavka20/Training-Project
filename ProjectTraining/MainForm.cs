using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTraining
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSkip_Click(object sender, EventArgs e)
        {
            bool isSkipped = false;

            if (isSkipped == false)
            {
                this.WindowState = FormWindowState.Minimized;
                isSkipped = true;
            }
            else isSkipped = false;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            //bool isSkipped = true;

            //if (isSkipped == true)
            //{
            //    pnlLeft.Size = new Size(186, 411);
            //    isSkipped = false;
            //}
            //else if ()
            //{
            //    isSkipped = true;
            //}
        }
    }
}
