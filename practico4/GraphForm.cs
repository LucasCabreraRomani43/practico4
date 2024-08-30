using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practico4
{   
    public partial class GraphForm : Form
        {
            public GraphForm()
            {
                InitializeComponent();
            }

            // Method to set the PlotModel for the PlotView
            public void SetPlotModel(PlotModel plotModel)
            {
                plotView1.Model = plotModel;
            }

            private void GraphForm_Load(object sender, EventArgs e)
            {

            }

            private void GraphForm_Load_1(object sender, EventArgs e)
            {

            }

            private void plotView2_Click(object sender, EventArgs e)
            {

            }
        }
    }
