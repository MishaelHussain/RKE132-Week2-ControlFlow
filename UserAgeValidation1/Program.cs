//rakendus küsib kasutaja l sisestada tema vanuse 
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse: 
//"You are too young to use Instagram" 
//konsoolis kuvatakse "Welcome to Instagram" 


Console.WriteLine("Enter your age");

//int userAge = Int32.Parse (Console.ReadLine()); // "13"-heap, - stack 

string userAge = Console.ReadLine();
int userAgeNum = 0;
bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum); 

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old."); 

if(isAgeNumber)
{
    if(userAgeNum > 13)
    {
        Console.WriteLine("Welcome to Instagram.");
    }

   else
    {
        Console.WriteLine("You are too young to use Instagram.");
    }
}
