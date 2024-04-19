namespace Лаба_10__2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            trackBar1 = new TrackBar();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Dock = DockStyle.Left;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(256, 461);
            button1.TabIndex = 0;
            button1.Text = "счёт по формуле суммы";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(225, 225, 0);
            button2.Dock = DockStyle.Right;
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(771, 0);
            button2.Name = "button2";
            button2.Size = new Size(236, 461);
            button2.TabIndex = 1;
            button2.Text = "счёт суммированием в цикле";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(413, 339);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 93);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(340, 299);
            label2.Name = "label2";
            label2.Size = new Size(401, 37);
            label2.TabIndex = 5;
            label2.Text = "Вывод посчитанного значения";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(262, 226);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(492, 45);
            trackBar1.TabIndex = 6;
            trackBar1.Tag = "";
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 26.2499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(528, 173);
            label3.Name = "label3";
            label3.Size = new Size(0, 50);
            label3.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(471, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 93);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(254, 80);
            label1.Name = "label1";
            label1.Size = new Size(511, 35);
            label1.TabIndex = 9;
            label1.Text = "Выберите значение n от 1 до 100";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 461);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(trackBar1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private TrackBar trackBar1;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
    }
}
