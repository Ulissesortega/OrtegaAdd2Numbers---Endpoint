//Name: Ulises Ortega
//Date: 10.25.22
//Project: Adding 2 Numbers - EndPoit
//Description: This EndPoint adds 2 numbers and then output in screen the to total of the two numbers.
//Peer Review: Manuel L. The code looks and works great, I went to postman to make sure everything is runinning right, and it
//outputed the right functions, great job on the whole assignment :)


//Description: in the example bellow your local host will change, all you need to do is enter your name where it say Your 1st Number and you Second number goes here
//Example:  https://localhost:7280/adding/numbers/Your 1st number/Your 2nd Number Name Goes Here

using Microsoft.AspNetCore.Mvc;
namespace OrtegaAdd2Numbers___Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AddingController : ControllerBase
{
    [HttpGet]
    [Route("numbers/{number1}/{number2}")]
    public int Math(string number1, string number2)
    {
        int result;
        
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2);

        result = convertNum1 + convertNum2; 
        
        return convertNum1 + convertNum2;
    
    }
}