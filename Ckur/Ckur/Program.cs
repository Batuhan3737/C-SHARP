using System;
using System.Diagnostics;
using System.Xml;

namespace Ckur
{
    class Program
    {
        static void Main(string[] args)
        {

            int tl ;
            string  doviz = "";

            string bugunku_kur = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugunku_kur);
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

            Console.WriteLine("         TCBM KUR");
            Console.WriteLine(" ");

            Console.WriteLine("TARİH: "+ tarih);
            Console.WriteLine(" ");

            string USD = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling ").InnerXml;
            Console.WriteLine(string.Format(" ABD DOLARI: {1}" , tarih.ToShortDateString() , USD + "  Döviz Kodu = USD"));

            string EURO = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling ").InnerXml;
            Console.WriteLine(string.Format(" EURO: {1}", tarih.ToShortDateString(), EURO + "  Döviz Kodu = EURO"));

            string STERLİN = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteSelling ").InnerXml;
            Console.WriteLine(string.Format(" STERLİN: {1}", tarih.ToShortDateString(), STERLİN + "  Döviz Kodu = STERLİN"));

            string AVUSTRALYAD = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='AUD']/BanknoteSelling ").InnerXml;
            Console.WriteLine(string.Format(" AVUSTRALYA DOLARI: {1}", tarih.ToShortDateString(), AVUSTRALYAD + "  Döviz Kodu = AVUSTRALYAD"));

            string DANİMARKAK = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='DKK']/BanknoteSelling ").InnerXml;
            Console.WriteLine(string.Format(" DANİMARKA KRONU: {1}", tarih.ToShortDateString(), DANİMARKAK + "  Döviz Kodu = DANİMARKAK"));

            string İSVİCREF = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/BanknoteSelling ").InnerXml;
            Console.WriteLine(string.Format(" İSVİÇRE FRANGI: {1}", tarih.ToShortDateString(), İSVİCREF + "  Döviz Kodu = İSVİCREF"));

            string İSVECK = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SEK']/BanknoteSelling ").InnerXml;
            Console.WriteLine(string.Format(" İSVEÇ KRONU: {1}", tarih.ToShortDateString(), İSVECK + "  Döviz Kodu = İSVECK"));

            string KANADAD = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/BanknoteSelling ").InnerXml;
            Console.WriteLine(string.Format(" KANADA DOLARI: {1}", tarih.ToShortDateString(), KANADAD + "  Döviz Kodu = KANADAD"));

            string ARAPR = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/BanknoteSelling ").InnerXml;
            Console.WriteLine(string.Format(" SUUDİ ARABİSTAN RİYALİ: {1}", tarih.ToShortDateString(), ARAPR + "  Döviz Kodu = ARAPR"));

            Console.WriteLine("         ");

            while (true)
            {

            Console.Write("TL Değrini Giriniz: ");
            tl = Convert.ToInt32(Console.ReadLine());

            Console.Write("Döviz Giriniz: ");
            doviz = Console.ReadLine();

            if (doviz == "USD")
            {
                Console.WriteLine( tl + " Türk Lirası " + (tl * Convert.ToDouble(USD) + " ABD Doları."));
            }
            else if (doviz == "EURO")
            {
                Console.WriteLine(tl + " Türk Lirası " + (tl * Convert.ToDouble(EURO) + " EURO."));

            }
            else if (doviz == "STERLİN")
            {
                Console.WriteLine(tl + " Türk Lirası " + (tl * Convert.ToDouble(STERLİN) + " PAUND."));

            }
            else if (doviz == "AVUSTRALYAD")
            {
                Console.WriteLine(tl + " Türk Lirası " + (tl * Convert.ToDouble(AVUSTRALYAD) + " Avustralya Doları."));

            }
            else if (doviz == "DANİMARKAK")
            {
                Console.WriteLine(tl + " Türk Lirası " + (tl * Convert.ToDouble(DANİMARKAK) + " Danimarka Kronu."));

            }
            else if (doviz == "İSVİCREF")
            {
                Console.WriteLine(tl + " Türk Lirası " + (tl * Convert.ToDouble(İSVİCREF) + " İsvicre Frangı."));

            }
            else if (doviz == "İSVECK")
            {
                Console.WriteLine(tl + " Türk Lirası " + (tl * Convert.ToDouble(İSVECK) + " İsvec Kronu."));

            }
            else if (doviz == "KANADAD")
            {
                Console.WriteLine(tl + " Türk Lirası " + (tl * Convert.ToDouble(KANADAD) + " Arap Riyali."));

            }
            else if (doviz == "ARAPR")
            {
                Console.WriteLine(tl + " Türk Lirası " + (tl * Convert.ToDouble(ARAPR) + " ABD Doları."));

            }
                Console.WriteLine("  ");
                Console.WriteLine("  ");
            }



            Console.ReadKey();
        }
    }
}
