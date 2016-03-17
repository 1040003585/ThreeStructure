/*
 * 简单三次代码生成器
 * 制作：艾新草
 * 时间：2013-10-10
 * 版权问题，请保留该信息
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sql
{
    public partial class FrmSelectMethod : Form
    {

        public MyGenerator form3;

        public FrmSelectMethod()
        {
            InitializeComponent();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox8.Checked)
            {
                for (int i = 0; i < panel1.Controls.Count; i++)
                {
                    ((CheckBox)panel1.Controls[i]).Checked = true;
                }
            }
            else
            {
                for (int i = 0; i < panel1.Controls.Count; i++)
                {
                    ((CheckBox)panel1.Controls[i]).Checked = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyMethod myMethod = new MyMethod();
            myMethod.MyAdd1 = this.checkBox1.Checked;
            myMethod.MyAddReturnId1 = this.checkBox2.Checked;
            myMethod.MyDelete1 = this.checkBox3.Checked;
            myMethod.MyChange1 = this.checkBox4.Checked;
            myMethod.MySelectAll1 = this.checkBox5.Checked;
            myMethod.MySelectById1 = this.checkBox6.Checked;
            myMethod.MySelectByWhere1 = this.checkBox7.Checked;
            form3.myMethod = myMethod;
            this.Close();
        }
    }
}
