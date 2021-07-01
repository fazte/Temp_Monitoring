namespace Temp_Monitoring
{
    partial class Temp_Monitoring_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Norm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otkl_Ot_Normu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbFish = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTemp = new System.Windows.Forms.Label();
            this.tbFish = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbTimeMax = new System.Windows.Forms.TextBox();
            this.tbTimeMin = new System.Windows.Forms.TextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.Fact,
            this.Norm,
            this.Otkl_Ot_Normu});
            this.dataGridView1.Location = new System.Drawing.Point(12, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // date
            // 
            this.date.HeaderText = "Время";
            this.date.Name = "date";
            this.date.Width = 200;
            // 
            // Fact
            // 
            this.Fact.HeaderText = "Факт";
            this.Fact.Name = "Fact";
            // 
            // Norm
            // 
            this.Norm.HeaderText = "Норма";
            this.Norm.Name = "Norm";
            // 
            // Otkl_Ot_Normu
            // 
            this.Otkl_Ot_Normu.HeaderText = "Отклонение от нормы";
            this.Otkl_Ot_Normu.Name = "Otkl_Ot_Normu";
            // 
            // lbFish
            // 
            this.lbFish.AutoSize = true;
            this.lbFish.Location = new System.Drawing.Point(22, 26);
            this.lbFish.Name = "lbFish";
            this.lbFish.Size = new System.Drawing.Size(57, 13);
            this.lbFish.TabIndex = 1;
            this.lbFish.Text = "Вид рыбы";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(25, 58);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(27, 13);
            this.lbMax.TabIndex = 2;
            this.lbMax.Text = "Max";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(25, 89);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(24, 13);
            this.lbMin.TabIndex = 3;
            this.lbMin.Text = "Min";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(25, 120);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(28, 13);
            this.lbDate.TabIndex = 4;
            this.lbDate.Text = "date";
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Location = new System.Drawing.Point(25, 163);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(74, 13);
            this.lbTemp.TabIndex = 5;
            this.lbTemp.Text = "Температура";
            this.lbTemp.Click += new System.EventHandler(this.lbTemp_Click);
            // 
            // tbFish
            // 
            this.tbFish.Location = new System.Drawing.Point(126, 23);
            this.tbFish.Name = "tbFish";
            this.tbFish.Size = new System.Drawing.Size(100, 20);
            this.tbFish.TabIndex = 6;
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(126, 58);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 20);
            this.tbMax.TabIndex = 7;
            this.tbMax.Text = "5";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(126, 89);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(100, 20);
            this.tbMin.TabIndex = 8;
            this.tbMin.Text = "-3";
            // 
            // tbTimeMax
            // 
            this.tbTimeMax.Location = new System.Drawing.Point(280, 58);
            this.tbTimeMax.Name = "tbTimeMax";
            this.tbTimeMax.ReadOnly = true;
            this.tbTimeMax.Size = new System.Drawing.Size(100, 20);
            this.tbTimeMax.TabIndex = 9;
            this.tbTimeMax.Text = "20";
            this.tbTimeMax.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbTimeMin
            // 
            this.tbTimeMin.Location = new System.Drawing.Point(280, 89);
            this.tbTimeMin.Name = "tbTimeMin";
            this.tbTimeMin.ReadOnly = true;
            this.tbTimeMin.Size = new System.Drawing.Size(100, 20);
            this.tbTimeMin.TabIndex = 10;
            this.tbTimeMin.Text = "60";
            this.tbTimeMin.TextChanged += new System.EventHandler(this.tbTimeMin_TextChanged);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(311, 30);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(30, 13);
            this.lbTime.TabIndex = 11;
            this.lbTime.Text = "Time";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(662, 20);
            this.textBox1.TabIndex = 12;
            // 
            // Temp_Monitoring_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.tbTimeMin);
            this.Controls.Add(this.tbTimeMax);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.tbFish);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.lbFish);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Temp_Monitoring_Form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Norm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otkl_Ot_Normu;
        private System.Windows.Forms.Label lbFish;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.TextBox tbFish;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbTimeMax;
        private System.Windows.Forms.TextBox tbTimeMin;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.TextBox textBox1;
    }
}

