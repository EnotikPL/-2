namespace лаба10_1
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
            label1 = new Label();
            buttonAmount = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TextBook = new TextBox();
            PencilCost = new TextBox();
            Pencil = new TextBox();
            TextBookCost = new TextBox();
            textBoxSumm = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Cascadia Code SemiLight", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(456, 43);
            label1.TabIndex = 2;
            label1.Text = "Введите цену тетрдаи Ct";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonAmount
            // 
            buttonAmount.Dock = DockStyle.Bottom;
            buttonAmount.Font = new Font("Cascadia Code Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAmount.Location = new Point(0, 488);
            buttonAmount.Name = "buttonAmount";
            buttonAmount.Size = new Size(1077, 110);
            buttonAmount.TabIndex = 3;
            buttonAmount.Text = "Нажми чтобы посчитать";
            buttonAmount.UseVisualStyleBackColor = true;
            buttonAmount.Click += buttonAmount_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Cascadia Code SemiLight", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(589, 43);
            label2.TabIndex = 6;
            label2.Text = "Введите количество тетрадей Kt";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Cascadia Code SemiLight", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 152);
            label3.Name = "label3";
            label3.Size = new Size(513, 43);
            label3.TabIndex = 7;
            label3.Text = "Введите цену карандашей Ck";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Cascadia Code SemiLight", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 219);
            label4.Name = "label4";
            label4.Size = new Size(513, 43);
            label4.TabIndex = 8;
            label4.Text = "Введите цену карандашей KK";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBook
            // 
            TextBook.Font = new Font("Cascadia Code Light", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBook.Location = new Point(607, 18);
            TextBook.Name = "TextBook";
            TextBook.Size = new Size(261, 45);
            TextBook.TabIndex = 9;
            TextBook.TextAlign = HorizontalAlignment.Center;
            // 
            // PencilCost
            // 
            PencilCost.Font = new Font("Cascadia Code Light", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PencilCost.Location = new Point(607, 216);
            PencilCost.Name = "PencilCost";
            PencilCost.Size = new Size(261, 45);
            PencilCost.TabIndex = 10;
            PencilCost.TextAlign = HorizontalAlignment.Center;
            // 
            // Pencil
            // 
            Pencil.Font = new Font("Cascadia Code Light", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pencil.Location = new Point(607, 152);
            Pencil.Name = "Pencil";
            Pencil.Size = new Size(261, 45);
            Pencil.TabIndex = 11;
            Pencil.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBookCost
            // 
            TextBookCost.Font = new Font("Cascadia Code Light", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBookCost.Location = new Point(607, 83);
            TextBookCost.Name = "TextBookCost";
            TextBookCost.Size = new Size(261, 45);
            TextBookCost.TabIndex = 12;
            TextBookCost.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxSumm
            // 
            textBoxSumm.Font = new Font("Cascadia Code Light", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSumm.Location = new Point(331, 359);
            textBoxSumm.Name = "textBoxSumm";
            textBoxSumm.Size = new Size(405, 45);
            textBoxSumm.TabIndex = 13;
            textBoxSumm.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1077, 598);
            Controls.Add(textBoxSumm);
            Controls.Add(TextBookCost);
            Controls.Add(Pencil);
            Controls.Add(PencilCost);
            Controls.Add(TextBook);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonAmount);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button buttonAmount;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TextBook;
        private TextBox PencilCost;
        private TextBox Pencil;
        private TextBox TextBookCost;
        private TextBox textBoxSumm;
    }
}
