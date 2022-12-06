using CommonClassLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace BezierModulePresentationUnit.Interfaces
{
    /// <summary>
    /// Interface for color separation provider
    /// </summary>
    public interface IColorSeparationProvider
    {
        float GetValueOfColor(ColorEnum color, float x);
    }
}
