namespace PRELIM_BSIT31A3_JB_LOBRICO.Models
{
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public class Student
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;

        public Student()
        {
            _firstName = "Unknown";
            _lastName = "Student";
            Title = "Mr./Ms.";
            Course = "BSIT";
            Section = "31A3";
            Birthday = new DateTime(2000, 1, 1);
            Gender = Gender.Unknown;
        }

        public Student(string firstName, string lastName)
        {
            SetFirstName(firstName);
            SetLastName(lastName);
            Title = "Mr./Ms.";
            Course = "BSIT";
            Section = "31A3";
            Birthday = new DateTime(2000, 1, 1);
            Gender = Gender.Unknown;
        }

        public string FirstName => _firstName;
        public string LastName => _lastName;

        public string Title { get; set; }
        public string Course { get; set; }
        public string Section { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }

        public void SetFirstName(string firstName) => _firstName = firstName;
        public void SetLastName(string lastName) => _lastName = lastName;
        public void SetGender(Gender gender) => Gender = gender;

        public string FullName => $"{Title} {FirstName} {LastName}";

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                int age = today.Year - Birthday.Year;
                if (Birthday > today.AddYears(-age)) age--;
                return age;
            }
        }
    }
}
