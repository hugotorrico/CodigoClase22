
//Obtener los números pares 
using LINQ;
using System.ComponentModel.DataAnnotations;

void MostrarNumerosPares()
{
    var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    var numerosPares = new List<int>();
    foreach (var item in numeros)
    {
        if (item % 2 == 0)
        {
            numerosPares.Add(item);
        }
    }

    foreach (var item in numerosPares)
    {
        Console.WriteLine(item);
    }
}

void MostrarNumerosParesLINQ()
{
    var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    
    //LINQ
    var numerosPares= (from c in numeros 
                       where c%2==0 
                       select c).ToList(); 


    foreach (var item in numerosPares)
    {
        Console.WriteLine(item);
    }
}

void MostrarNumerosParesLambda() //=>Anónimas
{
    var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
   
    var numerosPares = numeros.Where(x=>x % 2 == 0 ).ToList();

    var query = numeros.Where(x => x % 2 == 0);

    foreach (var item in numerosPares)
    {
        Console.WriteLine(item);
    }
}


void IEnumerableVsList() //=>Anónimas
{
    //Pares Mayores a 5

    var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };//10 elementos (new)
    
    //Primer escenario
    var numerosPares = numeros.Where(x => x % 2 == 0).ToList();// 5  elementos (new)    
    var numerosParesMayores5 = numerosPares.Where(x=>x>5).ToList();// 3 elementos (new)


    //Segundo escenario
    var queryPares = numeros.Where(x => x % 2 == 0);
    var queryParesMayores5 = queryPares.Where(x => x > 5);

    var _numerosParesMayores5 = queryParesMayores5.ToList();//3 elemmentos  (new)

    //Tercer escenario
    var __numerosParesMayores5 = numeros.Where(x => x %2==0 &&  x>5).ToList();

}

void BuscarPersona(List<Persona> personas, string nombre, string apellido, string ciudad)
{

    var query = personas.Select(x=>x);

    if (!string.IsNullOrEmpty(nombre))
        query = query.Where(x => x.Nombres.Contains(nombre));

    if (!string.IsNullOrEmpty(apellido))
        query= query.Where(x=>x.Apellidos.Contains(apellido));

    if (!string.IsNullOrEmpty(ciudad))
        query = query.Where(x => x.Ciudad.Contains(ciudad));


    //foreach (var item in query.ToList())
    //{
    //    Console.WriteLine(item.Nombres);
    //}
    Console.WriteLine("Búsqueda Terminada");


    //Alternativa B (Ineficiente)
    //if (!string.IsNullOrEmpty(nombre))
    //{
    //    var personasPorNombre = personas.Where(x => x.Nombres.Contains(nombre)).ToList();

    //    if (!string.IsNullOrEmpty(apellido))
    //    {
    //        var personasPorApellido = personasPorNombre.Where(x=>x.Apellidos.Contains(apellido)).ToList();

    //        if (!string.IsNullOrEmpty(ciudad))
    //        {
    //            var personasPorCiudad = personasPorApellido.Where(x => x.Ciudad.Contains(ciudad)).ToList();

    //        }

    //    }
    //}



    //Alternativa C (Confusa)
    //var encontrados = personas.Where(x => x.Nombres.Contains(nombre)
    //                                 && x.Apellidos.Contains(apellido)
    //                                 && x.Ciudad.Contains(ciudad)
    //                                ).ToList();




}

//BuscarPersona(PersonaData.GetPersonas(), "1", "", "");//Solo por nombres
//BuscarPersona(PersonaData.GetPersonas(), "", "2", "");// Solo por apellidos
//BuscarPersona(PersonaData.GetPersonas(), "", "", "3");// Solo por ciudad
//BuscarPersona(PersonaData.GetPersonas(), "1", "1", "1");//Por los 3
BuscarPersona(PersonaData.GetPersonas(), "1", "2", "");// por nombres y apellido






//MostrarNumerosParesLINQ();
//MostrarNumerosParesLambda();

Console.Read();


