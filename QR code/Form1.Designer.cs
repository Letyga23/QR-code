namespace QR_code
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
            this.geterateQR = new System.Windows.Forms.Button();
            this.saveQR = new System.Windows.Forms.Button();
            this.loadQR = new System.Windows.Forms.Button();
            this.readQR = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // geterateQR
            // 
            this.geterateQR.Location = new System.Drawing.Point(12, 214);
            this.geterateQR.Name = "geterateQR";
            this.geterateQR.Size = new System.Drawing.Size(170, 23);
            this.geterateQR.TabIndex = 0;
            this.geterateQR.Text = "Создать QR код";
            this.geterateQR.UseVisualStyleBackColor = true;
            this.geterateQR.Click += new System.EventHandler(this.geterateQR_Click);
            // 
            // saveQR
            // 
            this.saveQR.Location = new System.Drawing.Point(12, 243);
            this.saveQR.Name = "saveQR";
            this.saveQR.Size = new System.Drawing.Size(170, 23);
            this.saveQR.TabIndex = 1;
            this.saveQR.Text = "Сохранить QR код";
            this.saveQR.UseVisualStyleBackColor = true;
            this.saveQR.Click += new System.EventHandler(this.saveQR_Click);
            // 
            // loadQR
            // 
            this.loadQR.Location = new System.Drawing.Point(12, 272);
            this.loadQR.Name = "loadQR";
            this.loadQR.Size = new System.Drawing.Size(170, 23);
            this.loadQR.TabIndex = 2;
            this.loadQR.Text = "Загрузить QR код";
            this.loadQR.UseVisualStyleBackColor = true;
            this.loadQR.Click += new System.EventHandler(this.loadQR_Click);
            // 
            // readQR
            // 
            this.readQR.Location = new System.Drawing.Point(12, 301);
            this.readQR.Name = "readQR";
            this.readQR.Size = new System.Drawing.Size(170, 23);
            this.readQR.TabIndex = 3;
            this.readQR.Text = "Распознать QR код";
            this.readQR.UseVisualStyleBackColor = true;
            this.readQR.Click += new System.EventHandler(this.readQR_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 333);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.readQR);
            this.Controls.Add(this.loadQR);
            this.Controls.Add(this.saveQR);
            this.Controls.Add(this.geterateQR);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geterateQR;
        private System.Windows.Forms.Button saveQR;
        private System.Windows.Forms.Button loadQR;
        private System.Windows.Forms.Button readQR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

