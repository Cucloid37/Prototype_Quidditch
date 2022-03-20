using System;
using UnityEngine;
using V2._0._2_ProgrammData.Code.Scripts._GameController.Descriptions;

namespace DefaultNamespace
{
    public class TestMonobeh : MonoBehaviour
    {
        [SerializeField] private CarDescription description;
        private Vector3 vector = new Vector3(3, 3, 3);
        
        private async void Start()
        {
            var dictionary = description.GetCarsDictionary();
            var go = await description.GetView(dictionary[TypeCar.example]);
            go.transform.Translate(vector, Space.World);
        }
    }
}