using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PL_Web_Application.Controllers
{
    //This is an attribute that sets the base URL for the controller.
    //It means that any action method inside this CalculadoraController will be accessed through a URL that starts with /Calculadora
    //For example: Calculadora/api/Suma
    [Route("Calculadora")] 
    public class CalculadoraController : ApiController
    {
        //This is an HTTP verb attribute. It specifies that the Suma method can only be invoked using an HTTP POST request
        [HttpPost]

        //This is another route attribute, but this one is applied at the method level.
        //It defines a specific sub-route for this particular action.
        //When combined with the controller's base route, the full URL to access this method becomes /Calculadora/api/Suma.
        [Route("api/Suma")]
        public IHttpActionResult Suma(int Numero1, int Numero2)
        {
            return Ok ("La suma es: " + (Numero1 + Numero2));
        }

        [HttpPost]
        [Route("api/Resta")]
        public IHttpActionResult Resta(int Numero1, int Numero2)
        {
            return Ok("La resta es: " + (Numero1 - Numero2));
        }

        [HttpPost]
        [Route("api/Multiplicacion")]
        public IHttpActionResult Multiplicacion(int Numero1, int Numero2)
        {
            return Ok("La multiplicación es: " + (Numero1 * Numero2));
        }

        [HttpGet]
        [Route("api/Division")]
        public IHttpActionResult Division(int Numero1, int Numero2)
        {
            return Ok("La división es: " + (Numero1 / Numero2));
        }

        [HttpPost]
        [Route("api/SumaBody")]
        public IHttpActionResult SumaBody([FromBody] ML.Numeros numeros)
        {
            if (numeros == null)
            {
                return BadRequest("El cuerpo de la solicitud no es válido.");
            }
            return Ok(numeros.Numero1 + numeros.Numero2);
        }

        [HttpPost]
        [Route("api/RestaBody")]
        public IHttpActionResult RestaBody([FromBody] ML.Numeros numeros)
        {
            if (numeros == null)
            {
                return BadRequest("El cuerpo de la solicitud no es válido.");
            }
            return Ok(numeros.Numero1 - numeros.Numero2);
        }

        [HttpPost]
        [Route("api/MultiplicacionBody")]
        public IHttpActionResult MultiplicacionBody([FromBody] ML.Numeros numeros)
        {
            if (numeros == null)
            {
                return BadRequest("El cuerpo de la solicitud no es válido.");
            }
            return Ok(numeros.Numero1 * numeros.Numero2);
        }

        [HttpPost]
        [Route("api/DivisionBody")]
        public IHttpActionResult DivisionBody([FromBody] ML.Numeros numeros)
        {
            if (numeros == null)
            {
                return BadRequest("El cuerpo de la solicitud no es válido.");
            }
            return Ok(numeros.Numero1 / numeros.Numero2);
        }
    }
}
