// Dzien 6

using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

Employee employee1 = new Employee ("Daniel", "Kozlowski", 30);
Employee employee2 = new Employee("Marian", "Kruk", 18);
Employee employee3 = new Employee("Balbina", "Kaczka", 59);

employee1.AddScore(4);
employee1.AddScore(1);
employee1.AddScore(6);
employee1.AddScore(4);
employee1.AddScore(1);

employee2.AddScore(0);
employee2.AddScore(0);
employee2.AddScore(9);
employee2.AddScore(7);
employee2.AddScore(8);

employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(5);
employee3.AddScore(7);
employee3.AddScore(3);


var result = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee userWithMaxResult = null;

foreach(var employee  in employees)
{
    if(employee.Result > maxResult)
    {
        userWithMaxResult = employee;
        maxResult = employee.Result;
    }
}
Console.WriteLine("Pracownik:" + " " + userWithMaxResult.Name + " " + userWithMaxResult.Surname + " " + userWithMaxResult.Age + "z najwyzsza liczba ocen,  ktora wynosi: " + userWithMaxResult.Result);
class Employee 
{
    private List<int> score = new List<int>();
    public Employee (string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public int Age { get; private set; }
    public void AddScore (int number)
    {
        this.score.Add(number);
    }
    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }

}