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
using DevExpress.Utils;
using DevExpress.XtraTab.ViewInfo;

namespace WindowsApplication1
{
    public class MySkinTabPainter : SkinTabPainter
    {

        public MySkinTabPainter(IXtraTab tabControl)
            : base(tabControl)
        {

        }

        protected override void DrawHeaderPage(TabDrawArgs e, BaseTabRowViewInfo row, BaseTabPageViewInfo pInfo)
        {
            base.DrawHeaderPage(e, row, pInfo);
            XtraTabProgressPage page = pInfo.Page as XtraTabProgressPage;
            if (page == null)
                return;
            if (page.Progress == 0)
                return;

            Rectangle bounds = pInfo.Bounds;
            bounds.Inflate(-2, -2);
            bounds.X += 2;
            bounds.Width = bounds.Width * page.Progress / 100;
            Color progressColor = Color.FromArgb(0xB1, 0x21, 0xC9, 0x00);
            e.Graphics.FillRectangle(new SolidBrush(progressColor), bounds);
        }

    }
}
