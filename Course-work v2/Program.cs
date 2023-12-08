// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Создаем отдел
        Department hrDepartment = new Department();

        // Создаем сотрудника
        Employee employee1 = new Employee { FirstName = "Иван", LastName = "Иванов", Age = 30 };

        // Добавляем сотрудника в отдел
        hrDepartment.AddEmployee(employee1);

        // Выводим список сотрудников в отделе
        Console.WriteLine("Employees in HR Department:");
        hrDepartment.DisplayEmployees();

        // Выводим статистику
        Console.WriteLine("\nСтатистика:");
        Statistics departmentStatistics = new Statistics(new List<Employee> { employee1 });
        Console.WriteLine($"Общая зарплата: {departmentStatistics.CalculateTotalSalary()}");
        Console.WriteLine($"Старший сотрудник: {departmentStatistics.GetOldestEmployee()}");
        Console.WriteLine($"Младший сотрудник: {departmentStatistics.GetYoungestEmployee()}");
        Console.WriteLine($"Средняя зарплата: {hrDepartment.CalculateAverageSalary()}");
    }
}
