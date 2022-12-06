using System;

namespace CommonClassLib.Helpers
{
    public static class Utils
	{
		/// <summary>
		/// Rounds float to closes integer
		/// </summary>
		public static int Round(float x)
		{
			if (x - (int)x < 0.5)
				return (int)x;
			return (int)x + 1;
		}

		/// <summary>
		/// Calculates distance between 2 points
		/// </summary>
		/// <param name="x1">X coordinate of first point</param>
		/// <param name="y1">Y coordinate of first point</param>
		/// <param name="x2">X coordinate of second point</param>
		/// <param name="y2">Y coordinate of second point</param>
		public static float Distance(float x1, float y1, float x2, float y2)
		{
			return (float)Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
		}

		/// <summary>
		/// Converts logical coordinates ([0, 1]x[0, 1]) to draw area coordinates
		/// </summary>
		public static (float X, float Y) ConvertLogicCoordinatesToDrawArea(float x, float y)
		{
			return (
				x * Consts.BEZIER_DRAWAREA_WIDTH + Consts.MARGIN,
				(1 - y) * Consts.BEZIER_DRAWAREA_HEIGHT + Consts.MARGIN
				);
		}

		/// <summary>
		/// Converts draw area coordinates to logical coordinates ([0, 1]x[0, 1])
		/// </summary>
		public static (float X, float Y) ConvertDrawAreaXYToLogic(float x, float y)
		{
			return (
				(x - Consts.MARGIN) / Consts.BEZIER_DRAWAREA_WIDTH,
				1 - (y - Consts.MARGIN) / Consts.BEZIER_DRAWAREA_HEIGHT
				);
		}
	}
}
