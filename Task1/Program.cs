
Console.Clear();

void PalindFind(string stroka)
{
    if(stroka[0] == stroka[4] & stroka[1] == stroka[3])
    {
        Console.WriteLine($"Число {stroka} является полиндромом!");
    }
        else{Console.WriteLine($"Число {stroka} не является полиндромом!");}
 }
    
string EnterData(string ver)
{
    
    Console.Write("Введите число: ");
    ver = Console.ReadLine();
    return ver;
   
}  
string palind = string.Empty;
palind = EnterData(palind);
PalindFind(palind);



