namespace GameLife
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
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStep = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.groupCell = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.SandyBrown;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRun.Location = new System.Drawing.Point(0, 0);
            this.btnRun.Margin = new System.Windows.Forms.Padding(0);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(130, 30);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnStep
            // 
            this.btnStep.BackColor = System.Drawing.Color.SandyBrown;
            this.btnStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStep.Location = new System.Drawing.Point(208, 0);
            this.btnStep.Margin = new System.Windows.Forms.Padding(0);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(130, 30);
            this.btnStep.TabIndex = 1;
            this.btnStep.Text = "One step";
            this.btnStep.UseVisualStyleBackColor = false;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClean.Location = new System.Drawing.Point(412, 0);
            this.btnClean.Margin = new System.Windows.Forms.Padding(0);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(130, 30);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.SandyBrown;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRandom.Location = new System.Drawing.Point(614, 0);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(0);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(130, 30);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // sizeBox
            // 
            this.sizeBox.BackColor = System.Drawing.Color.Snow;
            this.sizeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sizeBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Items.AddRange(new object[] {
            "10",
            "30",
            "60",
            "90"});
            this.sizeBox.Location = new System.Drawing.Point(810, 0);
            this.sizeBox.Margin = new System.Windows.Forms.Padding(0);
            this.sizeBox.MinimumSize = new System.Drawing.Size(60, 0);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(90, 27);
            this.sizeBox.TabIndex = 4;
            this.sizeBox.SelectedIndexChanged += new System.EventHandler(this.sizeBox_SelectedIndexChanged);
            // 
            // groupCell
            // 
            this.groupCell.BackColor = System.Drawing.Color.White;
            this.groupCell.Location = new System.Drawing.Point(0, 30);
            this.groupCell.Margin = new System.Windows.Forms.Padding(0);
            this.groupCell.Name = "groupCell";
            this.groupCell.Padding = new System.Windows.Forms.Padding(0);
            this.groupCell.Size = new System.Drawing.Size(900, 900);
            this.groupCell.TabIndex = 5;
            this.groupCell.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(900, 931);
            this.Controls.Add(this.groupCell);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnStep);
            this.Controls.Add(this.btnRun);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра Жизнь";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.GroupBox groupCell;
    }
}

