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
            this.inputMetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.textBox = new System.Windows.Forms.TextBox();
            this.ImageMetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tileTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.generateMetroTile = new MetroFramework.Controls.MetroTile();
            this.importPyMetroTile = new MetroFramework.Controls.MetroTile();
            this.displayQRMetroTile = new MetroFramework.Controls.MetroTile();
            this.pythonPathMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.titleMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.overallTableLayoutPanel.SuspendLayout();
            this.metroTabControl.SuspendLayout();
            this.inputMetroTabPage.SuspendLayout();
            this.ImageMetroTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tileTableLayoutPanel.SuspendLayout();
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
            this.overallTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.72549F));
            this.overallTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.overallTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.39216F));
            this.overallTableLayoutPanel.Size = new System.Drawing.Size(520, 480);
            this.overallTableLayoutPanel.TabIndex = 0;
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.inputMetroTabPage);
            this.metroTabControl.Controls.Add(this.ImageMetroTabPage);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl.Location = new System.Drawing.Point(3, 96);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(514, 381);
            this.metroTabControl.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabControl.TabIndex = 1;
            // 
            // inputMetroTabPage
            // 
            this.inputMetroTabPage.Controls.Add(this.titleMetroTextBox);
            this.inputMetroTabPage.Controls.Add(this.textBox);
            this.inputMetroTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputMetroTabPage.HorizontalScrollbarBarColor = true;
            this.inputMetroTabPage.Location = new System.Drawing.Point(4, 35);
            this.inputMetroTabPage.Name = "inputMetroTabPage";
            this.inputMetroTabPage.Size = new System.Drawing.Size(506, 342);
            this.inputMetroTabPage.TabIndex = 0;
            this.inputMetroTabPage.Text = "Message";
            this.inputMetroTabPage.VerticalScrollbarBarColor = true;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(0, 32);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(506, 310);
            this.textBox.TabIndex = 0;
            // 
            // ImageMetroTabPage
            // 
            this.ImageMetroTabPage.Controls.Add(this.pictureBox);
            this.ImageMetroTabPage.HorizontalScrollbarBarColor = true;
            this.ImageMetroTabPage.Location = new System.Drawing.Point(4, 35);
            this.ImageMetroTabPage.Name = "ImageMetroTabPage";
            this.ImageMetroTabPage.Size = new System.Drawing.Size(506, 342);
            this.ImageMetroTabPage.TabIndex = 1;
            this.ImageMetroTabPage.Text = "QR Display";
            this.ImageMetroTabPage.VerticalScrollbarBarColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.Location = new System.Drawing.Point(0, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(506, 339);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // tileTableLayoutPanel
            // 
            this.tileTableLayoutPanel.ColumnCount = 3;
            this.tileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tileTableLayoutPanel.Controls.Add(this.generateMetroTile, 0, 0);
            this.tileTableLayoutPanel.Controls.Add(this.importPyMetroTile, 0, 0);
            this.tileTableLayoutPanel.Controls.Add(this.displayQRMetroTile, 1, 0);
            this.tileTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tileTableLayoutPanel.Name = "tileTableLayoutPanel";
            this.tileTableLayoutPanel.RowCount = 1;
            this.tileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tileTableLayoutPanel.Size = new System.Drawing.Size(514, 59);
            this.tileTableLayoutPanel.TabIndex = 1;
            // 
            // generateMetroTile
            // 
            this.generateMetroTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateMetroTile.Location = new System.Drawing.Point(172, 1);
            this.generateMetroTile.Margin = new System.Windows.Forms.Padding(1);
            this.generateMetroTile.Name = "generateMetroTile";
            this.generateMetroTile.Size = new System.Drawing.Size(169, 57);
            this.generateMetroTile.Style = MetroFramework.MetroColorStyle.Teal;
            this.generateMetroTile.TabIndex = 5;
            this.generateMetroTile.Text = "[ GENERATE ]\r\nQR Code";
            this.generateMetroTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.generateMetroTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.generateMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.generateMetroTile.Click += new System.EventHandler(this.generateMetroTile_Click);
            // 
            // importPyMetroTile
            // 
            this.importPyMetroTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importPyMetroTile.Location = new System.Drawing.Point(1, 1);
            this.importPyMetroTile.Margin = new System.Windows.Forms.Padding(1);
            this.importPyMetroTile.Name = "importPyMetroTile";
            this.importPyMetroTile.Size = new System.Drawing.Size(169, 57);
            this.importPyMetroTile.Style = MetroFramework.MetroColorStyle.Lime;
            this.importPyMetroTile.TabIndex = 4;
            this.importPyMetroTile.Text = "[ IMPORT ]\r\nPython Script";
            this.importPyMetroTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.importPyMetroTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.importPyMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.importPyMetroTile.Click += new System.EventHandler(this.importPyMetroTile_Click);
            // 
            // displayQRMetroTile
            // 
            this.displayQRMetroTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayQRMetroTile.Location = new System.Drawing.Point(343, 1);
            this.displayQRMetroTile.Margin = new System.Windows.Forms.Padding(1);
            this.displayQRMetroTile.Name = "displayQRMetroTile";
            this.displayQRMetroTile.Size = new System.Drawing.Size(170, 57);
            this.displayQRMetroTile.Style = MetroFramework.MetroColorStyle.Teal;
            this.displayQRMetroTile.TabIndex = 3;
            this.displayQRMetroTile.Text = "[ DISPLAY ]\r\nQR Code";
            this.displayQRMetroTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.displayQRMetroTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.displayQRMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.displayQRMetroTile.Click += new System.EventHandler(this.displayQRMetroTile_Click);
            // 
            // pythonPathMetroTextBox
            // 
            this.pythonPathMetroTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pythonPathMetroTextBox.Location = new System.Drawing.Point(3, 68);
            this.pythonPathMetroTextBox.Name = "pythonPathMetroTextBox";
            this.pythonPathMetroTextBox.Size = new System.Drawing.Size(514, 22);
            this.pythonPathMetroTextBox.TabIndex = 2;
            this.pythonPathMetroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titleMetroTextBox
            // 
            this.titleMetroTextBox.Location = new System.Drawing.Point(0, 3);
            this.titleMetroTextBox.Name = "titleMetroTextBox";
            this.titleMetroTextBox.Size = new System.Drawing.Size(506, 23);
            this.titleMetroTextBox.TabIndex = 2;
            this.titleMetroTextBox.Text = "*.png";
            // 
            // QRCodeGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(560, 560);
            this.Controls.Add(this.overallTableLayoutPanel);
            this.DoubleBuffered = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "QRCodeGenForm";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "QRCode Generator";
            this.Load += new System.EventHandler(this.QRCodeGenForm_Load);
            this.overallTableLayoutPanel.ResumeLayout(false);
            this.metroTabControl.ResumeLayout(false);
            this.inputMetroTabPage.ResumeLayout(false);
            this.inputMetroTabPage.PerformLayout();
            this.ImageMetroTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tileTableLayoutPanel.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroTile displayQRMetroTile;
        private MetroFramework.Controls.MetroTextBox pythonPathMetroTextBox;
        private MetroFramework.Controls.MetroTile generateMetroTile;
        private MetroFramework.Controls.MetroTextBox titleMetroTextBox;
    }
}

