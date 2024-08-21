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
            label1 = new Label();
            label2 = new Label();
            MainScreenPartModifyButton = new Button();
            MainScreenPartDeleteButton = new Button();
            MainScreenPartAddButton = new Button();
            MainScreenPartSearchButton = new Button();
            MainScreenSearchPartTextBox = new TextBox();
            MainScreenSearchProductsTextBox = new TextBox();
            MainScreenProductSearchButton = new Button();
            MainScreenProductAddButton = new Button();
            MainScreenProductDeleteButton = new Button();
            MainScreenProductModifyButton = new Button();
            label3 = new Label();
            MainScreenExitButton = new Button();
            dataGridViewMainScreenParts = new DataGridView();
            dataGridViewMainScreenProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMainScreenParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMainScreenProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(19, 83);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 2002;
            label1.Text = "Parts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(19, 26);
            label2.Name = "label2";
            label2.Size = new Size(227, 21);
            label2.TabIndex = 2000;
            label2.Text = "Inventory Management System";
            // 
            // MainScreenPartModifyButton
            // 
            MainScreenPartModifyButton.Font = new Font("Segoe UI", 9F);
            MainScreenPartModifyButton.Location = new Point(384, 303);
            MainScreenPartModifyButton.Name = "MainScreenPartModifyButton";
            MainScreenPartModifyButton.Size = new Size(55, 23);
            MainScreenPartModifyButton.TabIndex = 5;
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
            MainScreenPartDeleteButton.TabIndex = 6;
            MainScreenPartDeleteButton.Text = "Delete";
            MainScreenPartDeleteButton.UseVisualStyleBackColor = true;
            MainScreenPartDeleteButton.Click += MainScreenPartDeleteButton_Click;
            // 
            // MainScreenPartAddButton
            // 
            MainScreenPartAddButton.Font = new Font("Segoe UI", 9F);
            MainScreenPartAddButton.Location = new Point(323, 303);
            MainScreenPartAddButton.Name = "MainScreenPartAddButton";
            MainScreenPartAddButton.Size = new Size(55, 23);
            MainScreenPartAddButton.TabIndex = 4;
            MainScreenPartAddButton.Text = "Add";
            MainScreenPartAddButton.UseVisualStyleBackColor = true;
            MainScreenPartAddButton.Click += MainScreenPartAddButton_Click;
            // 
            // MainScreenPartSearchButton
            // 
            MainScreenPartSearchButton.Location = new Point(244, 84);
            MainScreenPartSearchButton.Name = "MainScreenPartSearchButton";
            MainScreenPartSearchButton.Size = new Size(50, 23);
            MainScreenPartSearchButton.TabIndex = 1;
            MainScreenPartSearchButton.Text = "Search";
            MainScreenPartSearchButton.UseVisualStyleBackColor = true;
            MainScreenPartSearchButton.Click += MainScreenPartSearchButton_Click;
            // 
            // MainScreenSearchPartTextBox
            // 
            MainScreenSearchPartTextBox.Location = new Point(300, 84);
            MainScreenSearchPartTextBox.Name = "MainScreenSearchPartTextBox";
            MainScreenSearchPartTextBox.Size = new Size(200, 23);
            MainScreenSearchPartTextBox.TabIndex = 2;
            MainScreenSearchPartTextBox.MouseLeave += MainScreenSearchPartTextBox_MouseLeave;
            // 
            // MainScreenSearchProductsTextBox
            // 
            MainScreenSearchProductsTextBox.Location = new Point(822, 84);
            MainScreenSearchProductsTextBox.Name = "MainScreenSearchProductsTextBox";
            MainScreenSearchProductsTextBox.Size = new Size(200, 23);
            MainScreenSearchProductsTextBox.TabIndex = 8;
            MainScreenSearchProductsTextBox.MouseLeave += MainScreenSearchProductsTextBox_MouseLeave;
            // 
            // MainScreenProductSearchButton
            // 
            MainScreenProductSearchButton.Location = new Point(766, 84);
            MainScreenProductSearchButton.Name = "MainScreenProductSearchButton";
            MainScreenProductSearchButton.Size = new Size(50, 23);
            MainScreenProductSearchButton.TabIndex = 7;
            MainScreenProductSearchButton.Text = "Search";
            MainScreenProductSearchButton.UseVisualStyleBackColor = true;
            MainScreenProductSearchButton.Click += MainScreenProductSearchButton_Click;
            // 
            // MainScreenProductAddButton
            // 
            MainScreenProductAddButton.Font = new Font("Segoe UI", 9F);
            MainScreenProductAddButton.Location = new Point(845, 303);
            MainScreenProductAddButton.Name = "MainScreenProductAddButton";
            MainScreenProductAddButton.Size = new Size(55, 23);
            MainScreenProductAddButton.TabIndex = 10;
            MainScreenProductAddButton.Text = "Add";
            MainScreenProductAddButton.UseVisualStyleBackColor = true;
            MainScreenProductAddButton.Click += MainScreenProductAddButton_Click;
            // 
            // MainScreenProductDeleteButton
            // 
            MainScreenProductDeleteButton.Font = new Font("Segoe UI", 9F);
            MainScreenProductDeleteButton.Location = new Point(967, 303);
            MainScreenProductDeleteButton.Name = "MainScreenProductDeleteButton";
            MainScreenProductDeleteButton.Size = new Size(55, 23);
            MainScreenProductDeleteButton.TabIndex = 12;
            MainScreenProductDeleteButton.Text = "Delete";
            MainScreenProductDeleteButton.UseVisualStyleBackColor = true;
            MainScreenProductDeleteButton.Click += MainScreenProductDeleteButton_Click;
            // 
            // MainScreenProductModifyButton
            // 
            MainScreenProductModifyButton.Font = new Font("Segoe UI", 9F);
            MainScreenProductModifyButton.Location = new Point(906, 303);
            MainScreenProductModifyButton.Name = "MainScreenProductModifyButton";
            MainScreenProductModifyButton.Size = new Size(55, 23);
            MainScreenProductModifyButton.TabIndex = 11;
            MainScreenProductModifyButton.Text = "Modify";
            MainScreenProductModifyButton.UseVisualStyleBackColor = true;
            MainScreenProductModifyButton.Click += MainScreenProductModifyButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(541, 83);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 2003;
            label3.Text = "Products";
            // 
            // MainScreenExitButton
            // 
            MainScreenExitButton.Location = new Point(947, 363);
            MainScreenExitButton.Name = "MainScreenExitButton";
            MainScreenExitButton.Size = new Size(75, 23);
            MainScreenExitButton.TabIndex = 13;
            MainScreenExitButton.Text = "Exit";
            MainScreenExitButton.UseVisualStyleBackColor = true;
            MainScreenExitButton.Click += MainScreenExitButton_Click;
            // 
            // dataGridViewMainScreenParts
            // 
            dataGridViewMainScreenParts.AllowUserToAddRows = false;
            dataGridViewMainScreenParts.AllowUserToDeleteRows = false;
            dataGridViewMainScreenParts.AllowUserToResizeColumns = false;
            dataGridViewMainScreenParts.AllowUserToResizeRows = false;
            dataGridViewMainScreenParts.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewMainScreenParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMainScreenParts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewMainScreenParts.Location = new Point(19, 124);
            dataGridViewMainScreenParts.MultiSelect = false;
            dataGridViewMainScreenParts.Name = "dataGridViewMainScreenParts";
            dataGridViewMainScreenParts.ReadOnly = true;
            dataGridViewMainScreenParts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewMainScreenParts.RowTemplate.ReadOnly = true;
            dataGridViewMainScreenParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMainScreenParts.ShowCellErrors = false;
            dataGridViewMainScreenParts.ShowCellToolTips = false;
            dataGridViewMainScreenParts.ShowEditingIcon = false;
            dataGridViewMainScreenParts.ShowRowErrors = false;
            dataGridViewMainScreenParts.Size = new Size(485, 173);
            dataGridViewMainScreenParts.TabIndex = 3;
            dataGridViewMainScreenParts.CellClick += dataGridViewMainScreenParts_CellClick;
            dataGridViewMainScreenParts.DataBindingComplete += dataGridViewMainScreenParts_DataBindingComplete;
            dataGridViewMainScreenParts.Enter += dataGridViewMainScreenParts_Enter;
            // 
            // dataGridViewMainScreenProducts
            // 
            dataGridViewMainScreenProducts.AllowUserToAddRows = false;
            dataGridViewMainScreenProducts.AllowUserToDeleteRows = false;
            dataGridViewMainScreenProducts.AllowUserToResizeColumns = false;
            dataGridViewMainScreenProducts.AllowUserToResizeRows = false;
            dataGridViewMainScreenProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMainScreenProducts.Location = new Point(537, 124);
            dataGridViewMainScreenProducts.Name = "dataGridViewMainScreenProducts";
            dataGridViewMainScreenProducts.ReadOnly = true;
            dataGridViewMainScreenProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewMainScreenProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMainScreenProducts.ShowCellErrors = false;
            dataGridViewMainScreenProducts.ShowCellToolTips = false;
            dataGridViewMainScreenProducts.ShowEditingIcon = false;
            dataGridViewMainScreenProducts.ShowRowErrors = false;
            dataGridViewMainScreenProducts.Size = new Size(485, 173);
            dataGridViewMainScreenProducts.TabIndex = 9;
            dataGridViewMainScreenProducts.CellClick += dataGridViewMainScreenProducts_CellClick;
            dataGridViewMainScreenProducts.DataBindingComplete += dataGridViewMainScreenProducts_DataBindingComplete;
            dataGridViewMainScreenProducts.Enter += dataGridViewMainScreenProducts_Enter;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 411);
            Controls.Add(dataGridViewMainScreenProducts);
            Controls.Add(dataGridViewMainScreenParts);
            Controls.Add(MainScreenExitButton);
            Controls.Add(MainScreenSearchProductsTextBox);
            Controls.Add(MainScreenProductSearchButton);
            Controls.Add(MainScreenProductAddButton);
            Controls.Add(MainScreenProductDeleteButton);
            Controls.Add(MainScreenProductModifyButton);
            Controls.Add(label3);
            Controls.Add(MainScreenSearchPartTextBox);
            Controls.Add(MainScreenPartSearchButton);
            Controls.Add(MainScreenPartAddButton);
            Controls.Add(MainScreenPartDeleteButton);
            Controls.Add(MainScreenPartModifyButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainScreen";
            Text = "Main Screen";
            Load += MainScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMainScreenParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMainScreenProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button MainScreenPartModifyButton;
        private Button MainScreenPartDeleteButton;
        private Button MainScreenPartAddButton;
        private Button MainScreenPartSearchButton;
        private TextBox MainScreenSearchPartTextBox;
        private TextBox MainScreenSearchProductsTextBox;
        private Button MainScreenProductSearchButton;
        private Button MainScreenProductAddButton;
        private Button MainScreenProductDeleteButton;
        private Button MainScreenProductModifyButton;
        private Label label3;
        private Button MainScreenExitButton;
        private DataGridView dataGridViewMainScreenParts;
        private DataGridView dataGridViewMainScreenProducts;
    }
}
