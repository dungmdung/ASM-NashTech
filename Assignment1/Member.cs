namespace Assignment1
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }
        public string IsGraduated { get; set; }
        public string InformationOfAll
        {
            get
            {
                return FirstName + " | " + LastName + " | " + Gender + " | " + DateOfBirth + " | " + PhoneNumber +
                        " | " + BirthPlace + " | " + Age + " | " + IsGraduated;
            }
        }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}