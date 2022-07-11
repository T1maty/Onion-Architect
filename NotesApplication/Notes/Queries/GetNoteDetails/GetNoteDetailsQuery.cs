using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace NotesApplication.Notes.Queries.GetNoteDetails
{
    public class GetNoteDetailsQuery : IRequest<NoteDetailsVm>
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
    }
}
