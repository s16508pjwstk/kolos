using s16508_kolokwium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s16508_kolokwium.DTO
{
    public class GetMusicianResponse
    {
        public int IdMusician { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NickName { get; set; } // nullable

        public virtual ICollection<MusicianTrack> MusicianTracks { get; set; }
    }
}
