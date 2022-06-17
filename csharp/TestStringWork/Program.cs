using static System.Console;
using  System.Text;
var s0 = "Tidiane";
s0 = "Diallo";
WriteLine(s0);
WriteLine("===============================");
var s1  = "Tidiane";
var s2  = "Tidiane";
WriteLine(s1 == s2);
WriteLine(Object.ReferenceEquals(s1, s2));
WriteLine("Initialisation de la variable à l'aide de new String ()");

var s3 = "Tidiane";
char[] charArray1 = { 'T','i','d','i','a','n','e'};
var s4 = new String(charArray1);
char[] charArray2 = { 'T','i','d','i','a','n','e'};
var s5 = new String(charArray2);
WriteLine(s3 == s4);
WriteLine(Object.ReferenceEquals(s4, s5));
WriteLine(s3 == s4 && s4 == s5);
WriteLine(Object.ReferenceEquals(s3, s4));
WriteLine(Object.ReferenceEquals(s4, s5));
WriteLine("===============================");
WriteLine("Variable de réglage implicite par référence");

var s6 = "Tidiane";
var s7 = s6;
s6 = "Diallo";
WriteLine(s6);
WriteLine(s7);
WriteLine(s6 == s7);
WriteLine(Object.ReferenceEquals(s6, s7));
WriteLine("===============================");
WriteLine("Variable de réglage explicite par référence");
var s8 = "Tidiane";
var s9 = s8;
UpdateStr(ref s8);
WriteLine(s8);
WriteLine(s9);
static void UpdateStr(ref string str)
{
    str += "_";
}
WriteLine("===============================");
WriteLine("Optimisation de la mémoire ");
var s10 = "";

for (var i = 1; i <= 5000; i++)
{
    s10 += i;
}
WriteLine(s10);
WriteLine("Pour optimiser ce qui précede on doit utiliser StringBuilder");
var builder = new StringBuilder();

for (var i = 1; i <= 5000; i++)
{
    builder.Append(i);
}
WriteLine(builder.ToString());
WriteLine("les deux codes produisent le même résultat mamais avec une allocation de mémoire optimisée.");