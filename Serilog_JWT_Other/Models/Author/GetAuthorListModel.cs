using Serilog_JWT_Other.Entities;

namespace Serilog_JWT_Other.Models.Author
{
    public class GetAuthorListRequestModel
    {

    }

    public class GetAuthorListResponseModel
    {
        public List<AuthorEntity> AuthorList { get; set; } = new List<AuthorEntity>();
    }
}
