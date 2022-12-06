using BezierModulePresentationUnit.Interfaces;
using CommonClassLib.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace BezierModulePresentationUnit.Classes
{
    /// <summary>
    /// Class representing bezier curve
    /// </summary>
    public class BezierCurve : IDrawable
    {
        private const int ARRAY_LENGTH = 1000;
        private readonly float[] xArray = new float[ARRAY_LENGTH];
        private readonly float[] yArray = new float[ARRAY_LENGTH];
        
        /// <summary>
        /// Constructor for deserialization
        /// </summary>
        public BezierCurve()
        { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="A">First point</param>
        /// <param name="B">Second point</param>
        /// <param name="C">Third point</param>
        /// <param name="D">Fourth point</param>
        /// <param name="color">Color of curve</param>
        public BezierCurve(Point A, Point B, Point C, Point D, Color color)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            Color = color;
        }

        public Point A
        {
            get;
            set;
        }
        public Point B
        {
            get;
            set;
        }
        public Point C
        {
            get;
            set;
        }
        public Point D
        {
            get;
            set;
        }
        public Color Color
        {
            get;
            set;
        }

        /// <summary>
        /// Gets list of points
        /// </summary>
        /// <returns>List of points in order A, B, C, D</returns>
        public IEnumerable<Point> GetPoints()
        {
            return new List<Point>(4)
            {
                A, B, C, D
            };
        }

        /// <summary>
        /// Gets value of function
        /// </summary>
        /// <param name="x">Argument</param>
        /// <returns>Value of function</returns>
        public float GetValue(float x)
        {
            var idx = Array.BinarySearch(xArray, x);
            return yArray[idx >= 0 ? idx : ~idx];
        }

        /// <summary>
        /// Checks if point is in any point of curve
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        public bool Contains(float x, float y)
        {
            return GetPoints().Any(p => p.Contains(x, y));
        }

        /// <summary>
        /// Calculates and draws curve
        /// </summary>
        /// <param name="drawArea">Bitmap to draw on</param>
        public void Draw(Bitmap drawArea)
        {
            float A0x = A.X;
            float A1x = 3 * (B.X - A.X);
            float A2x = 3 * (C.X - 2 * B.X + A.X);
            float A3x = D.X - 3 * C.X + 3 * B.X - A.X;

            float A0y = A.Y;
            float A1y = 3 * (B.Y - A.Y);
            float A2y = 3 * (C.Y - 2 * B.Y + A.Y);
            float A3y = D.Y - 3 * C.Y + 3 * B.Y - A.Y;

            int idx = 0;
            for (float t = 0; t <= 1 && idx < ARRAY_LENGTH; t += 1.0f / ARRAY_LENGTH, idx++)
            {
                float xf = ((A3x * t + A2x) * t + A1x) * t + A0x;
                float yf = ((A3y * t + A2y) * t + A1y) * t + A0y;

                xArray[idx] = xf;
                yArray[idx] = yf;

                int x = Utils.Round(xf * Consts.BEZIER_DRAWAREA_WIDTH + Consts.MARGIN);
                int y = Utils.Round((1 - yf) * Consts.BEZIER_DRAWAREA_HEIGHT + Consts.MARGIN);

                if (x >= 0 && x < drawArea.Width && y >= 0 && y < drawArea.Height)
                    drawArea.SetPixel(x, y, Color);
            }
        }

        /// <summary>
        /// Draws points
        /// </summary>
        /// <param name="drawArea">Bitmap to draw on</param>
        public void DrawPoint(Bitmap drawArea)
        {
            A.Draw(drawArea);
            B.Draw(drawArea);
            C.Draw(drawArea);
            D.Draw(drawArea);
        }

        public override string ToString()
        {
            return $"{Color} curve";
        }
    }
}
