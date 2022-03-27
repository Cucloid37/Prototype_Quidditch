using UnityEngine;

namespace V2._0
{
    public struct Coordinates
    {
        private int X { get; set; }
        private int Y { get; set; }
        private int Z { get; set; }
        public ReactiveValue<int> reactiveY { get; private set; }

        public Coordinates(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
            
            reactiveY = new ReactiveValue<int>(y);
        }

       

        public override string ToString() => $"X = {X}, Y = {Y}, Z = {Z}";

        public static Coordinates operator -(Coordinates c1, Coordinates c2)
        {
            Coordinates res = new Coordinates
            {
                X = c1.X - c2.X,
                Y = c1.Y - c2.Y,
                Z = c1.Z - c2.Z,
                
                reactiveY = new ReactiveValue<int>(c1.Y - c2.Y)
            };
            
            if (res.X < 0)           // Как можно красиво сократить подобную запись? С помощью индексов, которые мы еще не проходили?
            {
                res.X *= -1;
            }
            if (res.Y < 0)
            {
                res.Y *= -1;
                res.reactiveY.CurrentValue *= -1;
            }
            if (res.Z < 0)
            {
                res.Z *= -1;
            }

            return res;
        }
    }
}