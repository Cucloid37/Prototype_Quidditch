using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using Object = UnityEngine.Object;

namespace V2._0
{


    public static class Extensions
    {
        public static T DeepCopy<T>(this T self)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("Type must be iserializable");
            }

            if (ReferenceEquals(self, null))
            {
                return default;
            }

            var formatter = new BinaryFormatter();
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, self);
                stream.Seek(0, SeekOrigin.Begin);
                return (T) formatter.Deserialize(stream);
            }
        }

        public static T GetSet<T>(this T self) where T : Object
        {
            return self;
        }

        public static T GetOrAddComponent<T>(this T child) where T : Component
        {
            if (child.GetComponent<T>() == null)
            {
                return child.gameObject.AddComponent<T>();
            }

            return child.GetComponent<T>();
        }
    }
}