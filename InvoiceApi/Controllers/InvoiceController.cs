using Microsoft.AspNetCore.Mvc;

namespace InvoiceApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly ILogger<InvoiceController> _logger;
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(ILogger<InvoiceController> logger, IInvoiceService invoiceService)
        {
            _logger = logger;
            _invoiceService = invoiceService;
        }

        [HttpGet("CreateInvoice")]
        public ActionResult<Invoice> CreateInvoice()
        {
            return _invoiceService.CreateInvoice();
        }
    }
}