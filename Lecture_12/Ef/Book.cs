namespace Lecture_12.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Book
    {
        public int Id { get; set; }

        public int PublishedYear { get; set; }

        [Required]
        public string Title { get; set; }

        public int AuthorId { get; set; }

        public int ReaderId { get; set; }

        public virtual Author Author { get; set; }

        public virtual Reader Reader { get; set; }
    }
}
