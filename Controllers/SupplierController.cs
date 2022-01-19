using Microsoft.AspNetCore.Mvc;
namespace Supplier
{
    [Route("[controller]")]//controller represent prefix "Supplier"
public class SupplierController:ControllerBase
    {
        [HttpGet("Name")]
        public string GetSupplierName()
        {
            return "Madhuri";
        }
         [HttpGet("Address")]
        public string GetSupplierAddress()
        {
            return "Noida";
        }
    }


}


