using System;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Forms;
using IronPython.Hosting;
using IronPython.Runtime;
using Microsoft.Scripting.Hosting;
using System.Threading;


namespace QRCodeGenerator
{
    public partial class QRCodeGenForm : MetroForm
    {
        internal IronPythonWrapper ironPython { get; set; }
        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }
        private bool initialize;

        public QRCodeGenForm()
        {
            InitializeComponent();
        }

        private void QRCodeGenForm_Load(object sender, EventArgs e)
        {
            initialize = false;
            pythonPathMetroTextBox.Text = Path.Combine(AssemblyDirectory, "qr_code.py");
        }

        private async void importPyMetroTile_Click(object sender, EventArgs e)
        {
            try
            {
                metroTabControl.SelectedIndex = 0;
                if (!File.Exists(pythonPathMetroTextBox.Text))
                {
                    throw new Exception(string.Format("qr_code.py source code file is not found in {0}", AssemblyDirectory));
                }

                if (ironPython == null)
                {
                    await Task.Run(() =>
                    {
                        ironPython = new IronPythonWrapper(pythonPathMetroTextBox.Text);
                    });
                }
                importPyMetroTile.Style = MetroColorStyle.Teal;
                initialize = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private async void generateMetroTile_Click(object sender, EventArgs e)
        {
            try
            {
                metroTabControl.SelectedIndex = 0;
                if (!initialize)
                    throw new Exception("Please import the python script (.py) before generate the QR code");

                   await Task.Run(async () =>
                {
                    var generate_qr_code = await getVariable(ironPython.Scope, "generate_qr_code");
                    var save_qr_code_image = await getVariable(ironPython.Scope, "save_qr_code_image");
                    var message = generate_qr_code(textBox.Text);
                    save_qr_code_image(message, titleMetroTextBox.Text);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void displayQRMetroTile_Click(object sender, EventArgs e)
        {
            try
            {
                metroTabControl.SelectedIndex = 1;
                string image = Path.Combine(AssemblyDirectory, titleMetroTextBox.Text);

                pictureBox.ImageLocation = image;
                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private async Task<dynamic> getVariable(ScriptScope scope, string input)
        {
            return await Task.Run(() =>
            {
                dynamic result = scope.GetVariable(input);
                return result;
            });
        }
    }
}
