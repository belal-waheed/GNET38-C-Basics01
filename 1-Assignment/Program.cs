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
        }
    }
}
