using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwarePOO.entities.pcgamer
{
    public class PcGamer : Computador
    {
        public override bool Desligar(bool isOn)
        {
            if (isOn)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Ligar(bool isOff)
        {
            if (isOff)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
