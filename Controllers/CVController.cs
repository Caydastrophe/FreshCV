using Microsoft.AspNetCore.Mvc;

namespace freshCV.Controllers;

[ApiController]
[Route("[controller]")]

public class CVController : ControllerBase
{

    [HttpGet]

    public List<string> getCVFactory(string CVType="Industry")
    {
        CVFactory factory = new CVFactory();
        ICVFresh cv = factory.getCV(CVType);

        List<string> returnedDetails = cv.getDetails();
        return(returnedDetails);

    }

}