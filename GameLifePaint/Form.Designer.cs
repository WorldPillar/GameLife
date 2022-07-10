namespace GameLifePaint
{
    partial class Form
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
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnStep = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.tickBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sizeBox
            // 
            this.sizeBox.BackColor = System.Drawing.Color.White;
            this.sizeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sizeBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.sizeBox.Items.AddRange(new object[] {
            "Масштаб",
            "10",
            "50",
            "100",
            "150",
            "300",
            "450"});
            this.sizeBox.Location = new System.Drawing.Point(803, 2);
            this.sizeBox.Margin = new System.Windows.Forms.Padding(0);
            this.sizeBox.MinimumSize = new System.Drawing.Size(60, 0);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(97, 27);
            this.sizeBox.TabIndex = 9;
            this.sizeBox.TabStop = false;
            this.sizeBox.SelectedIndexChanged += new System.EventHandler(this.sizeBox_SelectedIndexChanged);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.LightGray;
            this.btnRandom.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRandom.Location = new System.Drawing.Point(540, 0);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(0);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(181, 30);
            this.btnRandom.TabIndex = 8;
            this.btnRandom.TabStop = false;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.LightGray;
            this.btnClean.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClean.Location = new System.Drawing.Point(360, 0);
            this.btnClean.Margin = new System.Windows.Forms.Padding(0);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(181, 30);
            this.btnClean.TabIndex = 7;
            this.btnClean.TabStop = false;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnStep
            // 
            this.btnStep.BackColor = System.Drawing.Color.LightGray;
            this.btnStep.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStep.Location = new System.Drawing.Point(180, 0);
            this.btnStep.Margin = new System.Windows.Forms.Padding(0);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(181, 30);
            this.btnStep.TabIndex = 6;
            this.btnStep.TabStop = false;
            this.btnStep.Text = "Step";
            this.btnStep.UseVisualStyleBackColor = false;
            this.btnStep.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.LightGray;
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRun.Location = new System.Drawing.Point(0, 0);
            this.btnRun.Margin = new System.Windows.Forms.Padding(0);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(181, 30);
            this.btnRun.TabIndex = 5;
            this.btnRun.TabStop = false;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.Color.White;
            this.pBox.Location = new System.Drawing.Point(0, 30);
            this.pBox.Margin = new System.Windows.Forms.Padding(0);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(900, 900);
            this.pBox.TabIndex = 0;
            this.pBox.TabStop = false;
            this.pBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBox_MouseClick);
            // 
            // tickBox
            // 
            this.tickBox.BackColor = System.Drawing.Color.White;
            this.tickBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tickBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tickBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tickBox.FormattingEnabled = true;
            this.tickBox.Items.AddRange(new object[] {
            "Тик",
            "10",
            "100",
            "200",
            "500",
            "1000"});
            this.tickBox.Location = new System.Drawing.Point(721, 2);
            this.tickBox.Margin = new System.Windows.Forms.Padding(0);
            this.tickBox.Name = "tickBox";
            this.tickBox.Size = new System.Drawing.Size(82, 27);
            this.tickBox.TabIndex = 10;
            this.tickBox.TabStop = false;
            this.tickBox.SelectedIndexChanged += new System.EventHandler(this.tickBox_SelectedIndexChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 930);
            this.Controls.Add(this.tickBox);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnStep);
            this.Controls.Add(this.btnRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form";
            this.Text = "GameLife";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.ComboBox tickBox;
        private System.Windows.Forms.ComboBox sizeBox;
    }
}

