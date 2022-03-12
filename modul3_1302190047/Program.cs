// See https://aka.ms/new-console-template for more information

class KodeBuah
{
    public enum NamaBuah
    {
        Apel, 
        Alprikot, 
        Alpukat, 
        Pisang, 
        Paprika, 
        Blackberry,
        Ceri, 
        Kelapa, 
        Jagung, 
        Kurma, 
        Durian, 
        Anggur, 
        Melon, 
        Semangka
    };

    public static string getKodeBuah(NamaBuah InputBuah)
    {
        string[] arrayKodeBuah = { "A00", 
                                    "B00", 
                                    "C00", 
                                    "D00", 
                                    "E00",
                                    "F00", 
                                    "H00", 
                                    "I00",
                                    "J00", 
                                    "K00",
                                    "L00", 
                                    "M00", 
                                    "N00",
                                    "O00"};
        int indexJawaban = (int)InputBuah;
        return arrayKodeBuah[indexJawaban];
    }
}
