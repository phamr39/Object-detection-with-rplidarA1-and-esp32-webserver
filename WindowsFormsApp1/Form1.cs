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
using System.Diagnostics.Eventing.Reader;
using System.Data.OleDb;
using System.Globalization;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        /* General variable defination */
        /* General defination*/
        double delta_error = 0;
        int max_range_detect = 3000;
        bool isStartMea = false;
        bool isGetDataClicked = false;
        bool isProcessDataDone = false;
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

        // Workbook for list students
        string studentListPath = "";
        List<string> studentList = new List<string>();
        int currentStudentListRowIdx = 0;
        int currentStudentListColIdx = 0;
        /* Result definition */
        double ResultDistance = 2.0;
        // double ResultAngle = 2.0;
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
            MyWorksheet.Cells[1, 3] = "Kết quả";
            MyWorksheet.Cells[1, 4] = "Thành tích tốt nhất";
            MyWorksheet.Cells[1, 5] = "Xếp loại";
            MyWorksheet.Cells[1, 6] = "Lớp";
            MyWorksheet.Cells[1, 7] = "Trường";
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
            // SecondTimeStatus.Image = Image.FromFile(ListImg[2]);
            // ThirtTimeStatus.Image = Image.FromFile(ListImg[2]);
            // ResultFirstTime.Text = "No Data";
            // ResultSecondTime.Text = "No Data";
            // ResultThirdTime.Text = "No Data";
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
        private void GrenadeMove(double Distance, double Angle) // Distance (mm), Angle (Radian)
        {
            try
            {
                // Distance = Distance;
                if (Distance > 3.5)
                {
                    Distance = 3.5;
                }
                Distance = Distance * ScaleRatio;
                Console.WriteLine("GrenadeMove Distance =  " + Distance);
                Console.WriteLine("GrenadeMove Angle =  " + Angle);
                Console.WriteLine("TargetCenterPoint_X " + TargetCenterPoint_X);
                Console.WriteLine("TargetCenterPoint_Y " + TargetCenterPoint_Y);
                int PosX = (int)(Distance * Math.Cos(Angle));
                int PosY = (int)(Distance * Math.Sin(Angle));
                Console.WriteLine("GrenadeMove Math.Sin(Angle) =  " + Math.Sin(Angle));
                Console.WriteLine("PosX " + PosX);
                Console.WriteLine("PosY " + PosY);
                _x = TargetCenterPoint_X + PosX - result_size / 2;
                _y = TargetCenterPoint_Y + PosY - result_size / 2;
                Console.WriteLine("_x " + _x);
                Console.WriteLine("_y " + _y);
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
            ResultFirstTime.Text = "No Data";
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
                DateTime localDate = DateTime.Now;
                string cultureName = "vi-VN";
                var culture = new CultureInfo(cultureName);
                string filename = "Report-nem-luu-dan-" + localDate.ToString(culture).Replace("/", "-").Replace(":","-").Replace(" ", "-") + ".xls";
                Console.WriteLine("AAAAAAAAAAAAA {0}", filename);
                string DesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("\\WindowsFormsApp1\\bin\\Debug", ""), filename);
                MyWorkbook.SaveAs(DesPath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                MyWorkbook.Close(true, misValue, misValue);
                xlApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                isWbClosed = true;
                DialogResult result = MessageBox.Show("Đã lưu file Excel tại: " + DesPath, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK) {
                    Process.Start("explorer.exe" , AppDomain.CurrentDomain.BaseDirectory.Replace("\\WindowsFormsApp1\\bin\\Debug", ""));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("ExcelGen_Click error", err);
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
                    MyWorksheet.Cells[1, 3] = "Kết quả";
                    MyWorksheet.Cells[1, 4] = "Điểm";
                    MyWorksheet.Cells[1, 5] = "Xếp loại";
                    isWbClosed = false;
                    MyWorkbook.Close(0);
                    xlApp.Quit();
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
            // Task.Delay(3000);
            isStartMea = false;
            try
            {
                Console.WriteLine("Get Data Clicked");
                if (Process_Data() == true)
                {
                    // ResultDistance = 0.935;
                    GrenadeMove(ResultDistance, -1.55);
                    if (true == true)
                    {
                        if (ResultDistance < 3)
                        {
                            FirstTimeStatus.Image = Image.FromFile(ListImg[1]);
                        }
                        else
                        {
                            FirstTimeStatus.Image = Image.FromFile(ListImg[0]);
                        }
                        ResultFirstTime.Text = Math.Abs(ResultDistance).ToString() + " m";
                    }
                    isProcessDataDone = false;
                }
                if ((ResultDistance >= 0) && (ResultDistance < 1))
                {
                    GoodBtn.Checked = true;
                }
                else if ((ResultDistance >= 1) && (ResultDistance < 2))
                {
                    MidBtn.Checked = true;
                }
                else if ((ResultDistance >= 2) && (ResultDistance < 3))
                {
                    OKBtn.Checked = true;
                }
                else
                {
                    failBtn.Checked = true;
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
            // int MeasureTime = 3;
            try
            {
                CurentRowWirtten = CurentRowWirtten + 1;
                MyWorksheet.Cells[CurentRowWirtten, 1] = CurentRowWirtten - 1;
                MyWorksheet.Cells[CurentRowWirtten, 2] = NameTextbox.Text;
                MyWorksheet.Cells[CurentRowWirtten, 3] = ResultFirstTime.Text;
                MyWorksheet.Cells[CurentRowWirtten, 6] = ClassTextbox.Text;
                MyWorksheet.Cells[CurentRowWirtten, 7] = SchoolTextbox.Text;

                // MyWorksheet.Cells[CurentRowWirtten, 4] = ResultSecondTime.Text;
                // MyWorksheet.Cells[CurentRowWirtten, 5] = ResultThirdTime.Text;
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
                double AvarageResult = Math.Min(Math.Min(FirstTimeScore, SecondTimeScore), ThirdTimeScore);
                if (ResultFirstTime.Text == "No Data")
                {
                    FinalScore = 0;
                }
                else
                {
                    if ((AvarageResult >= 0) && (AvarageResult < 1))
                    {
                        FinalScore = 1;
                    }
                    else if ((AvarageResult >= 1) && (AvarageResult < 2))
                    {
                        FinalScore = 2;
                    }
                    else if ((AvarageResult >= 2) && (AvarageResult < 3))
                    {
                        FinalScore = 3;
                    }
                    else
                    {
                        FinalScore = 4;
                    }
                }
                switch (FinalScore)
                {
                    case 0:
                        MyWorksheet.Cells[CurentRowWirtten, 4] = AvarageResult.ToString();
                        MyWorksheet.Cells[CurentRowWirtten, 5] = "Không đạt";
                        break;
                    case 1:
                        MyWorksheet.Cells[CurentRowWirtten, 4] = AvarageResult.ToString();
                        MyWorksheet.Cells[CurentRowWirtten, 5] = "Giỏi";
                        break;
                    case 2:
                        MyWorksheet.Cells[CurentRowWirtten, 4] = AvarageResult.ToString();
                        MyWorksheet.Cells[CurentRowWirtten, 5] = "Khá";
                        break;
                    case 3:
                        MyWorksheet.Cells[CurentRowWirtten, 4] = AvarageResult.ToString();
                        MyWorksheet.Cells[CurentRowWirtten, 5] = "Đạt";
                        break;
                    case 4:
                        MyWorksheet.Cells[CurentRowWirtten, 4] = AvarageResult.ToString();
                        MyWorksheet.Cells[CurentRowWirtten, 5] = "Không Đạt";
                        break;
                }
                dataGridView1.Rows[currentStudentListRowIdx].Cells[currentStudentListColIdx].Style.BackColor = Color.Green;
            }
            catch
            {
                Console.WriteLine("SaveBtn Error");
                MessageBox.Show("Không thể lưu dữ liệu vào excel, kiểm tra lại dữ liệu đã nhập", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
            try
            {
                // HttpResponseMessage response = await myClient.PostAsync("http://192.168.1.67:80/update", stringContent);
                // http://esplidar.local:80/update
                // HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:8000");
                if (isStartMea == true)
                {
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://192.168.1.67:80/update");
                    var response = await myClient.SendAsync(request);
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var jsonData = responseBody;
                    double tmpDistance = GetJsonData(jsonData, "distance");
                    // if (tmpDistance < (max_range_detect + delta_error) && tmpDistance > 240)
                    if (tmpDistance < (max_range_detect + delta_error))
                    // if (tmpDistance < (max_range_detect) && tmpDistance > 150)
                    {
                        dataList.Add(jsonData);
                        Console.WriteLine("responseBody = " + GetJsonData(jsonData, "distance"));
                    }
                }
                else
                {
                    try
                    {
                        if (dataList.Count >= 1)
                        {
                            dataList.Clear();
                        }
                    }
                    catch
                    {
                    }
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

        private string get_smallest_data()
        {
            // Get smallest data from list
            // double global_smalest_data;
            double smallest_distance = max_range_detect;
            string smallest_data = @"{'angle':'0','distance':'0'}";
            dataList.ForEach(delegate (string jsonData)
            {
                double tmpDistance = GetJsonData(jsonData, "distance");
                if (tmpDistance < smallest_distance && tmpDistance > 0)
                {
                    smallest_distance = tmpDistance;
                    smallest_data = jsonData;
                }
            });
            return smallest_data;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // string jsonData = get_result();
            // GrenadeMove(GetJsonData(jsonData, "distance"), GetJsonData(jsonData, "angle"));
            // ResultDistance = GetJsonData(jsonData, "distance") / 100
            try
            {
                MyWorkbook.Close(0);
                xlApp.Quit();
            }
            catch
            { }
        }

        private void StartMea_Click(object sender, EventArgs e)
        {
            isStartMea = true;
            Console.WriteLine("Start Measurement...");
        }

        private bool Process_Data()
        {
            string smallest_data = get_smallest_data();
            double angle = GetJsonData(smallest_data, "angle") *2*3.14/360;
            if (angle > 1.570796 && angle < 4.71238898)
            {
                ResultDistance = GetJsonData(smallest_data, "distance") / 1000 + delta_error / 1000;
            }
            else
            {
                ResultDistance = GetJsonData(smallest_data, "distance") / 1000 - delta_error / 1000;
            }
            Console.WriteLine("BriefAngle = " + GetJsonData(smallest_data, "angle"));
            Console.WriteLine("ResultAngle = " + angle);
            Console.WriteLine("BriefDistance = " + GetJsonData(smallest_data, "distance"));
            Console.WriteLine("ResultDistance = " + ResultDistance);
            GrenadeMove(ResultDistance, angle);
            return true;
        }

        private void preperalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingBox.Visible = true;
            SettingBox.Enabled = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            SettingBox.Visible = false;
            SettingBox.Enabled = false;
        }

        private void configOK_Click(object sender, EventArgs e)
        {
            SettingBox.Visible = false;
            SettingBox.Enabled = false;
            delta_error = 0;
            try
            {
                max_range_detect = int.Parse(max_range_tb.Text);
                delta_error = int.Parse(errorTb.Text);
                Console.WriteLine(max_range_detect);
                Console.WriteLine(delta_error);
            }
            catch
            {
                Console.WriteLine("Parse Error");
            }
        }

        private void selectList_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Chọn danh sách lớp";
            dlg.Filter = "Excel files (*.xls,*.xlsx)|*.xls*; *.xlsx*|All files(*.*) | *.* ";
            dlg.FilterIndex = 1;
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(dlg.FileName);
                if (extension == ".xls" || extension == ".xlsx")
                {
                    // MessageBox.Show(dlg.FileName);
                    DialogResult result = MessageBox.Show("Xác nhận thêm danh sách lớp?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        textBoxClassList.Text = dlg.FileName;
                        studentListPath = dlg.FileName;

                        try
                        {
                            DataTable dtExcel = new DataTable();
                            dtExcel = ReadExcel(studentListPath, extension); //read excel file  
                            dataGridView1.Visible = true;
                            dataGridView1.DataSource = dtExcel;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        //no...
                    }
                }
                else {
                    MessageBox.Show("Hãy chọn file excel, kết thúc bằng .xls hoặc .xlsx", "Error Title");
                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public DataTable ReadExcel(string fileName, string fileExt)
        {
            string conn = string.Empty;
            DataTable dtexcel = new DataTable();
            if (fileExt.CompareTo(".xls") == 0)
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
            else
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=NO';"; //for above excel 2007  
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [Sheet1$]", con); //here we read data from sheet1  
                    oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
                }
                catch { }
            }
            return dtexcel;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Selected student name
            NameTextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            // ClassTextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();
            // SchoolTextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString();
            currentStudentListColIdx = e.ColumnIndex;
            currentStudentListRowIdx = e.RowIndex;
            // dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
