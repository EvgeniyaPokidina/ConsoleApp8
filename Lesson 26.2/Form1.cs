namespace Lesson_26._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            try
            {
                int n, m;
                int.TryParse(textBoxFirst.Text, out n);
                int.TryParse(textBoxSecond.Text, out m);
                if (checkBoxSum.Checked)
                {
                    textBoxResult.Text = $"Результат: {n + m}";
                }

                else if (checkBoxMin.Checked)
                {
                    textBoxResult.Text = $"Результат: {n - m}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxFirst.Clear();
            textBoxSecond.Clear();
            textBoxResult.Clear();
        }
    }
}
