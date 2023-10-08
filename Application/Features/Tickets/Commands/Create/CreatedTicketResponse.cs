using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tickets.Commands.Create;

public class CreatedTicketResponse
{

    public Guid Id { get; set; }
    public string Name { get; set; }
}
