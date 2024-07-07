namespace Lesson_25_1
{
    partial class Планировщик
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
            addButton = new Button();
            buttonDelete = new Button();
            tittleLabel = new Label();
            taskTextBox = new TextBox();
            taskListBox = new ListBox();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.BackColor = Color.AntiqueWhite;
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            addButton.Location = new Point(12, 280);
            addButton.Name = "addButton";
            addButton.Size = new Size(132, 58);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить задачу";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.AntiqueWhite;
            buttonDelete.FlatStyle = FlatStyle.Popup;
            buttonDelete.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonDelete.Location = new Point(244, 280);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(130, 59);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Удалить задачу";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // tittleLabel
            // 
            tittleLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            tittleLabel.Location = new Point(12, 9);
            tittleLabel.Name = "tittleLabel";
            tittleLabel.Size = new Size(362, 31);
            tittleLabel.TabIndex = 2;
            tittleLabel.Text = "Введите ниже список задач";
            // 
            // taskTextBox
            // 
            taskTextBox.Location = new Point(12, 43);
            taskTextBox.Multiline = true;
            taskTextBox.Name = "taskTextBox";
            taskTextBox.Size = new Size(362, 74);
            taskTextBox.TabIndex = 3;
            taskTextBox.TextChanged += taskTextBox_TextChanged;
            // 
            // taskListBox
            // 
            taskListBox.ForeColor = Color.Black;
            taskListBox.FormattingEnabled = true;
            taskListBox.ItemHeight = 15;
            taskListBox.Location = new Point(12, 135);
            taskListBox.Name = "taskListBox";
            taskListBox.Size = new Size(362, 139);
            taskListBox.TabIndex = 4;
            // 
            // Планировщик
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(397, 364);
            Controls.Add(taskListBox);
            Controls.Add(taskTextBox);
            Controls.Add(tittleLabel);
            Controls.Add(buttonDelete);
            Controls.Add(addButton);
            Name = "Планировщик";
            Text = "Планировщик задач";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Button buttonDelete;
        private Label tittleLabel;
        private TextBox taskTextBox;
        private ListBox taskListBox;
    }
}
