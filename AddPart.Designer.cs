namespace FinalTaskAppC968
{
    partial class AddPart
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
            MachineIDLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            InHouse = new RadioButton();
            Outsourced = new RadioButton();
            AddPartCancel = new Button();
            AddPartSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 0;
            label1.Text = "Add Part";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 75);
            label2.Name = "label2";
            label2.Size = new Size(25, 21);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 116);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 158);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 3;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 205);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 4;
            label5.Text = "Price / Cost";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(92, 265);
            label6.Name = "label6";
            label6.Size = new Size(39, 21);
            label6.TabIndex = 5;
            label6.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(249, 265);
            label7.Name = "label7";
            label7.Size = new Size(37, 21);
            label7.TabIndex = 6;
            label7.Text = "Min";
            // 
            // MachineIDLabel
            // 
            MachineIDLabel.AutoSize = true;
            MachineIDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MachineIDLabel.Location = new Point(30, 333);
            MachineIDLabel.Name = "MachineIDLabel";
            MachineIDLabel.Size = new Size(88, 21);
            MachineIDLabel.TabIndex = 7;
            MachineIDLabel.Text = "Machine ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(164, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(164, 331);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(138, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(164, 160);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(138, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(148, 265);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(70, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(164, 207);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(138, 23);
            textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(303, 265);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(70, 23);
            textBox7.TabIndex = 14;
            // 
            // InHouse
            // 
            InHouse.AutoSize = true;
            InHouse.Checked = true;
            InHouse.Location = new Point(102, 25);
            InHouse.Name = "InHouse";
            InHouse.Size = new Size(74, 19);
            InHouse.TabIndex = 15;
            InHouse.TabStop = true;
            InHouse.Text = "In-House";
            InHouse.UseVisualStyleBackColor = true;
            InHouse.CheckedChanged += InHouse_CheckedChanged;
            // 
            // Outsourced
            // 
            Outsourced.AutoSize = true;
            Outsourced.Location = new Point(226, 25);
            Outsourced.Name = "Outsourced";
            Outsourced.Size = new Size(87, 19);
            Outsourced.TabIndex = 16;
            Outsourced.Text = "Outsourced";
            Outsourced.UseVisualStyleBackColor = true;
            Outsourced.CheckedChanged += Outsourced_CheckedChanged;
            // 
            // AddPartCancel
            // 
            AddPartCancel.Location = new Point(321, 396);
            AddPartCancel.Name = "AddPartCancel";
            AddPartCancel.Size = new Size(52, 23);
            AddPartCancel.TabIndex = 17;
            AddPartCancel.Text = "Cancel";
            AddPartCancel.UseVisualStyleBackColor = true;
            AddPartCancel.Click += AddPartCancel_Click;
            // 
            // AddPartSave
            // 
            AddPartSave.Location = new Point(261, 396);
            AddPartSave.Name = "AddPartSave";
            AddPartSave.Size = new Size(52, 23);
            AddPartSave.TabIndex = 18;
            AddPartSave.Text = "Save";
            AddPartSave.UseVisualStyleBackColor = true;
            AddPartSave.Click += AddPartSave_Click;
            // 
            // AddPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 450);
            Controls.Add(AddPartSave);
            Controls.Add(AddPartCancel);
            Controls.Add(Outsourced);
            Controls.Add(InHouse);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(MachineIDLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddPart";
            Text = "AddPart";
            Load += AddPart_Load;
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
        private Label MachineIDLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private RadioButton InHouse;
        private RadioButton Outsourced;
        private Button AddPartCancel;
        private Button AddPartSave;
    }
}