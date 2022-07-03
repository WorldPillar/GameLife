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
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRun.Location = new System.Drawing.Point(0, 0);
            this.btnRun.Margin = new System.Windows.Forms.Padding(0);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(80, 30);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnStep
            // 
            this.btnStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStep.Location = new System.Drawing.Point(80, 0);
            this.btnStep.Margin = new System.Windows.Forms.Padding(0);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(79, 30);
            this.btnStep.TabIndex = 1;
            this.btnStep.Text = "One step";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // btnClean
            // 
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClean.Location = new System.Drawing.Point(159, 0);
            this.btnClean.Margin = new System.Windows.Forms.Padding(0);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(80, 30);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRandom.Location = new System.Drawing.Point(239, 0);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(0);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(80, 30);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 631);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnStep);
            this.Controls.Add(this.btnRun);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра Жизнь";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnRandom;
    }
}

