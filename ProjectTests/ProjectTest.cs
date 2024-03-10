using Microsoft.VisualStudio.TestTools.UnitTesting;
using Npgsql;
using ProjectLibrary;
using ProjectLibrary.models;
using System;

namespace ProjectTests
{
    [TestClass]
    public class ProjectTest
    {
        private DatabaseEditor databaseEditor;
        private TaskRepository taskRepository;
        private ProjectRepository projectRepository;
        private UIEditor uiEditor; 
        private string connectionStr = "Server=localhost;Port=5432;Database=projectTask;User Id=postgres;Password=0987";

        [TestInitialize]
        public void init()
        {
            databaseEditor = new DatabaseEditor(connectionStr);
            taskRepository = new TaskRepository(connectionStr);
            projectRepository = new ProjectRepository(connectionStr);
            uiEditor = new UIEditor();
        }
        [TestMethod]
        public void TC_CreateProjectTable_1()
        {
            databaseEditor.CreateProjectTable();
        }

        [TestMethod]
        public void TC_CreateTaskTable_1()
        {
            databaseEditor.CreateTaskTable();
        }

        [TestMethod]
        public void TC_GetAllProjects_1()
        {
            var projects = projectRepository.GetAllProjects();
            Assert.IsNotNull(projects);
            Assert.IsTrue(projects.Count > 0);
        }

        [TestMethod]
        public void TC_GetAllTasks_1()
        {
            var tasks = taskRepository.GetAllTasks(1);
            Assert.IsNotNull(tasks);
            Assert.IsTrue(tasks.Count > 0);
        }

        [TestMethod]
        public void TC_InsertProject_1()
        {
            projectRepository.CreateProject(
                new Project
                {
                    Title = "Тестовый проект",
                    Description = "Невероятной сложности проект",
                    DateFrom = DateTime.Now,
                    DateTo = DateTime.Now.AddDays(3),
                });
        }

        [TestMethod]
        public void TC_InsertTask_1()
        {
            taskRepository.CreateTask(
                new Task
                {
                    Title = "Тестовая задача",
                    Description = "Невероятная задача",
                    IsDone = false,
                    ProjectId = 1,
                });
        }

        [TestMethod]
        public void TC_InsertTask_2()
        {
            // TODO assert throw типо проекта с ид ... нет
        }

        [TestMethod]
        public void TC_DeleteProject_1()
        {
            projectRepository.DeleteProject(1100);
        }

        [TestMethod]
        public void TC_DeleteTask_1()
        {
            taskRepository.DeleteTask(1100);
        }

        [TestMethod]
        public void TC_UpdateProject_1()
        {
            projectRepository.UpdateProject(
                new Project
                {
                    Id = 1,
                    Title = "Тестовый проект",
                    Description = "Невероятной сложности проект",
                    DateFrom = DateTime.Now,
                    DateTo = DateTime.Now.AddDays(3),
                });
        }

        [TestMethod]
        public void TC_UpdateTask_1()
        {
            taskRepository.UpdateTask(
                new Task
                {
                    Id = 1,
                    Title = "Тестовая задача",
                    Description = "Невероятная задача",
                    IsDone = false,
                    ProjectId = 1,
                });
        }

        [TestMethod]
        public void TC_CreateProjectUI_1()
        {
            uiEditor.CreateProject(
                new Project
                {
                    Title = "Тестовый проект",
                    Description = "Невероятной сложности проект",
                    DateFrom = DateTime.Now,
                    DateTo = DateTime.Now.AddDays(3),
                });
        }

        [TestMethod]
        public void TC_EditProjectUI_1()
        {
            uiEditor.EditProject(
                new Project
                {
                    Id = 1,
                    Title = "Тестовый проект",
                    Description = "Невероятной сложности проект",
                    DateFrom = DateTime.Now,
                    DateTo = DateTime.Now.AddDays(3),
                });
        }

        [TestMethod]
        public void TC_DeleteProjectUI_1()
        {
            uiEditor.DeleteProject(100);
        }

        [TestMethod]
        public void TC_CreateTaskUI_1()
        {
            uiEditor.CreateTask(
                new Task
                {
                    Title = "Тестовая задача",
                    Description = "Невероятная задача",
                    IsDone = false,
                    ProjectId = 1,
                });
        }

        [TestMethod]
        public void TC_UpdateTaskUI_1()
        {
            uiEditor.EditTask(
                new Task
                {
                    Id = 1,
                    Title = "Тестовая задача",
                    Description = "Невероятная задача",
                    IsDone = false,
                    ProjectId = 1,
                });
        }

        [TestMethod]
        public void TC_DeleteTackUI_1()
        {
            uiEditor.DeleteTask(100);
        }
    }
}
