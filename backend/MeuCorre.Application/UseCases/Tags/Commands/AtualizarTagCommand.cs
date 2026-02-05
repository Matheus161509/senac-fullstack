using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCorre.Application.UseCases.Tags.Commands
{
    class AtualizarTagCommand : IRequest<(string, bool)>
    {
        [Required(ErrorMessage = "Id de usuário é obrigatório")]
        public required Guid UsuarioId { get; set; }
        [Required(ErrorMessage = "Nome da tag é obrigatório")]
        public required string Nome { get; set; }
        [Required(ErrorMessage = "E necessário informar a cor")]
        public required string Cor { get; set; }
    }
    internal class AtualizarTagCommandHandler : IRequestHandler<AtualizarTagCommand, (string, bool)>
    {
        public Task<(string, bool)> Handle(AtualizarTagCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
