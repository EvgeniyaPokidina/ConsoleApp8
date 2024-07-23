using System.Diagnostics.Eventing.Reader;

namespace Lesson_28._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string filePath = textBoxPath.Text;
            if (File.Exists(filePath))
            {
                listBoxText.Items.Clear();
                string[] fruits = File.ReadAllLines(filePath);
                foreach (string fruit in fruits)
                {
                    listBoxText.Items.Add(fruit);
                }

            }
            else
            {
                MessageBox.Show("Нет такого файла"+ filePath);
            }
        }
    }
}
