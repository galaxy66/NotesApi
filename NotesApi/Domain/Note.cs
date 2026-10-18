using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesApi.Domain
{
    public class Note
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
        public bool HasTitle()
        {
            if (string.IsNullOrWhiteSpace(Title))
                return false;
            return true;
        }
    }
}
