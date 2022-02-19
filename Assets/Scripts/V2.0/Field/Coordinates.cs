using UnityEngine;

namespace V2._0
{
    public struct Coordinates
    {
        private int X { get; set; }
        private int Y { get; set; }
        private int Z { get; set; }

        public Coordinates(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static explicit operator Coordinates(Vector3 vector)
        {

            return new Coordinates { X = (int)vector.x, Y = (int)vector.y, Z = (int)vector.z };
        }

        public static implicit operator float(Coordinates coordinates)
        {
            float res = (float)coordinates.X + (float)coordinates.Y + (float)coordinates.Z;
            return res;
        }

        public static explicit operator Vector3(Coordinates coordinates)
        {
            Vector3 vector = new Vector3()
            {
                x = coordinates.X,
                y = coordinates.Y,
                z = coordinates.Z
            };

            return vector;

        }

        public override string ToString() => $"X = {X}, Y = {Y}, Z = {Z}";

        public static Coordinates operator -(Coordinates c1, Coordinates c2)
        {
            Coordinates res = new Coordinates
            {
                X = c1.X - c2.X,
                Y = c1.Y - c2.Y,
                Z = c1.Z - c2.Z
            };
            if (res.X < 0)           // Как можно красиво сократить подобную запись? С помощью индексов, которые мы еще не проходили?
            {
                res.X *= -1;
            }
            if (res.Y < 0)
            {
                res.Y *= -1;
            }
            if (res.Z < 0)
            {
                res.Z *= -1;
            }

            return res;
        }
    }
}