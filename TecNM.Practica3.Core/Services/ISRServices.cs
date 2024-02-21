using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Services.Interfaces;

namespace TecNM.Practica3.Core.Services;

public class ISRServices: IISRServices{
    public ISR ProcessISR (Salario sal){
        var isr = new ISR();
       

        if(sal.SalarioO >= 0.01 && sal.SalarioO < 7735){
            sal.LimiteI  = 0.01;
            sal.CuotaFija = 0;
            sal.SobreExcedente = 1.92 / 100;
        }else if( sal.SalarioO >= 7735.01 && sal.SalarioO < 65651.07){
            sal.LimiteI = 7735.01;
            sal.CuotaFija = 148.51;
            sal.SobreExcedente = 6.40 / 100;
        }
        else if(sal.SalarioO >= 65651.08 && sal.SalarioO < 115375.90){
            sal.LimiteI = 65651.08;
            sal.CuotaFija = 3855.14;
            sal.SobreExcedente = 10.88 / 100;
        }
         else if(sal.SalarioO>= 115375.91 && sal.SalarioO < 134119.41){
            sal.LimiteI = 115375.91;
            sal.CuotaFija = 9265.20;
            sal.SobreExcedente = 16 / 100;
        }
         else if(sal.SalarioO >= 134119.42 && sal.SalarioO < 160577.65){
            sal.LimiteI = 134119.42;
            sal.CuotaFija = 12264.16;
            sal.SobreExcedente = 17.92 / 100;
        }
        else if(sal.SalarioO >= 160577.66 && sal.SalarioO < 323862.00){
            sal.LimiteI = 160577.66;
            sal.CuotaFija = 17005.47;
            sal.SobreExcedente = 21.36 / 100;
        }
        else if(sal.SalarioO >= 323862.01 && sal.SalarioO < 510451.00){
            sal.LimiteI = 323862.01;
            sal.CuotaFija = 51883.01;
            sal.SobreExcedente = 23.52 / 100;
        }
        else if(sal.SalarioO >= 510451.01 && sal.SalarioO < 974535.03){
            sal.LimiteI = 510451.01;
            sal.CuotaFija = 95768.74;
            sal.SobreExcedente = 30 / 100;
        }
        else if(sal.SalarioO >= 974535.04 && sal.SalarioO < 1299380.04){
            sal.LimiteI = 974535.04;
            sal.CuotaFija = 234993.95;
            sal.SobreExcedente = 32 / 100;
        }
        else if(sal.SalarioO >= 1299380.05 && sal.SalarioO < 3898140.12){
            sal.LimiteI =  1299380.05;
            sal.CuotaFija = 338944.34;
            sal.SobreExcedente = 34 / 100;
        }
        else if(sal.SalarioO >= 3898140.13){
            sal.LimiteI =  3898140.13;
            sal.CuotaFija = 1222522.76;
            sal.SobreExcedente = 35 / 100;
        }

        
        isr.index = ((sal.SalarioO - sal.LimiteI) * sal.SobreExcedente) + sal.CuotaFija;
       
        
        return isr;
    }
}