using System;
using System.Collections.Generic;
using System.Text;

namespace BezierModulePresentationUnit.Interfaces
{
    /// <summary>
    /// Interface for canvas containing movable objects
    /// </summary>
    public interface IMovable
    {
        void StartMovingPoint(float x, float y);
        bool MovePoint(float x, float y);
        void StopMovingPoint();
    }
}
