using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        /* General variable defination */
        /* General defination*/
        private bool LockCheckboxStatus = false;
        /* Result point position */
        enum GrenadePosition 
        {
            Left, Right, Up, Down
        }
        private int _x;
        private int _y;
        private int result_size = 40;
        private GrenadePosition _grenadePos;
        /* Target position */
        private int target_x = 23;
        private int target_y = 56;
        private int target_size = 350;
        int TargetCenterPoint_X;
        int TargetCenterPoint_Y;
        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        public Form1()
        {
            InitializeComponent();
            // Create an grenade Image
            _x = 200;
            _y = 200;
            _grenadePos = GrenadePosition.Down;
            // Central Point Pos calculation
            TargetCenterPoint_X = target_x + target_size / 2;
            TargetCenterPoint_Y = target_y + target_size / 2;
        }
        /* Coordinate defination
         ^ (-)
         |
         |
         |        (+)
         --------->
         */
        private void GrenadeMove(int Distance, double Angle) // Distance (cm) => 1 pixel = 1cm, Angle (Radian)
        {
            int PosX = (int)(Distance * Math.Cos(Angle));
            int PosY = (int)(Distance * Math.Sin(Angle));
            _x = TargetCenterPoint_X + PosX - result_size/2;
            _y = TargetCenterPoint_Y + PosY - result_size/2;
            Invalidate();
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("target_fit.png"), target_x, target_y, target_size, target_size + 1);
            e.Graphics.DrawImage(new Bitmap("ResultPos.png"), _x, _y, result_size, result_size);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            GrenadeMove(100, 0.7);
        }

        private void LockCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            LockCheckboxStatus = !LockCheckboxStatus;
            SchoolTextbox.ReadOnly = LockCheckboxStatus;
            ClassTextbox.ReadOnly = LockCheckboxStatus;
        }
    }
}
