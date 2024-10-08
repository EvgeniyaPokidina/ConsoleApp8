﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_31._2
{
    public class Event
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Event(string title, string description, DateTime date)
        {
            Title = title;
            Description = description;
            Date = date;
        }
        public override string ToString()
        {
            return $"{Title} - {Description} - {Date.ToShortDateString()}";
        }

    }
}
