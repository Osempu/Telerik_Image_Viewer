namespace Telerik_Image_Viewer
{
    partial class MainView
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
            this.radPanelTop = new Telerik.WinControls.UI.RadPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFixed3D = new Telerik.WinControls.UI.RadRadioButton();
            this.rbFixedSingle = new Telerik.WinControls.UI.RadRadioButton();
            this.rbNone = new Telerik.WinControls.UI.RadRadioButton();
            this.sbSizeMode = new Telerik.WinControls.UI.RadSplitButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.ddbImages = new Telerik.WinControls.UI.RadDropDownButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.tbBackgroundColor = new Telerik.WinControls.UI.RadToggleButton();
            this.btnLoad = new Telerik.WinControls.UI.RadButton();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.rbRotate = new Telerik.WinControls.UI.RadRepeatButton();
            this.cbFlip = new Telerik.WinControls.UI.RadCheckBox();
            this.cbHorizontalFlip = new Telerik.WinControls.UI.RadCheckBox();
            this.cbVerticalFlip = new Telerik.WinControls.UI.RadCheckBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSizeModeNormal = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.btnSizeModeStretch = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.btnSizeModeCenterimage = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.btnSizeModeZoom = new Telerik.WinControls.UI.RadMenuButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).BeginInit();
            this.radPanelTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbFixed3D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbFixedSingle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbSizeMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddbImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBackgroundColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFlip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHorizontalFlip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVerticalFlip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelTop
            // 
            this.radPanelTop.Controls.Add(this.groupBox2);
            this.radPanelTop.Controls.Add(this.groupBox1);
            this.radPanelTop.Controls.Add(this.sbSizeMode);
            this.radPanelTop.Controls.Add(this.radLabel2);
            this.radPanelTop.Controls.Add(this.ddbImages);
            this.radPanelTop.Controls.Add(this.radLabel1);
            this.radPanelTop.Controls.Add(this.tbBackgroundColor);
            this.radPanelTop.Controls.Add(this.btnLoad);
            this.radPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanelTop.Location = new System.Drawing.Point(0, 0);
            this.radPanelTop.Name = "radPanelTop";
            this.radPanelTop.Size = new System.Drawing.Size(692, 125);
            this.radPanelTop.TabIndex = 0;
            this.radPanelTop.ThemeName = "ControlDefault";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cbVerticalFlip);
            this.groupBox2.Controls.Add(this.cbHorizontalFlip);
            this.groupBox2.Controls.Add(this.cbFlip);
            this.groupBox2.Controls.Add(this.rbRotate);
            this.groupBox2.Location = new System.Drawing.Point(310, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 66);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image Rotation";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbFixed3D);
            this.groupBox1.Controls.Add(this.rbFixedSingle);
            this.groupBox1.Controls.Add(this.rbNone);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 66);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Border Style";
            // 
            // rbFixed3D
            // 
            this.rbFixed3D.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbFixed3D.Location = new System.Drawing.Point(163, 29);
            this.rbFixed3D.Name = "rbFixed3D";
            this.rbFixed3D.Size = new System.Drawing.Size(63, 18);
            this.rbFixed3D.TabIndex = 2;
            this.rbFixed3D.Tag = "2";
            this.rbFixed3D.Text = "Fixed 3D";
            this.rbFixed3D.ThemeName = "ControlDefault";
            this.rbFixed3D.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.rbFixed3D.Click += new System.EventHandler(this.BorderStyleClick);
            // 
            // rbFixedSingle
            // 
            this.rbFixedSingle.Location = new System.Drawing.Point(69, 29);
            this.rbFixedSingle.Name = "rbFixedSingle";
            this.rbFixedSingle.Size = new System.Drawing.Size(80, 18);
            this.rbFixedSingle.TabIndex = 1;
            this.rbFixedSingle.TabStop = false;
            this.rbFixedSingle.Tag = "1";
            this.rbFixedSingle.Text = "Fixed Single";
            this.rbFixedSingle.ThemeName = "ControlDefault";
            this.rbFixedSingle.Click += new System.EventHandler(this.BorderStyleClick);
            // 
            // rbNone
            // 
            this.rbNone.Location = new System.Drawing.Point(7, 29);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(48, 18);
            this.rbNone.TabIndex = 0;
            this.rbNone.TabStop = false;
            this.rbNone.Tag = "0";
            this.rbNone.Text = "None";
            this.rbNone.ThemeName = "ControlDefault";
            this.rbNone.Click += new System.EventHandler(this.BorderStyleClick);
            // 
            // sbSizeMode
            // 
            this.sbSizeMode.BackColor = System.Drawing.Color.Transparent;
            this.sbSizeMode.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnSizeModeNormal,
            this.btnSizeModeStretch,
            this.btnSizeModeCenterimage,
            this.btnSizeModeZoom});
            this.sbSizeMode.Location = new System.Drawing.Point(539, 12);
            this.sbSizeMode.Name = "sbSizeMode";
            this.sbSizeMode.Size = new System.Drawing.Size(137, 30);
            this.sbSizeMode.TabIndex = 5;
            this.sbSizeMode.Text = "Choose a size Mode";
            this.sbSizeMode.ThemeName = "ControlDefault";
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Location = new System.Drawing.Point(463, 18);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(64, 18);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Size Mode :";
            this.radLabel2.ThemeName = "ControlDefault";
            // 
            // ddbImages
            // 
            this.ddbImages.BackColor = System.Drawing.Color.Transparent;
            this.ddbImages.DropDownDirection = Telerik.WinControls.UI.RadDirection.Right;
            this.ddbImages.Location = new System.Drawing.Point(310, 12);
            this.ddbImages.Name = "ddbImages";
            this.ddbImages.Size = new System.Drawing.Size(141, 30);
            this.ddbImages.TabIndex = 3;
            this.ddbImages.Text = "Choose Imagess";
            this.ddbImages.ThemeName = "ControlDefault";
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Location = new System.Drawing.Point(250, 18);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(48, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Images :";
            this.radLabel1.ThemeName = "ControlDefault";
            // 
            // tbBackgroundColor
            // 
            this.tbBackgroundColor.BackColor = System.Drawing.Color.Transparent;
            this.tbBackgroundColor.Location = new System.Drawing.Point(101, 12);
            this.tbBackgroundColor.Name = "tbBackgroundColor";
            this.tbBackgroundColor.Size = new System.Drawing.Size(137, 30);
            this.tbBackgroundColor.TabIndex = 1;
            this.tbBackgroundColor.Text = "Contrast Background";
            this.tbBackgroundColor.ThemeName = "ControlDefault";
            this.tbBackgroundColor.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.tbBackgroundColor_ToggleStateChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(77, 30);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.ThemeName = "ControlDefault";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // rbRotate
            // 
            this.rbRotate.Interval = 1000;
            this.rbRotate.Location = new System.Drawing.Point(17, 23);
            this.rbRotate.Name = "rbRotate";
            this.rbRotate.Size = new System.Drawing.Size(74, 30);
            this.rbRotate.TabIndex = 0;
            this.rbRotate.Text = "Rotate";
            this.rbRotate.ThemeName = "ControlDefault";
            this.rbRotate.Click += new System.EventHandler(this.RotateClick);
            // 
            // cbFlip
            // 
            this.cbFlip.Location = new System.Drawing.Point(111, 29);
            this.cbFlip.Name = "cbFlip";
            this.cbFlip.Size = new System.Drawing.Size(38, 18);
            this.cbFlip.TabIndex = 1;
            this.cbFlip.Text = "Flip";
            this.cbFlip.ThemeName = "ControlDefault";
            this.cbFlip.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.cbFlip_ToggleStateChanged);
            // 
            // cbHorizontalFlip
            // 
            this.cbHorizontalFlip.Location = new System.Drawing.Point(169, 29);
            this.cbHorizontalFlip.Name = "cbHorizontalFlip";
            this.cbHorizontalFlip.Size = new System.Drawing.Size(93, 18);
            this.cbHorizontalFlip.TabIndex = 2;
            this.cbHorizontalFlip.Text = "Horizontal Flip";
            this.cbHorizontalFlip.ThemeName = "ControlDefault";
            this.cbHorizontalFlip.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.cbHorizontalFlip_ToggleStateChanged);
            // 
            // cbVerticalFlip
            // 
            this.cbVerticalFlip.Location = new System.Drawing.Point(284, 29);
            this.cbVerticalFlip.Name = "cbVerticalFlip";
            this.cbVerticalFlip.Size = new System.Drawing.Size(78, 18);
            this.cbVerticalFlip.TabIndex = 3;
            this.cbVerticalFlip.Text = "Vertical Flip";
            this.cbVerticalFlip.ThemeName = "ControlDefault";
            this.cbVerticalFlip.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.cbHorizontalFlip_ToggleStateChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(0, 131);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(692, 341);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnSizeModeNormal
            // 
            this.btnSizeModeNormal.Name = "btnSizeModeNormal";
            this.btnSizeModeNormal.Tag = "0";
            this.btnSizeModeNormal.Text = "Normal";
            this.btnSizeModeNormal.Click += new System.EventHandler(this.SizeModeClick);
            // 
            // btnSizeModeStretch
            // 
            this.btnSizeModeStretch.Name = "btnSizeModeStretch";
            this.btnSizeModeStretch.Tag = "1";
            this.btnSizeModeStretch.Text = "Stretch Image";
            this.btnSizeModeStretch.Click += new System.EventHandler(this.SizeModeClick);
            // 
            // btnSizeModeCenterimage
            // 
            this.btnSizeModeCenterimage.Name = "btnSizeModeCenterimage";
            this.btnSizeModeCenterimage.Tag = "3";
            this.btnSizeModeCenterimage.Text = "Center Image";
            this.btnSizeModeCenterimage.Click += new System.EventHandler(this.SizeModeClick);
            // 
            // btnSizeModeZoom
            // 
            this.btnSizeModeZoom.Name = "btnSizeModeZoom";
            this.btnSizeModeZoom.Tag = "4";
            this.btnSizeModeZoom.Text = "Zoom";
            this.btnSizeModeZoom.Click += new System.EventHandler(this.SizeModeClick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 470);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.radPanelTop);
            this.Name = "MainView";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Image Viewer";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).EndInit();
            this.radPanelTop.ResumeLayout(false);
            this.radPanelTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbFixed3D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbFixedSingle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbSizeMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddbImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBackgroundColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFlip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHorizontalFlip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVerticalFlip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanelTop;
        private Telerik.WinControls.UI.RadDropDownButton ddbImages;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadToggleButton tbBackgroundColor;
        private Telerik.WinControls.UI.RadButton btnLoad;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private Telerik.WinControls.UI.RadSplitButton sbSizeMode;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadRadioButton rbFixed3D;
        private Telerik.WinControls.UI.RadRadioButton rbFixedSingle;
        private Telerik.WinControls.UI.RadRadioButton rbNone;
        private Telerik.WinControls.UI.RadCheckBox cbVerticalFlip;
        private Telerik.WinControls.UI.RadCheckBox cbHorizontalFlip;
        private Telerik.WinControls.UI.RadCheckBox cbFlip;
        private Telerik.WinControls.UI.RadRepeatButton rbRotate;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Telerik.WinControls.UI.RadMenuButtonItem btnSizeModeNormal;
        private Telerik.WinControls.UI.RadMenuButtonItem btnSizeModeStretch;
        private Telerik.WinControls.UI.RadMenuButtonItem btnSizeModeCenterimage;
        private Telerik.WinControls.UI.RadMenuButtonItem btnSizeModeZoom;
    }
}
