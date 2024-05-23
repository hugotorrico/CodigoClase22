
//Refactoring: Optimiza tu código.

//1. Más eficiente el código   
//2. Más entendible el código 


using CodigoClase22;
using System.Transactions;

// 1. Extracción de Método
void PrintPersonDetails(Person person)
{
    Console.WriteLine("Name: " + person.Name);
    Console.WriteLine("Age: " + person.Age);
    Console.WriteLine("Address: " + person.Address);
    Console.WriteLine("City: " + person.City);   
}

void PrintJobDetails(Person person)
{
    Console.WriteLine("Salary: " + person.Salary);
    Console.WriteLine("Company: " + person.Company);
}

// 2. Renombrar Variables
//Ctrl + R + R =>Cambiara Nombre
void CalculateTotalPrice(double price , int quantity)
{    
    double total = price * quantity;
    Console.WriteLine("Total Price: " + total);
}

// 3. Reemplazar un Número Mágico con una Constante
const double Pi = 3.14159;
const double IGV = 0.18;
double CalculateCircleArea(double radius)
{
    double area= Pi * radius * radius;
    return area;
}
double CalculateIGV(double price)
{
    double result= price * IGV;
    return result;
}
//4.Introducir una Variable Explícita
const double percentDiscounted = 0.1;
 double GetDiscountedPrice(double price)
{       
    double discounted = price * percentDiscounted;
    double priceDiscounted = price - discounted;
    return priceDiscounted;
}
// 5. Convertir una Sentencia If en un Switch
string GetDayName(int dayNumber)
{
    switch (dayNumber)
    {
        case 1:
            return "Monday";
        case 2:
            return "Tuesday";
        case 3:
            return "Wednesday";
        case 4:
            return "Thursday";
        case 5:
            return "Friday";
        case 6:
            return "Saturday";
        case 7:
            return "Sunday";
        default:
            return "Invalid day";
    }
}
// 6. Simplificar una Expresión Condicional
string GetStatus(bool isActive)
{    
    string status = isActive ? "Active" : "Inactive";
    return status;
}

string GetStatus2(bool isActive)
{
    return isActive ? "Active" : "Inactive";
}


Person person = new Person
{
    Address = "Santa Anita",
    Age = 36,
    City = "Lima",
    Company = "Tecsup",
    Name = "Hugo",
    Salary = 5000
};

//Imprimir mis datos personales
PrintPersonDetails(person);

//Imprimir datos del trabajo
PrintJobDetails(person);


Console.WriteLine("Hello, World!");
