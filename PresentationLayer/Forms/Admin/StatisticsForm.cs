﻿using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using SkiaSharp;
using LiveChartsCore.SkiaSharpView.WinForms;
using PresentationLayer.Reports.Categories;
using BusinessLayer.Services;

namespace PresentationLayer.Forms
{
    public partial class StatisticsForm : Form
    {
        private List<PerfomanceStats> statsList = new List<PerfomanceStats>();
        private BindingSource bindingSource = new BindingSource();
        private readonly ITeamService _teamService;

        public StatisticsForm(ITeamService teamService)
        {
            InitializeComponent();
            SetupDataBinding();
            _teamService = teamService;
            LoadDataRank();
        }

        private void SetupDataBinding()
        {
            bindingSource.DataSource = statsList;
            
        }
        public void LoadDataRank()
        {
            leagueTableDataGrip.DataSource = _teamService.GetRankedTeams();

            totalMatchesLabel.Text = _teamService.GetMatchesCount().ToString();
            displayTotaFoulsLabel.Text = _teamService.GetFouslCount().ToString();
            displayCornersLabel.Text = _teamService.GetCornersCount().ToString();
        }

        private void UpdateChart()
        {
            // Get data from DataGridView instead of statsList
            var dataList = new List<PerfomanceStats>();

       

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
