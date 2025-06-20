namespace BusinessObjects
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        override public string ToString()
        {
            return $"{Name} - {Email} - {Phone}";
        }
    }
}
