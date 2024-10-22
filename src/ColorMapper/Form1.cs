using ScottPlot;
using System.Diagnostics;

namespace ColorMapper;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Text = "ColorMapper 1.0";

        listBox1.Items.Add("#466be3");
        listBox1.Items.Add("#29bbec");
        listBox1.Items.Add("#30f199");
        listBox1.Items.Add("#edd03a");
        listBox1.Items.Add("#fb8023");
        listBox1.Items.Add("#d23104");

        UpdateAll();
    }

    void UpdateAll()
    {
        List<ScottPlot.Color> colors = [];

        foreach (var item in listBox1.Items)
        {
            colors.Add(ScottPlot.Color.FromHex(item.ToString()!));
        }

        IColormap cmap = new ScottPlot.Colormaps.LinearSegmented(colors.ToArray());
        UpdateColorbar(cmap);
        UpdatePlot(cmap);
    }

    void UpdateColorbar(IColormap cmap)
    {
        ScottPlot.Image img = cmap.GetImage(pictureBox1.Width, pictureBox1.Height);
        MemoryStream ms = new(img.GetImageBytes(ImageFormat.Bmp));
        System.Drawing.Bitmap bmp2 = new(ms);
        pictureBox1.Image = bmp2;
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    void UpdatePlot(IColormap cmap)
    {
        int stepCount = 256;
        double stepFrac = 1.0 / (stepCount - 1);
        double[] fracs = Enumerable.Range(0, stepCount).Select(x => x * stepFrac).ToArray();
        Debug.WriteLine(fracs.Last());

        ScottPlot.Color[] colors = fracs.Select(x => cmap.GetColor(x)).ToArray();
        double[] reds = colors.Select(x => (double)x.R).ToArray();
        double[] greens = colors.Select(x => (double)x.G).ToArray();
        double[] blues = colors.Select(x => (double)x.B).ToArray();
        double[] mean = colors.Select(x => (x.R + x.G + x.B) / 3.0).ToArray();

        formsPlot1.Plot.Clear();
        var sigR = formsPlot1.Plot.Add.Signal(reds);
        var sigG = formsPlot1.Plot.Add.Signal(greens);
        var sigB = formsPlot1.Plot.Add.Signal(blues);
        var sigM = formsPlot1.Plot.Add.Signal(mean);

        sigR.LineWidth = 1.5f;
        sigG.LineWidth = 1.5f;
        sigB.LineWidth = 1.5f;
        sigM.LineWidth = 1.5f;

        sigR.Color = Colors.Red;
        sigG.Color = Colors.Green;
        sigB.Color = Colors.Blue;
        sigM.Color = Colors.Black;
        sigM.LinePattern = ScottPlot.LinePattern.DenselyDashed;

        formsPlot1.Refresh();
    }
}
