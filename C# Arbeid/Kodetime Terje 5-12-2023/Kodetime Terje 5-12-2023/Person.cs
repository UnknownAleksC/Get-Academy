using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kodetime_Terje_5_12_2023;

var model = new Model
{
    people = new []
    {
        new Person
        {
            FirstName = "Terje",
            BirthYear = 1975
        }
    }
};

public class Person
{
    public string FirstName;
    public int BirthYear;
    Person[] people = null;
}