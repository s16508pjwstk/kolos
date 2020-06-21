using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace s16508_kolokwium.Models
{
    public class MusicianTrack
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMusicianTrack { get; set; }

        [ForeignKey("Musician")]
        public int? IdMusician { get; set; }

        public virtual Musician Musician { get; set; }

        [ForeignKey("Track")]
        public int? IdTrack { get; set; }

        public virtual Track Track { get; set; }

    }
}
