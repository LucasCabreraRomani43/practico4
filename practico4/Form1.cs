using OxyPlot.Series;
using OxyPlot;
using System.Security.Cryptography.Pkcs;
using System.Security.Policy;
using System.Windows.Forms;

namespace practico4
{
    public partial class lista : Form
    {
        public lista()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Bgenerar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tdesde.Text) || string.IsNullOrEmpty(Thasta.Text))
            {
                MessageBox.Show("Debe ingresar números en ambos campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listanum.Items.Clear();
                int desde = Int16.Parse(Tdesde.Text);
                int hasta = Int16.Parse(Thasta.Text);
                while (desde <= hasta)
                {
                    listanum.Items.Add(desde);
                    desde++;
                }

            }
            var plotModel = new PlotModel { Title = "Gráfico" };
            double[] ys = listanum.Items.Cast<int>().Select(x => (double)x).ToArray();
            double[] xs = Enumerable.Range(1, ys.Length).Select(x => (double)x).ToArray();
            var series = new LineSeries();
            for (int i = 0; i < xs.Length; i++)
            {
                series.Points.Add(new DataPoint(xs[i], ys[i]));
            }
            plotModel.Series.Add(series);

           
            var graphForm = new GraphForm();
            graphForm.SetPlotModel(plotModel);
            graphForm.Show();
        }

        private void Bpares_Click(object sender, EventArgs e)
        {
            if (listanum.Items.Count == 0)
            {
                MessageBox.Show("Lista de números vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listanum.Items.Clear();
                int desde = Int16.Parse(Tdesde.Text);
                int hasta = Int16.Parse(Thasta.Text);
                while (desde <= hasta)
                {
                    if (desde % 2 == 0)
                        listanum.Items.Add(desde);
                    desde++;
                }
                var plotModel = new PlotModel { Title = "Gráfico" };
                double[] ys = listanum.Items.Cast<int>().Select(x => (double)x).ToArray();
                double[] xs = Enumerable.Range(1, ys.Length).Select(x => (double)x).ToArray();
                var series = new LineSeries();
                for (int i = 0; i < xs.Length; i++)
                {
                    series.Points.Add(new DataPoint(xs[i], ys[i]));
                }
                plotModel.Series.Add(series);

                var graphForm = new GraphForm();
                graphForm.SetPlotModel(plotModel);
                graphForm.Show();

            }
        }

        private void Bimpar_Click(object sender, EventArgs e)
        {
            if (listanum.Items.Count == 0)
            {
                MessageBox.Show("Lista de números vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listanum.Items.Clear();
                int desde = Int16.Parse(Tdesde.Text);
                int hasta = Int16.Parse(Thasta.Text);
                while (desde <= hasta)
                {
                    if (desde % 2 != 0)
                        listanum.Items.Add(desde);
                    desde++;
                }
                var plotModel = new PlotModel { Title = "Gráfico" };
                double[] ys = listanum.Items.Cast<int>().Select(x => (double)x).ToArray();
                double[] xs = Enumerable.Range(1, ys.Length).Select(x => (double)x).ToArray();
                var series = new LineSeries();
                for (int i = 0; i < xs.Length; i++)
                {
                    series.Points.Add(new DataPoint(xs[i], ys[i]));
                }
                plotModel.Series.Add(series);

              
                var graphForm = new GraphForm();
                graphForm.SetPlotModel(plotModel);
                graphForm.Show();

            }
        }

        private void Bprimos_Click(object sender, EventArgs e)
        {
            if (listanum.Items.Count == 0)
            {
                MessageBox.Show("Lista de números vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listanum.Items.Clear();

                int desde = Convert.ToInt32(Tdesde.Text);
                while (desde <= Convert.ToInt32(Thasta.Text))
                {
                    bool esPrimo = true;
                    for (int i = 2; i <= Math.Sqrt(desde); i++)
                    {
                        if (desde % i == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }
                    if (esPrimo && desde > 1)
                    {
                        listanum.Items.Add(desde);
                    }
                    desde++;
                }

                var plotModel = new PlotModel { Title = "Gráfico" };
                double[] ys = listanum.Items.Cast<int>().Select(x => (double)x).ToArray();
                double[] xs = Enumerable.Range(1, ys.Length).Select(x => (double)x).ToArray();
                var series = new LineSeries();
                for (int i = 0; i < xs.Length; i++)
                {
                    series.Points.Add(new DataPoint(xs[i], ys[i]));
                }
                plotModel.Series.Add(series);

                
                var graphForm = new GraphForm();
                graphForm.SetPlotModel(plotModel);
                graphForm.Show();
            }
        }

        

    }
}
