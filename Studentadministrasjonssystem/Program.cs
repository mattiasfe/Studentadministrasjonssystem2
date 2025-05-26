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



// Herman herman = new Herman("Herman", 55, 2277, "IT", 5, 20, "Python", 222);
// Ola ola = new Ola("Ola", 27, 2278, "Medisin", 5, "NevroKirugi", 222, 23);
//
//
// List<Herman> hermanListe = [herman];
// List<Ola> olaListe = [ola];
// SkrivUtInfo();
//
// void SkrivUtInfo()
// {
//     Console.WriteLine("Velg informasjon du vil ha");
//     Console.WriteLine("Ola, Herman");
//
//     
//     string input = Console.ReadLine();
//
//     switch (input)
//     {
//         case "Ola":
//             break;        
//         case "Herman":
//             break;
//         default:
//             Console.WriteLine("Noe gikk galt");
//             break;
//   
//     }
//             if (input == "Herman")
//             {
//                 Console.WriteLine());
//             }
//             else
//             {
//                 Console.WriteLine(olaListe.ToArray());
//             }
//    
// }
