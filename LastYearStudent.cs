public class LastYearStudent : Student

    {

        public int AcademicYear

        {

            get => _academicYear;

            set
            {

                if (value < 3 || value > 5)

                    throw new Exception("Academic year for last year student must be in range of 3 to 5");

                else

                    _academicYear = value;

            }

        }

        public LastYearStudent(string firstName, string lastName, string email, DateTime dateOfBirth, IEnumerable<Hobby> hobbies, int streetNo, string streetAddress, string city, int zip, string state, int academicYear = 3)
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
            if (!Disciplines.Contains(discipline.ToLower()))
            {
                throw new Exception("Discipline is not available.");
            }

            if (discipline.ToLower() == "biology" && AcademicYear != 4)

            {

                throw new Exception("Only 4th year students can take \"Biology\" exam.");

            }



            if (discipline.ToLower() == "math" && AcademicYear != 3)

            {
                // Spelling correction: 3th -> 3rd
                throw new Exception("Only 3rd year students can take \"Math\" exam.");

            }
            // Changed from no-replay@emailer.com to "no-reply@emailer.com" -> made string and spelling correction
            _emailer.CreateAndSendExamResultEmail("no-reply@emailer.com", Email, FirstName, LastName, AcademicYear, discipline, mark);

        }

        public void GoToOpera(string operaName)

        {
            // String interpolation instead of concatenation and changed what was written to the console to a more complete snetence
            Console.WriteLine($"Went to the opera show {operaName}");

        }



    }