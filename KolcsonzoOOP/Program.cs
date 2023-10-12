
using KolcsonzoOOP;

List<IKolcsonozheto> katalogus = new List<IKolcsonozheto>();
List<Dvd> dvds = new List<Dvd>();

Konyv k1 = new Konyv("Golyók","Tóth Marcell", "420-6-9");
Dvd d1 = new Dvd("Evil Bong", 90);
Ujsag u1 = new Ujsag("Népszava", 2009,16);

katalogus.Add(d1);
katalogus.Add(k1);
katalogus.Add(u1);

Dvd d2 = new Dvd("Evil Bong 2 The King Bong", 108);
Dvd d3 = new Dvd("Evil Bong The Wrath of the BOng", 96);
Dvd d4 = new Dvd("Evil Bong 420", 120);
Dvd d5 = new Dvd("Evil Bong High Five", 90);

dvds.Add(d1);
dvds.Add(d2);
dvds.Add(d3);
dvds.Add(d4);
dvds.Add(d5);

dvds.Sort();

foreach (var k in katalogus)
{
	Console.WriteLine(k.MegjelenitendoNev()+ " ~ " + k.MeddigKolcsonozheto() + "nap.");
}






Console.ReadKey();