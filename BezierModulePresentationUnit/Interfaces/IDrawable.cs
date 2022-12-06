using System.Drawing;

namespace BezierModulePresentationUnit.Interfaces
{
    /// <summary>
    /// Interface for drawable object
    /// </summary>
    public interface IDrawable
    {
        void Draw(Bitmap drawArea);
        bool Contains(float x, float y);
    }
}
