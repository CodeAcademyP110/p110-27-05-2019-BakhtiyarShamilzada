﻿namespace _27_May_2019
{
    public class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} \n" +
                   $"Number: {Number}";
        }
    }
}
