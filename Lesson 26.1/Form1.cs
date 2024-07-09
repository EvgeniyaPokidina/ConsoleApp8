namespace Lesson_26._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                MessageBox.Show("Флажок 1 выбран");
            }
            else
            {
                MessageBox.Show("Флажок 1 снят");
            }
            if (checkBox2.Checked)
            {
                MessageBox.Show("Флажок 2 выбран");
            }
            else
            {
                MessageBox.Show("Флажок 2 снят");
            }
            if (checkBox3.Checked)
            {
                MessageBox.Show("Флажок 3 выбран");
            }
            else
            {
                MessageBox.Show("Флажок 3 снят");
            }

        }

        
    }
}
