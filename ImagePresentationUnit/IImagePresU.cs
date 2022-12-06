using CommonClassLib;
using System;

namespace ImagePresentationUnit
{
    /// <summary>
    /// Interface for image presentation module
    /// </summary>
    public interface IImagePresU
    {
        void Redraw();
        void SetSelectedColor(ColorEnum color);
        void SetAllPicturesForm(IAllPicturesDisplay form);
    }
}
