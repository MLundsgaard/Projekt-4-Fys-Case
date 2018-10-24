using System;
using System.Collections.Generic;
using System.Text;

namespace FysApp.ModelKlasser
{
    public class Borger
    {
        public string FName;
        public string LName;
        public int Age;
        public string Address;
        public int Ssn;
        public string Email;
    }

    public Borger(string FName, string LName, int Age, string Address, int Ssn, string Email)
    {
        this.FName = FName;
        this.LName = LName;
        this.Age = Age;
        this.Address = Address;
        this.Ssn = Ssn;
        this.Email = Email;
    }

    public string FName { get; set; }
    public string LName { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public int Ssn { get; set; }
    public string Email { get; set; }

}
