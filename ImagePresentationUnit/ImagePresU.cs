using CommonClassLib;
using System;
using System.Drawing;
using BezierModulePresentationUnit.Interfaces;
using FastBitmapLib;

namespace ImagePresentationUnit
{
    /// <summary>
    /// Image presentation module
    /// </summary>
    public class ImagePresU : IImagePresU
    {
        private readonly Bitmap sourceImage;
        private readonly Bitmap destinationImage;
        private readonly IColorSeparationProvider colorSeparationProvider;

        private ColorEnum selectedColor = ColorEnum.Cyan;
        private float[] colorValues = new float[4];
        private IAllPicturesDisplay allPicturesDisplay = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="source">Source image</param>
        /// <param name="destination">Destination image</param>
        /// <param name="colorSeparationProvider">Provider of color for separation</param>
        public ImagePresU(Bitmap source, Bitmap destination, IColorSeparationProvider colorSeparationProvider)
        {
            sourceImage = source;
            destinationImage = destination;
            this.colorSeparationProvider = colorSeparationProvider;
        }

        /// <summary>
        /// Redraws destination image
        /// </summary>
        public void Redraw()
        {
            using var fastDestinationImage = destinationImage.FastLock();
            for (int i = 0; i < sourceImage.Width; i++)
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    var rgbColor = sourceImage.GetPixel(i, j);

                    float c = 1 - rgbColor.R / 255.0f;
                    float m = 1 - rgbColor.G / 255.0f;
                    float y = 1 - rgbColor.B / 255.0f;
                    float kp = Math.Min(Math.Min(c, m), y);

                    colorValues[(int)ColorEnum.Cyan] = c - kp + colorSeparationProvider.GetValueOfColor(ColorEnum.Cyan, kp);
                    colorValues[(int)ColorEnum.Magenta] = m - kp + colorSeparationProvider.GetValueOfColor(ColorEnum.Magenta, kp);
                    colorValues[(int)ColorEnum.Yellow] = y - kp + colorSeparationProvider.GetValueOfColor(ColorEnum.Yellow, kp);
                    colorValues[(int)ColorEnum.Black] = colorSeparationProvider.GetValueOfColor(ColorEnum.Black, kp);

                    fastDestinationImage.SetPixel(i, j, GetRGBColorOfSelectedColor(colorValues[(int)selectedColor], selectedColor));

                    if(!(allPicturesDisplay is null))
                        allPicturesDisplay.SetPixel(i, j, GetRGBColorOfSelectedColor(colorValues[(int)selectedColor], selectedColor), selectedColor);
                }

        }

        /// <summary>
        /// Sets selected colors
        /// </summary>
        public void SetSelectedColor(ColorEnum color)
        {
            selectedColor = color;
        }

        /// <summary>
        /// Sets all pictures module
        /// </summary>
        public void SetAllPicturesForm(IAllPicturesDisplay display)
        {
            allPicturesDisplay = display;
        }

        /// <summary>
        /// Gets RGB value from CMYK
        /// </summary>
        /// <param name="x"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        private Color GetRGBColorOfSelectedColor(float x, ColorEnum color)
        {
            float y = 1 - x;
            switch (color)
            {
                case ColorEnum.Cyan:
                    return GetColorFromRGB(y * 255, 255, 255);
                case ColorEnum.Magenta:
                    return GetColorFromRGB(255, y * 255, 255);
                case ColorEnum.Yellow:
                    return GetColorFromRGB(255, 255, y * 255);
                case ColorEnum.Black:
                    return GetColorFromRGB(y * 255, y * 255, y * 255);
            }
            return Color.Black;
        }

        /// <summary>
        /// Gets RGB color
        /// </summary>
        /// <param name="r">Red value</param>
        /// <param name="g">Green value</param>
        /// <param name="b">Blue value</param>
        private Color GetColorFromRGB(float r, float g, float b)
        {
            return Color.FromArgb((int)Math.Max(Math.Min(r, 255), 0), (int)Math.Max(Math.Min(g, 255), 0), (int)Math.Max(Math.Min(b, 255), 0));
        }
    }
}
