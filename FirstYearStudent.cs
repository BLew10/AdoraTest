public class FirstYearStudent : Student

    {

        public int AcademicYear
        {
            get => _academicYear;
            set
            {
                if (value < 1 || value > 2)
                    throw new Exception("Academic year for a first year student must be 1 or 2.");
                else
                    _academicYear = value;
            }
        }

        public FirstYearStudent(string firstName, string lastName, string email, DateTime dateOfBirth, IEnumerable<Hobby> hobbies, int streetNo, string streetAddress, string city, int zip, string state, int academicYear = 1)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
            Hobbies = hobbies;
            StreetNo = streetNo;
            StreetAddress = streetAddress;
            City = city;
            Zip = zip;
            State = state;
            AcademicYear = academicYear;
            _emailer = new Emailer();
        }


        public override void EmailExamResult(string discipline, int mark)
        {
            if (!DisciplinesOptions.Contains(discipline.ToLower()))
            {
                throw new Exception("Discipline is not available.");
            }
            if (discipline.ToLower() == "math" && AcademicYear > 1)
            {
                throw new Exception("Only students in Academic Year 1 can take the \"Math\" exam.");
            }
            if (discipline.ToLower() == "computer science" && AcademicYear < 2)
            {
                throw new Exception("Students in their first academic year students cannot take \"Computer science\" exam.");
            }

            // Changed from no-replay@emailer.com to "no-reply@emailer.com" -> made string and spelling correction
            _emailer.CreateAndSendExamResultEmail("no-reply@emailer.com", Email, FirstName, LastName, AcademicYear, discipline, mark);

        }


    }