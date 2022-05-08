using LearningMicroService.Common;

namespace LearningMicroService.Data
{
    public class PeopleRepository : Repository<Person>, IPeopleRepository
    {
        public PeopleRepository(PeopleDbContext peopleDbContext)
            : base(peopleDbContext)
        {

        }

    }
}
