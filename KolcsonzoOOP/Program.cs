
using KolcsonzoOOP;

List<IKolcsonozheto> katalogus = new List<IKolcsonozheto>();

Konyv k1 = new Konyv("Golyók","Tóth Marcell", "420-6-9");
Dvd d1 = new Dvd("Evil Bong", 90);
Ujsag u1 = new Ujsag("Népszava", 2009,16);

katalogus.Add(d1);
katalogus.Add(k1);
katalogus.Add(u1);


foreach (var k in katalogus)
{
	Console.WriteLine(k.MegjelenitendoNev()+ " ~ " + k.MeddigKolcsonozheto() + "nap.");
}






Console.ReadKey();