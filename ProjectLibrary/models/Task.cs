namespace ProjectLibrary.models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public int ProjectId { get; set; } 
        public Task() { }
        public Task(int id, string title, string description, bool isDone, int projectId)
        {
            Id = id;
            Title = title;
            Description = description;
            IsDone = isDone;
            ProjectId = projectId;
        }
    }
}
