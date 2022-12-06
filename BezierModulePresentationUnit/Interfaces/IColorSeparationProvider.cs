using CommonClassLib;

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
