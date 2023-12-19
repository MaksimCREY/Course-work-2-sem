// Department.cs
using System;
using System.Collections.Generic;
using System.Linq;

public class Department
{
    private List<Employee> employees = new List<Employee>();

    //  метод для добавления сотрудника в отдел
    public void AddEmployee(Employee employee)
    {
        try
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee), "Employee cannot be null.");

            employees.Add(employee);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при добавлении сотрудника: {ex.Message}");
        }
    }

    // Метод для вывода списка сотрудников в отделе
    public void DisplayEmployees()
    {
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }
    }

    // Метод для расчета средней зарплаты в отделе
    public double CalculateAverageSalary()
    {
        if (employees.Count == 0)
            return 0;

        double totalSalary = employees.Sum(e => e.CalculateSalary());
        return totalSalary / employees.Count;
    }

    // Метод для получения старшего сотрудника в отделе
    public Employee GetOldestEmployee()
    {
        if (employees.Count == 0)
            return null;

        return employees.OrderByDescending(e => e.Age).FirstOrDefault();
    }

    // Метод для получения младшего сотрудника в отделе
    public Employee GetYoungestEmployee()
    {
        if (employees.Count == 0)
            return null;

        return employees.OrderBy(e => e.Age).FirstOrDefault();
    }

    // Другие методы для управления списком сотрудников в отделе

}
