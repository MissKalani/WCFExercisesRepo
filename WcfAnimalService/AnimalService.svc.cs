using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace WcfAnimalService
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]

    public class AnimalService : IAnimalService
    {  
        public static class SessionManager
        {
            private static List<Animal> _animalList = new List<Animal>();
            public static Animal AnimalCollectionSetter
            {
                set
                {
                    _animalList.Add(value);
                }
            }
            public static List<Animal> AnimalCollectionGetter
            {
                get
                {
                    return _animalList;
                }
            }

        }

        public void addAnimal(Animal animal)
        {
            SessionManager.AnimalCollectionSetter = animal;
        }
        public List<Animal> getAnimals()
        {
            return SessionManager.AnimalCollectionGetter;
        }

        //public string AddAnimal(Animal animal)
        //{
        //    animalList.Add(animal);
        //    return animal.Name;
        //}

        //public string GetAnimal(int i)
        //{
        //    foreach (var animal in animalList)
        //    {
        //        i = animalList.IndexOf(animal);
        //    }

        //    return animalList[i].Name;
        //}

        public string GreetAnimal(Animal animal)
        {
            return string.Format("Greetings from Animal Service! by: {0}", animal.Name);
        }
    }
}
