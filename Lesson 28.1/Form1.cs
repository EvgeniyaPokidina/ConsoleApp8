namespace Lesson_28._1
{
    public partial class Form1 : Form
    {
        private string[] str =
        {
          "Успех - это способность идти от одной неудачи к другой, не потеряв энтузиазма. - Уинстон Черчилль",
          "Будь изменением, которое ты хочешь видеть в мире. - Махатма Ганди",
          "Лучший способ предсказать будущее - создать его. - Питер Друкер",
          "Сложности - это возможности, скрытые в обманчивой обертке. - Альберт Эйнштейн",
          "Не важно, сколько раз вы падаете - важно, сколько раз вы поднимаетесь. - Мэрилин Монро"

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
