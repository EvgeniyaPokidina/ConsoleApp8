using Lesson_31._2;
using System.Windows.Forms;

namespace Lesson_31._2
{
    public partial class Form1 : Form
    {
        private List<Event> events = new List<Event>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string title = EventName.Text;
            string description = EventDescription.Text;
            var date = dateTimePicker.Value;

            var newEvent = new Event(title, description, date);
            events.Add(newEvent);
            UpdateEventList();

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var title = EventName.Text;
            events.RemoveAll(e => e.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            UpdateEventList();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var searchTerm = txtSearch.Text;
            var searchResults = events.Where(e => e.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
            e.Description.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                e.Date.ToShortDateString().Contains(searchTerm)).ToList();
            UpdateEventList(searchResults);
        }
        private void UpdateEventList(List<Event> eventsToDisplay = null)
        {
            listBoxEvent.Items.Clear();
            var eventsList = eventsToDisplay ?? events;
            foreach (var e in eventsList)
            {
                listBoxEvent.Items.Add(e);
            }
        }
    }
}
