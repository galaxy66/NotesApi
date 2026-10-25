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
    [ApiController]
    public class NotesController : ControllerBase
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
            return Created("/api/notes/" + note.Id, note);
        }


        [HttpPost]
        [Route("api/notes/{id}")]
        public IActionResult UpdateNote(int id, Note note)
        {
            if (!_notes.UpdateNote(id, note))
        }

        [HttpGet]
        [Route("api/notes")]
        public IActionResult GetAllNotes()
        {
            var notes = _notes.GetAll();

            return Ok(notes);
        }
    }
}
