using System.Collections.Generic;

namespace Bookstore.Catalog.Api.Dto.Books
{
    public class AuthorResponse
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public byte[] Photo { get; set; }
        public int BirthYear { get; set; }
        public string Nationality { get; set; }

        public ICollection<BookResponse> Books { get; set; }
    }
}
