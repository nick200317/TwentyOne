namespace TwentyOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Give = new System.Windows.Forms.Button();
            this.btn_End = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_1.Location = new System.Drawing.Point(8, 225);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(115, 24);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "Ваша рука:";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_2.Location = new System.Drawing.Point(12, 9);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(182, 24);
            this.lbl_2.TabIndex = 1;
            this.lbl_2.Text = "Рука противника:";
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Start.Location = new System.Drawing.Point(12, 170);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(111, 52);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Старт";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Give
            // 
            this.btn_Give.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Give.Location = new System.Drawing.Point(129, 170);
            this.btn_Give.Name = "btn_Give";
            this.btn_Give.Size = new System.Drawing.Size(121, 51);
            this.btn_Give.TabIndex = 3;
            this.btn_Give.Text = "Попросить ещё";
            this.btn_Give.UseVisualStyleBackColor = true;
            // 
            // btn_End
            // 
            this.btn_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_End.Location = new System.Drawing.Point(256, 170);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(113, 50);
            this.btn_End.TabIndex = 4;
            this.btn_End.Text = "Закончить";
            this.btn_End.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 418);
            this.Controls.Add(this.btn_End);
            this.Controls.Add(this.btn_Give);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Двадцать Одно";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Give;
        private System.Windows.Forms.Button btn_End;
    }
}

