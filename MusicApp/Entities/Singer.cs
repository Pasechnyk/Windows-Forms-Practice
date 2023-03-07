using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicApp.Entities
{
    public class Singer
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [ForeignKey("CountryId")]
        public Country Country { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
}
