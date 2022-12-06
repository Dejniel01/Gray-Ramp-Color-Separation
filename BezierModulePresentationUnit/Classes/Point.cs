using BezierModulePresentationUnit.Interfaces;
using CommonClassLib.Helpers;
using System.Drawing;

namespace BezierModulePresentationUnit.Classes
{
    /// <summary>
    /// Class representing point
    /// </summary>
    public class Point : IDrawable
    {
        public const float POINT_RADIUS = 10;
        private float _x;
        private float _y;

        /// <summary>
        /// Constructor for json deserialization
        /// </summary>
        public Point() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        public Point(double x, double y) : this((float)x, (float)y) { }

        /// <summary>
        /// X coordinate
        /// </summary>
        public float X
        {
            get => _x;
            set
            {
                if (value < MinX)
                    _x = MinX;
                else if (value > MaxX)
                    _x = MaxX;
                else
                    _x = value;
            }
        }

        /// <summary>
        /// Y coordinate
        /// </summary>
        public float Y
        {
            get => _y;
            set
            {
                if (value < MinY)
                    _y = MinY;
                else if (value > MaxY)
                    _y = MaxY;
                else
                    _y = value;
            }
        }

        /// <summary>
        /// Minimal x value
        /// </summary>
        public float MinX
        {
            get;
            set;
        } = 0;

        /// <summary>
        /// Maximum x value
        /// </summary>
        public float MaxX
        {
            get;
            set;
        } = 1;

        /// <summary>
        /// Minimum y value
        /// </summary>
        public float MinY
        {
            get;
            set;
        } = 0;

        /// <summary>
        /// Maximum y value
        /// </summary>
        public float MaxY
        {
            get;
            set;
        } = 1;

        /// <summary>
        /// Checks if specified point is inside of point
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        public bool Contains(float x, float y)
        {
            var (thisX, thisY) = Utils.ConvertLogicCoordinatesToDrawArea(X, Y);
            return Utils.Distance(x, y, thisX, thisY) <= POINT_RADIUS;
        }

        /// <summary>
        /// Draws point
        /// </summary>
        /// <param name="drawArea">Bitmap to draw on</param>
        public void Draw(Bitmap drawArea)
        {
            using var g = Graphics.FromImage(drawArea);
            using var pen = new Pen(Brushes.Black, 2);
            var (x, y) = Utils.ConvertLogicCoordinatesToDrawArea(X, Y);
            g.DrawEllipse(pen, x - POINT_RADIUS, y - POINT_RADIUS,
                2 * POINT_RADIUS, 2 * POINT_RADIUS);
        }

        public override string ToString()
        {
            return $"Point ({X}, {Y})";
        }
    }
}
