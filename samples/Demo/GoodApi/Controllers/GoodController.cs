using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GoodApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GoodController : ControllerBase
    {
        private readonly ILogger<GoodController> _logger;

        public GoodController(ILogger<GoodController> logger)
        {
            _logger = logger;
        }

        // GET: api/good
        [HttpGet]
        public IEnumerable<Good> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Good
            {
                ID = index,
                GoodName = "Good" + index,
                Price = 100 * index
            })
            .ToArray();
        }
    }
}
