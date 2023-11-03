using EntityFrameWork_InMemory.Persistence;
using EntityFrameWork_InMemory.Entities;

Console.WriteLine("Entity Framework Core - InMemory");

NoteMasterDbContext _context = new();

_context.Notes.Add(new("Note1"));
_context.Notes.Add(new("Note2"));
_context.Notes.Add(new("Note3"));
_context.Notes.Add(new("Note4"));

_context.SaveChanges();

List<Note> notes = _context.Notes.ToList();

Console.WriteLine();


