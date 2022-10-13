namespace Voting{
    public static class Kategoriler{
        public static List<string> kategoriler = new List<string>(){"Teknoloji","Spor","Araba"};

        public static Dictionary<string,int> teknoloji = new Dictionary<string,int>(){{"Bilgisayar",0},{"Telefon",0},{"Televizyon",0},{"Playstation",0},{"Tablet",0}};
        public static Dictionary<string,int> spor = new Dictionary<string,int>()
        {{"Futbol",0},{"Basketbol",0},{"Voleybol",0},{"Tenis",0},{"Hokey",0},{"Ralli",0},{"Kayak",0},{"Jimnastik",0}};
        public static Dictionary<string,int> araba = new Dictionary<string,int>()
        {{"Ford",0},{"Citroen",0},{"Skoda",0},{"Toyota",0},{"Honda",0},{"Ferrai",0},{"Mercedes",0},{"Wolksvagen",0},{"Peugeot",0}};

    }
}