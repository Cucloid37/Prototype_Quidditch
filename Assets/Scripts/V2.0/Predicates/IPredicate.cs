namespace V2._0.Predicates
{
    public interface IPredicate
    {
        bool IsReady(IContext target);
    }
}