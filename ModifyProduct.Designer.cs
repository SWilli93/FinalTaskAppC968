namespace FinalTaskAppC968
{
    partial class ModifyProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ModifyProductSearchButton = new Button();
            ModifyProductSearchTextBox = new TextBox();
            label9 = new Label();
            ModifyProductIDTextBox = new TextBox();
            ModifyProductNameTextBox = new TextBox();
            ModifyProductInventoryTextBox = new TextBox();
            ModifyProductPriceTextBox = new TextBox();
            ModifyProductMaxTextBox = new TextBox();
            ModifyProductMinTextBox = new TextBox();
            ModifyProductAddAssociatedPartButton = new Button();
            ModifyProductDeleteAssociatedPartButton = new Button();
            ModifyProductSaveButton = new Button();
            ModifyProductCancelButton = new Button();
            ModifyProductAllParts = new DataGridView();
            ModifyProductAssociatedParts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ModifyProductAllParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ModifyProductAssociatedParts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(43, 31);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 10000;
            label1.Text = "Modify Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 201);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 10001;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 243);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 10002;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 281);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 10003;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 323);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 10004;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(92, 375);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 10005;
            label6.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(234, 375);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 10006;
            label7.Text = "Min";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(499, 64);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 10007;
            label8.Text = "All Candidate Parts";
            // 
            // ModifyProductSearchButton
            // 
            ModifyProductSearchButton.Location = new Point(741, 42);
            ModifyProductSearchButton.Name = "ModifyProductSearchButton";
            ModifyProductSearchButton.Size = new Size(75, 23);
            ModifyProductSearchButton.TabIndex = 7;
            ModifyProductSearchButton.Text = "Search";
            ModifyProductSearchButton.UseVisualStyleBackColor = true;
            ModifyProductSearchButton.Click += ModifyProductSearchButton_Click;
            // 
            // ModifyProductSearchTextBox
            // 
            ModifyProductSearchTextBox.Location = new Point(822, 42);
            ModifyProductSearchTextBox.Name = "ModifyProductSearchTextBox";
            ModifyProductSearchTextBox.Size = new Size(207, 23);
            ModifyProductSearchTextBox.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(499, 323);
            label9.Name = "label9";
            label9.Size = new Size(186, 15);
            label9.TabIndex = 100012;
            label9.Text = "Parts Associated with this Product";
            // 
            // ModifyProductIDTextBox
            // 
            ModifyProductIDTextBox.Enabled = false;
            ModifyProductIDTextBox.Location = new Point(197, 191);
            ModifyProductIDTextBox.Name = "ModifyProductIDTextBox";
            ModifyProductIDTextBox.Size = new Size(100, 23);
            ModifyProductIDTextBox.TabIndex = 1;
            // 
            // ModifyProductNameTextBox
            // 
            ModifyProductNameTextBox.Location = new Point(197, 243);
            ModifyProductNameTextBox.Name = "ModifyProductNameTextBox";
            ModifyProductNameTextBox.Size = new Size(100, 23);
            ModifyProductNameTextBox.TabIndex = 2;
            // 
            // ModifyProductInventoryTextBox
            // 
            ModifyProductInventoryTextBox.Location = new Point(197, 281);
            ModifyProductInventoryTextBox.Name = "ModifyProductInventoryTextBox";
            ModifyProductInventoryTextBox.Size = new Size(100, 23);
            ModifyProductInventoryTextBox.TabIndex = 3;
            // 
            // ModifyProductPriceTextBox
            // 
            ModifyProductPriceTextBox.Location = new Point(197, 323);
            ModifyProductPriceTextBox.Name = "ModifyProductPriceTextBox";
            ModifyProductPriceTextBox.Size = new Size(100, 23);
            ModifyProductPriceTextBox.TabIndex = 4;
            // 
            // ModifyProductMaxTextBox
            // 
            ModifyProductMaxTextBox.Location = new Point(138, 372);
            ModifyProductMaxTextBox.Name = "ModifyProductMaxTextBox";
            ModifyProductMaxTextBox.Size = new Size(90, 23);
            ModifyProductMaxTextBox.TabIndex = 5;
            // 
            // ModifyProductMinTextBox
            // 
            ModifyProductMinTextBox.Location = new Point(281, 372);
            ModifyProductMinTextBox.Name = "ModifyProductMinTextBox";
            ModifyProductMinTextBox.Size = new Size(100, 23);
            ModifyProductMinTextBox.TabIndex = 6;
            // 
            // ModifyProductAddAssociatedPartButton
            // 
            ModifyProductAddAssociatedPartButton.Location = new Point(954, 272);
            ModifyProductAddAssociatedPartButton.Name = "ModifyProductAddAssociatedPartButton";
            ModifyProductAddAssociatedPartButton.Size = new Size(50, 23);
            ModifyProductAddAssociatedPartButton.TabIndex = 10;
            ModifyProductAddAssociatedPartButton.Text = "Add";
            ModifyProductAddAssociatedPartButton.UseVisualStyleBackColor = true;
            ModifyProductAddAssociatedPartButton.Click += ModifyProductAddAssociatedPartButton_Click;
            // 
            // ModifyProductDeleteAssociatedPartButton
            // 
            ModifyProductDeleteAssociatedPartButton.Location = new Point(954, 526);
            ModifyProductDeleteAssociatedPartButton.Name = "ModifyProductDeleteAssociatedPartButton";
            ModifyProductDeleteAssociatedPartButton.Size = new Size(50, 23);
            ModifyProductDeleteAssociatedPartButton.TabIndex = 12;
            ModifyProductDeleteAssociatedPartButton.Text = "Delete";
            ModifyProductDeleteAssociatedPartButton.UseVisualStyleBackColor = true;
            ModifyProductDeleteAssociatedPartButton.Click += ModifyProductDeleteAssociatedPartButton_Click;
            // 
            // ModifyProductSaveButton
            // 
            ModifyProductSaveButton.Location = new Point(893, 572);
            ModifyProductSaveButton.Name = "ModifyProductSaveButton";
            ModifyProductSaveButton.Size = new Size(55, 23);
            ModifyProductSaveButton.TabIndex = 13;
            ModifyProductSaveButton.Text = "Save";
            ModifyProductSaveButton.UseVisualStyleBackColor = true;
            ModifyProductSaveButton.Click += ModifyProductSaveButton_Click;
            // 
            // ModifyProductCancelButton
            // 
            ModifyProductCancelButton.Location = new Point(954, 572);
            ModifyProductCancelButton.Name = "ModifyProductCancelButton";
            ModifyProductCancelButton.Size = new Size(55, 23);
            ModifyProductCancelButton.TabIndex = 14;
            ModifyProductCancelButton.Text = "Cancel";
            ModifyProductCancelButton.UseVisualStyleBackColor = true;
            ModifyProductCancelButton.Click += ModifyProductCancelButton_Click;
            // 
            // ModifyProductAllParts
            // 
            ModifyProductAllParts.AllowUserToAddRows = false;
            ModifyProductAllParts.AllowUserToDeleteRows = false;
            ModifyProductAllParts.AllowUserToResizeColumns = false;
            ModifyProductAllParts.AllowUserToResizeRows = false;
            ModifyProductAllParts.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            ModifyProductAllParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ModifyProductAllParts.EditMode = DataGridViewEditMode.EditProgrammatically;
            ModifyProductAllParts.Location = new Point(499, 91);
            ModifyProductAllParts.MultiSelect = false;
            ModifyProductAllParts.Name = "ModifyProductAllParts";
            ModifyProductAllParts.ReadOnly = true;
            ModifyProductAllParts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            ModifyProductAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ModifyProductAllParts.ShowCellErrors = false;
            ModifyProductAllParts.ShowCellToolTips = false;
            ModifyProductAllParts.ShowEditingIcon = false;
            ModifyProductAllParts.ShowRowErrors = false;
            ModifyProductAllParts.Size = new Size(530, 175);
            ModifyProductAllParts.TabIndex = 9;
            ModifyProductAllParts.CellClick += ModifyProductAllParts_CellClick;
            ModifyProductAllParts.Enter += ModifyProductAllParts_Enter;
            // 
            // ModifyProductAssociatedParts
            // 
            ModifyProductAssociatedParts.AllowUserToAddRows = false;
            ModifyProductAssociatedParts.AllowUserToDeleteRows = false;
            ModifyProductAssociatedParts.AllowUserToResizeColumns = false;
            ModifyProductAssociatedParts.AllowUserToResizeRows = false;
            ModifyProductAssociatedParts.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            ModifyProductAssociatedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ModifyProductAssociatedParts.EditMode = DataGridViewEditMode.EditProgrammatically;
            ModifyProductAssociatedParts.Location = new Point(499, 345);
            ModifyProductAssociatedParts.MultiSelect = false;
            ModifyProductAssociatedParts.Name = "ModifyProductAssociatedParts";
            ModifyProductAssociatedParts.ReadOnly = true;
            ModifyProductAssociatedParts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            ModifyProductAssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ModifyProductAssociatedParts.ShowCellErrors = false;
            ModifyProductAssociatedParts.ShowCellToolTips = false;
            ModifyProductAssociatedParts.ShowEditingIcon = false;
            ModifyProductAssociatedParts.ShowRowErrors = false;
            ModifyProductAssociatedParts.Size = new Size(530, 175);
            ModifyProductAssociatedParts.TabIndex = 11;
            ModifyProductAssociatedParts.CellClick += ModifyProductAssociatedParts_CellClick;
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 612);
            Controls.Add(ModifyProductAssociatedParts);
            Controls.Add(ModifyProductAllParts);
            Controls.Add(ModifyProductCancelButton);
            Controls.Add(ModifyProductSaveButton);
            Controls.Add(ModifyProductDeleteAssociatedPartButton);
            Controls.Add(ModifyProductAddAssociatedPartButton);
            Controls.Add(ModifyProductMinTextBox);
            Controls.Add(ModifyProductMaxTextBox);
            Controls.Add(ModifyProductPriceTextBox);
            Controls.Add(ModifyProductInventoryTextBox);
            Controls.Add(ModifyProductNameTextBox);
            Controls.Add(ModifyProductIDTextBox);
            Controls.Add(label9);
            Controls.Add(ModifyProductSearchTextBox);
            Controls.Add(ModifyProductSearchButton);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModifyProduct";
            Text = "Product";
            Load += ModifyProduct_Load;
            ((System.ComponentModel.ISupportInitialize)ModifyProductAllParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)ModifyProductAssociatedParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button ModifyProductSearchButton;
        private TextBox ModifyProductSearchTextBox;
        private Label label9;
        private TextBox ModifyProductIDTextBox;
        private TextBox ModifyProductNameTextBox;
        private TextBox ModifyProductInventoryTextBox;
        private TextBox ModifyProductPriceTextBox;
        private TextBox ModifyProductMaxTextBox;
        private TextBox ModifyProductMinTextBox;
        private Button ModifyProductAddAssociatedPartButton;
        private Button ModifyProductDeleteAssociatedPartButton;
        private Button ModifyProductSaveButton;
        private Button ModifyProductCancelButton;
        private DataGridView ModifyProductAllParts;
        private DataGridView ModifyProductAssociatedParts;
    }
}