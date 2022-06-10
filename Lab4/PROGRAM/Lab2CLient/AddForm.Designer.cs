namespace Lab2CLient
{
    partial class AddForm
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
            this.canselButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.lf5 = new System.Windows.Forms.Label();
            this.lf4 = new System.Windows.Forms.Label();
            this.lf3 = new System.Windows.Forms.Label();
            this.lf2 = new System.Windows.Forms.Label();
            this.lf1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // canselButton
            // 
            this.canselButton.Location = new System.Drawing.Point(335, 224);
            this.canselButton.Name = "canselButton";
            this.canselButton.Size = new System.Drawing.Size(140, 42);
            this.canselButton.TabIndex = 29;
            this.canselButton.Text = "Cansel";
            this.canselButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(189, 224);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(140, 42);
            this.addButton.TabIndex = 30;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // lf5
            // 
            this.lf5.AutoSize = true;
            this.lf5.Location = new System.Drawing.Point(7, 196);
            this.lf5.Name = "lf5";
            this.lf5.Size = new System.Drawing.Size(46, 16);
            this.lf5.TabIndex = 28;
            this.lf5.Text = "Phone";
            // 
            // lf4
            // 
            this.lf4.AutoSize = true;
            this.lf4.Location = new System.Drawing.Point(7, 168);
            this.lf4.Name = "lf4";
            this.lf4.Size = new System.Drawing.Size(30, 16);
            this.lf4.TabIndex = 27;
            this.lf4.Text = "Sex";
            // 
            // lf3
            // 
            this.lf3.AutoSize = true;
            this.lf3.Location = new System.Drawing.Point(7, 140);
            this.lf3.Name = "lf3";
            this.lf3.Size = new System.Drawing.Size(32, 16);
            this.lf3.TabIndex = 26;
            this.lf3.Text = "Age";
            // 
            // lf2
            // 
            this.lf2.AutoSize = true;
            this.lf2.Location = new System.Drawing.Point(7, 112);
            this.lf2.Name = "lf2";
            this.lf2.Size = new System.Drawing.Size(72, 16);
            this.lf2.TabIndex = 25;
            this.lf2.Text = "Last Name";
            // 
            // lf1
            // 
            this.lf1.AutoSize = true;
            this.lf1.Location = new System.Drawing.Point(7, 84);
            this.lf1.Name = "lf1";
            this.lf1.Size = new System.Drawing.Size(72, 16);
            this.lf1.TabIndex = 24;
            this.lf1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Select table";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 22);
            this.textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 22);
            this.textBox3.TabIndex = 21;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(92, 193);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(168, 22);
            this.textBox5.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(92, 165);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 22);
            this.textBox4.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 22);
            this.textBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Employee",
            "Orders",
            "Items",
            "Parts"});
            this.comboBox1.Location = new System.Drawing.Point(7, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 24);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 276);
            this.Controls.Add(this.canselButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.lf5);
            this.Controls.Add(this.lf4);
            this.Controls.Add(this.lf3);
            this.Controls.Add(this.lf2);
            this.Controls.Add(this.lf1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "AddForm";
            this.Text = "AddEdit";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button canselButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label lf5;
        private System.Windows.Forms.Label lf4;
        private System.Windows.Forms.Label lf3;
        private System.Windows.Forms.Label lf2;
        private System.Windows.Forms.Label lf1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}