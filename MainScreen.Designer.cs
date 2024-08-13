namespace FinalTaskAppC968
{
    partial class MainScreen
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
            MainScreenPartModifyButton = new Button();
            MainScreenPartDeleteButton = new Button();
            MainScreenPartAddButton = new Button();
            PartSearchButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ProductSearchButton = new Button();
            MainScreenProductAddButton = new Button();
            MainScreenProductDeleteButton = new Button();
            MainScreenProductModifyButton = new Button();
            label3 = new Label();
            listView2 = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            MainScreenExitButton = new Button();
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
            // MainScreenPartModifyButton
            // 
            MainScreenPartModifyButton.Font = new Font("Segoe UI", 9F);
            MainScreenPartModifyButton.Location = new Point(384, 303);
            MainScreenPartModifyButton.Name = "MainScreenPartModifyButton";
            MainScreenPartModifyButton.Size = new Size(55, 23);
            MainScreenPartModifyButton.TabIndex = 3;
            MainScreenPartModifyButton.Text = "Modify";
            MainScreenPartModifyButton.UseVisualStyleBackColor = true;
            MainScreenPartModifyButton.Click += MainScreenPartModifyButton_Click;
            // 
            // MainScreenPartDeleteButton
            // 
            MainScreenPartDeleteButton.Font = new Font("Segoe UI", 9F);
            MainScreenPartDeleteButton.Location = new Point(445, 303);
            MainScreenPartDeleteButton.Name = "MainScreenPartDeleteButton";
            MainScreenPartDeleteButton.Size = new Size(55, 23);
            MainScreenPartDeleteButton.TabIndex = 4;
            MainScreenPartDeleteButton.Text = "Delete";
            MainScreenPartDeleteButton.UseVisualStyleBackColor = true;
            // 
            // MainScreenPartAddButton
            // 
            MainScreenPartAddButton.Font = new Font("Segoe UI", 9F);
            MainScreenPartAddButton.Location = new Point(323, 303);
            MainScreenPartAddButton.Name = "MainScreenPartAddButton";
            MainScreenPartAddButton.Size = new Size(55, 23);
            MainScreenPartAddButton.TabIndex = 5;
            MainScreenPartAddButton.Text = "Add";
            MainScreenPartAddButton.UseVisualStyleBackColor = true;
            MainScreenPartAddButton.Click += MainScreenPartAddButton_Click;
            // 
            // PartSearchButton
            // 
            PartSearchButton.Location = new Point(244, 84);
            PartSearchButton.Name = "PartSearchButton";
            PartSearchButton.Size = new Size(50, 23);
            PartSearchButton.TabIndex = 6;
            PartSearchButton.Text = "Search";
            PartSearchButton.UseVisualStyleBackColor = true;
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
            // ProductSearchButton
            // 
            ProductSearchButton.Location = new Point(766, 84);
            ProductSearchButton.Name = "ProductSearchButton";
            ProductSearchButton.Size = new Size(50, 23);
            ProductSearchButton.TabIndex = 13;
            ProductSearchButton.Text = "Search";
            ProductSearchButton.UseVisualStyleBackColor = true;
            // 
            // MainScreenProductAddButton
            // 
            MainScreenProductAddButton.Font = new Font("Segoe UI", 9F);
            MainScreenProductAddButton.Location = new Point(845, 303);
            MainScreenProductAddButton.Name = "MainScreenProductAddButton";
            MainScreenProductAddButton.Size = new Size(55, 23);
            MainScreenProductAddButton.TabIndex = 12;
            MainScreenProductAddButton.Text = "Add";
            MainScreenProductAddButton.UseVisualStyleBackColor = true;
            // 
            // MainScreenProductDeleteButton
            // 
            MainScreenProductDeleteButton.Font = new Font("Segoe UI", 9F);
            MainScreenProductDeleteButton.Location = new Point(967, 303);
            MainScreenProductDeleteButton.Name = "MainScreenProductDeleteButton";
            MainScreenProductDeleteButton.Size = new Size(55, 23);
            MainScreenProductDeleteButton.TabIndex = 11;
            MainScreenProductDeleteButton.Text = "Delete";
            MainScreenProductDeleteButton.UseVisualStyleBackColor = true;
            // 
            // MainScreenProductModifyButton
            // 
            MainScreenProductModifyButton.Font = new Font("Segoe UI", 9F);
            MainScreenProductModifyButton.Location = new Point(906, 303);
            MainScreenProductModifyButton.Name = "MainScreenProductModifyButton";
            MainScreenProductModifyButton.Size = new Size(55, 23);
            MainScreenProductModifyButton.TabIndex = 10;
            MainScreenProductModifyButton.Text = "Modify";
            MainScreenProductModifyButton.UseVisualStyleBackColor = true;
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
            // MainScreenExitButton
            // 
            MainScreenExitButton.Location = new Point(947, 363);
            MainScreenExitButton.Name = "MainScreenExitButton";
            MainScreenExitButton.Size = new Size(75, 23);
            MainScreenExitButton.TabIndex = 15;
            MainScreenExitButton.Text = "Exit";
            MainScreenExitButton.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 411);
            Controls.Add(MainScreenExitButton);
            Controls.Add(textBox2);
            Controls.Add(ProductSearchButton);
            Controls.Add(MainScreenProductAddButton);
            Controls.Add(MainScreenProductDeleteButton);
            Controls.Add(MainScreenProductModifyButton);
            Controls.Add(label3);
            Controls.Add(listView2);
            Controls.Add(textBox1);
            Controls.Add(PartSearchButton);
            Controls.Add(MainScreenPartAddButton);
            Controls.Add(MainScreenPartDeleteButton);
            Controls.Add(MainScreenPartModifyButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "MainScreen";
            Text = "Main Screen";
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
        private Button MainScreenPartModifyButton;
        private Button MainScreenPartDeleteButton;
        private Button MainScreenPartAddButton;
        private Button PartSearchButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button ProductSearchButton;
        private Button MainScreenProductAddButton;
        private Button MainScreenProductDeleteButton;
        private Button MainScreenProductModifyButton;
        private Label label3;
        private ListView listView2;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private Button MainScreenExitButton;
    }
}
