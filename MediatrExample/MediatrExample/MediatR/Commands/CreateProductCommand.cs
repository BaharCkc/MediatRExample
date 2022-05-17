using MediatR;

namespace MediatrExample.MediatR.Commands
{
    public class CreateProductCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }


        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
        {
            public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                // repository aracılığı ile veri veritabanına gönderilir.

                return await Task.FromResult(Guid.NewGuid());

                throw new NotImplementedException();
            }
        }
    }
}
