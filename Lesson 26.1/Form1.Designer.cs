﻿namespace Lesson_26._1
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 14.25F);
            checkBox1.Location = new Point(27, 27);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(116, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Галочка 1";
            checkBox1.UseVisualStyleBackColor = true;
            
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 14.25F);
            checkBox2.Location = new Point(27, 58);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(116, 29);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Галочка 2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 14.25F);
            checkBox3.Location = new Point(27, 86);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(116, 29);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Галочка 3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.Location = new Point(27, 174);
            button1.Name = "button1";
            button1.Size = new Size(146, 74);
            button1.TabIndex = 3;
            button1.Text = "Проверить флажок";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 307);
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button1;
    }
}