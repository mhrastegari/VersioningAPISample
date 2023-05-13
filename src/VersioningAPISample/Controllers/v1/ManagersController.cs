namespace VersioningAPISample.Controllers.v1;

[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
[ApiVersion("1.0", Deprecated = true)]
public class ManagersController : ControllerBase
{
    // GET: api/Managers
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "Manager 1", "Manager 2" };
    }

    // GET api/Managers/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return $"Manager {id}";
    }

    // POST api/Managers
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/Managers/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/Managers/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
