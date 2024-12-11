namespace uts_714230032
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            groupBox1 = new GroupBox();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            groupBox2 = new GroupBox();
            textBoxDiastolic = new TextBox();
            delete = new Button();
            edit = new Button();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            textBox7 = new TextBox();
            textBoxSystolic = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            textBoxSearch = new TextBox();
            search = new Button();
            button2 = new Button();
            label10 = new Label();
            chartAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label11 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartAnalysis).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 1;
            label1.Text = "Dashboard";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(836, 64);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkVisited = true;
            linkLabel2.Location = new Point(679, 28);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(48, 15);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Statistik";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(598, 28);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(73, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Form Harian";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBoxDiastolic);
            groupBox2.Controls.Add(delete);
            groupBox2.Controls.Add(edit);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBoxSystolic);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(60, 105);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(266, 420);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Visible = false;
            // 
            // textBoxDiastolic
            // 
            textBoxDiastolic.Location = new Point(178, 289);
            textBoxDiastolic.Name = "textBoxDiastolic";
            textBoxDiastolic.Size = new Size(71, 23);
            textBoxDiastolic.TabIndex = 18;
            // 
            // delete
            // 
            delete.Location = new Point(180, 364);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 17;
            delete.Text = "DELETE";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // edit
            // 
            edit.Location = new Point(97, 364);
            edit.Name = "edit";
            edit.Size = new Size(75, 23);
            edit.TabIndex = 16;
            edit.Text = "EDIT";
            edit.UseVisualStyleBackColor = true;
            edit.Click += edit_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(102, 210);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(147, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(12, 364);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "INPUT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button2_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(102, 329);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(147, 23);
            textBox7.TabIndex = 7;
            // 
            // textBoxSystolic
            // 
            textBoxSystolic.Location = new Point(102, 289);
            textBoxSystolic.Name = "textBoxSystolic";
            textBoxSystolic.Size = new Size(70, 23);
            textBoxSystolic.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(102, 250);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(147, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(102, 173);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(147, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(2, 333);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 14;
            label9.Text = "Kadar Gula Darah:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1, 293);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 13;
            label8.Text = "Tekanan Darah     :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1, 254);
            label7.Name = "label7";
            label7.Size = new Size(103, 15);
            label7.TabIndex = 12;
            label7.Text = "Berat Badan          :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 216);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 11;
            label6.Text = "Tanggal                 :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 177);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 10;
            label5.Text = "Usia                       :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 137);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 9;
            label4.Text = "Nama                    :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 97);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 8;
            label3.Text = "UserID                   :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 30);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 0;
            label2.Text = "Form Data Harian";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(377, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(406, 231);
            dataGridView1.TabIndex = 4;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(451, 112);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(117, 23);
            textBoxSearch.TabIndex = 5;
            // 
            // search
            // 
            search.Location = new Point(376, 112);
            search.Margin = new Padding(0);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 6;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // button2
            // 
            button2.Location = new Point(377, 369);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Load Data";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(38, 103);
            label10.Name = "label10";
            label10.Size = new Size(523, 37);
            label10.TabIndex = 8;
            label10.Text = "WELCOME TO DATA KESEHATAN HARIAN";
            // 
            // chartAnalysis
            // 
            chartArea1.Name = "ChartArea1";
            chartAnalysis.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartAnalysis.Legends.Add(legend1);
            chartAnalysis.Location = new Point(150, 170);
            chartAnalysis.Name = "chartAnalysis";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartAnalysis.Series.Add(series1);
            chartAnalysis.Size = new Size(549, 365);
            chartAnalysis.TabIndex = 9;
            chartAnalysis.Text = "chart1";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(-22, 5);
            label11.Name = "label11";
            label11.Size = new Size(428, 25);
            label11.TabIndex = 10;
            label11.Text = "Statistik Tekanan Darah Dan Tekanan Gula Darah";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(836, 573);
            Controls.Add(chartAnalysis);
            Controls.Add(label10);
            Controls.Add(button2);
            Controls.Add(search);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartAnalysis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox textBox7;
        private TextBox textBoxSystolic;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private TextBox textBoxSearch;
        private Button search;
        private Button edit;
        private Button delete;
        private Button button2;
        private TextBox textBoxDiastolic;
        private Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalysis;
        private Label label11;
    }
}