namespace VehicleAdministration.Win {
    partial class XafSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XafSplashScreen));
            this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.labelCopyright = new DevExpress.XtraEditors.LabelControl();
            this.labelStatus = new DevExpress.XtraEditors.LabelControl();
            this.pcApplicationName = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelSubtitle = new DevExpress.XtraEditors.LabelControl();
            this.labelApplicationName = new DevExpress.XtraEditors.LabelControl();
            this.peImage = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcApplicationName)).BeginInit();
            this.pcApplicationName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarControl
            // 
            this.progressBarControl.EditValue = 0;
            this.progressBarControl.Location = new System.Drawing.Point(184, 464);
            this.progressBarControl.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.progressBarControl.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.progressBarControl.Properties.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(0)))));
            this.progressBarControl.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.progressBarControl.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.progressBarControl.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.progressBarControl.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.progressBarControl.Properties.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.progressBarControl.Size = new System.Drawing.Size(467, 20);
            this.progressBarControl.TabIndex = 5;
            // 
            // labelCopyright
            // 
            this.labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelCopyright.Location = new System.Drawing.Point(16, 538);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(4);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(144, 16);
            this.labelCopyright.TabIndex = 6;
            this.labelCopyright.Text = "Copyright by Rüdiger Noll";
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(343, 492);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(57, 16);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Starting...";
            // 
            // pcApplicationName
            // 
            this.pcApplicationName.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pcApplicationName.Appearance.Options.UseBackColor = true;
            this.pcApplicationName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcApplicationName.ContentImage = global::VehicleAdministration.Win.Properties.Resources.Moped;
            this.pcApplicationName.Controls.Add(this.labelControl1);
            this.pcApplicationName.Controls.Add(this.labelSubtitle);
            this.pcApplicationName.Controls.Add(this.labelApplicationName);
            this.pcApplicationName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcApplicationName.Location = new System.Drawing.Point(1, 1);
            this.pcApplicationName.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pcApplicationName.Margin = new System.Windows.Forms.Padding(4);
            this.pcApplicationName.Name = "pcApplicationName";
            this.pcApplicationName.Size = new System.Drawing.Size(834, 357);
            this.pcApplicationName.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(331, 321);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(196, 32);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Administration";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(188)))));
            this.labelSubtitle.Appearance.Options.UseFont = true;
            this.labelSubtitle.Appearance.Options.UseForeColor = true;
            this.labelSubtitle.Location = new System.Drawing.Point(238, 160);
            this.labelSubtitle.Margin = new System.Windows.Forms.Padding(4);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(148, 32);
            this.labelSubtitle.TabIndex = 1;
            this.labelSubtitle.Text = "enjoy the app";
            // 
            // labelApplicationName
            // 
            this.labelApplicationName.Appearance.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationName.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelApplicationName.Appearance.Options.UseFont = true;
            this.labelApplicationName.Appearance.Options.UseForeColor = true;
            this.labelApplicationName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelApplicationName.Location = new System.Drawing.Point(304, 4);
            this.labelApplicationName.Margin = new System.Windows.Forms.Padding(4);
            this.labelApplicationName.Name = "labelApplicationName";
            this.labelApplicationName.Size = new System.Drawing.Size(95, 32);
            this.labelApplicationName.TabIndex = 0;
            this.labelApplicationName.Text = "Vehicle";
            this.labelApplicationName.Click += new System.EventHandler(this.labelApplicationName_Click);
            // 
            // peImage
            // 
            this.peImage.EditValue = ((object)(resources.GetObject("peImage.EditValue")));
            this.peImage.Location = new System.Drawing.Point(16, 15);
            this.peImage.Margin = new System.Windows.Forms.Padding(4);
            this.peImage.Name = "peImage";
            this.peImage.Properties.AllowFocused = false;
            this.peImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peImage.Properties.Appearance.Options.UseBackColor = true;
            this.peImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peImage.Properties.ShowMenu = false;
            this.peImage.Size = new System.Drawing.Size(568, 222);
            this.peImage.TabIndex = 9;
            this.peImage.Visible = false;
            // 
            // XafSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 559);
            this.Controls.Add(this.pcApplicationName);
            this.Controls.Add(this.peImage);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.progressBarControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XafSplashScreen";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcApplicationName)).EndInit();
            this.pcApplicationName.ResumeLayout(false);
            this.pcApplicationName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
        private DevExpress.XtraEditors.LabelControl labelCopyright;
        private DevExpress.XtraEditors.LabelControl labelStatus;
        private DevExpress.XtraEditors.PictureEdit peImage;
        private DevExpress.XtraEditors.PanelControl pcApplicationName;
        private DevExpress.XtraEditors.LabelControl labelSubtitle;
        private DevExpress.XtraEditors.LabelControl labelApplicationName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
