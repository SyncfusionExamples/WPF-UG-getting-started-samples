using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Syncfusion.UI.Xaml.Gauges;

namespace GaugeGettingStarted
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Initializing circular gauge
            SfCircularGauge sfCircularGauge = new SfCircularGauge();
            sfCircularGauge.Height = 250;
            sfCircularGauge.Width = 250;

            //Adding header
            sfCircularGauge.HeaderAlignment = HeaderAlignment.Custom;
            sfCircularGauge.GaugeHeaderPosition = new Point(0.63, 0.75);
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "Temperature (K)";
            textBlock.Height = 40;
            textBlock.Width = 140;
            textBlock.FontSize = 13;
            textBlock.Foreground = new SolidColorBrush(Colors.Black);
            textBlock.FontWeight = FontWeights.SemiBold;
            sfCircularGauge.GaugeHeader = textBlock;

            //Initializing scales for circular gauge
            CircularScale mainscale = new CircularScale();
            mainscale.RimStroke = new SolidColorBrush(Colors.LightGray);
            mainscale.RimStrokeThickness = 3;
            mainscale.LabelOffset = 0.1;

            MajorTickSetting majorTickSetting = new MajorTickSetting();
            majorTickSetting.StrokeThickness = 1;
            majorTickSetting.Length = 10;
            mainscale.MajorTickSettings = majorTickSetting;

            MinorTickSetting minorTickSetting = new MinorTickSetting();
            minorTickSetting.StrokeThickness = 1;
            minorTickSetting.Length = 5;
            mainscale.MinorTickSettings = minorTickSetting;

            //Adding range
            CircularRange circularRange = new CircularRange();
            circularRange.StartValue = 0;
            circularRange.EndValue = 60;
            circularRange.Stroke = new SolidColorBrush(Colors.Gray);
            mainscale.Ranges.Add(circularRange);

            //Adding needle pointer
            CircularPointer circularPointer = new CircularPointer();
            circularPointer.PointerType = PointerType.NeedlePointer;
            circularPointer.Value = 60;
            circularPointer.NeedleLengthFactor = 0.5;
            circularPointer.NeedlePointerType = NeedlePointerType.Triangle;
            circularPointer.PointerCapDiameter = 12;
            circularPointer.NeedlePointerStroke = (SolidColorBrush)new BrushConverter().ConvertFrom("#757575");
            circularPointer.KnobFill = (SolidColorBrush)new BrushConverter().ConvertFrom("#757575");
            circularPointer.KnobStroke = (SolidColorBrush)new BrushConverter().ConvertFrom("#757575");
            circularPointer.NeedlePointerStrokeThickness = 7;
            mainscale.Pointers.Add(circularPointer);

            //Adding range pointer
            CircularPointer circularPointer1 = new CircularPointer();
            circularPointer1.PointerType = PointerType.RangePointer;
            circularPointer1.Value = 40;
            circularPointer1.RangePointerStrokeThickness = 5;
            circularPointer1.RangePointerStroke = (SolidColorBrush)new BrushConverter().ConvertFrom("#27beb6");
            mainscale.Pointers.Add(circularPointer1);

            //Adding symbol pointer
            CircularPointer circularPointer2 = new CircularPointer();
            circularPointer2.PointerType = PointerType.SymbolPointer;
            circularPointer2.Value = 70;
            circularPointer2.SymbolPointerHeight = 12;
            circularPointer2.SymbolPointerWidth = 12;
            circularPointer2.Symbol = Symbol.InvertedTriangle;
            circularPointer2.SymbolPointerStroke = (SolidColorBrush)new BrushConverter().ConvertFrom("#757575");
            mainscale.Pointers.Add(circularPointer2);

            sfCircularGauge.Scales.Add(mainscale);

            this.Content = sfCircularGauge;
        }
    }
}
