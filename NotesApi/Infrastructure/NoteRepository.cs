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
        public Note GetById(int id)
        {
            return notes.FirstOrDefault(n => n.Id == id);

        }

        public void Remove(int id)
        {
            var note = GetById(id);
            if (note != null)
            {
                notes.Remove(note);
            }
        }
        public bool UpdateNote(int id, Note note)
        {
            var existingNote = GetById(id);
            if (existingNote != null)
            {
                notes.Remove(existingNote);
                note.Id = id;
                notes.Add(note);
                return true;
            }
            return false;
        }
    }
}
