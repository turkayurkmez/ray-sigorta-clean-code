// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");
int x = 1;
int d = 255; //Bir müşterinin kayıt olduğu günden bu yana geçen gün sayısı.
int daysSinceUserCreated = 400;
int musterininKayitliGunSayisi = 155;

//1. Anlamlı isimler kullanın.
bool banuAlkan = false;
//2. Mümkün olduğunca (karıştırılma ihtimalinden dolayı) kısaltmadan kaçının.
var hp = 0;
/*
 * hp yazıcı sayısı
 * healthPower
 * horsePower
 * HitPoint
 * hesapPlanı
 * 
 */
//3. Eğer mecbur kalırsanız bari, okunması (telafuzu) kolay olsun
DateTime btouaddMMyyyy;

int yas = 44;
var adres = "Eskişehir";

bool isApproved = true;
bool hasElement = false;

bool condition = isApproved && hasElement;
condition = condition || yas < 20;

if (condition)
{

}

//4. Kompleks tiplerde; instance adında tipin ismine gönderme yapın:
Random randomNumberGenerator = new Random();
DataTable urunlerDataTable = new DataTable();


//Böyle şeyler yapmayın :(
var o = 0;
var l = 1;

if (o==1)
{
    o = l;
    l = 0;
}

var passWordSample = "123A!456";

var charArray = passWordSample.ToCharArray();
bool isDigit = false;
bool isLetter = false;
bool isSymbol = false;

foreach (char charOfString in charArray)
{

    if (char.IsLetter(charOfString))
    {
     
        isLetter = true;
        continue;
    }
    else if(char.IsDigit(charOfString))
    {
        isDigit = true;
        continue;
    }
    else
    {
        isSymbol = true;
        continue;
    }

   
}
bool isStrongPassword = isSymbol && isLetter && isDigit;
if (isStrongPassword)
{
    Console.WriteLine("Harbi güçlü şifre");
}
else
{
    Console.WriteLine("Şifre, meh :(");
}