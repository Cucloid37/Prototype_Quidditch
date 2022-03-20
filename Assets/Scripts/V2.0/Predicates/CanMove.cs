namespace V2._0.Predicates
{
    public class CanMove : IPredicate, ICanMove
    {
        public bool IsActiveTeam { get; set; }
        public bool IsActiveFlyer { get; set; }
        public SubscriptionProperty<bool> IsSelectedFlyer { get; set; }

        public CanMove()
        {
            IsSelectedFlyer = new SubscriptionProperty<bool>();
        }
        
        public bool IsReady(IContext target)
        {
            var context = target as ICanMove;
            
            if (context is {IsActiveTeam: true})
            {
                return context.IsActiveFlyer;
            }
            return false;
        }

       
    }
}