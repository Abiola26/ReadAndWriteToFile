// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");*/
using ReadAndWriteToFile;
using System.Text.Json;
using Newtonsoft.Json;

/*string path = @"C:\Users\hp\source\repos\ReadAndWriteToFile\data.txt";*/
string path = @"C:\Users\hp\source\repos\ReadAndWriteToFile\name.txt";
/*string path1 = @"C:\Users\hp\source\repos\ReadAndWriteToFile\name.txt";*/
/*string path2 = "C:\\Users\\hp\\source\\repos\\ReadAndWriteToFile\\Students\\students.txt";*/
/*string path3 = "C:\\Users\\hp\\source\\repos\\ReadAndWriteToFile\\Students\\file.txt";*/

/*string readText = File.ReadAllText(path);
Console.WriteLine(readText);*/

/*string message = "Hasbiyallah is a girl";
File.WriteAllText(path, message);
string messag = "Hasbiyallah is a boy";
File.WriteAllText(path, messag);*/

/*string newText = " Mine";
File.AppendAllText(path, newText);
*/

/*var directory = "C:\\Users\\hp\\source\\repos\\ReadAndWriteToFile\\Students";
Directory.CreateDirectory(directory);
var FileName = "students.txt";
var fullpath = Path.Combine(directory, FileName);
using (File.Create(fullpath))
{

}*/


/*File.Copy(path1, path3);*/

/*string[] text = File.ReadAllLines(path1);
foreach (var item in text)
{
    Console.WriteLine(item);
}*/

/*StreamReader reader = new StreamReader(path);
int number = 0;
var lines = reader.ReadLine();
while(lines is not null)
{
    number++;
    Console.WriteLine($"{number} {lines}");
    lines = reader.ReadLine();
}
reader.Close();*/

/*
using (StreamReader reader = new StreamReader(path))
{
    int number = 0;
    var lines = reader.ReadLine();
    while (lines is not null)
    {
        number++;
        Console.WriteLine($"{number} {lines}");
        lines = reader.ReadLine();
    }
}*/

/*StreamWriter writer = new StreamWriter(path,true);
string a = "My Instructor is Abbass Joda";
writer.WriteLine(a);
writer.Close();*/

/*using (StreamWriter writer = new StreamWriter(path, true))
{
    string a = "He is a big man";
    writer.Write(a);
}*/

/*using(FileStream stream = new("sss.txt",FileMode.OpenOrCreate))
{
    Student student = new Student(102, "hjmd");
    string jsonString = JsonSerializer.Serialize(student);
}*/


Student student = new Student(102, "Ade");
//string jsonString = JsonSerializer.Serialize(student);
string json = JsonConvert.SerializeObject(student);

File.WriteAllText(path, json);
Console.WriteLine(json);

var read = File.ReadAllText(path);
var deserialized = JsonConvert.DeserializeObject<Student>(read);
if (deserialized != null)
{
    Console.WriteLine($"Roll no: {deserialized.RoolNo} \t Name: {deserialized.Name}");
}