using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicApp.Entities
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }

        [ForeignKey("SingerId")]
        public Singer Singer { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }
        [ForeignKey("PlaylistId")]
        public PlayList PlayList { get; set; }

        public override string ToString()
        {
            return $"{Id + 1} {Name} {Singer.Name} {Genre.Name} {Duration}s.";
        }
    }
}
