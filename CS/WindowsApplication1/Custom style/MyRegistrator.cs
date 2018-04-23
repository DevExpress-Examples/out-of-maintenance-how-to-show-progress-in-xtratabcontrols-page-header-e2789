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

namespace WindowsApplication1
{
    public class MyRegistrator : SkinViewInfoRegistrator
    {

        public MyRegistrator()
        {

        }

        public override string ViewName
        {
            get
            {
                return "MyStyle";
            }
        }

        public override BaseTabPainter CreatePainter(DevExpress.XtraTab.IXtraTab tabControl)
        {
            return new MySkinTabPainter(tabControl);
        }

    }
}
