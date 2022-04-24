using Microsoft.AspNetCore.Mvc;

namespace ShipmentApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShipmentController : ControllerBase
    {
        private readonly ILogger<ShipmentController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public ShipmentController(ILogger<ShipmentController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet("CreateShipment")]
        public async Task<Shipment> CreateShipment()
        {
            var invoiceApiClient = _httpClientFactory.CreateClient("InvoiceApi");
            var createInvResp = await invoiceApiClient.GetAsync("invoice/CreateInvoice");
            var invoice = await createInvResp.Content.ReadAsStringAsync();
            return new Shipment() { Id = 1, Invoice = invoice };
        }
    }
}