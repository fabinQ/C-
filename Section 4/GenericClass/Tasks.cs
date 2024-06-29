using System;

namespace Coding.Exercise
{
    using System.Collections.Generic;

    public class TaskManager
    {
        private List<string> tasks = new List<string>();

        public void AddTask(string task)
        {
            // TODO: Uzupełnij implementację metody AddTask, aby dodawała nowe zadanie do listy.
            tasks.Add(task);
        }

        public void RemoveTask(string task)
        {
            // TODO: Uzupełnij implementację metody RemoveTask, aby usuwała zadanie z listy, jeśli istnieje.
            // Metoda remove nie zwraca wyjątku więc try catch jest nie potrzebne
            tasks.Remove(task);

        }

        public List<string> GetTasks()
        {
            // TODO: Uzupełnij implementację metody GetTasks, aby zwracała listę wszystkich zadań.
            return tasks;
        }
    }


}
