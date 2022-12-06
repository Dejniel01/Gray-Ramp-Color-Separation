using BezierModulePresentationUnit.Classes;
using BezierModulePresentationUnit.Interfaces;
using CommonClassLib;
using CommonClassLib.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using Point = BezierModulePresentationUnit.Classes.Point;

namespace BezierModulePresentationUnit
{
    /// <summary>
    /// Presentation unit for bezier curve module
    /// </summary>
    public class BezierModulePresU : IBezierModule, IMovable, IColorSeparationProvider
    {
        private readonly Bitmap drawArea;
        private BezierCurve cyanCurve;
        private BezierCurve magentaCurve;
        private BezierCurve yellowCurve;
        private BezierCurve blackCurve;
        private BezierCurve[] curves;

        private ColorEnum selectedColor = ColorEnum.Cyan;
        private bool drawAll = true;
        private Point movingPoint = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="drawArea">Bitmap to draw on</param>
        public BezierModulePresU(Bitmap drawArea)
        {
            this.drawArea = drawArea;

            InitializeCurves();

            Redraw();
        }


        /// <summary>
        /// Initializes curves
        /// </summary>
        private void InitializeCurves()
        {
            cyanCurve = new BezierCurve(
                new Point(0, 0)
                {
                    MaxX = 0
                },
                new Point(0.2, 0.1),
                new Point(0.6, 0.4),
                new Point(1, 0.8)
                {
                    MinX = 1
                },
                Color.Cyan);
            magentaCurve = new BezierCurve(
                new Point(0, 0)
                {
                    MaxX = 0
                },
                new Point(0.3, 0.7),
                new Point(0.7, 0.4),
                new Point(1, 1)
                {
                    MinX = 1
                },
                Color.Magenta);
            yellowCurve = new BezierCurve(
                new Point(0, 0)
                {
                    MaxX = 0
                },
                new Point(0.4, 0.6),
                new Point(0.8, 0.8),
                new Point(1, 0.9)
                {
                    MinX = 1
                },
                Color.Yellow);
            blackCurve = new BezierCurve(
                new Point(0, 0)
                {
                    MaxX = 0
                },
                new Point(0.4, 0.4),
                new Point(0.8, 0.8),
                new Point(1, 1)
                {
                    MinX = 1
                },
                Color.Black);

            curves = new BezierCurve[4]
            {
                cyanCurve,
                magentaCurve,
                yellowCurve,
                blackCurve
            };
        }

        #region IMovable

        /// <summary>
        /// Starts moving point
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        public void StartMovingPoint(float x, float y)
        {
            movingPoint = curves[(int)selectedColor].GetPoints().FirstOrDefault(p => p.Contains(x, y));
        }

        /// <summary>
        /// Moves point
        /// </summary>
        /// <param name="x">New x coordinate</param>
        /// <param name="y">New y coordinate</param>
        /// <returns>Bool saying if anything changed</returns>
        public bool MovePoint(float x, float y)
        {
            if (movingPoint is null)
                return false;
            (movingPoint.X, movingPoint.Y) = Utils.ConvertDrawAreaXYToLogic(x, y);
            return true;
        }

        /// <summary>
        /// Stops moving point
        /// </summary>
        public void StopMovingPoint()
        {
            movingPoint = null;
        }

        #endregion

        #region IColorSeparationProvider

        /// <summary>
        /// Gets value of color function
        /// </summary>
        /// <param name="color">Color to get value</param>
        /// <param name="x">Argument</param>
        public float GetValueOfColor(ColorEnum color, float x)
        {
            return curves[(int)color].GetValue(x);
        }

        #endregion

        #region IBezierModule

        /// <summary>
        /// Redraws all curves
        /// </summary>
        public void Redraw()
        {
            using var g = Graphics.FromImage(drawArea);
            g.Clear(Color.White);

            var zz = Utils.ConvertLogicCoordinatesToDrawArea(0, 0);
            var zj = Utils.ConvertLogicCoordinatesToDrawArea(0, 1);
            var jz = Utils.ConvertLogicCoordinatesToDrawArea(1, 0);
            using var pen = new Pen(Brushes.Black)
            {
                CustomEndCap = new AdjustableArrowCap(5, 5)
            };
            g.DrawLine(pen, zz.X, zz.Y, zj.X, zj.Y);
            g.DrawLine(pen, zz.X, zz.Y, jz.X, jz.Y);

            if (drawAll)
            {
                cyanCurve.Draw(drawArea);
                magentaCurve.Draw(drawArea);
                yellowCurve.Draw(drawArea);
                blackCurve.Draw(drawArea);
            }
            else
                curves[(int)selectedColor].Draw(drawArea);

            curves[(int)selectedColor].DrawPoint(drawArea);
        }

        /// <summary>
        /// Sets mode of drawing all curves on canvas
        /// </summary>
        public void SetDrawAll(bool drawAll)
        {
            this.drawAll = drawAll;
        }

