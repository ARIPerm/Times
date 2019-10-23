namespace Times
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HoursUp = new System.Windows.Forms.NumericUpDown();
            this.MinutesUp = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateTimeButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MinutesAdd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.AddTimButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CountTime = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DeleteTimeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MinutesDelete = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesUp)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesAdd)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateTimeButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MinutesUp);
            this.groupBox1.Controls.Add(this.HoursUp);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create time";
            // 
            // HoursUp
            // 
            this.HoursUp.Location = new System.Drawing.Point(80, 21);
            this.HoursUp.Name = "HoursUp";
            this.HoursUp.Size = new System.Drawing.Size(76, 22);
            this.HoursUp.TabIndex = 1;
            // 
            // MinutesUp
            // 
            this.MinutesUp.Location = new System.Drawing.Point(80, 49);
            this.MinutesUp.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinutesUp.Name = "MinutesUp";
            this.MinutesUp.Size = new System.Drawing.Size(76, 22);
            this.MinutesUp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minutes";
            // 
            // CreateTimeButton
            // 
            this.CreateTimeButton.Location = new System.Drawing.Point(172, 20);
            this.CreateTimeButton.Name = "CreateTimeButton";
            this.CreateTimeButton.Size = new System.Drawing.Size(75, 51);
            this.CreateTimeButton.TabIndex = 5;
            this.CreateTimeButton.Text = "Create time";
            this.CreateTimeButton.UseVisualStyleBackColor = true;
            this.CreateTimeButton.Click += new System.EventHandler(this.CreateTimeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddTimButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.MinutesAdd);
            this.groupBox2.Location = new System.Drawing.Point(13, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add time";
            // 
            // MinutesAdd
            // 
            this.MinutesAdd.Location = new System.Drawing.Point(79, 31);
            this.MinutesAdd.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinutesAdd.Name = "MinutesAdd";
            this.MinutesAdd.Size = new System.Drawing.Size(76, 22);
            this.MinutesAdd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Minutes";
            // 
            // AddTimButton
            // 
            this.AddTimButton.Location = new System.Drawing.Point(171, 17);
            this.AddTimButton.Name = "AddTimButton";
            this.AddTimButton.Size = new System.Drawing.Size(75, 48);
            this.AddTimButton.TabIndex = 7;
            this.AddTimButton.Text = "Add time";
            this.AddTimButton.UseVisualStyleBackColor = true;
            this.AddTimButton.Click += new System.EventHandler(this.AddTimButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 38;
            this.listBox1.Location = new System.Drawing.Point(279, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 346);
            this.listBox1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CountTime);
            this.groupBox3.Location = new System.Drawing.Point(486, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 62);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Count time";
            // 
            // CountTime
            // 
            this.CountTime.Location = new System.Drawing.Point(6, 25);
            this.CountTime.Name = "CountTime";
            this.CountTime.ReadOnly = true;
            this.CountTime.Size = new System.Drawing.Size(153, 22);
            this.CountTime.TabIndex = 4;
            this.CountTime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DeleteTimeButton);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.MinutesDelete);
            this.groupBox4.Location = new System.Drawing.Point(12, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 73);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete time";
            // 
            // DeleteTimeButton
            // 
            this.DeleteTimeButton.Location = new System.Drawing.Point(171, 17);
            this.DeleteTimeButton.Name = "DeleteTimeButton";
            this.DeleteTimeButton.Size = new System.Drawing.Size(75, 50);
            this.DeleteTimeButton.TabIndex = 7;
            this.DeleteTimeButton.Text = "Delete time";
            this.DeleteTimeButton.UseVisualStyleBackColor = true;
            this.DeleteTimeButton.Click += new System.EventHandler(this.DeleteTimeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Minutes";
            // 
            // MinutesDelete
            // 
            this.MinutesDelete.Location = new System.Drawing.Point(80, 32);
            this.MinutesDelete.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinutesDelete.Name = "MinutesDelete";
            this.MinutesDelete.Size = new System.Drawing.Size(76, 22);
            this.MinutesDelete.TabIndex = 3;
            this.MinutesDelete.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 455);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Times";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesUp)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesAdd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CreateTimeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MinutesUp;
        private System.Windows.Forms.NumericUpDown HoursUp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddTimButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MinutesAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox CountTime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button DeleteTimeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown MinutesDelete;
    }
}

