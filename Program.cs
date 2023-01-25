// Hello Brandon,

// As the final step in your interview process, can you please answer the following coding challenge questions:


// Problem #1



// In order to win the prize for most cookies sold, my friend Todd and I are going to merge our Boy Scout Cookies orders and enter as one unit.

// Each order is represented by an "order id" (an integer).

// We have our lists of orders sorted numerically already, in arrays. Write a method to merge our arrays of orders into one sorted array.



// For example:

int[] myArray = { 3, 4, 6, 10, 11, 15 };

int[] toddsArray = { 1, 5, 8, 12, 14, 19 };

int[] MergeArrays(int[] arrOne, int[] arrTwo)
{
    int pointerOne = 0;
    int pointerTwo = 0;
    int[] result = new int[arrOne.Length + arrTwo.Length];
    for (int i = 0; i < result.Length; i++)
    {
        if (pointerOne >= arrOne.Length)
        {
            result[i] = arrTwo[pointerTwo++];
        }
        else if (pointerTwo >= arrTwo.Length)
        {
            result[i] = arrOne[pointerOne++];
        }
        else
        {
            result[i] = arrOne[pointerOne] < arrTwo[pointerTwo] ? arrOne[pointerOne++] : arrTwo[pointerTwo++];
        }
    }
    return result;
}



// Prints [1, 3, 4, 5, 6, 8, 10, 11, 12, 14, 15, 19]

Console.WriteLine($"[{string.Join(", ", MergeArrays(toddsArray, myArray))}]");



// Problem #2

FirstYearStudent eric = new FirstYearStudent("Eric","Bush","ebush@mail.com", new DateTime(2003, 04, 30), new List<Hobby>() { Hobby.Football, Hobby.Music }, 10,"Rosemary Ct.", "Sacramento", 95678, "CA", 1);

eric.GoToParty("Chris's wedding");

eric.EmailExamResult("Math", 4);



LastYearStudent andrew = new LastYearStudent("Andrew", "Hanna", "ahanna@test.com",new DateTime(2000, 11, 15), new List<Hobby>() { Hobby.Movies, Hobby.Music, Hobby.Cars },14, "Helen St.", "Rocklin", 95985, "CA", 5);
andrew.GoToParty("Chris's wedding");

andrew.GoToOpera("Othello");

andrew.EmailExamResult("Chemistry", 4);

Console.ReadKey();









