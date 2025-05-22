using Studentadministrasjonssystem;

Student student = new Student("ola", 55, 2277, "IT");
Fag fag = new Fag(23, "Python",  222);
skrivUtInfo();
void skrivUtInfo()
{
student.GetName("Ola");
student.GetAge(25);
student.GetStudentId(666);
student.GetStudeieProgram("IT");
fag.GetFagkode(23);
fag.GetAntallStudiepoeng(222);
fag.GetFagnavn("Python");

}


