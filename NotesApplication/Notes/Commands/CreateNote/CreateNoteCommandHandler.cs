using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using MediatR;
using NotesApplication.Interfaces;

namespace NotesApplication.Notes.Commands.CreateNote
{

    public class CreateNoteCommandHandler : IRequestHandler<CreateNoteComand,Guid>
    {
        private readonly INotesDbContext _dbContext;
        public CreateNoteCommandHandler(INotesDbContext dbContext) =>
            _dbContext = dbContext;
        public async Task<Guid> Handle(CreateNoteComand request,
            CancellationToken cancellationToken)
        {
            var note = new Note
            {
                UserId = request.UserId,
                Title = request.Title,
                Details = request.Details,
                Id = Guid.NewGuid(),
                EditDate = null
            };
            await _dbContext.Notes.AddAsync(note,cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return note.Id; 
        }
    }
}
