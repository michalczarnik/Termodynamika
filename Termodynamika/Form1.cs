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
using Termodynamika.Models;
using Termodynamika.Solver;
using Termodynamika.Utilities;

namespace Termodynamika
{
    public partial class Form1 : Form
    {
        private InputDataModel input;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Filter = "Data Files|*.dat";
            oFD.Title = "Select a Data File";
            if (oFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                input = oFD.OpenFile().ParseFile();
                countButton.Enabled = true;
                loadFile.Enabled = false;
            }
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            if (input != null)
            {
                OutputDataModel output1 = input.Count();
                string pathToOutput1 = @"output1.dat";
                OutputDataModel output3 = input.Count(3);
                string pathToOutput3 = @"output3.dat";
                output1.WriteToFile(pathToOutput1);
                output3.WriteToFile(pathToOutput3);
            }
            else
            {
                throw new EntryPointNotFoundException("Something wen't wrong with... The input structure is null");
            }
        }
    }
}
