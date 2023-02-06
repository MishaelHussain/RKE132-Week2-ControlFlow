// See https://aka.ms/new-console-template for more information
//Uued andmet tüübid: int ja char 
//if-statements (control flow) 
//rakendus küsib kasutajal valida tema sugu (m/f) 
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt: 
//"Welcome, Mr. [kasutaja perekonnanimi / "welcome, Ms. [kasutaja perekonnanimi)"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine());

Console.WriteLine("Please, enter your last name"); 

string userLastame = Console.ReadLine(); 


if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");

} 
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.!")
}

Console.WriteLine($"Welcome, {userGender}");  
else
{
    Console.WriteLine("Welcome!"); 
}