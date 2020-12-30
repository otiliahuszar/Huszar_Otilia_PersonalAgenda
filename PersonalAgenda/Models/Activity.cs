﻿using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalAgenda.Models
{
    public class Activity
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Description { get; set; }

        [OneToMany]
        public List<NoteActivity> NoteActivities { get; set; }
    }
}
