DateTime dt = DateTime.Now;

Console.WriteLine(dt);

object o1 = "x";
object o2 = 'y';
object o3 = 4;


//string

string str1 = string.Empty;
str1 = "Zikriye Ürkmez";
string ad = "Zikriye";

string soyad = "Ürkmez";

string tamIsim = ad + " " + soyad;

//integer

int integer1 = 5;
int integer2 = 3;
int integer3 = integer2 + integer1;


//bool

bool b1 = 10 < 2;
bool b2 = 2 > 10;

Console.WriteLine(b2);

//String Dönüşüm

string str20 = "20";

int int20 = 20;

string yeniDeger = str20 + int20.ToString();

Console.WriteLine(yeniDeger);

int int22 = int20 + int.Parse(str20);

Console.WriteLine(int22);

//DateTime

string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

