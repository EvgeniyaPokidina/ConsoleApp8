namespace Lesson_31._2
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
            EventName = new TextBox();
            dateTimePicker = new DateTimePicker();
            label2 = new Label();
            EventDescription = new TextBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonSearch = new Button();
            listBoxEvent = new ListBox();
            label3 = new Label();
            txtSearch = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 19);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите название события";
            // 
            // EventName
            // 
            EventName.Location = new Point(178, 16);
            EventName.Multiline = true;
            EventName.Name = "EventName";
            EventName.Size = new Size(218, 18);
            EventName.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(19, 160);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(377, 23);
            dateTimePicker.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 61);
            label2.Name = "label2";
            label2.Size = new Size(156, 15);
            label2.TabIndex = 3;
            label2.Text = "Введите описание события";
            // 
            // EventDescription
            // 
            EventDescription.Location = new Point(178, 40);
            EventDescription.Multiline = true;
            EventDescription.Name = "EventDescription";
            EventDescription.Size = new Size(218, 50);
            EventDescription.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(19, 204);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(103, 50);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Добавить событие";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(148, 204);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(105, 50);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Удалить событие";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(283, 204);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(105, 48);
            buttonSearch.TabIndex = 7;
            buttonSearch.Text = "Поиск события";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // listBoxEvent
            // 
            listBoxEvent.FormattingEnabled = true;
            listBoxEvent.ItemHeight = 15;
            listBoxEvent.Location = new Point(16, 285);
            listBoxEvent.Name = "listBoxEvent";
            listBoxEvent.Size = new Size(380, 79);
            listBoxEvent.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 120);
            label3.Name = "label3";
            label3.Size = new Size(164, 15);
            label3.TabIndex = 9;
            label3.Text = "Введите событие для поиска";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(178, 96);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(218, 49);
            txtSearch.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 392);
            Controls.Add(txtSearch);
            Controls.Add(label3);
            Controls.Add(listBoxEvent);
            Controls.Add(buttonSearch);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(EventDescription);
            Controls.Add(label2);
            Controls.Add(dateTimePicker);
            Controls.Add(EventName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox EventName;
        private DateTimePicker dateTimePicker;
        private Label label2;
        private TextBox EventDescription;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonSearch;
        private ListBox listBoxEvent;
        private Label label3;
        private TextBox txtSearch;
    }
}
