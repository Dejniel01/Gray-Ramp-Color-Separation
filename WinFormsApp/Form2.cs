using CommonClassLib;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp
{
    /// <summary>
    /// Form for all pictures module
    /// </summary>
    public partial class Form2 : Form, IAllPicturesDisplay
    {
        private readonly Bitmap[] bitmaps;
        private readonly PictureBox[] canvases;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="sourceCanvas">Canvas with source image</param>
        public Form2(PictureBox sourceCanvas)
        {
            InitializeComponent();

            bitmaps = new Bitmap[]
            {
                new Bitmap(sourceCanvas.Image.Width, sourceCanvas.Image.Height),
                new Bitmap(sourceCanvas.Image.Width, sourceCanvas.Image.Height),
                new Bitmap(sourceCanvas.Image.Width, sourceCanvas.Image.Height),
                new Bitmap(sourceCanvas.Image.Width, sourceCanvas.Image.Height)
            };
            canvases = new PictureBox[]
            {
                CyanCanvas,
                MagentaCanvas,
                YellowCanvas,
                BlackCanvas
            };

            for (int i = 0; i < 4; i++)
            {
                canvases[i].Image = bitmaps[i];
                canvases[i].Width = sourceCanvas.Image.Width;
                canvases[i].Height = sourceCanvas.Image.Height;
            }

            tableLayoutPanel1.AutoScrollMinSize = new Size(2 * sourceCanvas.Image.Width, 2 * sourceCanvas.Image.Height);
        }

        /// <summary>
        /// Sets color of pixel on 1 bitmap
        /// </summary>
        /// <param name="x">X coordinate of pixel</param>
        /// <param name="y">Y coordinate of pixel</param>
        /// <param name="color">Colors to be set</param>
        /// <param name="colorEnum">Enum to select which CMYK bitmap will be set</param>
        public void SetPixel(int x, int y, Color color, ColorEnum colorEnum)
        {
            bitmaps[(int)colorEnum].SetPixel(x, y, color);
        }

        /// <summary>
        /// Refreshes all canvases
        /// </summary>
        public void RefreshCanvas()
        {
            foreach (var canvas in canvases)
                canvas.Refresh();
        }

        /// <summary>
        /// Closes module
        /// </summary>
        public void CloseModule()
        {
            this.Close();
        }

        /// <summary>
        /// Save generated pictures to files in format eg. {filename}_Cyan.bmp
        /// </summary>
        /// <param name="filename">Name of file</param>
        public void SavePictures(string filename)
        {
            var colors = Enum.GetValues(typeof(ColorEnum)).Cast<ColorEnum>().ToArray();
            for (int i = 0; i < colors.Length; i++)
                bitmaps[i].Save($"{filename}_{colors[i]}.bmp");
        }
    }
}
