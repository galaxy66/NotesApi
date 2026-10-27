using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotesApi.Application;
using NotesApi.Domain;
using NotesApi.Infrastructure;
using NotesApi.Application.DTO;

namespace NotesApi.Controllers
{
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INoteRepository _notes;
        private readonly CreateNoteRequest _createNoteRequest;
        public NotesController(INoteRepository note)
        {
            _notes = note;
        }
        [HttpGet]
        [Route("api/notes/{id}")]
        public IActionResult GetNoteById(int id)
        {
            var note = _notes.GetById(id);
            if (note == null)
                return NotFound();
            return Ok(note);
        }


        [HttpPost]
        [Route("api/notes")]
        public IActionResult CreateNote (CreateNoteRequest request)
        {
            var note=new Note
            {
                Title = request.Title,
                Body = request.Body
            };
            if (!note.HasTitle())
                return BadRequest();
            _notes.Add(note);
            return Created("/api/notes/" + note.Id, note);
        }


        [HttpPut]
        [Route("api/notes/{id}")]
        public IActionResult UpdateNote(int id, Note note)
        {
            if (!_notes.UpdateNote(id, note))
                return NotFound();
            return Ok(note);
        }

        [HttpGet]
        [Route("api/notes")]
        public IActionResult GetAllNotes()
        {
            var notes = _notes.GetAll();

            return Ok(notes);
        }

        [HttpDelete]
        [Route("api/notes/{id}")]
        public IActionResult DeleteRow(int id)
        {
            var note = _notes.GetById(id);
            if (note == null)
                return NotFound();
            _notes.Remove(id);
            return NoContent();
        }
    }
}
