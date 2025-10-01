using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
internal class DateController : ControllerBase
{
    [HttpPost("calcular")]
    public IActionResult Calcular([FromBody] FechaRequest request)
    {

    }
}
