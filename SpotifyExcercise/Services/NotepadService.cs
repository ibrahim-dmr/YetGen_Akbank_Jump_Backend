using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyExcercise.Entities;

namespace SpotifyExcercise.Services
{
    public class NotepadService
    {
        public void PlaylistToNotepad(Playlist playlist)
        {

            string directory = @$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName }\Playlists";

            if (!File.Exists(directory))
                Directory.CreateDirectory(directory);

            string saveFile = Path.Combine(directory, $"{playlist.Id}.txt");

            File.WriteAllText(saveFile, playlist.GetSongs());

            Console.WriteLine("Data Successfully Saved to Notepad!");
        }
    }
}
