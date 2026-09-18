namespace Vonat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vonat TokajIC;
            TokajIC = new Vonat("személy", true,5,true,true);
            Console.WriteLine("TokajIC");
            Console.WriteLine(TokajIC.GyorsE()? "Gyors ez a vonat":"Nem gyors ez a vonat");
            Console.WriteLine(TokajIC.SzemelyIC_e() ? "Ez a vonat rendelkezik első osztályal" : "Nem rendelkezik első osztályal");
            Console.WriteLine(TokajIC.Szallitmany() ? "Ez a vonat teherkocsikal rendelkezik" : "Ez a vonat személykocsikal rendelkezik");
            Console.WriteLine(TokajIC.hosszuvonate() ? "Ez a vonat hosszúszerelvényel rendelkezik" : "Ez a vonat nem hosszú");
            Console.WriteLine("-------------------------------------------------------");
            Vonat AgriaIR;
            AgriaIR = new Vonat("személy", false, 6,false,true);
            Console.WriteLine("AgriaIR");
            Console.WriteLine(AgriaIR.GyorsE() ? "Gyors ez a vonat" : "Nem gyors ez a vonat");
            Console.WriteLine(AgriaIR.SzemelyIC_e() ? "Ez a vonat rendelkezik első osztályal" : "Nem rendelkezik első osztályal");
            Console.WriteLine(AgriaIR.Szallitmany() ? "Ez a vonat teherkocsikal rendelkezik" : "Ez a vonat személykocsikal rendelkezik");
            Console.WriteLine(AgriaIR.hosszuvonate() ? "Ez a vonat hosszúszerelvényel rendelkezik" : "Ez a vonat nem hosszú");
            Console.WriteLine("-------------------------------------------------------");
            Vonat Teher;
            Teher = new Vonat("Teher", false, 18,false,false);
            Console.WriteLine("Tehervonat");
            Console.WriteLine(Teher.GyorsE() ? "Gyors ez a vonat" : "Nem gyors ez a vonat");
            Console.WriteLine(Teher.SzemelyIC_e() ? "Ez a vonat rendelkezik első osztályal" : "Nem rendelkezik első osztályal");
            Console.WriteLine(Teher.Szallitmany() ? "Ez a vonat teherkocsikal rendelkezik" : "Ez a vonat személykocsikal rendelkezik");
            Console.WriteLine(Teher.hosszuvonate()? "Ez a vonat hosszúszerelvényel rendelkezik":"Ez a vonat nem hosszú");
            Console.WriteLine("-------------------------------------------------------");
            Vasutallomas Miskolc;
            Miskolc = new Vasutallomas(true,5,4,3);
            Console.WriteLine("Miskolc");
            Console.WriteLine(Miskolc.KesovonatokazallomasonvannakE()?"Vannak Késő vonatok az állomáson":"Nincsenek késő vonatok az állomáson");
            Console.WriteLine(Miskolc.tobbErkezoMintIndulo()?"Több érkező vonat van mint induló":"Több induló vonat van mint érkező");
            Console.WriteLine(Miskolc.tobbAzAtlagaErkezoInduloMintAllomasonlevoErkezoAtlaga()?"Több az átlaga az érkező és induló vonatoknak mint a érkező és állomáson tartozkódóknak": "Nem több az átlaga az érkező és induló vonatoknak mint a érkező és állomáson tartozkódóknak");
            Console.WriteLine("-------------------------------------------------------");
            Vasutallomas Szerencs;
            Szerencs = new Vasutallomas(false, 2, 4, 3);
            Console.WriteLine("Szerencs");
            Console.WriteLine(Szerencs.KesovonatokazallomasonvannakE() ? "Vannak Késő vonatok az állomáson" : "Nincsenek késő vonatok az állomáson");
            Console.WriteLine(Szerencs.tobbErkezoMintIndulo() ? "Több érkező vonat van mint induló" : "Több induló vonat van mint érkező");
            Console.WriteLine(Szerencs.tobbAzAtlagaErkezoInduloMintAllomasonlevoErkezoAtlaga() ? "Több az átlaga az érkező és induló vonatoknak mint a érkező és állomáson tartozkódóknak" : "Nem több az átlaga az érkező és induló vonatoknak mint a érkező és állomáson tartozkódóknak");
        }
    }
}
