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
using System.Net.Http;
using Excel = Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        /* General variable defination */
        /* General defination*/
        int max_range_detect = 3000;
        List<string> dataList = new List<string>();
        int ScaleRatio = 50;
        private bool LockCheckboxStatus = false;
        /* Sound defination*/
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
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
        bool isWbClosed = false;
        /* Result definition */
        double ResultDistance = 2.0;
        double ResultAngle = 2.0;
        /* Radio Button Group Definition*/
        bool isFirstTime = false;
        bool isSecondTime = false;
        bool isThirdTime = false;
        List<string> ListImg;
        /* Http client definition */
        HttpClient myClient = new HttpClient();
        private void timer1_Tick(object sender, EventArgs e)
        {
            // System.Threading.Thread.Sleep(100);
            HttpRequest();
            // PlayAudio();
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
            /* Remove target picture box back color */
            Color noColor = Color.FromArgb(0, 0, 0, 0);
            targetBox.BackColor = noColor;
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
            try
            {
                Distance = Distance / 100;
                if (Distance > 3.5)
                {
                    Distance = 3.5;
                }
                Distance = Distance * ScaleRatio;
                // Console.WriteLine("TargetCenterPoint_X " + TargetCenterPoint_X);
                // Console.WriteLine("TargetCenterPoint_Y " + TargetCenterPoint_Y);
                int PosX = (int)(Distance * Math.Cos(Angle));
                int PosY = (int)(Distance * Math.Sin(Angle));
                // Console.WriteLine("PosX " + PosX);
                // Console.WriteLine("PosY " + PosY);
                _x = TargetCenterPoint_X + PosX - result_size / 2;
                _y = TargetCenterPoint_Y + PosY - result_size / 2;
                // Console.WriteLine("_x " + _x);
                // Console.WriteLine("_y " + _y);
                //Invalidate();
                targetBox.Left = _x;
                targetBox.Top = _y;
            }
            catch
            {
                MessageBox.Show("Không thể hiển thị con trỏ, hãy thử lại", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("target_fit.png"), target_x, target_y, target_size, target_size + 1);
            // e.Graphics.DrawImage(new Bitmap("ResultPos.png"), _x, _y, result_size, result_size);
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
            try
            {
                string filename = SchoolTextbox.Text + "-" + ClassTextbox.Text + "-" + "Report.xls";
                string DesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("\\WindowsFormsApp1\\bin\\Debug", ""), filename);
                MyWorkbook.SaveAs(DesPath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                MyWorkbook.Close(true, misValue, misValue);
                xlApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                isWbClosed = true;
            }
            catch
            {
                Console.WriteLine("ExcelGen_Click error");
                MessageBox.Show("Không tạo được file Excel, hãy kiểm tra dữ liệu đã nhập", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (isWbClosed == true)
            {
                try
                {
                    /* Excel init */
                    // Create new workbook
                    Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                    object misValue = System.Reflection.Missing.Value;
                    Excel.Workbook MyWorkbook;
                    Excel.Worksheet MyWorksheet;
                    int CurentRowWirtten = 1;
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
                    isWbClosed = false;
                }
                catch
                {
                    Console.WriteLine("Re-create Excel Error");
                }
            }
            // Close all excel process


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
            try
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
            catch
            {
                Console.WriteLine("Get data error");
                MessageBox.Show("Không thể lấy dữ liệu", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            try
            {
                CurentRowWirtten = CurentRowWirtten + 1;
                MyWorksheet.Cells[CurentRowWirtten, 1] = CurentRowWirtten - 1;
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
                 * > 3m : Không đạt */
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
            catch
            {
                Console.WriteLine("SaveBtn Error");
                MessageBox.Show("Không thể lưu dữ liệu vào excel, kiểm tra lại dữ liệu đã nhập", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            // GrenadeMove(3.5,0.5);
            //player.SoundLocation = "./test_.mp3";
            //player.Play();
            // TestHttp();
            // PlayAudio();
            string jsonData = @"{'angle':'3.15','distance':'251'}";
            GrenadeMove(GetJsonData(jsonData, "distance"), GetJsonData(jsonData, "angle"));
            ResultDistance = GetJsonData(jsonData, "distance")/100;
        }
        private void PlayAudio()
        {
            string filename = "nade_sound.wav";
            string DesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("\\WindowsFormsApp1\\bin\\Debug", ""), filename);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(DesPath);
            player.Play();
        }
        private async void HttpRequest()
        {
            // var payload = new Dictionary<string, string>
            // {
              // {"PostRequets", "OK"}
            // };
            try
            {
                // string strPayload = JsonConvert.SerializeObject(payload);
                // HttpContent stringContent = new StringContent(strPayload, Encoding.UTF8, "application/json");
                // HttpResponseMessage response = await myClient.PostAsync("http://192.168.1.67:80/update", stringContent);
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "http://192.168.1.67:80/update");
                // HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:8000");
                // response.EnsureSuccessStatusCode();
                // Console.WriteLine("request " + request);
                var response = await myClient.SendAsync(request);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine("responseBody = " + responseBody);
                var jsonData = responseBody;
                double tmpDistance = GetJsonData(jsonData, "distance");
                if (tmpDistance < (max_range_detect + 300) && tmpDistance != 0)
                {
                    dataList.Add(jsonData);
                }
                if (dataList.Count >= 360)
                {
                    dataList.RemoveAt(0);
                }
                // Console.WriteLine("aaaaaaaaaaaa" + dataList);
                // GrenadeMove(GetJsonData(jsonData, "distance"), GetJsonData(jsonData, "angle"));
                // ResultDistance = GetJsonData(jsonData, "distance") / 100;
            }
            catch
            {
               // Console.WriteLine("Exception Handle");
            }
        }
        private double GetJsonData(string JsonString, string key)
        {
            try
            {
                var LidarData = JObject.Parse(JsonString);
                var output = Convert.ToDouble(LidarData[key]);
                return output;
            }
            catch
            {
                return -1;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private string get_result()
        {
            // Get smallest data from list
            double smallest_distance = max_range_detect;
            string smallest_data = @"{'angle':'0','distance':'0'}";
            dataList.ForEach(delegate (string jsonData)
            {
                double tmpDistance = GetJsonData(jsonData, "distance");
                if (tmpDistance < smallest_distance)
                {
                    smallest_distance = tmpDistance;
                    smallest_data = jsonData;
                }
            });
            return smallest_data;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string jsonData = get_result();
            GrenadeMove(GetJsonData(jsonData, "distance"), GetJsonData(jsonData, "angle"));
            ResultDistance = GetJsonData(jsonData, "distance") / 100;
        }
    }
}
