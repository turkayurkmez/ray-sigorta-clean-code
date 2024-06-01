// See https://aka.ms/new-console-template for more information
using Functions;

Console.WriteLine("Hello, World!");
/*
 * 1. One job at a time: Birim zamanda bir iş yapmalı.
 * 2. Gövde kodu ne kadar az satırdan oluşuyorsa o kadar iyi.
 * 3. Parametreler ne kadar az o kadar iyi...
 */

bool isEven(int number) => number % 2 == 0;


string rastgeleKelimeSec(List<string> kelimeler)
{
    return "ayna";
}
string kelimeyiBulmacayaDonustur(string kelime)
{
    return "----";
}

void bulmacayiGoster(string bulmaca)
{
    Console.WriteLine(bulmaca);
}

string kullanicidanHarfAl()
{
    return "a";
}

bool kelimedeHarfVarMi(string kelime, string harf)
{
    return true;
}

string harfinYeriniGoster(string harf, string puzzle)
{
    return "a--a";
}

/*
 * 1. Kelime listesi içinden bir kelime seç.
 * 2. Bu kelimenin harf sayısı katar "-" işareti koy.
 * 3. Ekranda bulmacayı göster.
 * 4. Kullanıcıdan harf iste.
 * 5. Girilen harfin kelimede olup olmadığına bak.
 * 6. Varsa o pozisyondaki - işaretini harfle değiştir. Yoksa haktan bir düş.
 * 
 */

var kelime = rastgeleKelimeSec(new List<string>());
var bulmaca = kelimeyiBulmacayaDonustur(kelime);
bulmacayiGoster(bulmaca);
var harf = kullanicidanHarfAl();

if (kelimedeHarfVarMi(kelime,harf))
{
    bulmaca = harfinYeriniGoster(harf, bulmaca);
    bulmacayiGoster(bulmaca);
}
else
{

}



List<int[]> cellsOnABoard = new List<int[]>();

List<int[]> getFlaggedCells()
{
    var flaggedCells = new List<int[]>();
    foreach (var cell in cellsOnABoard)
    {
        if (cell[0] == CellState.Flagged)
        {
            flaggedCells.Add(cell);
        }
    }
    return flaggedCells;
}

try
{
    ReportGenerator reportGenerator = new ReportGenerator("");
    reportGenerator.SetReportDetails(null);
}
catch (ArgumentNullException ex )
{

    Console.WriteLine($"{ex.ParamName} parametresi boş olamaz: {ex.Message}");
}
catch(Exception genel)
{
    if (genel is ArgumentNullException)
    {

    }
    else if (genel is DivideByZeroException)
    {

    }
    Console.WriteLine(genel.Message);
}




public class CellState
{
    public const int Empty=0;
    public const int Flagged = 4;
    public const int Number = 2;
    public const int Explosed = 3;
}

