using Recap_App.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recap_App.Interfaces
{
    public interface IBusinessLogic
    {
        Task<List<Photo>> photosAsync();
    }
}