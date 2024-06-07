namespace View_Components_Ex.Models
{
    public class Book
    {
        public Int64  BookId { get; set; }
        public string  BookName { get; set; }
        public string AuthorName {  get; set; }
        public decimal Price { get; set; }  
        public Book()
        {
            this.BookId = 1;
            this.BookName = "Jungle Book";
            this.AuthorName = "P.C.Chaure";
            this.Price = 450;        }
    }
}
