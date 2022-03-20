namespace V2._0
{
    public class Ring
    {
        // Кольцо должна знать только свою команду и view. Всё
        
        private readonly FlyerTeam _team;
        private readonly RingView _view;

        public Ring(FlyerTeam team, RingView view)
        {
            _team = team;
            _view = view;
        }
    }
}