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
    public class XtraTabProgressPage : XtraTabPage
    {

        public XtraTabProgressPage()
        {

        }

        private int _Progress;
        public int Progress
        {
            get { return _Progress; }
            set
            {
                if (value < 0)
                    value = 0;
                if (value > 100)
                    value = 100;
                _Progress = value;
                OnProgressChanged();
            }
        }
        private void OnProgressChanged()
        {
            Parent.Refresh();
        }

        public override string Text
        {
            get
            {
                return String.Format("{0} ({1}%) ", base.Text, Progress);
            }
            set
            {
                base.Text = value;
            }
        }
    }
}
