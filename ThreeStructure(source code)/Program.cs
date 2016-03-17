
/*
 * 简单三次代码生成器
 * 制作：艾新草
 * 时间：2013-10-10
 * 版权问题，请保留该信息
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sql
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyGenerator());
        }
    }
}
