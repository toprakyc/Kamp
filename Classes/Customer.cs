using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer //bir class içersinde class ı tanımlayan özellikler ekleyeceksek field değilde propertyler tanımlarız
    {
        public int Id { get; set; }
        public string FirstName { get; set; }  //property
        //field -> public string FirstName;
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
