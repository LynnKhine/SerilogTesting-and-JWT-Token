﻿namespace Serilog_JWT_Other.Models.Author
{
    public class GetAuthorByNameRequestModel
    {
        public string PenName { get; set; }
    }

    public class GetAuthorByNameResponseModel
    {
        public AuthorModel AuthorRes { get; set; }
    }
}
