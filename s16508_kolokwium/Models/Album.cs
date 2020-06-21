using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace s16508_kolokwium.Models
{
    public class Album
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAlbum { get; set; }

        public string AlbumName { get; set; }

        public DateTime PublishDate { get; set; }

        [ForeignKey("MusicLabel")]
        public int? IdMusicLabel { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }
    }
}
