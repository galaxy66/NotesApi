using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotesApi.Application;
using NotesApi.Domain;
using NotesApi.Infrastructure;

namespace NotesApi.Controllers
{
    public class NotesController:ControllerBase
    {
        private readonly INoteRepository _notes;
        public NotesController(INoteRepository note)
        {
            _notes = note;
        }
        [HttpPost]
        [Route("api/notes")]
        public IActionResult CreateNote(Note note)
        {
            if (!note.HasTitle())
                return BadRequest();
            _notes.Add(note);
            return Created("/api/notes/" + note.Id,note);
        }
    }
}
