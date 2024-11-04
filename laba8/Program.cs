using DocumentingTheStudentAccountingSystem;
using System;

// Пример использования:
var db = new StudentDatabase();

// Список студентов для добавления
var studentsToAdd = new List<Student>
{
    new Student("Иван", "Петров", 20, "S12345", EducationType.Budget),
    new Student("Анастасия", "Симонова", 23, "S14341", EducationType.Budget),
    new Student("Анна", "Сидорова", 22, "S54321", EducationType.Contract)

};

// Добавление студентов
foreach (var student in studentsToAdd)
{
    db.AddStudent(student);
}

// Вывод информации о добавленных студентах
Console.WriteLine("Добавленные студенты:");
foreach (var student in studentsToAdd)
{
    Console.WriteLine($"{student.FirstName} {student.LastName} - {student.Age} лет, ID: {student.StudentID}, тип обучения: {student.GetEducationTypeInRussian()}");
}
Console.WriteLine("--------------------------------------------------------");

// Поиск студента
var foundStudent = db.FindStudent("S12345");
if (foundStudent != null)
{
    Console.WriteLine($"Найден студент: {foundStudent.FirstName} {foundStudent.LastName} - {foundStudent.Age} лет, ID: {foundStudent.StudentID}, тип обучения: {foundStudent.GetEducationTypeInRussian()}");
}
else
{
    Console.WriteLine("Студент с таким ID не найден.");
}
Console.WriteLine("--------------------------------------------------------");

// Удаление студента
db.RemoveStudent("S12345");
Console.WriteLine("Студент с ID S12345 удален из базы.");
Console.WriteLine("--------------------------------------------------------");

// Сортировка студентов по фамилии
db.SortStudentsByLastName();
Console.WriteLine("Студенты отсортированы по фамилии.");
var allStudents = db.GetAllStudents();
foreach (var student in allStudents)
{
    Console.WriteLine($"{student.FirstName} {student.LastName} - {student.Age} лет, ID: {student.StudentID}, тип обучения: {student.GetEducationTypeInRussian()}");
}