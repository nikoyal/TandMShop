namespace TandMShop.Web.ViewModels.Settings
{
    using TandMShop.Data.Models;
    using TandMShop.Services.Mapping;

    using AutoMapper;

    public class SettingViewModel : IMapFrom<Setting>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public string NameAndValue { get; set; }


    }
}
