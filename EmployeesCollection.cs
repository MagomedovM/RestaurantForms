using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantForms
{
    public class EmployeesCollection
    {
        public List<Employee> array = new List<Employee>()
        {
            new Employee() { firstName = "Марат",      lastName = "Магомедов", Position = "Директор ресторана", Salary = 250000},
            new Employee() { firstName = "Александра", lastName = "Шмелёва",   Position = "Администратор зала", Salary = 150000},
            new Employee() { firstName = "Максим",     lastName = "Алексеев",  Position = "Главный бухгалтер",  Salary = 120000},
            new Employee() { firstName = "Алексей",    lastName = "Лебедев",   Position = "Шеф повар",          Salary = 150000},
            new Employee() { firstName = "Анастасия",  lastName = "Солнцева",  Position = "Повар",              Salary = 100000},
            new Employee() { firstName = "Ирина",      lastName = "Витальева", Position = "Повар",              Salary = 100000},                new Employee() { firstName = "Антон",      lastName = "Прыкин",    Position = "Повар",              Salary = 100000},
            new Employee() { firstName = "Аркадий",    lastName = "Паровозов", Position = "Уборщик",            Salary = 40000},
            new Employee() { firstName = "Василий",    lastName = "Петров",    Position = "Гардеробщик",        Salary = 50000},
            new Employee() { firstName = "Алёна",      lastName = "Морозова",  Position = "Оффициант",          Salary = 80000},
            new Employee() { firstName = "Николай",    lastName = "Шумов",     Position = "Оффициант",          Salary = 80000},
            new Employee() { firstName = "Виктория",   lastName = "Медлякова", Position = "Мойщик посуды",      Salary = 40000},
        };
    }
}
