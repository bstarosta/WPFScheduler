using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFScheduler.Database
{
    /// <summary>
    /// Klasa zarządzająca danymi o zadaniach. Zawiera metody pozwalające
    /// na zapisywanie i ususuwania danych o zadaniach do wykonania.
    /// </summary>
    public class TasksToDoData
    {
        /// <value>Lista przechowująca lokalne dane o zadaniach do wykonania</value>
        public List<TaskToDo> TasksToDo { get; set; }

        /// <summary>
        /// Metoda ładująca dane o zadaniach do wykonania z bazy do aplikacji
        /// </summary>
        public void LoadDataFromDatabase()
        {
            using (var context = new SchedulerDbContext())
                TasksToDo = context.TasksToDo.ToList();
        }

        /// <summary>
        /// Metoda zapisująca dane o zadaniu do bazy danych oraz danych lokalnych
        /// </summary>
        /// <param name="taskToDo">Zadanie do zapisania</param>
        public void Save(TaskToDo taskToDo)
        {
            using (var context = new SchedulerDbContext())
            {
                context.TasksToDo.Add(taskToDo);
                context.SaveChanges();
            }
            TasksToDo.Add(taskToDo);
        }

        /// <summary>
        /// Metoda usuwająca dane o zadaniu do wykonania z bazy danych oraz danych lokalnych
        /// </summary>
        /// <param name="taskToDo">Zadanie do usunięcia</param>
        public void Remove(TaskToDo taskToDo)
        {
            using (var context = new SchedulerDbContext())
            {
                TasksToDo.Remove(taskToDo);
                context.TasksToDo.Attach(taskToDo);
                context.TasksToDo.Remove(taskToDo);
                context.SaveChanges();
            }
        }
    }
}
