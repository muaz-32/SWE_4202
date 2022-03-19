namespace Employee_Management_System_Easy
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_designation = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.listBox_employees = new System.Windows.Forms.ListBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_view = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Designation";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(153, 135);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 31);
            this.textBox_name.TabIndex = 3;
            // 
            // textBox_designation
            // 
            this.textBox_designation.Location = new System.Drawing.Point(211, 294);
            this.textBox_designation.Name = "textBox_designation";
            this.textBox_designation.Size = new System.Drawing.Size(100, 31);
            this.textBox_designation.TabIndex = 4;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(117, 214);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 31);
            this.textBox_id.TabIndex = 5;
            // 
            // listBox_employees
            // 
            this.listBox_employees.FormattingEnabled = true;
            this.listBox_employees.ItemHeight = 25;
            this.listBox_employees.Location = new System.Drawing.Point(451, 121);
            this.listBox_employees.Name = "listBox_employees";
            this.listBox_employees.Size = new System.Drawing.Size(307, 204);
            this.listBox_employees.TabIndex = 6;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(130, 380);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(123, 43);
            this.button_add.TabIndex = 7;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_view
            // 
            this.button_view.Location = new System.Drawing.Point(503, 380);
            this.button_view.Name = "button_view";
            this.button_view.Size = new System.Drawing.Size(123, 43);
            this.button_view.TabIndex = 8;
            this.button_view.Text = "View";
            this.button_view.UseVisualStyleBackColor = true;
            this.button_view.Click += new System.EventHandler(this.button_view_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(278, 380);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(123, 43);
            this.button_clear.TabIndex = 9;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 532);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_view);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.listBox_employees);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.textBox_designation);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_designation;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.ListBox listBox_employees;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_view;
        private System.Windows.Forms.Button button_clear;
    }
}

