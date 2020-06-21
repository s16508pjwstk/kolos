using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using s16508_kolokwium.DTO;
using s16508_kolokwium.Models;

namespace s16508_kolokwium.Controllers
{
    [Route("api/musician")]
    [ApiController]
    public class MusicianController : ControllerBase
    {
        private readonly MusicDbContext _context;

        public MusicianController(MusicDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetMusicianInfo(int id)
        {
            Musician musician = _context.Musicians.Where(e => e.IdMusician == id).First();
            ICollection<MusicianTrack> MusicianTracks = musician.MusicianTracks;
            ICollection<Track> tracks = new ICollection<Track>();

            foreach (var i in MusicianTracks)
            {
                tracks.Add(i.Track);
            }
            GetMusicianResponse getMusicianResponse = new GetMusicianResponse();
            getMusicianResponse.IdMusician = musician.IdMusician;
            getMusicianResponse.FirstName = musician.FirstName;
            getMusicianResponse.LastName = musician.LastName;
            if(musician.NickName != null)
            {
                getMusicianResponse.NickName = musician.NickName;
            }
            getMusicianResponse.MusicianTracks = tracks;

            return Ok(getMusicianResponse);


        }

        [HttpPost]
        public IActionResult AddMusician(AddMusician addMusician)
        {
            Musician musician = new Musician();
            musician.FirstName = addMusician.FirstName;
            musician.LastName = addMusician.LastName;

            Track track = new Track();
            addMusician.track.
        }
    }
}