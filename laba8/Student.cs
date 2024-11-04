using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentingTheStudentAccountingSystem
{
    /// <summary>
    /// Класс, представляющий информацию о студенте.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Имя студента.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия студента.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Возраст студента.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Номер студенческого билета.
        /// </summary>
        public string StudentID { get; set; }

        /// <summary>
        /// Статус студента.
        /// </summary>
        public EducationType Education { get; set; }

        /// <summary>
        /// Конструктор для создания нового студента.
        /// </summary>
        /// <param name="firstName">Имя студента.</param>
        /// <param name="lastName">Фамилия студента.</param>
        /// <param name="age">Возраст студента.</param>
        /// <param name="studentId">Номер студенческого билета.</param>
        /// <param name="education">Тип обучения студента.</param>
        public Student(string firstName, string lastName, int age, string studentId, EducationType education)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            StudentID = studentId;
            Education = education;
        }

        /// <summary>
        /// Возвращает тип обущения на русском языке.
        /// </summary>
        /// <returns>Тип обучения на русском языке.</returns>
        public string GetEducationTypeInRussian()
        {
            return Education switch
            {
                EducationType.Budget => "Бюджет",
                EducationType.Contract => "Контракт",
                _ => "Неизвестно"
            };
        }
    }
}