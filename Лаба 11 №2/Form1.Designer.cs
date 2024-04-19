namespace Лаба_11__2
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            generateButton = new Button();
            Cleaner = new Button();
            sortButton = new Button();
            SearchButton = new Button();
            textBox1 = new TextBox();
            vScrollBar1 = new VScrollBar();
            vScrollBar2 = new VScrollBar();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(10, 9);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(387, 349);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(456, 9);
            listBox2.Margin = new Padding(3, 2, 3, 2);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(385, 349);
            listBox2.TabIndex = 1;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(10, 376);
            generateButton.Margin = new Padding(3, 2, 3, 2);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(104, 22);
            generateButton.TabIndex = 2;
            generateButton.Text = "сгенерировать";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += GenerateButton_Click;
            // 
            // Cleaner
            // 
            Cleaner.Location = new Point(315, 376);
            Cleaner.Margin = new Padding(3, 2, 3, 2);
            Cleaner.Name = "Cleaner";
            Cleaner.Size = new Size(82, 22);
            Cleaner.TabIndex = 3;
            Cleaner.Text = "очистить";
            Cleaner.UseVisualStyleBackColor = true;
            Cleaner.Click += Cleaner_Click;
            // 
            // sortButton
            // 
            sortButton.Location = new Point(456, 376);
            sortButton.Margin = new Padding(3, 2, 3, 2);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(98, 22);
            sortButton.TabIndex = 4;
            sortButton.Text = "Сортировать";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(758, 378);
            SearchButton.Margin = new Padding(3, 2, 3, 2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(82, 22);
            SearchButton.TabIndex = 5;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(630, 378);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 6;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(843, 9);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 348);
            vScrollBar1.TabIndex = 7;
            // 
            // vScrollBar2
            // 
            vScrollBar2.Location = new Point(400, 9);
            vScrollBar2.Name = "vScrollBar2";
            vScrollBar2.Size = new Size(26, 348);
            vScrollBar2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 425);
            Controls.Add(vScrollBar2);
            Controls.Add(vScrollBar1);
            Controls.Add(textBox1);
            Controls.Add(SearchButton);
            Controls.Add(sortButton);
            Controls.Add(Cleaner);
            Controls.Add(generateButton);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button generateButton;
        private Button Cleaner;
        private Button sortButton;
        private Button SearchButton;
        private TextBox textBox1;
        private VScrollBar vScrollBar1;
        private VScrollBar vScrollBar2;
    }
}
