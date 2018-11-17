using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SQLite;

namespace FysioterapiApp.ModelKlasser
{
    public class Borger : INotifyPropertyChanged
    {

        public string fName { get; set; }

        public string lName { get; set; }

        public int age { get; set; }

        public string address { get; set; }

        private int _ssn;

        [PrimaryKey]
        [MaxLength(10)]
        public int ssn { get; set; }

        public string email { get; set; }
    }


}
