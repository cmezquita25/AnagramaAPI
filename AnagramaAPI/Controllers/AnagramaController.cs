using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//UNIVERSIDAD TECNOLOGICA METROPOLITANA
//JOEL IVAN CHUC UC
//APLICACIONES WEB ORIENTADAS A SERVICIOS
//CARLOS MANUEL MEZQUITA ALVARADO
// ANAGRAMA
// 4 ° B
//PARCIAL 1
// SEPTIEMBRE - DICIEMBRE 2021

namespace AnagramaAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class AnagramaController : ControllerBase
    {

        [HttpGet]
         public IActionResult anagramresult(string Palabra1, string Palabra2)
        {
            bool anagrama;
            var RoT = "";
            if (Palabra1.Length != Palabra2.Length)
            {
                anagrama = false;
            }
            else
            {

                //SE CREA UNA MATRIZ, SE ALMACENAN Y SE GUARDAN LAS LETRAS
                char[] letras1 = Palabra1.ToCharArray();
                Array.Sort(letras1);
                char[] letras2 = Palabra2.ToCharArray();
                Array.Sort(letras2);

                //CREAMOS VARIABLES
                string pal = new string(letras1);
                string pal2 = new string(letras2);

                if (pal == pal2)
                {
                    anagrama = true;
                }
                else
                {
                    anagrama = false;
                }
            }

            // SE REALIZA LA COMPARATIVA Y ENVIA 
            if (anagrama == true)
            {
                RoT = "Las palabras " + Palabra1 + " y " + Palabra2 + " SON Anagramas";
            }
            else
            {
                RoT = "Las palabras " + Palabra1 + " y " + Palabra2 + " NO son Anagramas";
            }
            return Ok(RoT);

        }
    }
}
