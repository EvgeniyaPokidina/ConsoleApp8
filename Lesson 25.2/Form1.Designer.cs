namespace Lesson_25._2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelWelcome = new Label();
            labelText1 = new Label();
            label1 = new Label();
            buttonLogin = new Button();
            labelAccount = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.BackColor = Color.Transparent;
            labelWelcome.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelWelcome.ForeColor = Color.Black;
            labelWelcome.Location = new Point(87, 284);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(144, 40);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Welcome";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelText1
            // 
            labelText1.BackColor = Color.Transparent;
            labelText1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelText1.Location = new Point(32, 343);
            labelText1.Name = "labelText1";
            labelText1.Size = new Size(275, 23);
            labelText1.TabIndex = 1;
            labelText1.Text = "Fell less stressed and  more minful";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(87, 370);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 2;
            label1.Text = "with  meditation";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.ActiveCaptionText;
            buttonLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(60, 427);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(224, 48);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Login                          → ";
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // labelAccount
            // 
            labelAccount.BackColor = Color.Transparent;
            labelAccount.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelAccount.Location = new Point(32, 511);
            labelAccount.Name = "labelAccount";
            labelAccount.Size = new Size(231, 23);
            labelAccount.TabIndex = 4;
            labelAccount.Text = "Dont have an account?";
            // 
            // linkLabel1
            // 
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(269, 511);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(100, 23);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(374, 548);
            Controls.Add(linkLabel1);
            Controls.Add(labelAccount);
            Controls.Add(buttonLogin);
            Controls.Add(label1);
            Controls.Add(labelText1);
            Controls.Add(labelWelcome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Label labelText1;
        private Label label1;
        private Button buttonLogin;
        private Label labelAccount;
        private LinkLabel linkLabel1;
    }
}
