namespace EF_2504.DAL.Entities
{
    public class BookDetail
    {
        public int BookDetailId { get; set; }
        public string BookDetailIsbn { get; set; }
        public string BookDetailCity { get; set; }
        public string BookDetailCountry { get; set; }
        public int BookDetailYear { get; set; }
        //Foreign Key
        public int BookId { get; set; }
        //Navigation Key
        public Book Book { get; set; }
    }
}
