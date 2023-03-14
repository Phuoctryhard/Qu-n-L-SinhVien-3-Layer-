namespace GUI
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
            this.checkPic = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textClass = new System.Windows.Forms.TextBox();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.text5 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkCCCD = new System.Windows.Forms.CheckBox();
            this.checkHocba = new System.Windows.Forms.CheckBox();
            this.MSV = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkPic
            // 
            this.checkPic.AutoSize = true;
            this.checkPic.Location = new System.Drawing.Point(6, 49);
            this.checkPic.Name = "checkPic";
            this.checkPic.Size = new System.Drawing.Size(52, 20);
            this.checkPic.TabIndex = 17;
            this.checkPic.Text = "Ảnh";
            this.checkPic.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class";
            // 
            // textClass
            // 
            this.textClass.Location = new System.Drawing.Point(174, 42);
            this.textClass.Name = "textClass";
            this.textClass.Size = new System.Drawing.Size(100, 22);
            this.textClass.TabIndex = 2;
            this.textClass.TextChanged += new System.EventHandler(this.textClass_TextChanged);
            // 
            // cbbSearch
            // 
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Items.AddRange(new object[] {
            "Name",
            "Dtb",
            "Msv"});
            this.cbbSearch.Location = new System.Drawing.Point(567, 339);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(121, 24);
            this.cbbSearch.TabIndex = 3;
            this.cbbSearch.SelectedIndexChanged += new System.EventHandler(this.cbbSearch_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(267, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Sửa ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(383, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "cập nhật";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(486, 339);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "sort";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // text5
            // 
            this.text5.Location = new System.Drawing.Point(771, 381);
            this.text5.Name = "text5";
            this.text5.Size = new System.Drawing.Size(100, 22);
            this.text5.TabIndex = 10;
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(771, 235);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(100, 22);
            this.text3.TabIndex = 12;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(771, 158);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(100, 22);
            this.text2.TabIndex = 13;
            this.text2.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(771, 91);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(100, 22);
            this.text1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioFemale);
            this.groupBox1.Controls.Add(this.radioMale);
            this.groupBox1.Location = new System.Drawing.Point(913, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 122);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(6, 72);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(74, 20);
            this.radioFemale.TabIndex = 20;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(6, 33);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(58, 20);
            this.radioMale.TabIndex = 19;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkCCCD);
            this.groupBox2.Controls.Add(this.checkHocba);
            this.groupBox2.Controls.Add(this.checkPic);
            this.groupBox2.Location = new System.Drawing.Point(913, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 177);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xác thực";
            // 
            // checkCCCD
            // 
            this.checkCCCD.AutoSize = true;
            this.checkCCCD.Location = new System.Drawing.Point(6, 139);
            this.checkCCCD.Name = "checkCCCD";
            this.checkCCCD.Size = new System.Drawing.Size(142, 20);
            this.checkCCCD.TabIndex = 19;
            this.checkCCCD.Text = "căn cước công dân";
            this.checkCCCD.UseVisualStyleBackColor = true;
            // 
            // checkHocba
            // 
            this.checkHocba.AutoSize = true;
            this.checkHocba.Location = new System.Drawing.Point(6, 95);
            this.checkHocba.Name = "checkHocba";
            this.checkHocba.Size = new System.Drawing.Size(73, 20);
            this.checkHocba.TabIndex = 18;
            this.checkHocba.Text = "học bạ ";
            this.checkHocba.UseVisualStyleBackColor = true;
            // 
            // MSV
            // 
            this.MSV.AutoSize = true;
            this.MSV.Location = new System.Drawing.Point(691, 94);
            this.MSV.Name = "MSV";
            this.MSV.Size = new System.Drawing.Size(36, 16);
            this.MSV.TabIndex = 19;
            this.MSV.Text = "MSV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(691, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Class";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(691, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(691, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "DTB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(691, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(550, 150);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cbbClass
            // 
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(534, 42);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(121, 24);
            this.cbbClass.TabIndex = 26;
            this.cbbClass.SelectedIndexChanged += new System.EventHandler(this.cbbClass_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(733, 310);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbbClass);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MSV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbbSearch);
            this.Controls.Add(this.textClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textClass;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox text5;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.CheckBox checkCCCD;
        private System.Windows.Forms.CheckBox checkHocba;
        private System.Windows.Forms.Label MSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.CheckBox checkPic;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}


