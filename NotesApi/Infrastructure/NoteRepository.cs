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
        list<Note> notes = new list<Note>();
        public void Add(Note note)
        {

            notes.Add(note);

        }
    }
}
