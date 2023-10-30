using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyExcercise.Entities
{
    public class Playlist
    {
        public Guid Id { get; set; }
        private List<Song> Songs { get; set; }
        private Random random;


      
        public Playlist(Song firstSong)
        {
            Id = Guid.NewGuid();    
            Songs = new List<Song>();
            random = new();
            AddSong(firstSong);
        }

        public void AddSong(Song song)
        {
            if (song != null)
                Songs.Add(song);
        }

        public string GetSongs()
        {
          
            return string.Join("\n", Songs.Select(song => $"{song.Title} - {song.Composer}"));
        }

        public void SuffleSong()
        {
            int Count = Songs.Count;

            while (Count > 0)
            {
                Count--;
                
                Song song = Songs[Count];

                int randomIndex = random.Next(Count);

                Songs[Count] = Songs[randomIndex];

                Songs[randomIndex] = song;
            }
        }
    }
}
