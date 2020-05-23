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
            this.radOpenFileDialog = new Telerik.WinControls.UI.RadOpenFileDialog();
            this.btnLoad = new Telerik.WinControls.UI.RadButton();
            this.radToggleButton1 = new Telerik.WinControls.UI.RadToggleButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownButton1 = new Telerik.WinControls.UI.RadDropDownButton();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).BeginInit();
            this.radPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToggleButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelTop
            // 
            this.radPanelTop.Controls.Add(this.radDropDownButton1);
            this.radPanelTop.Controls.Add(this.radLabel1);
            this.radPanelTop.Controls.Add(this.radToggleButton1);
            this.radPanelTop.Controls.Add(this.btnLoad);
            this.radPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanelTop.Location = new System.Drawing.Point(0, 0);
            this.radPanelTop.Name = "radPanelTop";
            this.radPanelTop.Size = new System.Drawing.Size(692, 125);
            this.radPanelTop.TabIndex = 0;
            this.radPanelTop.ThemeName = "ControlDefault";
            // 
            // radOpenFileDialog
            // 
            this.radOpenFileDialog.Filter = "jpg(*.jpg)|*.jpg|png (*.png)|*.png\"";
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
            // 
            // radToggleButton1
            // 
            this.radToggleButton1.Location = new System.Drawing.Point(95, 12);
            this.radToggleButton1.Name = "radToggleButton1";
            this.radToggleButton1.Size = new System.Drawing.Size(137, 30);
            this.radToggleButton1.TabIndex = 1;
            this.radToggleButton1.Text = "radToggleButton1";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(289, 19);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(55, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "radLabel1";
            // 
            // radDropDownButton1
            // 
            this.radDropDownButton1.Location = new System.Drawing.Point(366, 12);
            this.radDropDownButton1.Name = "radDropDownButton1";
            this.radDropDownButton1.Size = new System.Drawing.Size(175, 30);
            this.radDropDownButton1.TabIndex = 3;
            this.radDropDownButton1.Text = "radDropDownButton1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radPanelTop);
            this.Name = "MainView";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Image Viewer";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).EndInit();
            this.radPanelTop.ResumeLayout(false);
            this.radPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToggleButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanelTop;
        private Telerik.WinControls.UI.RadOpenFileDialog radOpenFileDialog;
        private Telerik.WinControls.UI.RadDropDownButton radDropDownButton1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadToggleButton radToggleButton1;
        private Telerik.WinControls.UI.RadButton btnLoad;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private System.Windows.Forms.Button button1;
    }
}
