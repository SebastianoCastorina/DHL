﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DHL.Models



{
    
    public class Amministratori 
    {
        
        public string Username { get; set; }
        public string Password { get; set; }
        public string Ruolo { get; set; }
        public Amministratori() { }
        public Amministratori(string username, string password, string ruolo)
        {
            Username = username;
            Password = password;
            Ruolo = ruolo;
        }
    }
}