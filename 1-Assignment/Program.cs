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

        }
    }
}
