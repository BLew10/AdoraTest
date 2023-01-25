 public class Emailer

    {
        public bool CreateAndSendExamResultEmail(string from, string to, string firstName, string lastName, int academicYear, string discipline, int mark)
        {
            //String interpolation used  
            Email email = new Email();
            email.From = from;
            email.To = to;
            email.Subject = $"{firstName} {lastName} exam result for discipline {discipline}";
            email.Body = $"Hi there! Here is the exam result for student {firstName} {lastName}: Discipline: {discipline}, Academic year: {academicYear},  Mark: {mark}";

            return Send(email);
        }

        public bool Send(Email email)
        {
            Random rand = new Random();
            int rInt = rand.Next(1, 3);
            if (1 / rInt == 1)
            {
                Console.WriteLine("Email sent successfully.");
                Console.WriteLine(email.Body);
                return true;

            }
            else
            {
                Console.WriteLine("Email failed to send.");
                return false;
            }


        }

    }