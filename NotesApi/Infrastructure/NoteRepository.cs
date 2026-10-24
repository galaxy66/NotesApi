using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotesApi.Application;
using NotesApi.Domain;

namespace NotesApi.Infrastructure
{


    public class NoteRepository : INoteRepository
    {
        List<Note> notes = new List<Note>();
        public void Add(Note note)
        {
            note.Id = notes.Count + 1;
            notes.Add(note);

        }
        public List<Note> GetAll()
        {
            return notes;
        }
    }
}