        /// <summary>
        /// Sets selected color
        /// </summary>
        public void SetSelectedColor(ColorEnum color)
        {
            selectedColor = color;
        }


        /// <summary>
        /// Sets 0% separation
        /// </summary>
        public void SetZeroPercent()
        {
            foreach(var curve in curves)
            {
                curve.A.X = curve.A.Y = 0;
                curve.B.X = 0.33f;
                curve.C.X = 0.67f;
            }

            blackCurve.B.Y = 0;
            blackCurve.C.Y = 0;
            blackCurve.D.Y = 0;

            cyanCurve.B.Y = cyanCurve.B.X;
            cyanCurve.C.Y = cyanCurve.C.X;
            cyanCurve.D.Y = 1;

            magentaCurve.D.Y = 1;
            magentaCurve.C.Y = magentaCurve.C.X - 0.1f;
            magentaCurve.B.Y = magentaCurve.B.X - 0.1f;

            yellowCurve.D.Y = 1;
            yellowCurve.B.Y = yellowCurve.B.X - 0.1f;
            yellowCurve.C.Y = yellowCurve.C.X - 0.15f;
        }

        /// <summary>
        /// Sets 100% separation
        /// </summary>
        public void SetHundredPercent()
        {
            foreach(var curve in curves)
            {
                curve.A.X = curve.A.Y = 0;
                curve.B.X = 0.33f;
                curve.C.X = 0.67f;
                curve.B.Y = curve.C.Y = curve.D.Y = 0;
            }

            blackCurve.B.Y = blackCurve.B.X;
            blackCurve.C.Y = blackCurve.C.X;
            blackCurve.D.Y = 1;
        }

        /// <summary>
        /// Sets UCR separation
        /// </summary>
        public void SetUCR()
        {
            foreach(var curve in curves)
                curve.A.X = curve.A.Y = 0;

            blackCurve.B.X = 0.75f;
            blackCurve.C.X = 1;
            blackCurve.B.Y = blackCurve.C.Y = 0;
            blackCurve.D.Y = 1;

            cyanCurve.B.X = cyanCurve.C.X = 0.75f;
            cyanCurve.B.Y = cyanCurve.C.Y = 0.8f;
            cyanCurve.D.Y = 0.8f;

            magentaCurve.B.X = magentaCurve.C.X = 0.75f;
            magentaCurve.B.Y = magentaCurve.C.Y = 0.73f;
            magentaCurve.D.Y = 0.73f;

            yellowCurve.B.X = yellowCurve.B.X = 0.75f;
            yellowCurve.B.Y = yellowCurve.C.Y = 0.72f;
            yellowCurve.D.Y = 0.72f;
        }

        /// <summary>
        /// Sets GCR separation
        /// </summary>
        public void SetGCR()
        {
            foreach (var curve in curves)
                curve.A.X = curve.A.Y = 0;

            blackCurve.B.X = blackCurve.C.X = 0.75f;
            blackCurve.B.Y = 0.1f;
            blackCurve.C.Y = 0;
            blackCurve.D.Y = 1;

            cyanCurve.B.X = cyanCurve.C.X = 0.75f;
            cyanCurve.B.Y = cyanCurve.C.Y = 0.8f;
            cyanCurve.D.Y = 0.8f;

            magentaCurve.B.X = magentaCurve.C.X = 0.75f;
            magentaCurve.B.Y = magentaCurve.C.Y = 0.73f;
            magentaCurve.D.Y = 0.73f;

            yellowCurve.B.X = yellowCurve.B.X = 0.75f;
            yellowCurve.B.Y = yellowCurve.C.Y = 0.72f;
            yellowCurve.D.Y = 0.72f;
        }

        /// <summary>
        /// Serializes curves to json
        /// </summary>
        public string Serialize()
        {
            var sb = new StringBuilder();
            foreach (var curve in curves)
                sb.AppendLine(JsonSerializer.Serialize(curve, new JsonSerializerOptions()
                {
                    Converters =
                    {
                        new ColorJsonConverter()
                    }
                }));
            return sb.ToString();
        }

        /// <summary>
        /// Deserializes curves from json
        /// </summary>
        /// <param name="fileName">Json file</param>
        /// <returns>Bool saying if deserialization was succesfull</returns>
        public bool Deserialize(string fileName)
        {
            var tempCurves = new List<BezierCurve>(4);

            foreach (var line in File.ReadAllLines(fileName))
                tempCurves.Add(JsonSerializer.Deserialize<BezierCurve>(line, new JsonSerializerOptions()
                {
                    Converters =
                    {
                        new ColorJsonConverter()
                    }
                }));

            if (tempCurves.Count != 4)
                return false;

            curves = tempCurves.ToArray();
            cyanCurve = curves[0];
            magentaCurve = curves[1];
            yellowCurve = curves[2];
            blackCurve = curves[3];

            return true;
        }

        #endregion
    }
}
