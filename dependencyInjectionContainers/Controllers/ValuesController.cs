using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dependencyInjectionContainers.Models;
using dependencyInjectionContainers.Services;
using Microsoft.AspNetCore.Mvc;

namespace dependencyInjectionContainers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ITopicAreaService _topicAreaService;
        public ValuesController(ITopicAreaService topicAreaService)
        {
            _topicAreaService = topicAreaService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<TopicArea> Get()
        {
            return _topicAreaService.GetAllTopicAreas();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
