using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace banco.Pages;


public class IndexModel : PageModel

    {

        public void OnGet()

        {

        }

 

        public void OnPost(DateTime fecha, string monto)

        {

            double total,moras;
            
            double resultado = 0;
           
            DateTime fechaActual = DateTime.Now;

            TimeSpan diferencia = fechaActual - fecha;
            
            int diasTranscurridos = diferencia.Days;                  

            double mont = double.Parse(monto);

            moras = diasTranscurridos * (mont*0.005);
            
            resultado = mont + moras;

           

            ViewData["resultado"] = resultado;

        }

    }


