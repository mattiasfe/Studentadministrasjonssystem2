using Studentadministrasjonssystem;
List<Student> studentListe = 
[
    new ("Herman", 22, 3344, "Medisin"),
    new ("Ola", 24, 3364, "IT")
];

foreach (var student in studentListe)
{
    student.SkrivUtInfo();
}

