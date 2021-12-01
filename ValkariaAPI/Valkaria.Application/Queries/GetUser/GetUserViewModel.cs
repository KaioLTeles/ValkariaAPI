using System.Collections.Generic;
using Valkaria.Core.Entities;

namespace Valkaria.Application.Queries.GetUser
{
    public class GetUserViewModel
    {
        public GetUserViewModel(int id, string name, List<PartyViewModel> partiesList)
        {
            Id = id;
            Name = name;
            PartiesList = partiesList;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public List<PartyViewModel> PartiesList { get; set; }
    }
}
