﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaRoC
{
    public partial class Chienthang : Form
    {
        public Chienthang()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn thực sự muốn thoát", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
