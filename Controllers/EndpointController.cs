//Marcel Rodriguez
//10-25-22
//Adding 2 Numbers Endpoint
//This controller will ask the user for 2 inputs in the url and output the sum
//Peer review - Reed Goodwin - A decent program that follows the direction to a T! I would add some UI so the user has some idea of what is going on!
using Microsoft.AspNetCore.Mvc;

namespace RodriguezMAdd2NumbersEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class EndpointController : ControllerBase
{
    [HttpGet]
    [Route("Adding/{number1}/{number2}")]

    public string Math(string number1, string number2)
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2);
        
        int sum = convertNum1 + convertNum2;

        return $"The sum of {number1} and {number2} is {sum}!";
    }
}
