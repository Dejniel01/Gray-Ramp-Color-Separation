using CommonClassLib;

namespace BezierModulePresentationUnit.Interfaces
{
    /// <summary>
    /// Interface for Bezier module
    /// </summary>
    public interface IBezierModule
    {
        void Redraw();
        void SetSelectedColor(ColorEnum color);
        void SetDrawAll(bool drawAll);
        void SetZeroPercent();
        void SetHundredPercent();
        void SetUCR();
        void SetGCR();
        string Serialize();
        bool Deserialize(string fileName);
    }
}
