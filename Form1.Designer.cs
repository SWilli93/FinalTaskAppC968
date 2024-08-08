namespace FinalTaskAppC968
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label3 = new Label();
            listView2 = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            button9 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ControlDark;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Location = new Point(19, 124);
            listView1.Name = "listView1";
            listView1.Size = new Size(485, 173);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Part ID";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Inventory";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Price";
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Min";
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Max";
            columnHeader6.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(19, 83);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 1;
            label1.Text = "Parts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(19, 26);
            label2.Name = "label2";
            label2.Size = new Size(227, 21);
            label2.TabIndex = 2;
            label2.Text = "Inventory Management System";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(384, 303);
            button1.Name = "button1";
            button1.Size = new Size(55, 23);
            button1.TabIndex = 3;
            button1.Text = "Modify";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(445, 303);
            button2.Name = "button2";
            button2.Size = new Size(55, 23);
            button2.TabIndex = 4;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F);
            button3.Location = new Point(323, 303);
            button3.Name = "button3";
            button3.Size = new Size(55, 23);
            button3.TabIndex = 5;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(244, 84);
            button4.Name = "button4";
            button4.Size = new Size(50, 23);
            button4.TabIndex = 6;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(300, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(822, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 14;
            // 
            // button5
            // 
            button5.Location = new Point(766, 84);
            button5.Name = "button5";
            button5.Size = new Size(50, 23);
            button5.TabIndex = 13;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F);
            button6.Location = new Point(845, 303);
            button6.Name = "button6";
            button6.Size = new Size(55, 23);
            button6.TabIndex = 12;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9F);
            button7.Location = new Point(967, 303);
            button7.Name = "button7";
            button7.Size = new Size(55, 23);
            button7.TabIndex = 11;
            button7.Text = "Delete";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F);
            button8.Location = new Point(906, 303);
            button8.Name = "button8";
            button8.Size = new Size(55, 23);
            button8.TabIndex = 10;
            button8.Text = "Modify";
            button8.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(541, 83);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 9;
            label3.Text = "Products";
            // 
            // listView2
            // 
            listView2.BackColor = SystemColors.ControlDark;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            listView2.Location = new Point(541, 124);
            listView2.Name = "listView2";
            listView2.Size = new Size(485, 173);
            listView2.TabIndex = 8;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Product ID";
            columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Name";
            columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Inventory";
            columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Price";
            columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Min";
            columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Max";
            columnHeader12.Width = 80;
            // 
            // button9
            // 
            button9.Location = new Point(947, 363);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 15;
            button9.Text = "Exit";
            button9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 411);
            Controls.Add(button9);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(label3);
            Controls.Add(listView2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label3;
        private ListView listView2;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private Button button9;
    }
}
