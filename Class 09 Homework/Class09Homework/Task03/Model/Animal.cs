using System;
using System.Collections.Generic;
using Task03.Enum;

namespace Task03.Model
{
    public class Animal
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public int Age { get; set; }

        public GenderEnum Gender { get; set; }
    }
}