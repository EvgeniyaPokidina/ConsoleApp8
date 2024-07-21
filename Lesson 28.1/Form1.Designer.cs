namespace Lesson_28._1
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
            textBoxText = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxText
            // 
            textBoxText.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            textBoxText.Location = new Point(12, 12);
            textBoxText.Multiline = true;
            textBoxText.Name = "textBoxText";
            textBoxText.Size = new Size(291, 136);
            textBoxText.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            button1.Location = new Point(51, 172);
            button1.Name = "button1";
            button1.Size = new Size(195, 54);
            button1.TabIndex = 2;
            button1.Text = "Нажмите кнопку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 250);
            Controls.Add(button1);
            Controls.Add(textBoxText);
            Name = "Form1";
            Text = "Случайная цитата";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxText;
        private Button button1;
    }
}
