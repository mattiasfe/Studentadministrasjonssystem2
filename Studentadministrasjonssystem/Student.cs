namespace Studentadministrasjonssystem;

public class Student
{
    private string name;
    private int age;
    private int studentId;
    string studieProgram;

    public Student(string name, int age, int studentId, string studieProgram)
    {
        this.name = name;
        this.age = age;
        this.studentId = studentId;
        this.studieProgram = studieProgram;
    }
    
    public void GetName(string name)
    {
        Console.WriteLine($"Navn: {name}");
    }
    public void GetAge(int age)
    {
        Console.WriteLine($"Alder: {age}");;
    }
    public void GetStudentId(int studentId)
    {
        Console.WriteLine($"Id: {studentId}");
    }

    public void GetStudeieProgram(string studieProgram)
    {
        Console.WriteLine($"StudieProgram: {studieProgram}");
    }
}



