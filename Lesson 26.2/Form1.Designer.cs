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
            buttonCount = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBoxFirst
            // 
            textBoxFirst.Location = new Point(19, 32);
            textBoxFirst.Multiline = true;
            textBoxFirst.Name = "textBoxFirst";
            textBoxFirst.Size = new Size(65, 45);
            textBoxFirst.TabIndex = 0;
            textBoxFirst.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxSecond
            // 
            textBoxSecond.Location = new Point(113, 32);
            textBoxSecond.Multiline = true;
            textBoxSecond.Name = "textBoxSecond";
            textBoxSecond.Size = new Size(65, 45);
            textBoxSecond.TabIndex = 1;
            textBoxSecond.TextAlign = HorizontalAlignment.Center;
            // 
            // checkBoxSum
            // 
            checkBoxSum.AutoSize = true;
            checkBoxSum.Font = new Font("Segoe UI", 12F);
            checkBoxSum.Location = new Point(203, 31);
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
            checkBoxMin.Location = new Point(203, 62);
            checkBoxMin.Name = "checkBoxMin";
            checkBoxMin.Size = new Size(108, 25);
            checkBoxMin.TabIndex = 3;
            checkBoxMin.Text = "Вычитание";
            checkBoxMin.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            textBoxResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxResult.Location = new Point(19, 107);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(276, 34);
            textBoxResult.TabIndex = 4;
            textBoxResult.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonCount
            // 
            buttonCount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCount.Location = new Point(19, 167);
            buttonCount.Name = "buttonCount";
            buttonCount.Size = new Size(124, 66);
            buttonCount.TabIndex = 5;
            buttonCount.Text = "Посчитать";
            buttonCount.UseVisualStyleBackColor = true;
            buttonCount.Click += buttonCount_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(184, 169);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(111, 62);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 297);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCount);
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
        private Button buttonCount;
        private Button buttonCancel;
    }
}
