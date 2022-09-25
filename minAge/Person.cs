namespace minAge
{
    public struct Person
    {
        public string FullName;

        public DateOfBirth BirthDate;

        public Person(string fullName ,DateOfBirth birthDate)
        {
            FullName = fullName;
            
            BirthDate = birthDate;
        }

        public string ToString()
        {
            return $"{FullName} родился {BirthDate.ToString()}";
        }
    }
}