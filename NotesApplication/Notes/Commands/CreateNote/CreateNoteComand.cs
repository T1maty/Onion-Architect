using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace NotesApplication.Notes.Commands.CreateNote
{
    public class CreateNoteComand : IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
    }
}
