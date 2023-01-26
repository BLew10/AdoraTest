abstract public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        // Made the list of Hobbies nullable due to the fact that the hobbies given are limited and that it is likely that list of Hobbies is not necessary information to have/store if not given. 
        public IEnumerable<Hobby>? Hobbies { get; set; }

        public int StreetNo { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public int Zip { get; set; }

        public string State { get; set; }

        protected List<string> DisciplinesOptions = new List<string>() {"computer science", "math", "biology", "chemistry", "history", "physics", "english"};

        // Given the access modifier "protected" so that the methods of _emailer and  are only accessible within the child classes
        protected Emailer _emailer;

        // Given the access modifier "protected" so that the _academicYear can be modified only by the setter method of AcademicYear (which exists in the child classes) so that the int passed in is validated
        protected int _academicYear;

        public void GoToParty(string partyName)
        {
            //String interpolation used instead of string concatenation 
            Console.WriteLine($"Went to party at {partyName}");

        }

        //Both children used this method, marked as abstract so it can be overriden by the children since they each use different logic.
        public abstract void EmailExamResult(string discipline, int mark);
    }