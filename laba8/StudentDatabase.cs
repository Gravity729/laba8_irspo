using DocumentingTheStudentAccountingSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentingTheStudentAccountingSystem
{
    /// <summary>
    /// Класс для работы с базой данных студентов.
    /// </summary>
    public class StudentDatabase
    {
        /// <summary>
        /// Список студентов.
        /// </summary>
        private List<Student> students = new List<Student>();

        /// <summary>
        /// Метод для добавления студента в базу.
        /// </summary>
        /// <param name="student">Студент для добавления.</param>
        /// <exception cref="ArgumentNullException">Выбрасывается, если студент равен null.</exception>
        /// <example>
        /// <code>
        /// var db = new StudentDatabase();
        /// var student1 = new Student("Иван", "Петров", 20, "S12345", EducationType.Budget); 
        /// db.AddStudent(student1);  // В данном примере добавляется новый студент Иван Петров.
        /// </code>
        /// </example>
        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student), "Студент не может быть null.");
            }
            students.Add(student);
        }

        /// <summary>
        /// Метод для удаления студента по номеру студенческого билета.
        /// </summary>
        /// <param name="studentId">Номер студенческого билета студента для удаления.</param>
        /// <exception cref="InvalidOperationException">Выбрасывается, если студент с указанным номером не найден.</exception>
        /// <example>
        /// <code>
        /// var db = new StudentDatabase();
        /// var student1 = new Student("Иван", "Петров", 20, "S12345");
        /// db.RemoveStudent("S12345"); // Удалит Ивана из базы
        /// </code>
        /// </example>
        public void RemoveStudent(string studentId)
        {
            var student = students.FirstOrDefault(s => s.StudentID == studentId);
            if (student == null)
            {
                throw new InvalidOperationException("Студент с указанным номером не найден.");
            }
            students.Remove(student);
        }

        /// <summary>
        /// Метод для поиска студента по номеру студенческого билета.
        /// </summary>
        /// <param name="studentId">Номер студенческого билета студента для поиска.</param>
        /// <returns>Найденный студент или null, если студент не найден.</returns>
        /// <example>
        /// <code>
        /// var db = new StudentDatabase();
        /// var student1 = new Student("Иван", "Петров", 20, "S12345");
        /// var foundStudent = db.FindStudent("S12345"); // Найдет студента Ивана
        /// </code>
        /// </example>
        public Student FindStudent(string studentId)
        {
            return students.FirstOrDefault(s => s.StudentID == studentId);
        }

        /// <summary>
        /// Метод для сортировки студентов по фамилии.
        /// <remarks>
        /// Алгоритм сортировки использует метод OrderBy из LINQ для упрощения 
        /// сортировки списка студентов по их фамилии. 
        /// </remarks>
        /// </summary>
        /// <example>
        /// <c>
        /// db.SortStudentsByLastName(); // Сортирует студентов по фамилии
        /// </c>
        /// </example>
        public void SortStudentsByLastName()
        {
            students = students.OrderBy(s => s.LastName).ToList();
        }

        /// <summary>
        /// Получение списка всех студентов.
        /// </summary>
        /// <returns>Список студентов.</returns>
        /// <example>
        /// <c>
        /// var allStudents = db.GetAllStudents(); // Получит список всех студентов
        /// </c>
        /// </example>
        public List<Student> GetAllStudents()
        {
            return students;
        }
    }
}