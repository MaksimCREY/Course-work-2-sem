using System.Collections.Generic;
using System;

class Program
{
    static void Main()
    {
        // Создаем менеджер аутентификации
        AuthenticationManager authManager = new AuthenticationManager();

        // Пользовательский ввод для проверки аутентификации
        Console.Write("Введите имя пользователя: ");
        string username = Console.ReadLine();

        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();

        // Проверка аутентификации
        if (authManager.Authenticate(username, password))
        {
            Console.WriteLine("Аутентификация успешна!");

            // Создаем отдел
            Department hrDepartment = new Department();

            // Создаем сотрудников различных типов
            Employee employee1 = new Manager { FirstName = "Иван", LastName = "Иванов", Age = 35 };
            Employee employee2 = new Developer { FirstName = "Петр", LastName = "Петров", Age = 28 };
            Employee employee3 = new Administrator { FirstName = "Анна", LastName = "Иванова", Age = 30 };

            // Добавляем сотрудников в отдел
            hrDepartment.AddEmployee(employee1);
            hrDepartment.AddEmployee(employee2);
            hrDepartment.AddEmployee(employee3);

            // Выводим список сотрудников в отделе
            Console.WriteLine("Список сотрудников в отделе:");
            hrDepartment.DisplayEmployees();

            // Выводим статистику
            Console.WriteLine("\nСтатистика:");
            Statistics departmentStatistics = new Statistics(new List<Employee> { employee1, employee2, employee3 });
            Console.WriteLine($"Общая зарплата: {departmentStatistics.CalculateTotalSalary()}");
            Console.WriteLine($"Старший сотрудник: {departmentStatistics.GetOldestEmployee()}");
            Console.WriteLine($"Младший сотрудник: {departmentStatistics.GetYoungestEmployee()}");
            Console.WriteLine($"Средняя зарплата: {hrDepartment.CalculateAverageSalary()}");
            // Дополнительные статистические вычисления
            Console.WriteLine($"Средний возраст: {departmentStatistics.CalculateAverageAge()}");
            Console.WriteLine($"Количество сотрудников младше 30 лет: {departmentStatistics.CountEmployeesYoungerThan(30)}");
        }
        else
        {
            Console.WriteLine("Ошибка аутентификации. Доступ запрещен.");
        }
    }
}
