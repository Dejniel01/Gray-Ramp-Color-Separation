﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CommonClassLib
{
    /// <summary>
    /// Interface for all pictures display
    /// </summary>
    public interface IAllPicturesDisplay
    {
        void SetPixel(int x, int y, Color color, ColorEnum colorEnum);
        void RefreshCanvas();
        void CloseModule();
        void SavePictures(string filename);
    }
}
