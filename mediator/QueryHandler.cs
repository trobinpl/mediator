namespace mediator
{
    public interface IQueryHandler<TQuery, TResponse>
    {
        TResponse Handle(TQuery query);
    }
}