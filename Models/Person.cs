namespace Models
{
    public class Person
    {
        public string SecretCode { get; set; }
        public string Name { get; set; }

        public Person(string secretCode, string name)
        {
            SecretCode = secretCode;
            Name = name;
        }
    }
}