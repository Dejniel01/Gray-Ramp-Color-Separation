using BezierModulePresentationUnit;
using CommonClassLib;
using CommonClassLib.Helpers;
using ImagePresentationUnit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    /// <summary>
    /// Main form of app
    /// </summary>
    public partial class Form1 : Form
    {
        private readonly BezierModulePresU bezierModulePresU;
        private ImagePresU imagePresU;
        private IAllPicturesDisplay allPicturesDisplay;
        private string filename = "lena.png";

        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            var bitmap = new Bitmap(Consts.BEZIER_DRAWAREA_WIDTH + 2 * Consts.MARGIN, Consts.BEZIER_DRAWAREA_HEIGHT + 2 * Consts.MARGIN);
            this.BezierCanvas.Image = bitmap;
            bezierModulePresU = new BezierModulePresU(bitmap);

            LoadPic(filename);

            Redraw();
        }

        #region Event handlers

        /// <summary>
        /// Event handler for changing selection of color 
        /// </summary>
        private void ButtonCheckedChanged(object sender, EventArgs e)
        {
            if (CyanButton.Checked)
                SetSelectedColor(ColorEnum.Cyan);
            else if (MagentaButton.Checked)
                SetSelectedColor(ColorEnum.Magenta);
            else if (YellowButton.Checked)
                SetSelectedColor(ColorEnum.Yellow);
            else
                SetSelectedColor(ColorEnum.Black);

            bezierModulePresU.SetDrawAll(AllCheckbox.Checked);

            Redraw();
        }

        /// <summary>
        /// Event handler for clicking on bezier canvas
        /// </summary>
        private void BezierCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            bezierModulePresU.StartMovingPoint(e.X, e.Y);
        }

        /// <summary>
        /// Event handler for releasing mouse click on bezier canvas
        /// </summary>
        private void BezierCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            bezierModulePresU.StopMovingPoint();
        }

        /// <summary>
        /// Event handler for moving mouse on bezier canvas
        /// </summary>
        private void BezierCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (bezierModulePresU.MovePoint(e.X, e.Y))
                Redraw();
        }

        /// <summary>
        /// Event handler for clicking on "0%" button
        /// </summary>
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            bezierModulePresU.SetZeroPercent();
            ReloadAllPictures();
            Redraw();
        }

        /// <summary>
        /// Event handler for clicking on "100%" button
        /// </summary>
        private void HundredButton_Click(object sender, EventArgs e)
        {
            bezierModulePresU.SetHundredPercent();
            ReloadAllPictures();
            Redraw();
        }

        /// <summary>
        /// Event handler for clicking on "UCR" button
        /// </summary>
        private void UCRButton_Click(object sender, EventArgs e)
        {
            bezierModulePresU.SetUCR();
            ReloadAllPictures();
            Redraw();
        }

        /// <summary>
        /// Event handler for clicking on "GCR" button
        /// </summary>
        private void GCRButton_Click(object sender, EventArgs e)
        {
            bezierModulePresU.SetGCR();
            ReloadAllPictures();
            Redraw();
        }

        /// <summary>
        /// Event handler for clicking on "Change pic" button
        /// </summary>
        private void ChangePictureButton_Click(object sender, EventArgs e)
        {
            if (ChangePicDialog.ShowDialog() == DialogResult.OK)
                LoadPic(ChangePicDialog.FileName);
        }

        /// <summary>
        /// Event handler for clicking on "Save curves" button
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SaveCurvesDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(SaveCurvesDialog.FileName))
                File.WriteAllText(SaveCurvesDialog.FileName, bezierModulePresU.Serialize());
        }

        /// <summary>
        /// Event handler for clicking on "Load curves" button
        /// </summary>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (LoadCurvesDialog.ShowDialog() == DialogResult.OK)
            {
                if (bezierModulePresU.Deserialize(LoadCurvesDialog.FileName))
                    Redraw();
                else
                    MessageBox.Show("Error while loading saved curves. File corrupted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Event handler for clicking on "Show all pictures" button
        /// </summary>
        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            var newForm = new Form2(ImageCanvas);
            newForm.FormClosed += new FormClosedEventHandler((sender, e) =>
            {
                imagePresU.SetAllPicturesForm(null);
                allPicturesDisplay = null;
            });
            imagePresU.SetAllPicturesForm(newForm);
            allPicturesDisplay = newForm;
            newForm.Show();

            ReloadAllPictures();
        }

        /// <summary>
        /// Event handler for clicking on "Save pictures" button
        /// </summary>
        private void SavePicButton_Click(object sender, EventArgs e)
        {
            if (allPicturesDisplay is null)
            {

                var newForm = new Form2(ImageCanvas);
                imagePresU.SetAllPicturesForm(newForm);
                allPicturesDisplay = newForm;
                ReloadAllPictures();

                allPicturesDisplay.SavePictures(filename);

                imagePresU.SetAllPicturesForm(null);
                allPicturesDisplay = null;
                newForm.Close();
            }
            else
                allPicturesDisplay.SavePictures(filename);

        }

#endregion

        #region Utils

        /// <summary>
        /// Redraw all modules
        /// </summary>
        private void Redraw()
        {
            bezierModulePresU.Redraw();
            BezierCanvas.Refresh();

            imagePresU.Redraw();
            ImageCanvas.Refresh();
            SeparatedImageCanvas.Refresh();

            allPicturesDisplay?.RefreshCanvas();
        }

        /// <summary>
        /// Sets selected color in all modules
        /// </summary>
        /// <param name="color">New selected color</param>
        private void SetSelectedColor(ColorEnum color)
        {
            bezierModulePresU.SetSelectedColor(color);
            imagePresU.SetSelectedColor(color);
        }

        /// <summary>
        /// Loads picture from file specified
        /// </summary>
        /// <param name="fileName">Path to picture</param>
        private void LoadPic(string fileName)
        {
            allPicturesDisplay?.CloseModule();

            filename = fileName;

            var bitmap1 = new Bitmap(fileName);
            ImageCanvas.Image = bitmap1;
            ImageCanvas.Width = ImageCanvas.Image.Width;
            ImageCanvas.Height = ImageCanvas.Image.Height;
            var bitmap2 = new Bitmap(ImageCanvas.Image.Width, ImageCanvas.Image.Height);
            SeparatedImageCanvas.Image = bitmap2;
            SeparatedImageCanvas.Width = SeparatedImageCanvas.Image.Width;
            SeparatedImageCanvas.Height = SeparatedImageCanvas.Image.Height;
            imagePresU = new ImagePresU(bitmap1, bitmap2, bezierModulePresU);
            tableLayoutPanel3.AutoScrollMinSize = new Size(ImageCanvas.Image.Width, 2 * ImageCanvas.Image.Height);

            ButtonCheckedChanged(null, null);
        }

        /// <summary>
        /// Reloads all pictures on all pictures module
        /// </summary>
        private void ReloadAllPictures()
        {
            if (allPicturesDisplay is null)
                return;

            foreach (ColorEnum color in (ColorEnum[])Enum.GetValues(typeof(ColorEnum)))
            {
                SetSelectedColor(color);
                Redraw();
            }

            ButtonCheckedChanged(null, null);
        }

        #endregion
    }
}
