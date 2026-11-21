using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotesApi.Domain;

namespace NotesApi.Application.DTO
{
    public class NoteResponse
    {
        public int Id
        {
            get; set;
        }
        public string Title
        {
            get; set;
        }
        public string Body
        {
            get; set;
        }
        public static NoteResponse FromNote(Note note)
        {
            NoteResponse noteresp = new NoteResponse
            {
                Id = note.Id,
                Title = note.Title,
                Body = note.Body
            };
            return noteresp;
        }

    }
}
