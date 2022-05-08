using LearningMicroService.Common;
using LearningMicroService.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningMicroService.Service
{
    public class GetPeopleQueryHandler : IRequestHandler<GetPeopleQuery, List<Person>>
    {
        private readonly IPeopleRepository _peopleRepository;

        public GetPeopleQueryHandler(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }
        public async Task<List<Person>> Handle(GetPeopleQuery request, CancellationToken cancellationToken)
        {
            return await Task.Run(() => _peopleRepository.GetAll());
        }
    }
}
