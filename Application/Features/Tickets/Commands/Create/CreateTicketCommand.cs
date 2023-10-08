using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tickets.Commands.Create;

public class CreateTicketCommand : IRequest<CreatedTicketResponse>
{
    public string Name { get; set; }



    public class CreateTicketCommandHandler : IRequestHandler<CreateTicketCommand, CreatedTicketResponse>
    {
        public Task<CreatedTicketResponse>? Handle(CreateTicketCommand request, CancellationToken cancellationToken)
        {
            CreatedTicketResponse createdTicketResponse = new CreatedTicketResponse();
            createdTicketResponse.Name = request.Name;
            createdTicketResponse.Id = new Guid();

            return null;
        }
    }

}
