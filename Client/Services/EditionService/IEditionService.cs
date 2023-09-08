using DoanTMDT.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoanTMDT.Client.Services.EditionService
{
    public interface IEditionService
    {
        event Action OnChange;
        public List<Edition> Editions { get; set; }
        Task GetEditions();
        Task AddEdition(Edition edition);
        Task UpdateEdition(Edition edition);
        Edition CreateNewEdition();
    }
}
