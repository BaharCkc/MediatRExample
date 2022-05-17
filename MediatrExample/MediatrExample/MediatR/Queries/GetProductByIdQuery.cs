using MediatR;
using MediatrExample.Models;

namespace MediatrExample.MediatR.Queries
{
    public class GetProductByIdQuery : IRequest<GetProductModel>
    {
        public Guid Id { get; set; }
    }
}
