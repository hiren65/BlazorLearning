using BlazorLearning.Domain;

namespace BlazorLearning.Services
{
    public interface ISearchMasterItem
    {
        public Task<Master_Inventory_Record> GetItem(string partName);
    }
}
