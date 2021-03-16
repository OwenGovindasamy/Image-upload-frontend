using Recap_App.Models;
using System.Threading.Tasks;

namespace Recap_App.Interfaces
{
    public interface IBusinessLogic
    {
        Task<Photo> photosAsync();
    }
}