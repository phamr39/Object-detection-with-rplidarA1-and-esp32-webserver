using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
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
        int ScaleRatio = 50;
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
        /* Excel init */
        // Create new workbook
        /* Excel init */
        // Create new workbook
        Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        object misValue = System.Reflection.Missing.Value;
        Excel.Workbook MyWorkbook;
        Excel.Worksheet MyWorksheet;
        int CurentRowWirtten = 1;
        /* Result definition */
        double ResultDistance = 2.0;
        double ResultAngle = 2.0;
        /* Radio Button Group Definition*/
        bool isFirstTime = false;
        bool isSecondTime = false;
        bool isThirdTime = false;
        List<string> ListImg;
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
            /* Excel init */
            if (xlApp == null)
            {
                MessageBox.Show("Excel chưa được cài đặt!");
                return;
            }
            MyWorkbook = xlApp.Workbooks.Add(misValue);
            MyWorksheet = (Excel.Worksheet)MyWorkbook.Worksheets.get_Item(1);
            // Create the first row
            MyWorksheet.Cells[1, 1] = "STT";
            MyWorksheet.Cells[1, 2] = "Họ và tên";
            MyWorksheet.Cells[1, 3] = "Kết quả lần 1";
            MyWorksheet.Cells[1, 4] = "Kết quả lần 2";
            MyWorksheet.Cells[1, 5] = "Kết quả lần 3";
            MyWorksheet.Cells[1, 6] = "Điểm";
            MyWorksheet.Cells[1, 7] = "Xếp loại";
            /* Create Image list */
            ListImg = new List<string>
            {
                 Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", ""), "fail-icon.jpg"),
                 Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", ""), "pass-icon.jpg"),
                 Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", ""), "no-data.jpg"),
            };
            /* Reset GUI */
            GrenadeMove(0, 0);
            FirstTimeStatus.Image = Image.FromFile(ListImg[2]);
            SecondTimeStatus.Image = Image.FromFile(ListImg[2]);
            ThirtTimeStatus.Image = Image.FromFile(ListImg[2]);
            ResultFirstTime.Text = "No Data";
            ResultSecondTime.Text = "No Data";
            ResultThirdTime.Text = "No Data";
        }
        /* Coordinate defination
         ^ (-)
         |
         |
         |        (+)
         --------->
         */
        private void GrenadeMove(double Distance, double Angle) // Distance (m), Angle (Radian)
        {
            if(Distance > 3.5)
            {
                Distance = 3.5;
            }
            Distance = Distance * ScaleRatio;
            Console.WriteLine("TargetCenterPoint_X " + TargetCenterPoint_X);
            Console.WriteLine("TargetCenterPoint_Y " + TargetCenterPoint_Y);
            int PosX = (int)(Distance * Math.Cos(Angle));
            int PosY = (int)(Distance * Math.Sin(Angle));
            Console.WriteLine("PosX " + PosX);
            Console.WriteLine("PosY " + PosY);
            _x = TargetCenterPoint_X + PosX - result_size/2;
            _y = TargetCenterPoint_Y + PosY - result_size/2;
            Console.WriteLine("_x "+ _x);
            Console.WriteLine("_y " + _y);
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
            GrenadeMove(0, 0);
            FirstTimeStatus.Image = Image.FromFile(ListImg[2]);
            SecondTimeStatus.Image = Image.FromFile(ListImg[2]);
            ThirtTimeStatus.Image = Image.FromFile(ListImg[2]);
            ResultFirstTime.Text = "No Data";
            ResultSecondTime.Text = "No Data";
            ResultThirdTime.Text = "No Data";
            NameTextbox.Text = "";
        }

        private void LockCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            LockCheckboxStatus = !LockCheckboxStatus;
            SchoolTextbox.ReadOnly = LockCheckboxStatus;
            ClassTextbox.ReadOnly = LockCheckboxStatus;
        }

        private void ExcelGen_Click(object sender, EventArgs e)
        {
            string filename = SchoolTextbox.Text + "-" + ClassTextbox.Text + "-" + "Report.xls";
            string DesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("\\WindowsFormsApp1\\bin\\Debug", ""), filename);
            MyWorkbook.SaveAs(DesPath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            MyWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
        }

        private void ThirdTimeBtn_CheckedChanged(object sender, EventArgs e)
        {
            isFirstTime = false;
            isSecondTime = false;
            isThirdTime = true;
        }

        private void SecondTimeBtn_CheckedChanged(object sender, EventArgs e)
        {
            isFirstTime = false;
            isSecondTime = true;
            isThirdTime = false;
        }

        private void FirstTimeBtn_CheckedChanged(object sender, EventArgs e)
        {
            isFirstTime = true;
            isSecondTime = false;
            isThirdTime = false;
        }

        private void GetDataBtn_Click(object sender, EventArgs e)
        {
            if (isFirstTime == true)
            {
                if (ResultDistance < 3)
                {
                    FirstTimeStatus.Image = Image.FromFile(ListImg[1]);
                }
                else 
                {
                    FirstTimeStatus.Image = Image.FromFile(ListImg[0]);
                }
                ResultFirstTime.Text = ResultDistance.ToString() + " m";
            }

            if (isSecondTime == true)
            {
                if (ResultDistance < 3)
                {
                    SecondTimeStatus.Image = Image.FromFile(ListImg[1]);
                }
                else
                {
                    SecondTimeStatus.Image = Image.FromFile(ListImg[0]);
                }
                ResultSecondTime.Text = ResultDistance.ToString() + " m";
            }

            if (isThirdTime == true)
            {
                if (ResultDistance < 3)
                {
                    ThirtTimeStatus.Image = Image.FromFile(ListImg[1]);
                }
                else
                {
                    ThirtTimeStatus.Image = Image.FromFile(ListImg[0]);
                }
                ResultThirdTime.Text = ResultDistance.ToString() + " m";
            }
        }

        private void ResultFirstTime_Click(object sender, EventArgs e)
        {
            
        }

        private void FirstTimeStatus_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            double FinalScore = 0;
            double FirstTimeScore = 0;
            double SecondTimeScore = 0;
            double ThirdTimeScore = 0;
            int MeasureTime = 3;
            CurentRowWirtten = CurentRowWirtten + 1;
            MyWorksheet.Cells[CurentRowWirtten, 1] = CurentRowWirtten-1;
            MyWorksheet.Cells[CurentRowWirtten, 2] = NameTextbox.Text;
            MyWorksheet.Cells[CurentRowWirtten, 3] = ResultFirstTime.Text;
            MyWorksheet.Cells[CurentRowWirtten, 4] = ResultSecondTime.Text;
            MyWorksheet.Cells[CurentRowWirtten, 5] = ResultThirdTime.Text;
            // Calculate final score
            String[] sepe = { " " };
            if (ResultFirstTime.Text == "")
            {
                FirstTimeScore = 0;
            }
            else
            {
                String[] txt1score = ResultFirstTime.Text.Split(sepe, 2, StringSplitOptions.RemoveEmptyEntries);
                double.TryParse(txt1score[0], out FirstTimeScore);
            }
            if (ResultSecondTime.Text == "")
            {
                SecondTimeScore = 0;
            }
            else
            {
                String[] txt2score = ResultSecondTime.Text.Split(sepe, 2, StringSplitOptions.RemoveEmptyEntries);
                double.TryParse(txt2score[0], out SecondTimeScore);
            }
            if (ResultThirdTime.Text == "")
            {
                ThirdTimeScore = 0;
            }
            else
            {
                String[] txt3score = ResultThirdTime.Text.Split(sepe, 2, StringSplitOptions.RemoveEmptyEntries);
                double.TryParse(txt3score[0], out ThirdTimeScore);
            }
            if (ResultFirstTime.Text == "No Data")
            {
                MeasureTime = MeasureTime - 1;
            }
            if (ResultSecondTime.Text == "No Data")
            {
                MeasureTime = MeasureTime - 1;
            }
            if (ResultThirdTime.Text == "No Data")
            {
                MeasureTime = MeasureTime - 1;
            }
            if (MeasureTime == 0)
            {
                MeasureTime = 3;
            }
            double AvarageResult = (FirstTimeScore + SecondTimeScore + ThirdTimeScore) / MeasureTime;
            /* Score Map:
             * 0-0.5m : 9-10 
             * 0.5-1m : 8-9
             * 1-1.5m : 7-8
             * 1.5-2m : 6-7
             * 2-2.5m : 5-6
             * 2.5-3m : 4-5
             * > 3m : Không đạt*/
            if (ResultFirstTime.Text == "No Data" && ResultSecondTime.Text == "No Data" && ResultThirdTime.Text == "No Data")
            {
                FinalScore = 0;
            }
            else
            { 
                FinalScore = 10 - (AvarageResult * 2); 
            }
            if (FinalScore >= 4)
            {
                MyWorksheet.Cells[CurentRowWirtten, 6] = FinalScore.ToString();
                MyWorksheet.Cells[CurentRowWirtten, 7] = "Đạt";
            }
            else
            {
                MyWorksheet.Cells[CurentRowWirtten, 6] = "0";
                MyWorksheet.Cells[CurentRowWirtten, 7] = "Không Đạt";
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            //GrenadeMove(3.5,0.5);
        }
    }
}
