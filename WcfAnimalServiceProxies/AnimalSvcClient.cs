using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

using WcfAnimalServiceLibrary;

namespace WcfAnimalServiceProxies
{
    public class AnimalSvcClient : ClientBase<IAnimalSvcLibrary>, IAnimalSvcLibrary
    {
        public string AddAnimal(Animal animal)
        {
           Channel.AddAnimal(animal);
            return animal.Name;
        }

        public List<Animal> getAnimals()
        {
            return Channel.getAnimals();
        }

        public string GreetAnimal(Animal animal)
        {
            return Channel.GreetAnimal(animal);
        }

    
    }

    public class AnimalSvcClient2 : ClientBase<IAnimalSvcPrivateLibrary>, IAnimalSvcPrivateLibrary
    {
        public string GetAnimalInfo()
        {
            return Channel.GetAnimalInfo();
        }
    }

}
