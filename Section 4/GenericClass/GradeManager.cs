using System;

namespace Coding.Exercise.GradeManagerClass
{
    using System.Collections.Generic;
    using System.Linq;
    
    public class GradeManager
    {
        private Dictionary<string, List<int>> DicOfGradueded = new Dictionary<string, List<int>>();
        
        public void AddGrade(string studentName, int grade)
        {
            // TODO: Uzupełnij implementację metody AddGrade, aby dodawała nową ocenę do listy ocen ucznia.
            if (!DicOfGradueded.ContainsKey(studentName))
            {
                DicOfGradueded[studentName] = new List<int>();
            }
            DicOfGradueded[studentName].Add(grade);
        
            
        }
    
        public void RemoveGrade(string studentName, int grade)
        {
            // TODO: Uzupełnij implementację metody RemoveGrade, aby usuwała ocenę z listy ocen ucznia, jeśli istnieje.
            if (DicOfGradueded.ContainsKey(studentName))
            {
                DicOfGradueded[studentName].Remove(grade);
            }
            else
            {
                System.Console.WriteLine("Incorect key value");
            }
        }
    
        public double CalculateAverageGrade(string studentName)
        {
            // TODO: Uzupełnij implementację metody CalculateAverageGrade, aby obliczała średnią ocen ucznia, jeśli istnieją oceny.
            if (DicOfGradueded.ContainsKey(studentName)  && DicOfGradueded[studentName].Count>0)
            {
                return DicOfGradueded[studentName].Average();
            }
            return 0;
        }
    }

}
