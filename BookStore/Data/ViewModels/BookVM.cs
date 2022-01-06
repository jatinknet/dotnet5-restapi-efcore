﻿using System;

namespace BookStore.Data.ViewModels
{
    public class BookVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }

        public string Genre { get; set; }

        public string Author { get; set; }

        public int? Rate { get; set; }

        public string CoverUrl { get; set; }
    }
}
