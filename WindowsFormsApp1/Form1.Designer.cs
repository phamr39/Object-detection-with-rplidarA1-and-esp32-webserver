namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.ClassTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LockCheckbox = new System.Windows.Forms.CheckBox();
            this.SchoolTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.failBtn = new System.Windows.Forms.RadioButton();
            this.OKBtn = new System.Windows.Forms.RadioButton();
            this.MidBtn = new System.Windows.Forms.RadioButton();
            this.GoodBtn = new System.Windows.Forms.RadioButton();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ResultFirstTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FirstTimeStatus = new System.Windows.Forms.PictureBox();
            this.GetDataBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StartMea = new System.Windows.Forms.Button();
            this.ExcelGen = new System.Windows.Forms.Button();
            this.targetBox = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preperalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingBox = new System.Windows.Forms.GroupBox();
            this.configOK = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.errorTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.max_range_tb = new System.Windows.Forms.TextBox();
            this.selectList = new System.Windows.Forms.Button();
            this.textBoxClassList = new System.Windows.Forms.TextBox();
            this.theNextStudent = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstTimeStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SettingBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần mềm chấm điểm bài thi ném lựu đạn ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên học sinh";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextbox.Location = new System.Drawing.Point(485, 150);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(196, 31);
            this.NameTextbox.TabIndex = 2;
            this.NameTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ClassTextbox
            // 
            this.ClassTextbox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassTextbox.Location = new System.Drawing.Point(485, 113);
            this.ClassTextbox.Name = "ClassTextbox";
            this.ClassTextbox.Size = new System.Drawing.Size(75, 31);
            this.ClassTextbox.TabIndex = 4;
            this.ClassTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lớp";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LockCheckbox
            // 
            this.LockCheckbox.AutoSize = true;
            this.LockCheckbox.Location = new System.Drawing.Point(603, 122);
            this.LockCheckbox.Name = "LockCheckbox";
            this.LockCheckbox.Size = new System.Drawing.Size(51, 17);
            this.LockCheckbox.TabIndex = 5;
            this.LockCheckbox.Text = "Khóa";
            this.LockCheckbox.UseVisualStyleBackColor = true;
            this.LockCheckbox.CheckedChanged += new System.EventHandler(this.LockCheckbox_CheckedChanged);
            // 
            // SchoolTextbox
            // 
            this.SchoolTextbox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchoolTextbox.Location = new System.Drawing.Point(485, 76);
            this.SchoolTextbox.Name = "SchoolTextbox";
            this.SchoolTextbox.Size = new System.Drawing.Size(196, 31);
            this.SchoolTextbox.TabIndex = 7;
            this.SchoolTextbox.Text = " ";
            this.SchoolTextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Trường";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.failBtn);
            this.groupBox1.Controls.Add(this.OKBtn);
            this.groupBox1.Controls.Add(this.MidBtn);
            this.groupBox1.Controls.Add(this.GoodBtn);
            this.groupBox1.Controls.Add(this.ClearBtn);
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.ResultFirstTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.FirstTimeStatus);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(379, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 215);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Xếp loại";
            // 
            // failBtn
            // 
            this.failBtn.AutoSize = true;
            this.failBtn.Location = new System.Drawing.Point(166, 133);
            this.failBtn.Name = "failBtn";
            this.failBtn.Size = new System.Drawing.Size(106, 27);
            this.failBtn.TabIndex = 21;
            this.failBtn.TabStop = true;
            this.failBtn.Text = "Không đạt";
            this.failBtn.UseVisualStyleBackColor = true;
            // 
            // OKBtn
            // 
            this.OKBtn.AutoSize = true;
            this.OKBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OKBtn.Location = new System.Drawing.Point(166, 100);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(55, 27);
            this.OKBtn.TabIndex = 20;
            this.OKBtn.TabStop = true;
            this.OKBtn.Text = "Đạt";
            this.OKBtn.UseVisualStyleBackColor = true;
            // 
            // MidBtn
            // 
            this.MidBtn.AutoSize = true;
            this.MidBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MidBtn.Location = new System.Drawing.Point(29, 133);
            this.MidBtn.Name = "MidBtn";
            this.MidBtn.Size = new System.Drawing.Size(57, 27);
            this.MidBtn.TabIndex = 19;
            this.MidBtn.TabStop = true;
            this.MidBtn.Text = "Khá";
            this.MidBtn.UseVisualStyleBackColor = true;
            // 
            // GoodBtn
            // 
            this.GoodBtn.AutoSize = true;
            this.GoodBtn.ForeColor = System.Drawing.Color.Lime;
            this.GoodBtn.Location = new System.Drawing.Point(29, 100);
            this.GoodBtn.Name = "GoodBtn";
            this.GoodBtn.Size = new System.Drawing.Size(58, 27);
            this.GoodBtn.TabIndex = 18;
            this.GoodBtn.TabStop = true;
            this.GoodBtn.Text = "Giỏi";
            this.GoodBtn.UseVisualStyleBackColor = true;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(46, 166);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 37);
            this.ClearBtn.TabIndex = 15;
            this.ClearBtn.Text = "Xóa";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(174, 166);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 37);
            this.SaveBtn.TabIndex = 14;
            this.SaveBtn.Text = "Lưu";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ResultFirstTime
            // 
            this.ResultFirstTime.AutoSize = true;
            this.ResultFirstTime.Location = new System.Drawing.Point(195, 39);
            this.ResultFirstTime.Name = "ResultFirstTime";
            this.ResultFirstTime.Size = new System.Drawing.Size(54, 23);
            this.ResultFirstTime.TabIndex = 17;
            this.ResultFirstTime.Text = "0.1 m";
            this.ResultFirstTime.Click += new System.EventHandler(this.ResultFirstTime_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kết quả ném";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FirstTimeStatus
            // 
            this.FirstTimeStatus.Image = ((System.Drawing.Image)(resources.GetObject("FirstTimeStatus.Image")));
            this.FirstTimeStatus.InitialImage = null;
            this.FirstTimeStatus.Location = new System.Drawing.Point(140, 30);
            this.FirstTimeStatus.Name = "FirstTimeStatus";
            this.FirstTimeStatus.Size = new System.Drawing.Size(32, 32);
            this.FirstTimeStatus.TabIndex = 13;
            this.FirstTimeStatus.TabStop = false;
            this.FirstTimeStatus.Click += new System.EventHandler(this.FirstTimeStatus_Click);
            // 
            // GetDataBtn
            // 
            this.GetDataBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetDataBtn.Location = new System.Drawing.Point(186, 433);
            this.GetDataBtn.Name = "GetDataBtn";
            this.GetDataBtn.Size = new System.Drawing.Size(142, 35);
            this.GetDataBtn.TabIndex = 20;
            this.GetDataBtn.Text = "Lấy kết quả";
            this.GetDataBtn.UseVisualStyleBackColor = true;
            this.GetDataBtn.Click += new System.EventHandler(this.GetDataBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartMea
            // 
            this.StartMea.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartMea.Location = new System.Drawing.Point(27, 433);
            this.StartMea.Name = "StartMea";
            this.StartMea.Size = new System.Drawing.Size(142, 35);
            this.StartMea.TabIndex = 21;
            this.StartMea.Text = "Bắt đầu đo";
            this.StartMea.UseVisualStyleBackColor = true;
            this.StartMea.Click += new System.EventHandler(this.StartMea_Click);
            // 
            // ExcelGen
            // 
            this.ExcelGen.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcelGen.Location = new System.Drawing.Point(470, 433);
            this.ExcelGen.Name = "ExcelGen";
            this.ExcelGen.Size = new System.Drawing.Size(142, 35);
            this.ExcelGen.TabIndex = 22;
            this.ExcelGen.Text = "Tạo file Excel";
            this.ExcelGen.UseVisualStyleBackColor = true;
            this.ExcelGen.Click += new System.EventHandler(this.ExcelGen_Click);
            // 
            // targetBox
            // 
            this.targetBox.BackColor = System.Drawing.Color.PaleGreen;
            this.targetBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.targetBox.Image = global::WindowsFormsApp1.Properties.Resources.ResultPos;
            this.targetBox.Location = new System.Drawing.Point(151, 265);
            this.targetBox.Name = "targetBox";
            this.targetBox.Size = new System.Drawing.Size(40, 40);
            this.targetBox.TabIndex = 23;
            this.targetBox.TabStop = false;
            this.targetBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1112, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.preperalToolStripMenuItem,
            this.addToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // preperalToolStripMenuItem
            // 
            this.preperalToolStripMenuItem.Name = "preperalToolStripMenuItem";
            this.preperalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.preperalToolStripMenuItem.Text = "Setting";
            this.preperalToolStripMenuItem.Click += new System.EventHandler(this.preperalToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.advanceToolStripMenuItem,
            this.bookmarkToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.goToToolStripMenuItem.Text = "Go To";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // advanceToolStripMenuItem
            // 
            this.advanceToolStripMenuItem.Name = "advanceToolStripMenuItem";
            this.advanceToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.advanceToolStripMenuItem.Text = "Advance";
            // 
            // bookmarkToolStripMenuItem
            // 
            this.bookmarkToolStripMenuItem.Name = "bookmarkToolStripMenuItem";
            this.bookmarkToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.bookmarkToolStripMenuItem.Text = "Bookmark";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.noticeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // noticeToolStripMenuItem
            // 
            this.noticeToolStripMenuItem.Name = "noticeToolStripMenuItem";
            this.noticeToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.noticeToolStripMenuItem.Text = "Notice";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.checkForUpdateToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.checkForUpdateToolStripMenuItem.Text = "Check for Update";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.sendFeedbackToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // sendFeedbackToolStripMenuItem
            // 
            this.sendFeedbackToolStripMenuItem.Name = "sendFeedbackToolStripMenuItem";
            this.sendFeedbackToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sendFeedbackToolStripMenuItem.Text = "Send Feedback";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.aboutToolStripMenuItem.Text = "About..";
            // 
            // SettingBox
            // 
            this.SettingBox.Controls.Add(this.configOK);
            this.SettingBox.Controls.Add(this.label8);
            this.SettingBox.Controls.Add(this.errorTb);
            this.SettingBox.Controls.Add(this.label7);
            this.SettingBox.Controls.Add(this.max_range_tb);
            this.SettingBox.Enabled = false;
            this.SettingBox.Location = new System.Drawing.Point(70, 92);
            this.SettingBox.Name = "SettingBox";
            this.SettingBox.Size = new System.Drawing.Size(232, 145);
            this.SettingBox.TabIndex = 25;
            this.SettingBox.TabStop = false;
            this.SettingBox.Text = "Setting";
            this.SettingBox.Visible = false;
            this.SettingBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // configOK
            // 
            this.configOK.Location = new System.Drawing.Point(81, 113);
            this.configOK.Name = "configOK";
            this.configOK.Size = new System.Drawing.Size(75, 23);
            this.configOK.TabIndex = 4;
            this.configOK.Text = "OK";
            this.configOK.UseVisualStyleBackColor = true;
            this.configOK.Click += new System.EventHandler(this.configOK_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "Error Value\r\n(mm)";
            // 
            // errorTb
            // 
            this.errorTb.Location = new System.Drawing.Point(94, 74);
            this.errorTb.Name = "errorTb";
            this.errorTb.Size = new System.Drawing.Size(100, 20);
            this.errorTb.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Max Range\r\n(mm)";
            // 
            // max_range_tb
            // 
            this.max_range_tb.Location = new System.Drawing.Point(94, 36);
            this.max_range_tb.Name = "max_range_tb";
            this.max_range_tb.Size = new System.Drawing.Size(100, 20);
            this.max_range_tb.TabIndex = 0;
            // 
            // selectList
            // 
            this.selectList.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectList.Location = new System.Drawing.Point(470, 491);
            this.selectList.Name = "selectList";
            this.selectList.Size = new System.Drawing.Size(142, 35);
            this.selectList.TabIndex = 26;
            this.selectList.Text = "Thêm danh sách lớp";
            this.selectList.UseVisualStyleBackColor = true;
            this.selectList.Click += new System.EventHandler(this.selectList_Click);
            // 
            // textBoxClassList
            // 
            this.textBoxClassList.Location = new System.Drawing.Point(12, 499);
            this.textBoxClassList.Name = "textBoxClassList";
            this.textBoxClassList.ReadOnly = true;
            this.textBoxClassList.Size = new System.Drawing.Size(443, 20);
            this.textBoxClassList.TabIndex = 5;
            this.textBoxClassList.Text = "Danh sách lớp...";
            this.textBoxClassList.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // theNextStudent
            // 
            this.theNextStudent.AutoSize = true;
            this.theNextStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theNextStudent.Location = new System.Drawing.Point(726, 92);
            this.theNextStudent.Name = "theNextStudent";
            this.theNextStudent.Size = new System.Drawing.Size(94, 16);
            this.theNextStudent.TabIndex = 23;
            this.theNextStudent.Text = "Danh sách lớp";
            this.theNextStudent.Click += new System.EventHandler(this.label9_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(729, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(371, 404);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 556);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.theNextStudent);
            this.Controls.Add(this.textBoxClassList);
            this.Controls.Add(this.selectList);
            this.Controls.Add(this.SettingBox);
            this.Controls.Add(this.targetBox);
            this.Controls.Add(this.ExcelGen);
            this.Controls.Add(this.StartMea);
            this.Controls.Add(this.GetDataBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SchoolTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LockCheckbox);
            this.Controls.Add(this.ClassTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ClassTextbox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstTimeStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SettingBox.ResumeLayout(false);
            this.SettingBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox ClassTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox LockCheckbox;
        private System.Windows.Forms.TextBox SchoolTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox FirstTimeStatus;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label ResultFirstTime;
        private System.Windows.Forms.Button GetDataBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StartMea;
        private System.Windows.Forms.Button ExcelGen;
        private System.Windows.Forms.PictureBox targetBox;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RadioButton OKBtn;
        private System.Windows.Forms.RadioButton MidBtn;
        private System.Windows.Forms.RadioButton GoodBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton failBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preperalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox SettingBox;
        private System.Windows.Forms.TextBox max_range_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox errorTb;
        private System.Windows.Forms.Button configOK;
        private System.Windows.Forms.Button selectList;
        private System.Windows.Forms.TextBox textBoxClassList;
        private System.Windows.Forms.Label theNextStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

