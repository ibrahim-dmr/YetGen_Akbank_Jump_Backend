using SpotifyExcercise.Entities;
using SpotifyExcercise.Services;

Console.WriteLine("Spotify - Music for Noone");

var song1 = new Song("Give Me Tonight", null, "George Benson", "RHINO");
var song2 = new Song("Moonlight Sonata", "Ludwig van Beethoven", "Various Artists", "Classical Records");
var song3 = new Song("The Four Seasons", "Antonio Vivaldi", "Chamber Orchestra", "Baroque Productions");
var song4 = new Song("Symphony No. 9", "Ludwig van Beethoven", "Philharmonic Orchestra", "Classic Harmony Records");

var playlist1 = new Playlist(song1);
playlist1.AddSong(song2);
playlist1.AddSong(song3);
playlist1.AddSong(song4);

Console.WriteLine("\nBefore Shuffle: ");
Console.WriteLine(playlist1.GetSongs());

playlist1.SuffleSong();

Console.WriteLine("\n\nAfter Shuflle: ");
Console.WriteLine(playlist1.GetSongs());

NotepadService notepadService = new();
notepadService.WriteToNotepad(playlist1);


