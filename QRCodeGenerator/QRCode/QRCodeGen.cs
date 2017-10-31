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
using System.Drawing;

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
        private bool resize;

        public QRCodeGenForm()
        {
            InitializeComponent();
        }

        private void QRCodeGenForm_Load(object sender, EventArgs e)
        {
            initialize = false;
            resize = false;
            metroTabControl.SelectedIndex = 0;
            importPyMetroTile.Select();
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

                MessageBox.Show(string.Format("Successfully generated the QR code image (i.e. {0}) at {1}",
                    titleMetroTextBox.Text, AssemblyDirectory), "Information");
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
                if (!File.Exists(image))
                {
                    throw new Exception(string.Format("Invalid image path {0}", image));
                }

                Bitmap img = new Bitmap(image);
                pictureBox.Image = img;
                pictureBox.Size = pictureBox.Image.Size;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                exceptionMessageBox(ex.Message);
            }
        }

        private void resizeMetroTile_Click(object sender, EventArgs e)
        {
            try
            {
                metroTabControl.SelectedIndex = 1;
                if (pictureBox.Image == null)
                {
                    throw new Exception("Please display a valid image file (i.e. *.png) first");
                }

                Size size = pictureBox.Size;
                int zoom = 2;
                if (!resize)
                {
                    size.Width /= zoom;
                    size.Height /= zoom;
                }
                else
                {
                    size.Width *= zoom;
                    size.Height *= zoom;
                }
                pictureBox.Size = size;
                resize = !resize;
            }
            catch (Exception ex)
            {
                exceptionMessageBox(ex.Message);
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

        private void exceptionMessageBox(string message)
        {
            metroTabControl.SelectedIndex = 0;
            titleMetroTextBox.Select();
            pictureBox.Image = null;
            MessageBox.Show(message, "ERROR");
        }
    }
}
