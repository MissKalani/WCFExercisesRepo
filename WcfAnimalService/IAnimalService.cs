using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfAnimalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAnimalService" in both code and config file together.
    //[ServiceContract(SessionMode = SessionMode.Required)]
    public interface IAnimalService
    {
        [OperationContract]
        String GreetAnimal(Animal animal);

        [OperationContract]
        void addAnimal(Animal animal);

        [OperationContract]
        List<Animal> getAnimals();      
    }

    [DataContract]
    public class Animal
    {
        [DataMember]
        public string Name { get; set; }
    }
}
