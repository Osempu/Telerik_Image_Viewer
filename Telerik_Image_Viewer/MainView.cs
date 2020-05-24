using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Collections;
using Telerik_Image_Viewer.Properties;
using Telerik.WinControls.Enumerations;

namespace Telerik_Image_Viewer
{
    public partial class MainView : Telerik.WinControls.UI.RadForm
    {
        public MainView()
        {
            InitializeComponent();
        }
        private void MainView_Load(object sender, EventArgs e)
        {
            ResourceSet resourceSet = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true);
            IDictionaryEnumerator enumerator = resourceSet.GetEnumerator();

            while (enumerator.MoveNext())
            {
                string key = ((string)enumerator.Key).Replace('_', ' ');
                Image image = (Image)enumerator.Value;
                RadMenuItem item = GetImageMenuItem(key, image);
                ddbImages.Items.Add(item);
            }

            ddbImages.Items[0].PerformClick();

            ThemeResolutionService.ApplicationThemeName = "Desert";
            sbSizeMode.DefaultItem = sbSizeMode.Items["btnSizeModeZoom"];
            sbSizeMode.Text = sbSizeMode.Items["btnSizeModeZoom"].Text;
            sbSizeMode.DefaultItem.PerformClick();
        }

        private void SizeModeClick(object sender, EventArgs e)
        {
            RadMenuButtonItem item = sender as RadMenuButtonItem;
            pictureBox.SizeMode = (PictureBoxSizeMode)Convert.ToInt32(item.Tag);
            sbSizeMode.Text = item.Text;
        }

        private void BorderStyleClick(object sender, EventArgs e)
        {
            pictureBox.BorderStyle = (BorderStyle)Convert.ToInt32((sender as RadRadioButton).Tag);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(openFileDialog.FileName);
                string key = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                RadMenuItem item = GetImageMenuItem(key, bitmap);
                ddbImages.Items.Insert(0, item);
                item.PerformClick();
                pictureBox.Image = bitmap;
            }
        }


        private void ChooseImagesClick(object sender, EventArgs e)
        {
            RadMenuItem item = (sender as RadMenuItem);
            ddbImages.Image = ((Image)item.Tag).GetThumbnailImage(16, 16, null, new IntPtr());
            ddbImages.Text = item.Text;
            ddbImages.TextImageRelation = TextImageRelation.ImageBeforeText;

            pictureBox.Image = (Image)item.Tag;
            SetBackgroundColor(tbBackgroundColor.ToggleState);
        }

        private RadMenuItem GetImageMenuItem(string name, Image image)
        {
            RadMenuItem item = new RadMenuItem();
            item.Text = name;
            item.Tag = image;
            item.Image = image.GetThumbnailImage(20, 20, null, new IntPtr());
            item.Click += new EventHandler(ChooseImagesClick);
            return item;
        }

        private void SetBackgroundColor(ToggleState toggleState)
        {
            Bitmap bitmap = pictureBox.Image as Bitmap;
            Color color = bitmap.GetPixel(bitmap.Width / 2, bitmap.Height / 2);
            Color contrastingColor = Color.FromArgb(color.ToArgb() ^ 0x00ffffff);
            pictureBox.BackColor = toggleState == ToggleState.Off ? color : contrastingColor;
        }

        private void tbBackgroundColor_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            SetBackgroundColor(args.ToggleState);
        }

        private void cbHorizontalFlip_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            bool bothOff = (cbHorizontalFlip.ToggleState == ToggleState.Off) &&
                (cbVerticalFlip.ToggleState == ToggleState.Off);

            bool bothOn = (cbHorizontalFlip.ToggleState == ToggleState.On) &&
                (cbVerticalFlip.ToggleState == ToggleState.On);

            if (bothOn)
            {
                cbFlip.ToggleState = ToggleState.On;
            }else if (bothOff)
            {
                cbFlip.ToggleState = ToggleState.Off;
            }
            else
            {
                cbFlip.ToggleState = ToggleState.Indeterminate;
            }
        }

        private void cbFlip_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState != ToggleState.Indeterminate)
            {
                // unhook event handler temporarily
                cbHorizontalFlip.ToggleStateChanged -= cbHorizontalFlip_ToggleStateChanged;
                cbVerticalFlip.ToggleStateChanged -= cbHorizontalFlip_ToggleStateChanged;
                cbHorizontalFlip.ToggleState = args.ToggleState;
                cbVerticalFlip.ToggleState = args.ToggleState;
                // re-hook event handler
                cbHorizontalFlip.ToggleStateChanged += cbHorizontalFlip_ToggleStateChanged;
                cbVerticalFlip.ToggleStateChanged += cbHorizontalFlip_ToggleStateChanged;
            }
        }

        private void RotateClick(object sender, EventArgs e)
        {
            if (cbFlip.ToggleState == ToggleState.On)
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            else if (cbHorizontalFlip.ToggleState == ToggleState.On)
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
            else if (cbVerticalFlip.ToggleState == ToggleState.On)
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
            else
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox.Refresh();
        }
    }
}
