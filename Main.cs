﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subject sj = new Subject();
            sj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher tr = new Teacher();
            tr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Section sn = new Section();
            sn.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Enrollment et = new Enrollment();
            et.Show();
        }
    }
}
