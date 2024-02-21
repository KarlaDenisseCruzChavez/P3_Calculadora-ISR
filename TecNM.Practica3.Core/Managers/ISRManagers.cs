using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Managers.Interfaces;
using TecNM.Practica3.Core.Services.Interfaces;

namespace TecNM.Practica3.Core.Managers;
public class ISRManagers : IISRManagers{

    //Nomeclatura de buenas prácticas cuando algo sea privado _.
    private readonly IISRServices _service;
    public ISRManagers (IISRServices service){
    _service = service;
    }

    public ISR GetISR (Salario sal){
    return _service.ProcessISR(sal);
    }
}