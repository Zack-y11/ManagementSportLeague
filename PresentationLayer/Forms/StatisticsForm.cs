using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using SkiaSharp;
using LiveChartsCore.SkiaSharpView.WinForms;
using PresentationLayer.Reports.Categories;

namespace PresentationLayer.Forms
{
    public partial class StatisticsForm : Form
    {
        private List<PerfomanceStats> statsList = new List<PerfomanceStats>();
        private BindingSource bindingSource = new BindingSource();

        public StatisticsForm()
        {
            InitializeComponent();
            SetupDataBinding();
         

        }

        private void SetupDataBinding()
        {
            bindingSource.DataSource = statsList;
            perfomanceDataGrip.DataSource = bindingSource;
        }

        private void UpdateChart()
        {
            // Get data from DataGridView instead of statsList
            var dataList = new List<PerfomanceStats>();

            foreach (DataGridViewRow row in perfomanceDataGrip.Rows)
            {
                // Skip the last row if it's the new row
                if (!row.IsNewRow)
                {
                    var stats = new PerfomanceStats
                    {
                        TeamName = row.Cells["TeamName"].Value?.ToString() ?? "",
                        Points = Convert.ToInt32(row.Cells["Points"].Value),
                        GoalsFor = Convert.ToInt32(row.Cells["GoalsFor"].Value)
                    };
                    dataList.Add(stats);
                }
            }

            if (dataList.Count == 0) return;

            var cartesianChart = new CartesianChart
            {
                Series = new ISeries[]
                {
                    new ColumnSeries<int>
                    {
                        Values = dataList.Select(s => s.Points).ToArray(),
                        Name = "Points",
                        Fill = new SolidColorPaint(SKColors.Blue)
                    },
                    new LineSeries<int>
                    {
                        Values = dataList.Select(s => s.GoalsFor).ToArray(),
                        Name = "Goals For",
                        Stroke = new SolidColorPaint(SKColors.Red) { StrokeThickness = 3 }
                    }
                },
                XAxes = new Axis[]
                {
                    new Axis
                    {
                        Labels = dataList.Select(s => s.TeamName).ToArray(),
                        LabelsRotation = 45
                    }
                }
            };

            perfomanceChart.Series = cartesianChart.Series;
            perfomanceChart.XAxes = cartesianChart.XAxes;
        }

        private void updateChartBtn_Click(object sender, EventArgs e)
        {
            UpdateChart();
        }

        // Optional: Method to add data programmatically if needed
        public void AddStats(PerfomanceStats stats)
        {
            statsList.Add(stats);
            bindingSource.ResetBindings(false);
        }
    }
}
