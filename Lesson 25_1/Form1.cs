namespace Lesson_25_1
{
    public partial class Планировщик : Form
    {
        public Планировщик()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string task = taskTextBox.Text;
            if (!string.IsNullOrWhiteSpace(task))
            {
                taskListBox.Items.Add(task);
                taskTextBox.Clear();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedIndex != -1)
            {
                string selectedTask = taskListBox.SelectedItems.ToString()!;
                taskListBox.Items.Clear();
            }
        }

        private void taskTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
