
namespace WindowsFormsApplication
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.RadioButton();
            this.Subtract = new System.Windows.Forms.RadioButton();
            this.Multiply = new System.Windows.Forms.RadioButton();
            this.Divide = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(553, 118);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(553, 174);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add.Location = new System.Drawing.Point(553, 234);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(94, 21);
            this.Add.TabIndex = 2;
            this.Add.TabStop = true;
            this.Add.Text = "ADDITION";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Subtract
            // 
            this.Subtract.AutoSize = true;
            this.Subtract.Location = new System.Drawing.Point(553, 262);
            this.Subtract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(127, 21);
            this.Subtract.TabIndex = 3;
            this.Subtract.TabStop = true;
            this.Subtract.Text = "SUBTRACTION";
            this.Subtract.UseVisualStyleBackColor = true;
            // 
            // Multiply
            // 
            this.Multiply.AutoSize = true;
            this.Multiply.Location = new System.Drawing.Point(553, 290);
            this.Multiply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(141, 21);
            this.Multiply.TabIndex = 4;
            this.Multiply.TabStop = true;
            this.Multiply.Text = "MULTIPLICATION";
            this.Multiply.UseVisualStyleBackColor = true;
            // 
            // Divide
            // 
            this.Divide.AutoSize = true;
            this.Divide.Location = new System.Drawing.Point(553, 319);
            this.Divide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(87, 21);
            this.Divide.TabIndex = 5;
            this.Divide.TabStop = true;
            this.Divide.Text = "DIVISION";
            this.Divide.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 362);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton Add;
        private System.Windows.Forms.RadioButton Subtract;
        private System.Windows.Forms.RadioButton Multiply;
        private System.Windows.Forms.RadioButton Divide;
        private System.Windows.Forms.Button button1;
    }
}

