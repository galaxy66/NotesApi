using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotesApi.Domain;

namespace NotesApi.Application
{
    public interface INoteRepository
    {
        void Add(Note note);
        List<Note> GetAll();
    }
}
