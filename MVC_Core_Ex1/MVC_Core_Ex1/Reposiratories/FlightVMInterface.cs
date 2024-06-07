using MVC_Core_Ex1.Models;
using MVC_Core_Ex1.ViewModels;

namespace MVC_Core_Ex1.Reposiratories
{
    public interface FlightVMInterface
    {

        List<FlightVM> GetAllFlightVM();
        List<Flights> GetAllFlightVM1();
        void Add(FlightVM rec);
       
    }
}
