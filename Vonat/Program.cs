namespace Vonat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzemelyVonat TokajIC;
            TokajIC = new SzemelyVonat(5,true,true);
            Console.WriteLine("TokajIC");
            Console.WriteLine(TokajIC.GyorsE()? "Gyors ez a vonat":"Nem gyors ez a vonat");
            Console.WriteLine(TokajIC.SzemelyIC_e() ? "Ez a vonat rendelkezik első osztályal" : "Nem rendelkezik első osztályal");
            Console.WriteLine(TokajIC.hosszuvonate() ? "Ez a vonat hosszúszerelvényel rendelkezik" : "Ez a vonat nem hosszú");
            Console.WriteLine("-------------------------------------------------------");
            SzemelyVonat AgriaIR;
            AgriaIR = new SzemelyVonat(6,false,false);
            Console.WriteLine("AgriaIR");
            Console.WriteLine(AgriaIR.GyorsE() ? "Gyors ez a vonat" : "Nem gyors ez a vonat");
            Console.WriteLine(AgriaIR.SzemelyIC_e() ? "Ez a vonat rendelkezik első osztályal" : "Nem rendelkezik első osztályal");
            Console.WriteLine(AgriaIR.hosszuvonate() ? "Ez a vonat hosszúszerelvényel rendelkezik" : "Ez a vonat nem hosszú");
            Console.WriteLine("-------------------------------------------------------");
            Tehervonat Teher;
            Teher = new Tehervonat(true,"Tégla");
            Console.WriteLine("Tehervonat");
            Console.WriteLine(Teher.Szallitmany() ? "Ez a vonat teherkocsikal rendelkezik" : "Ez a vonat személykocsikal rendelkezik");
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
