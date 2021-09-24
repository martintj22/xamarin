using SQLite;

namespace LocalDatabase
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; } // ID PÅ LEJER
        public string Name { get; set; } // NAVN 
        public int Room { get; set; } // Værelse nr
        public string OrderFood { get; set; } // NAVN 

    }
}
