namespace Lesson_26._2
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
            textBoxFirst = new TextBox();
            textBoxSecond = new TextBox();
            checkBoxSum = new CheckBox();
            checkBoxMin = new CheckBox();
            textBoxResult = new TextBox();
            buttonResult = new Button();
            SuspendLayout();
            // 
            // textBoxFirst
            // 
            textBoxFirst.Location = new Point(24, 32);
            textBoxFirst.Multiline = true;
            textBoxFirst.Name = "textBoxFirst";
            textBoxFirst.Size = new Size(105, 67);
            textBoxFirst.TabIndex = 0;
            // 
            // textBoxSecond
            // 
            textBoxSecond.Location = new Point(165, 32);
            textBoxSecond.Multiline = true;
            textBoxSecond.Name = "textBoxSecond";
            textBoxSecond.Size = new Size(100, 67);
            textBoxSecond.TabIndex = 1;
            // 
            // checkBoxSum
            // 
            checkBoxSum.AutoSize = true;
            checkBoxSum.Font = new Font("Segoe UI", 12F);
            checkBoxSum.Location = new Point(285, 36);
            checkBoxSum.Name = "checkBoxSum";
            checkBoxSum.Size = new Size(102, 25);
            checkBoxSum.TabIndex = 2;
            checkBoxSum.Text = "Сложение";
            checkBoxSum.UseVisualStyleBackColor = true;
            // 
            // checkBoxMin
            // 
            checkBoxMin.AutoSize = true;
            checkBoxMin.Font = new Font("Segoe UI", 12F);
            checkBoxMin.Location = new Point(285, 70);
            checkBoxMin.Name = "checkBoxMin";
            checkBoxMin.Size = new Size(108, 25);
            checkBoxMin.TabIndex = 3;
            checkBoxMin.Text = "Вычитание";
            checkBoxMin.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(28, 131);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(342, 84);
            textBoxResult.TabIndex = 4;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(30, 250);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(340, 66);
            buttonResult.TabIndex = 5;
            buttonResult.Text = "Посчитать";
            buttonResult.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 355);
            Controls.Add(buttonResult);
            Controls.Add(textBoxResult);
            Controls.Add(checkBoxMin);
            Controls.Add(checkBoxSum);
            Controls.Add(textBoxSecond);
            Controls.Add(textBoxFirst);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirst;
        private TextBox textBoxSecond;
        private CheckBox checkBoxSum;
        private CheckBox checkBoxMin;
        private TextBox textBoxResult;
        private Button buttonResult;
    }
}
