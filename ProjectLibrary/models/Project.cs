using System;
using System.Collections.Generic;

namespace ProjectLibrary.models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime DateFrom { get; set;}
        public List<Task> Tasks { get; set; }
        public Project() { }
        public Project(int id, string title, string description, DateTime dateTo, DateTime dateFrom, List<Task> tasks)
        {
            Id = id;
            Title = title;
            Description = description;
            DateTo = dateTo;
            DateFrom = dateFrom;
            Tasks = tasks;
        }
    }
}
