﻿namespace LibrarySystem.Models.Book
{
    public class GetBookByIdRequestModel
    {
        public string Id { get; set; }

    }

    public class GetBookByIdResponseModel
    {
        public BookModel BookRes { get; set; }
    }
}
