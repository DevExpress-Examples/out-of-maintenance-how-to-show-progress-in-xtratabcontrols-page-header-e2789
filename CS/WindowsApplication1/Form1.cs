using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab.Registrator;
using DevExpress.XtraTab.Drawing;
using DevExpress.XtraTab;
using System.Threading;

namespace WindowsApplication1
{
    public partial class Form1 : XtraForm
    {
        XtraTabProgressPage page = new XtraTabProgressPage();

        public Form1()
        {
            InitializeComponent();
            PaintStyleCollection.DefaultPaintStyles.Add(new MyRegistrator());
            xtraTabControl1.PaintStyleName = "MyStyle";
           
            page.Text = "Progress";
            page.ImageIndex = 0;
            xtraTabControl1.TabPages.Add(page);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                page.Progress = i;
                Thread.Sleep(20);
            }
        }
    }
}