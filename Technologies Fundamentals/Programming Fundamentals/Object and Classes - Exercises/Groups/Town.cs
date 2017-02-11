using System.Collections.Generic;

namespace Groups
{
    public class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }
}