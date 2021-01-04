namespace TandMShop.Services.Mapping
{
    using AutoMapper;

    public interface IHaveCustomMappings
    {
        void 
            pings(IProfileExpression configuration);
    }
}
