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
            this.dgvGrafik = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Norm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otkl_Ot_Normu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbFish = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTemp = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbTimeMax = new System.Windows.Forms.TextBox();
            this.tbTimeMin = new System.Windows.Forms.TextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.lbOtchet = new System.Windows.Forms.Label();
            this.btGraf = new System.Windows.Forms.Button();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.tbOtchet = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btDown = new System.Windows.Forms.Button();
            this.tbFish = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrafik
            // 
            this.dgvGrafik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.Fact,
            this.Norm,
            this.Otkl_Ot_Normu});
            this.dgvGrafik.Location = new System.Drawing.Point(25, 262);
            this.dgvGrafik.Name = "dgvGrafik";
            this.dgvGrafik.Size = new System.Drawing.Size(544, 261);
            this.dgvGrafik.TabIndex = 0;
            this.dgvGrafik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrafik_CellContentClick);
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
            this.lbFish.Location = new System.Drawing.Point(22, 16);
            this.lbFish.Name = "lbFish";
            this.lbFish.Size = new System.Drawing.Size(57, 13);
            this.lbFish.TabIndex = 1;
            this.lbFish.Text = "Вид рыбы";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(25, 48);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(27, 13);
            this.lbMax.TabIndex = 2;
            this.lbMax.Text = "Max";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(25, 79);
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
            this.lbTemp.Location = new System.Drawing.Point(24, 160);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(74, 13);
            this.lbTemp.TabIndex = 5;
            this.lbTemp.Text = "Температура";
            this.lbTemp.Click += new System.EventHandler(this.lbTemp_Click);
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(126, 48);
            this.tbMax.Name = "tbMax";
            this.tbMax.ReadOnly = true;
            this.tbMax.Size = new System.Drawing.Size(100, 20);
            this.tbMax.TabIndex = 7;
            this.tbMax.Text = "5";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(126, 79);
            this.tbMin.Name = "tbMin";
            this.tbMin.ReadOnly = true;
            this.tbMin.Size = new System.Drawing.Size(100, 20);
            this.tbMin.TabIndex = 8;
            this.tbMin.Text = "-3";
            this.tbMin.TextChanged += new System.EventHandler(this.tbMin_TextChanged);
            // 
            // tbTimeMax
            // 
            this.tbTimeMax.Location = new System.Drawing.Point(280, 48);
            this.tbTimeMax.Name = "tbTimeMax";
            this.tbTimeMax.ReadOnly = true;
            this.tbTimeMax.Size = new System.Drawing.Size(100, 20);
            this.tbTimeMax.TabIndex = 9;
            this.tbTimeMax.Text = "20";
            this.tbTimeMax.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbTimeMin
            // 
            this.tbTimeMin.Location = new System.Drawing.Point(280, 79);
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
            this.lbTime.Location = new System.Drawing.Point(311, 20);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(30, 13);
            this.lbTime.TabIndex = 11;
            this.lbTime.Text = "Time";
            // 
            // tbTemp
            // 
            this.tbTemp.Location = new System.Drawing.Point(126, 157);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.Size = new System.Drawing.Size(662, 20);
            this.tbTemp.TabIndex = 12;
            this.tbTemp.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lbOtchet
            // 
            this.lbOtchet.AutoSize = true;
            this.lbOtchet.Location = new System.Drawing.Point(25, 194);
            this.lbOtchet.Name = "lbOtchet";
            this.lbOtchet.Size = new System.Drawing.Size(36, 13);
            this.lbOtchet.TabIndex = 14;
            this.lbOtchet.Text = "Отчет";
            // 
            // btGraf
            // 
            this.btGraf.Location = new System.Drawing.Point(652, 500);
            this.btGraf.Name = "btGraf";
            this.btGraf.Size = new System.Drawing.Size(75, 23);
            this.btGraf.TabIndex = 16;
            this.btGraf.Text = "Рассчитать";
            this.btGraf.UseVisualStyleBackColor = true;
            this.btGraf.Click += new System.EventHandler(this.btGraf_Click);
            // 
            // mtbDate
            // 
            this.mtbDate.Location = new System.Drawing.Point(126, 117);
            this.mtbDate.Mask = "00/00/0000 90:00";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(100, 20);
            this.mtbDate.TabIndex = 17;
            this.mtbDate.ValidatingType = typeof(System.DateTime);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(652, 433);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 18;
            this.btClear.Text = "clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // tbOtchet
            // 
            this.tbOtchet.Location = new System.Drawing.Point(28, 229);
            this.tbOtchet.Name = "tbOtchet";
            this.tbOtchet.ReadOnly = true;
            this.tbOtchet.Size = new System.Drawing.Size(760, 20);
            this.tbOtchet.TabIndex = 19;
            this.tbOtchet.TextChanged += new System.EventHandler(this.tbOtchet_TextChanged);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(652, 381);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 20;
            this.btSave.Text = "сохранение";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDown
            // 
            this.btDown.Location = new System.Drawing.Point(686, 120);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(75, 23);
            this.btDown.TabIndex = 21;
            this.btDown.Text = "загрузить";
            this.btDown.UseVisualStyleBackColor = true;
            this.btDown.Click += new System.EventHandler(this.btDown_Click);
            // 
            // tbFish
            // 
            this.tbFish.Location = new System.Drawing.Point(126, 13);
            this.tbFish.Name = "tbFish";
            this.tbFish.ReadOnly = true;
            this.tbFish.Size = new System.Drawing.Size(100, 20);
            this.tbFish.TabIndex = 22;
            this.tbFish.Text = "Семга";
            // 
            // Temp_Monitoring_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.tbFish);
            this.Controls.Add(this.btDown);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbOtchet);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.mtbDate);
            this.Controls.Add(this.btGraf);
            this.Controls.Add(this.lbOtchet);
            this.Controls.Add(this.tbTemp);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.tbTimeMin);
            this.Controls.Add(this.tbTimeMax);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.lbFish);
            this.Controls.Add(this.dgvGrafik);
            this.Name = "Temp_Monitoring_Form";
            this.Text = "Temp_Monitoring_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrafik;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Norm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otkl_Ot_Normu;
        private System.Windows.Forms.Label lbFish;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbTimeMax;
        private System.Windows.Forms.TextBox tbTimeMin;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.Label lbOtchet;
        private System.Windows.Forms.Button btGraf;
        private System.Windows.Forms.MaskedTextBox mtbDate;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox tbOtchet;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btDown;
        private System.Windows.Forms.TextBox tbFish;
    }
}

