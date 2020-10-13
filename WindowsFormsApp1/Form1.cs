using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Circle drawing definition 
        GraphPane graphPane;
        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        public Form1()
        {
            InitializeComponent();
            graphPane = zedGraphControl1.GraphPane;
            DrawABackground();
        }
        private void DrawABackground()
        {
            LineItem virtualAxis_X = new LineItem("Point", new double[] { -10, 0, 10 }, new double[] { 0, 0, 0 }, Color.Red, SymbolType.None);
            LineItem virtualAxis_Y = new LineItem("Point", new double[] { 0, 0, 0 }, new double[] { -10, 0, 10 }, Color.Blue, SymbolType.None);
            LineItem line = new LineItem("Point", new double[] { 0 }, new double[] { 0 }, Color.Black, SymbolType.Circle);
            line.Symbol.Size = 100;
            line.Symbol.Fill = new Fill(Color.Transparent);
            graphPane.CurveList.Add(virtualAxis_X);
            graphPane.CurveList.Add(virtualAxis_Y);
            graphPane.CurveList.Add(line);
            graphPane.AxisChange();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
