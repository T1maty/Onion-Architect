using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NotesApplication.Interfaces;

namespace NotesApplication.Notes.Commands.UpdateNote
{
    public class UpdateNoteCommandHandler
        :IRequestHandler<UpdateNoteCommand>
    {
        private readonly INotesDbContext _dbContext;
        public UpdateNoteCommandHandler(INotesDbContext dbContext) =>
            _dbContext = dbContext;
            public async Task<Unit> Handle(UpdateNoteCommand request, 
                CancellationToken cancellationToken)
        {
            var entity =
                await _dbContext.Notes.FirstOrDefaultAsync(note =>
                note.Id = request.Id, cancellationToken);

                return Unit.Value;
        }
    }
}
