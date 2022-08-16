namespace GeniyIdiot.Common.Models
{
    public class User
    {
        public string Name { get; set; }
        public User(string name)
        {
            Name = name;
        }

        public User() { }
    }
}
