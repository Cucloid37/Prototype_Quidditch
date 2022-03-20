namespace V2._0.Predicates
{
    public interface ICanMove : IContext
    {
        bool IsActiveTeam { get; set; }
        bool IsActiveFlyer { get; set; }
        SubscriptionProperty<bool> IsSelectedFlyer { get; set; }
    }
}