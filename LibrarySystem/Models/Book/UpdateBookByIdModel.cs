﻿namespace LibrarySystem.Models.Book
{
    public class UpdateBookByIdRequestModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string AuthorId { get; set; }

        public string CategoryId { get; set; }

        public int PublishedYear { get; set; }

        public int TotalQuantity { get; set; }

        public int AvailableQuantity { get; set; }
    }
    public class UpdateBookByIdResponseModel
    {

    }
}
