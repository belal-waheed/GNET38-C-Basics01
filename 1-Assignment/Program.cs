namespace _1_Assignment
{
    class Book
    {
        public string? Title;
        public int Pages;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            // Create a Book class with a Title (string) and Pages (int). Create a Book object and store it
            // in a variable of type object. Print it.

            //object book = new Book() { Title = "Clean Code", Pages = 464 };
            //Console.WriteLine(book);
            #endregion

            #region Question 02
            // Using the Book class above, print the result of calling ToString(), Equals() (compare book
            // with itself), GetHashCode(), and GetType() on book.

            //Book book = new Book() { Title = "Clean Code", Pages = 464 };
            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());
            #endregion

            #region Question 03
            // Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            // int pages = "464";

            // Compile-time error — you can't put string into an int , fix just remove the string quotes.

            //int pages = 464;
            //Console.WriteLine(pages);
            #endregion

            #region Question 04
            // Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot
            // divide by zero", and then prints "Done" in a finally block.
            //try
            //{
            //    int x = 10;
            //    int y = 0;
            //    int result = x / y;
            //    Console.WriteLine(result);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion

            #region Question 05
            // Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages = 300;
            //double doublePages = pages;
            //Console.WriteLine(doublePages);
            #endregion

            #region Question 06
            // Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 49.99;
            //int priceInt = (int)price;
            //Console.WriteLine(priceInt);
            #endregion

            #region Question 07
            // Given string pagesText = "464";, convert it into an int using the Convert class.
            //string pagesText = "464";
            //int pages = Convert.ToInt32(pagesText);
            //Console.WriteLine(pages);
            #endregion

            #region Question 08
            // Given string yearText = "2023";, convert it using int.Parse(). Then given string badText =
            // "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.

            //string yearText = "2023";
            //int parsedYear = int.Parse(yearText);
            //Console.WriteLine(parsedYear);
            //string badText = "bbc";
            //if (int.TryParse(badText, out int result))
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}
            #endregion


            #region Question 09
            // Given int pages = 464;, convert it into a string using ToString() and print its type using
            // GetType() to prove it's now a string.

            //int pages = 464;
            //string pagesString = pages.ToString();
            //Console.WriteLine(pagesString);
            //Console.WriteLine(pagesString.GetType());
            #endregion

            #region Question 10
            // Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
            // variable, and print both.

            //int copies = 100;
            //object boxedCopies = copies;
            //int unboxedCopies = (int)boxedCopies;
            //Console.WriteLine(boxedCopies);
            //Console.WriteLine(unboxedCopies);
            #endregion

            #region Question 11
            // Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its
            // value.

            //int? year = null; // null is just nothing empty 
            //Console.WriteLine(year.HasValue);
            //year = 2023;
            //Console.WriteLine(year.Value);
            #endregion

            #region Question 12
            // Declare a string? reviewer = null;. Print whether it is null.

            //string? reviewer = null;
            //Console.WriteLine(reviewer == null);
            #endregion

            #region Question 13
            // Declare a Book? book = null;. Use ?. to safely read book.Title without crashing the
            // program, and print the result.

            //Book? book = null;
            //string? title = book?.Title;
            //Console.WriteLine(title);
            #endregion

            #region Question 14
            // Using title from the previous question, use ?? to print "Untitled" if title is null. Then use ??=
            // to assign title the value "Untitled" only if it's still null.

            //Book? book = null;
            //string? title = book?.Title;
            //Console.WriteLine(title ?? "Untitled");
            //title ??= "Untitled";
            //Console.WriteLine(title);
            #endregion
        }
    }
}
