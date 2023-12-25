using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Wpf;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tsk8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class Model
    {

        public Model()
        {
            this.MyModel = new PlotModel { Title = "Example 1" };
            this.MyModel.Series.Add(new FunctionSeries(Math.Cos, 0, 20, 0.1, "cos(x)"));
        }

        public PlotModel MyModel { get; private set; }
    }

    //public class GraphControl : ContentControl
    //{
    //    static GraphControl()
    //    {
    //        DefaultStyleKeyProperty.OverrideMetadata(typeof(GraphControl), new FrameworkPropertyMetadata(typeof(GraphControl)));
    //    }

    //    public PlotModel PlotModel
    //    {
    //        get { return (PlotModel)GetValue(PlotModelProperty); }
    //        set { SetValue(PlotModelProperty, value); }
    //    }

    //    public static readonly DependencyProperty PlotModelProperty =
    //        DependencyProperty.Register("PlotModel", typeof(PlotModel), typeof(GraphControl), new PropertyMetadata(null));

    //    public override void OnApplyTemplate()
    //    {
    //        base.OnApplyTemplate();

    //        PlotView plotView = GetTemplateChild("PART_PlotView") as PlotView;
    //        if (plotView != null)
    //        {
    //            plotView.Model = PlotModel;
    //        }
    //    }
    //}
}