namespace Lesson_28._1
{
    public partial class Form1 : Form
    {
        private string[] str =
        {
          "����� - ��� ����������� ���� �� ����� ������� � ������, �� ������� ����������. - ������� ��������",
          "���� ����������, ������� �� ������ ������ � ����. - ������� �����",
          "������ ������ ����������� ������� - ������� ���. - ����� ������",
          "��������� - ��� �����������, ������� � ���������� �������. - ������� ��������",
          "�� �����, ������� ��� �� ������� - �����, ������� ��� �� ������������. - ������� �����"

        };
        public Form1()
        {
            InitializeComponent();
            ShowRandomQuotation();
        }
        private void ShowRandomQuotation()
        { 
            Random random = new Random();
            int index=random.Next(str.Length);
            textBoxText.Text = str[index];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowRandomQuotation();
        }
    }
}
