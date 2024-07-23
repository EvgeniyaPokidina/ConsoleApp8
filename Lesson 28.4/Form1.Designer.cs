namespace Lesson_28._4
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
            label1 = new Label();
            label2 = new Label();
            textBoxPath = new TextBox();
            buttonLoad = new Button();
            listBoxText = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Список элементов";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 239);
            label2.Name = "label2";
            label2.Size = new Size(229, 15);
            label2.TabIndex = 2;
            label2.Text = "Укажите путь к файлу для вывода текста";
            // 
            // textBoxPath
            // 
            textBoxPath.Location = new Point(19, 270);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(284, 23);
            textBoxPath.TabIndex = 3;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(330, 217);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(96, 76);
            buttonLoad.TabIndex = 4;
            buttonLoad.Text = "Вывести текст файла";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // listBoxText
            // 
            listBoxText.FormattingEnabled = true;
            listBoxText.ItemHeight = 15;
            listBoxText.Location = new Point(17, 29);
            listBoxText.Name = "listBoxText";
            listBoxText.Size = new Size(314, 169);
            listBoxText.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 318);
            Controls.Add(listBoxText);
            Controls.Add(buttonLoad);
            Controls.Add(textBoxPath);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Считывание файла";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxPath;
        private Button buttonLoad;
        private ListBox listBoxText;
    }
}
