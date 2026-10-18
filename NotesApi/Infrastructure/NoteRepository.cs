using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotesApi.Application;
using NotesApi.Domain;

namespace NotesApi.Infrastructure
{
   
    
    public class NoteRepository:INoteRepository
    {
       
        public NoteRepository(INoteRepository note)
        {
            
        }
        public void Add(Note note)
        {
            


        }
    }
}
