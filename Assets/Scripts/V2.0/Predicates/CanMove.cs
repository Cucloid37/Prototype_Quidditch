namespace V2._0.Predicates
{
    public class CanMove : IPredicate
    {
        
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