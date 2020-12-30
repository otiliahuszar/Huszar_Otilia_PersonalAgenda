using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalAgenda.Models
{
    public class Agenda
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Text { get; set; }

        public DateTime Date { get; set; }
    }
}
