using System.Text.Json;

namespace ReadAndWriteToFile
{
    internal class Serialization
    {

    }
    [Serializable]
    class Student 
    {
        
        public int RoolNo;
        public string Name;

        public Student(int roolNo, string name)
        {
            RoolNo = roolNo;
            Name = name;
        }
    }
}
