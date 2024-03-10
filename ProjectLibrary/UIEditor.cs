using ProjectLibrary.models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;

namespace ProjectLibrary
{
    public class UIEditor
    {
        private static string conn = "Server=localhost;Port=5432;Database=projectTask;User Id=postgres;Password=0987";
        private ProjectRepository projectRepository = new ProjectRepository(conn);
        private TaskRepository taskRepository = new TaskRepository(conn);

        public DataGridView ProjectView { get; set; }
        public DataGridView TaskView { get; set; }

        public void RefreshProjectList()
        {
            ProjectView.Rows.Clear();
            List<Project> projects = projectRepository.GetAllProjects();
            foreach (Project project in projects)
            {
                ProjectView.Rows.Add(project.Id, project.Title, project.Description, project.DateFrom.ToShortDateString(), project.DateTo.ToShortDateString());
            }
        }

        public void CreateProject(Project project)
        {
            projectRepository.CreateProject(project);
        }

        public void EditProject(Project project)
        {
            projectRepository.UpdateProject(project);
        }

        public void DeleteProject(int projectId)
        {
            projectRepository.DeleteProject(projectId);
        }

        public void RefreshTaskList(int projectId)
        {
            TaskView.Rows.Clear();
            List<Task> tasks = taskRepository.GetAllTasks(projectId);
            foreach (Task task in tasks)
            {
                TaskView.Rows.Add(task.Id, task.Title, task.Description, task.IsDone);
            }
        }

        public void CreateTask(Task task)
        {
            taskRepository.CreateTask(task);
        }

        public void EditTask(Task task)
        {
            taskRepository.UpdateTask(task);
        }

        public void DeleteTask(int taskId)
        {
            taskRepository.DeleteTask(taskId);
        }
    }
}
