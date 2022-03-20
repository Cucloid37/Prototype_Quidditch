using System;
using System.Threading.Tasks;
using UnityEngine.AddressableAssets;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using JetBrains.Annotations;
using UnityEngine;
using Object = UnityEngine.Object;

namespace V2._0
{
    namespace _2_ProgrammData.Code.Scripts._GameController.Descriptions
    {
        [CreateAssetMenu(fileName = "Car", menuName = "Descriptions/Car")]
        public class CarDescription : ScriptableObject
        {
            [SerializeField] private Car[] cars;

            public Dictionary<TypeCar, AssetReference> GetCarsDictionary()
            {
                return cars.ToDictionary(car => car.TypeCar, car => car.Reference);
            }
            
            public async Task<GameObject> GetView(AssetReference viewReference)
            {
                return await Addressables.LoadAssetAsync<GameObject>(viewReference).Task;
            }

            
        }

        public enum TypeCar
        {
            example,
            simple
        }

        [Serializable]
        public class Car : Dictionary<TypeCar, AssetReference>
        {
            [SerializeField] private AssetReference reference;
            [SerializeField] private TypeCar typeCar;
            [SerializeField] private int speed;
            [SerializeField] private int somethingProperty;

            public AssetReference Reference => reference;
            public TypeCar TypeCar => typeCar;

            public ICarModel GetModel => new CarModel(speed, somethingProperty);
            
        }

        public interface ICarModel
        {
            int speed { get; }
            int somethingProperty { get; }
        }

        public class CarModel : ICarModel
        {
            public int speed { get; }
            public int somethingProperty { get; }
            
            public CarModel(int speed, int somethingProperty)
            {
                this.speed = speed;
                this.somethingProperty = somethingProperty;
            }

        }
    }
}