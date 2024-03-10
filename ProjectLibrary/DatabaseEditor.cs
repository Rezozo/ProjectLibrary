using Npgsql;
using ProjectLibrary.models;
using System;
using System.Collections.Generic;

namespace ProjectLibrary
{
    public class DatabaseEditor
    {
        private NpgsqlConnection connection;

        public DatabaseEditor(string connection)
        {
            this.connection = new NpgsqlConnection(connection);
        }

        public void CreateProjectTable()
        {
            var command = new NpgsqlCommand("CREATE TABLE IF NOT EXISTS project ( " +
                "id serial PRIMARY KEY, " +
                "title text NOT NULL, " +
                "description text NOT NULL, " +
                "date_from date NOT NULL, " +
                "date_to date NOT NULL)");
            runQueryWithoutResult(command);
        }

        public void CreateTaskTable()
        {
            var command = new NpgsqlCommand( "CREATE TABLE IF NOT EXISTS task ( " +
                "id serial PRIMARY KEY, " +
                "description text NOT NULL, " +
                "done bool NOT NULL, " +
                "project_id integer NOT NULL REFERENCES project(id) ON DELETE CASCADE)");
            runQueryWithoutResult(command);
        }

        public void runQueryWithoutResult(NpgsqlCommand query)
        {
            connection.Open();
            var command = query;
            command.Connection = connection;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<Project> GetAllProjects()
        {
            var result = new List<Project>();
            connection.Open();
            var command = new NpgsqlCommand("SELECT * FROM project", connection);
            var reader = command.ExecuteReader();
            while (reader.Read()) 
            {
                var project = new Project();
                project.Id = (int)reader[0];
                project.Title = (string)reader[1];
                project.Description = (string)reader[2];
                project.DateFrom = (DateTime)reader[3]; 
                project.DateTo = (DateTime)reader[4];
                result.Add(project);
            }
            reader.Close();
            connection.Close();
            return result;
        }

        public void CreateProject(Project project)
        {
            var command = new NpgsqlCommand($"INSERT INTO project VALUES (DEFAULT, '{project.Title}', '{project.Description}'," +
                $"'{project.DateFrom}', '{project.DateTo}')");
            runQueryWithoutResult(command);
        }

        public void UpdateProject(Project project)
        {
            try
            {
                var command = new NpgsqlCommand($"UPDATE project SET title = '{project.Title}', description = '{project.Description}', " +
                    $" date_from = '{project.DateFrom}', date_to = '{project.DateTo}' WHERE id = {project.Id}");
                runQueryWithoutResult(command);
            } catch
            {
                throw new Exception($"Проекта с id = {project.Id} не существует");
            }
        }

        public void DeleteProject(int projectId)
        {
            var command = new NpgsqlCommand($"DELETE FROM project WHERE id = {projectId}");
            runQueryWithoutResult(command);
        }

        public List<Task> GetAllTasks(int projectId)
        {
            List<Task> tasks = new List<Task>();
            connection.Open();
            var command = new NpgsqlCommand($"SELECT * FROM task WHERE project_id = {projectId}", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Task task = new Task();
                task.Id = (int)reader[0];
                task.Description = (string)reader[1];
                task.IsDone = (bool)reader[2];
                task.ProjectId = (int)reader[3];
                task.Title = (string)reader[4];
                tasks.Add(task);
            }
            reader.Close();
            connection.Close();

            return tasks;
        }

        public void CreateTask(Task task)
        {
            var command = new NpgsqlCommand($"INSERT INTO task VALUES (DEFAULT, " +
                $" '{task.Description}', {task.IsDone}, {task.ProjectId}, '{task.Title}')");
            runQueryWithoutResult(command);
        }

        public void UpdateTask(Task task)
        {
            try { 
                var command = new NpgsqlCommand($"UPDATE task SET title = '{task.Title}', description = '{task.Description}', " +
                    $" done = {task.IsDone} WHERE id = {task.Id}");
                runQueryWithoutResult(command);
            } catch
            {
                throw new Exception($"Проекта с id = {task.ProjectId} не существует, невозможно добавить задачу");
            }
        }

        public void DeleteTask(int taskId)
        {
            var command = new NpgsqlCommand($"DELETE FROM task WHERE id = {taskId}");
            runQueryWithoutResult(command);
        }
    }
}
