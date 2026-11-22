This is the NotesApi ,A REST API for managing notes, built with Clean Architecture..
I use .Net 5 with C# and ASP.NET. and this project has 4 layers 
(Domain, Application, Infrastructure, API).
these are my APIs: 
Post api/notes →  CreateNote -  create new note 
Get api/notes/{id} →  GetNoteById- get a note by id 
Put api/notes/{id} →  UpdateNote-  update the note 
Get api/notes →  GetAllNotes- get all of them 
Delete api/notes/{id}  →   DeleteRow- delete one by one 
run it and open swagger to test