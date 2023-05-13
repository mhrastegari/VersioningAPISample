namespace VersioningAPISample.Controllers.v2;

[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
[ApiVersion("2.0")]
public class AdminsController : ControllerBase
{
    // GET: api/Admins
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "Version 2 Admin 1", "Version 2 Admin 2" };
    }

    // GET api/Admins/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return $"Version 2 Admin {id}";
    }

    // POST api/Admins
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/Admins/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/Admins/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
