using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Termodynamika.Models;
using Termodynamika.Solver;
using Termodynamika.Utilities;

namespace Termodynamika
{
    public partial class Form1 : Form
    {
        private InputDataModel input;
        private OutputDataModel output1;
        private OutputDataModel output3;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            SetUpCharts();
            button1.Enabled = false;
        }

        private void SetUpCharts()
        {
            chart1.Series.Clear();
            chart2.Series.Clear();

            Series chartVs = new Series();
            chartVs.ChartType = SeriesChartType.Line;
            chartVs.Name = "Vs";
            chart1.Series.Add(chartVs);

            Series chartVc = new Series();
            chartVc.ChartType = SeriesChartType.Line;
            chartVc.Name = "Vc";
            chart1.Series.Add(chartVc);

            chart1.ChartAreas.FirstOrDefault().AxisX.Title = "Vg [Nm^3/h]";
            chart1.ChartAreas.FirstOrDefault().AxisY.Title = "V [m^3/h]";

            Series chartQs = new Series();
            chartQs.ChartType = SeriesChartType.Line;
            chartQs.Name = "Qs";
            chart2.Series.Add(chartQs);

            Series chartQw = new Series();
            chartQw.ChartType = SeriesChartType.Line;
            chartQw.Name = "Qw";
            chart2.Series.Add(chartQw);

            Series chartQstr = new Series();
            chartQstr.ChartType = SeriesChartType.Line;
            chartQstr.Name = "Qstr";
            chart2.Series.Add(chartQstr);

            chart1.ChartAreas.FirstOrDefault().AxisX.Title = "Vg [Nm^3/h]";
            chart1.ChartAreas.FirstOrDefault().AxisY.Title = "V [m^3/h]";

            chart2.ChartAreas.FirstOrDefault().AxisX.Title = "Vg [Nm^3/h]";
            chart2.ChartAreas.FirstOrDefault().AxisY.Title = "Q [kW]";
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Filter = "Data Files|*.dat";
            oFD.Title = "Select a Data File";
            if (oFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    input = oFD.OpenFile().ParseFile();
                    countButton.Enabled = true;
                    loadFile.Enabled = false;
                }catch(Exception ex)
                {
                    Alert(ex.Message);
                }
            }
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            double temperature;
            if (!Helpers.ParseDouble(tempBox.Text, out temperature))
            {
                Alert("The temperature value is in incorrect form");
                statusLabel.Text = "Error";
                statusLabel.BackColor = Color.Red;
                button1.Enabled = false;
            }
            else if (input != null)
            {
                input.Temperature = temperature;
                output1 = input.Count();
                output3 = input.Count(3);
                statusLabel.Text = "Done";
                statusLabel.BackColor = Color.Green;
                button1.Enabled = true;
            }
            else
            {
                Alert("Something went wrong... The input structure is null");
                countButton.Enabled = false;
                button1.Enabled = false;
                loadFile.Enabled = true;
                statusLabel.Text = "Error";
                statusLabel.BackColor = Color.Red;
            }
        }

        public void Alert(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AddValuesToVChart(OutputDataModel o1, OutputDataModel o2)
        {
            chart1.Series["Vs"].Points.AddXY(o1.Vg, o1.Vs2);
            chart1.Series["Vs"].Points.AddXY(o2.Vg, o2.Vs2);

            chart1.Series["Vc"].Points.AddXY(o1.Vg, o1.Vc);
            chart1.Series["Vc"].Points.AddXY(o2.Vg, o2.Vc);

        }

        private void AddValuesToQChart(OutputDataModel o1, OutputDataModel o2)
        {
            chart2.Series["Qs"].Points.AddXY(o1.Vg, o1.Qs);
            chart2.Series["Qs"].Points.AddXY(o2.Vg, o2.Qs);

            chart2.Series["Qw"].Points.AddXY(o1.Vg, o1.Qw);
            chart2.Series["Qw"].Points.AddXY(o2.Vg, o2.Qw);

            chart2.Series["Qstr"].Points.AddXY(o1.Vg, o1.Qstr);
            chart2.Series["Qstr"].Points.AddXY(o2.Vg, o2.Qstr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pathToOutput1 = @"output1.dat";
            string pathToOutput3 = @"output3.dat";
            output1.WriteToFile(pathToOutput1);
            output3.WriteToFile(pathToOutput3);
            chart1.SaveImage("Chart1.png", ChartImageFormat.Png);
            chart2.SaveImage("Chart2.png", ChartImageFormat.Png);
        }
    }
}
