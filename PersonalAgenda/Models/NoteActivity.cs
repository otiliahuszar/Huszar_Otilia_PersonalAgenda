using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalAgenda.Models
{
    public class NoteActivity
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(Agenda))]
        public int AgendaID { get; set; }

        public int ActivityID { get; set; }
    }
}
