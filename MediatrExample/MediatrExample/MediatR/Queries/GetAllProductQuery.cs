using MediatR;
using MediatrExample.Models;

namespace MediatrExample.MediatR.Queries
{
    public class GetAllProductQuery : IRequest<List<GetProductModel>>
    {
        //GetAllProductQuery modelin parametre almadığı için handler ı farklı bir class yapmak yerine bu class ın içine yazdık.

        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductModel>>
        {
            public async Task<List<GetProductModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var model2 = new GetProductModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Bilgisayar"

                };
                var model = new GetProductModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Klavye"
                };

                return await Task.FromResult(new List<GetProductModel>() { model, model2});
            }
        }
    }
}
