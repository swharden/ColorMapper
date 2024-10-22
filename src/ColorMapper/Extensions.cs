using ScottPlot;
using SkiaSharp;

namespace ColorMapper;

public static class IColormapExtensions
{
    public static ScottPlot.Image GetImage(this IColormap colormap, int height = 1, int width = 256)
    {
        using SKBitmap bmp = new(width, height);
        using SKCanvas canvas = new(bmp);
        using SKPaint paint = new() { IsStroke = true, IsAntialias = false, StrokeWidth = 1 };

        for (int x = 0; x < width; x++)
        {
            double frac = (double)x / (width - 1);
            ScottPlot.Color color = colormap.GetColor(frac);
            paint.Color = color.ToSKColor();
            canvas.DrawLine(x, 0, x, height, paint);
        }

        return new ScottPlot.Image(bmp);
    }
}