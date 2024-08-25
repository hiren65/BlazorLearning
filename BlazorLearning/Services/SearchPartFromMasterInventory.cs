using BlazorLearning.DAL;
using BlazorLearning.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlazorLearning.Services
{
    public class SearchPartFromMasterInventory:ISearchMasterItem
    {
        private readonly BlazorLearningDbContext _dbContext;
        public SearchPartFromMasterInventory(BlazorLearningDbContext blazorLearningDbContext)
        {
                _dbContext = blazorLearningDbContext;
        }

        public async Task<Master_Inventory_Record> GetItem(string partCode)
        {
           
            try
            {
              var cc=  _dbContext.Master_Inventory_Record.Where(m => m.PartCode.Trim() == partCode.Trim()).Select(m => m).FirstOrDefault();
                return await Task.FromResult(cc);
            }
            catch (Exception)
            {
                


            }
           

            return await Task.FromResult(new Master_Inventory_Record());
        }
    }
}
