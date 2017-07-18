using System;
using System.Linq;
using System.Windows.Forms;

namespace ChartNQA
{
    public partial class Form1 : Form
    {

        CsvReader reader;
        MyChart myChart;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            string filename = null;
            Nullable<bool> result;

            dlg.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.RestoreDirectory = true;
            listBox1.Items.Clear();
            result = (dlg.ShowDialog() == DialogResult.OK) ? true : false;
            if (result == true)
            {
                filename = dlg.FileName;
                reader = new CsvReader(filename);
                reader.Read();
                for (int i = 6; i < reader.headers.Length; i++)
                {
                        listBox1.Items.Add(reader.headers[i]);
                }
                trackPoints.Minimum = 1;
                trackPoints.Maximum = reader.lines.Length / 2 - 1;
                label8.Text = trackPoints.Maximum.ToString();
                trackPoints.Value = 24;
                trackPoints.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please, select value in list", "Error !", MessageBoxButtons.OK);
                return;
            }
            if (chart1.Name != "done")
                myChart = new MyChart(chart1);

            chart1.Name = "done";
            trackPoints.Maximum = myChart.UpdateValue(trackPoints.Value, textTitle.Text, textDateTo.Text, textDateFrom.Text, listBox1, reader);
            label8.Text = trackPoints.Maximum.ToString();
            picturePDF.Enabled = true;
            picturePNG.Enabled = true;
                
        }

        private void trackPoints_ValueChanged(object sender, EventArgs e)
        {
            labeltrack.Text = trackPoints.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textDateFrom.Text = "01/01/1970 00:00";
            textDateTo.Text = "31/12/2099 23:59";
        }

        private void picturePNG_Click(object sender, EventArgs e)
        {
            myChart.SaveFile(1, textTitle.Text);
            MessageBox.Show(string.Format("Image save : {0}", textTitle.Text), "Message", MessageBoxButtons.OK);
        }

        private void picturePDF_Click(object sender, EventArgs e)
        {
            myChart.SaveFile(2, textTitle.Text);
            MessageBox.Show(string.Format("Document save : {0}", textTitle.Text), "Message", MessageBoxButtons.OK);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void checkboxGridX_CheckStateChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                checkboxGridX.Checked = false;
                MessageBox.Show("Please, select value in list", "Error !", MessageBoxButtons.OK);
                return;
            }
            if (checkboxGridX.Checked)
                myChart.AxisXGrid = 1;
            else
                myChart.AxisXGrid = 0;
            trackPoints.Maximum = myChart.UpdateValue(trackPoints.Value, textTitle.Text, textDateTo.Text, textDateFrom.Text, listBox1, reader);
            label8.Text = trackPoints.Maximum.ToString();
        }

        private void checkboxGridY_CheckStateChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                checkboxGridY.Checked = false;
                MessageBox.Show("Please, select value in list", "Error !", MessageBoxButtons.OK);
                return;
            }
            if (checkboxGridY.Checked)
                myChart.AxisYGrid = 1;
            else
                myChart.AxisYGrid = 0;
            trackPoints.Maximum = myChart.UpdateValue(trackPoints.Value, textTitle.Text, textDateTo.Text, textDateFrom.Text, listBox1, reader);
            label8.Text = trackPoints.Maximum.ToString();
        }
    }
}
