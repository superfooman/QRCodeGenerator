using System;
using MetroFramework.Forms;
using IronPython.Hosting;
using IronPython.Runtime;

namespace QRCodeGenerator
{
    public partial class QRCodeGenForm : MetroForm
    {
        public QRCodeGenForm()
        {
            InitializeComponent();
        }

        private void QRCodeGenForm_Load(object sender, EventArgs e)
        {
            metroTabControl.SelectedIndex = 0;
        }
    }
}
