using System;
using System.Collections.Generic;

namespace MvcMusicStore.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}
