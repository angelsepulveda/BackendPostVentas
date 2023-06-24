using BackendPostVentas.WareHouse.Application.Brands.Create;

namespace BackendPostVentas.WebAPI.Controllers.WareHouse
{
   
    [Route("/api/brands")]
    public class BrandController : ApiController
    {
        private readonly ISender _mediator;

        public BrandController(ISender mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        public async ValueTask<IActionResult> Create([FromBody] CreateBrandCommand command)
        {
            var createBrandResult = await _mediator.Send(command);

            return createBrandResult.Match(
                brand => Ok(),
                errors => Problem(errors)
            );
        }
        
    }
}
