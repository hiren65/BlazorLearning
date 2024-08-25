using BlazorLearning.DAL;

namespace BlazorLearning.Services
{
    public class MasterInventoryManagement: IGetCount
    {
        private readonly BlazorLearningDbContext blazorLearningDbContext;
        public MasterInventoryManagement(BlazorLearningDbContext blazorLearningDbContext)
        {
                this.blazorLearningDbContext = blazorLearningDbContext;
        }
        public int GetCount()
        {
            var cnt = 0;
            var cc = blazorLearningDbContext.Master_Inventory_Record.Count();

            return cc;
        }


    }
}
