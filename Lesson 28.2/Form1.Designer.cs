namespace Lesson_28._2
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
            label3 = new Label();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            textBoxUserName = new TextBox();
            buttonGenerate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(20, 16);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 0;
            label1.Text = "Имя пользователя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(211, 16);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 1;
            label2.Text = "Логин:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(351, 16);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 2;
            label3.Text = "Пароль:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(337, 56);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(116, 174);
            textBoxPassword.TabIndex = 3;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(211, 56);
            textBoxLogin.Multiline = true;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(111, 174);
            textBoxLogin.TabIndex = 4;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(20, 56);
            textBoxUserName.Multiline = true;
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(161, 70);
            textBoxUserName.TabIndex = 5;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonGenerate.Location = new Point(20, 149);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(159, 81);
            buttonGenerate.TabIndex = 6;
            buttonGenerate.Text = "СГЕНЕРИРОВАТЬ ПАРОЛЬ";
            buttonGenerate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 267);
            Controls.Add(buttonGenerate);
            Controls.Add(textBoxUserName);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Менеджер паролей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxUserName;
        private Button buttonGenerate;
    }
}
