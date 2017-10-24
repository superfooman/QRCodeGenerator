namespace QRCodeGenerator
{
    partial class QRCodeGenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.overallTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.tileTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.inputMetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.textBox = new System.Windows.Forms.TextBox();
            this.ImageMetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.saveMetroTile = new MetroFramework.Controls.MetroTile();
            this.generateQRMetroTile = new MetroFramework.Controls.MetroTile();
            this.importPyMetroTile = new MetroFramework.Controls.MetroTile();
            this.pythonPathMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.overallTableLayoutPanel.SuspendLayout();
            this.metroTabControl.SuspendLayout();
            this.tileTableLayoutPanel.SuspendLayout();
            this.inputMetroTabPage.SuspendLayout();
            this.ImageMetroTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // overallTableLayoutPanel
            // 
            this.overallTableLayoutPanel.ColumnCount = 1;
            this.overallTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.overallTableLayoutPanel.Controls.Add(this.metroTabControl, 0, 2);
            this.overallTableLayoutPanel.Controls.Add(this.tileTableLayoutPanel, 0, 0);
            this.overallTableLayoutPanel.Controls.Add(this.pythonPathMetroTextBox, 0, 1);
            this.overallTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overallTableLayoutPanel.Location = new System.Drawing.Point(20, 60);
            this.overallTableLayoutPanel.Name = "overallTableLayoutPanel";
            this.overallTableLayoutPanel.RowCount = 3;
            this.overallTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.overallTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.overallTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.overallTableLayoutPanel.Size = new System.Drawing.Size(460, 320);
            this.overallTableLayoutPanel.TabIndex = 0;
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.inputMetroTabPage);
            this.metroTabControl.Controls.Add(this.ImageMetroTabPage);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl.Location = new System.Drawing.Point(3, 99);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 1;
            this.metroTabControl.Size = new System.Drawing.Size(454, 218);
            this.metroTabControl.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTabControl.TabIndex = 1;
            // 
            // tileTableLayoutPanel
            // 
            this.tileTableLayoutPanel.ColumnCount = 3;
            this.tileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tileTableLayoutPanel.Controls.Add(this.importPyMetroTile, 0, 0);
            this.tileTableLayoutPanel.Controls.Add(this.generateQRMetroTile, 1, 0);
            this.tileTableLayoutPanel.Controls.Add(this.saveMetroTile, 2, 0);
            this.tileTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tileTableLayoutPanel.Name = "tileTableLayoutPanel";
            this.tileTableLayoutPanel.RowCount = 1;
            this.tileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tileTableLayoutPanel.Size = new System.Drawing.Size(454, 58);
            this.tileTableLayoutPanel.TabIndex = 1;
            // 
            // inputMetroTabPage
            // 
            this.inputMetroTabPage.Controls.Add(this.textBox);
            this.inputMetroTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputMetroTabPage.HorizontalScrollbarBarColor = true;
            this.inputMetroTabPage.Location = new System.Drawing.Point(4, 35);
            this.inputMetroTabPage.Name = "inputMetroTabPage";
            this.inputMetroTabPage.Size = new System.Drawing.Size(446, 179);
            this.inputMetroTabPage.TabIndex = 0;
            this.inputMetroTabPage.Text = "Input";
            this.inputMetroTabPage.VerticalScrollbarBarColor = true;
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(446, 179);
            this.textBox.TabIndex = 0;
            // 
            // ImageMetroTabPage
            // 
            this.ImageMetroTabPage.Controls.Add(this.pictureBox);
            this.ImageMetroTabPage.HorizontalScrollbarBarColor = true;
            this.ImageMetroTabPage.Location = new System.Drawing.Point(4, 35);
            this.ImageMetroTabPage.Name = "ImageMetroTabPage";
            this.ImageMetroTabPage.Size = new System.Drawing.Size(446, 179);
            this.ImageMetroTabPage.TabIndex = 1;
            this.ImageMetroTabPage.Text = "QR Display";
            this.ImageMetroTabPage.VerticalScrollbarBarColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(440, 189);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // saveMetroTile
            // 
            this.saveMetroTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveMetroTile.Location = new System.Drawing.Point(305, 3);
            this.saveMetroTile.Name = "saveMetroTile";
            this.saveMetroTile.Size = new System.Drawing.Size(146, 52);
            this.saveMetroTile.Style = MetroFramework.MetroColorStyle.Green;
            this.saveMetroTile.TabIndex = 2;
            this.saveMetroTile.Text = "[ SAVE ]\r\nImage";
            this.saveMetroTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveMetroTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.saveMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // generateQRMetroTile
            // 
            this.generateQRMetroTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateQRMetroTile.Location = new System.Drawing.Point(154, 3);
            this.generateQRMetroTile.Name = "generateQRMetroTile";
            this.generateQRMetroTile.Size = new System.Drawing.Size(145, 52);
            this.generateQRMetroTile.Style = MetroFramework.MetroColorStyle.Teal;
            this.generateQRMetroTile.TabIndex = 3;
            this.generateQRMetroTile.Text = "[ GENERATE ]\r\nQR Code";
            this.generateQRMetroTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.generateQRMetroTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.generateQRMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // importPyMetroTile
            // 
            this.importPyMetroTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importPyMetroTile.Location = new System.Drawing.Point(3, 3);
            this.importPyMetroTile.Name = "importPyMetroTile";
            this.importPyMetroTile.Size = new System.Drawing.Size(145, 52);
            this.importPyMetroTile.Style = MetroFramework.MetroColorStyle.Blue;
            this.importPyMetroTile.TabIndex = 4;
            this.importPyMetroTile.Text = "[ IMPORT ]\r\nPython Script";
            this.importPyMetroTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.importPyMetroTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.importPyMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // pythonPathMetroTextBox
            // 
            this.pythonPathMetroTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pythonPathMetroTextBox.Location = new System.Drawing.Point(3, 67);
            this.pythonPathMetroTextBox.Name = "pythonPathMetroTextBox";
            this.pythonPathMetroTextBox.Size = new System.Drawing.Size(454, 26);
            this.pythonPathMetroTextBox.TabIndex = 2;
            // 
            // QRCodeGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.overallTableLayoutPanel);
            this.DoubleBuffered = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "QRCodeGenForm";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "QRCode Generator";
            this.Load += new System.EventHandler(this.QRCodeGenForm_Load);
            this.overallTableLayoutPanel.ResumeLayout(false);
            this.metroTabControl.ResumeLayout(false);
            this.tileTableLayoutPanel.ResumeLayout(false);
            this.inputMetroTabPage.ResumeLayout(false);
            this.inputMetroTabPage.PerformLayout();
            this.ImageMetroTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel overallTableLayoutPanel;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private System.Windows.Forms.TableLayoutPanel tileTableLayoutPanel;
        private MetroFramework.Controls.MetroTabPage inputMetroTabPage;
        private System.Windows.Forms.TextBox textBox;
        private MetroFramework.Controls.MetroTabPage ImageMetroTabPage;
        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroTile importPyMetroTile;
        private MetroFramework.Controls.MetroTile generateQRMetroTile;
        private MetroFramework.Controls.MetroTile saveMetroTile;
        private MetroFramework.Controls.MetroTextBox pythonPathMetroTextBox;
    }
}

