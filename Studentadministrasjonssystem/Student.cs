namespace Studentadministrasjonssystem;

public class Student
{
    string _name;
    int _age;
    int _studentId;
    string _studieProgram;

    private List<Fag> fagListe =
    [
        new("IT", 20, 222)
    ];

    public Student(string name, int age, int studentId, string studieProgram)
    {
        _name = name;
        _age = age;
        _studentId = studentId;
        _studieProgram = studieProgram;
    }

    public void SkrivUtInfo()
    {
        Console.WriteLine($"""
                           Navn: {_name},
                           Alder: {_age},
                           Id: {_studentId},
                           StudieProgram: {_studieProgram},
                           Fag oversikt:
                           """);
        foreach (var fag in fagListe)
        {
            fag.skrivUtInfo();
        }
    }
}

