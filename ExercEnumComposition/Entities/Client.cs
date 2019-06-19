using System;

namespace ExercEnumComposition.Entities
{
    class Client
    {
        //Atributos/Auto-Properties
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        
        //Construtores
        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
