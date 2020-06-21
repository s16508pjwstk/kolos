using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace s16508_kolokwium.Models
{
    public class Track
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTrack { get; set; }

        public string TrackName { get; set; }

        public float Duration { get; set; }

        [ForeignKey("Album")]
        public int? IdAlbum { get; set; }

        public virtual Album Album { get; set; }


    }
}
