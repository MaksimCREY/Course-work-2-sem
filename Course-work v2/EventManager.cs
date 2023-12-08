// EventManager.cs
using System;

public class EventManager
{
    // Определение делегата для события
    public delegate void EmployeeListChangedEventHandler(object sender, EventArgs e);

    // Событие, которое срабатывает при изменении списка сотрудников
    public event EmployeeListChangedEventHandler EmployeeListChanged;

    // Метод, вызывающий событие
    protected virtual void OnEmployeeListChanged(EventArgs e)
    {
        // Проверка, что есть подписчики на событие
        EmployeeListChanged?.Invoke(this, e);
    }

    // Добавление сотрудника в отдел
    public void AddEmployeeToDepartment(Employee employee, Department department)
    {
        department.AddEmployee(employee);

        // Вызываем событие, сообщая об изменении списка сотрудников
        OnEmployeeListChanged(EventArgs.Empty);
    }
}
