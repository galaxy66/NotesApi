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

        public void Add(Note note)
        {
            list<Note> notes = new list<Note>();
            notes.Add(note);

        }
    }
}
