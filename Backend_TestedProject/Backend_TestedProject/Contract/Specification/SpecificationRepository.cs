using Backend_TestedProject.Contract.Common;
using Backend_TestedProject.DataLayer.Common;
using Backend_TestedProject.Infrastruchers.Models.Specifications;

namespace Backend_TestedProject.Contract.Specification
{
    
    public class SpecificationRepository : BaseRepository<Specifications>,ISpecificationRepository
    {
        public SpecificationRepository(TestProject_Context dbContext) : base(dbContext)
        {

        }
    }
}
