﻿namespace Serilog_JWT_Other.Models.Author
{
    public class GetAuthorByIdRequestModel
    {
        public string Id { get; set; }
    }

    public class GetAuthorByIdResponseModel
    {
        public AuthorModel AuthorRes { get; set; }
    }
}
