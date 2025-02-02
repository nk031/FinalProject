﻿using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace FinalProject.Tables
{
    public class Allergy
    {
        [PrimaryKey, NotNull]//primary key 
        public string Type
        {
            get;
            set;
        }

        [ManyToMany(typeof(UsersAllergies))]
        public List<User> Users
        {
            get;
            set;
        }
    }
}
