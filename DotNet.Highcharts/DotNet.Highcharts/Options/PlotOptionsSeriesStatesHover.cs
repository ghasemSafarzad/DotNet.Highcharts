using System;
using System.Drawing;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Helpers;

namespace DotNet.Highcharts.Options
{
	public class PlotOptionsSeriesStatesHover
	{
		/// <summary>
		/// Enable separate styles for the hovered series to visualize that the user hovers
		/// either the series itself or the legend. Defaults to true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// Pixel with of the graph line. Defaults to 2
		/// </summary>
		public Number? LineWidth { get; set; }

		/// <summary>
		/// Defines the appearance of the point markers.
		/// </summary>
		public PlotOptionsSeriesMarker Marker { get; set; }

	}

}