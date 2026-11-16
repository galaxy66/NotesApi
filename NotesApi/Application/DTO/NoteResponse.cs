using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesApi.Application.DTO
{
    public class NoteResponse
    {
        public int id
        {
            get; set;
        }
        public string Title
        {
            get; set;
        }
        public int Body
        {
            get; set;
        }

    }
}
