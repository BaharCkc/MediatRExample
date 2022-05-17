using MediatR;
using MediatrExample.Models;

namespace MediatrExample.MediatR.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductModel>
    {
        public async Task<GetProductModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var viewModel = new GetProductModel()
            {
                //Id = request.Id, 
                Id = Guid.NewGuid(),
                Name = "Bilgisayar"

            };

            return await Task.FromResult(viewModel);
        }
    }
}
