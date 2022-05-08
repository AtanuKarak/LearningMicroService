using LearningMicroService.Common;
using MediatR;
using System.Collections.Generic;

namespace LearningMicroService.Service
{
    public class GetPeopleQuery : IRequest<List<Person>>
    {

    }
}
