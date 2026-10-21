public class Employee
{
   public int Id;
   public string? FirstName;
   public string? LastName;
   public int Age;
    public string? PhoneNumber;
    public double Salary;
    public int GetBirthYear()
    {
        return 2026-Age;
    }
    public Employee(){}
    public Employee(string? name, string? sur)
    {
        FirstName=name;
        LastName=sur;
    }
}