using SQLite;



namespace LekomanApp.Models
{
    public class LekomanItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Lek { get; set; }

        public string Dawka { get; set; }

        public string Data { get; set; }

        public string Godzina { get; set; }

        public bool Zrobione { get; set; }
    }
}
