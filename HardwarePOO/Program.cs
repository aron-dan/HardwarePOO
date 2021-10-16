using HardwarePOO.entities;
using HardwarePOO.entities.pcgamer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwarePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Computador PcGamer = new PcGamer();
            PcGamer.Fabricante.Name = "Kabum";
            PcGamer.Fabricante.Modelo = "PC-Gamer Hyper Mega Power 3000";
            PcGamer.Processador.Fabricante.Name = "intel";
            PcGamer.Processador.Fabricante.Modelo = "i9";
            PcGamer.Processador.GenerationPC = "10100f";
            PcGamer.Processador.Ghz = 3.4;
            PcGamer.MortherBoard.Fabricante.Name = "Asus";
            PcGamer.MortherBoard.Fabricante.Modelo = "AsRock 320-M";
            PcGamer.MortherBoard.Geracao = "LGA-1155";
            PcGamer.MortherBoard.Slots = 4;
            PcGamer.RAM.DRR = "DDR4";
            PcGamer.RAM.quantidade = 2;
            PcGamer.RAM.Espaço = 8;
            PcGamer.RAM.MegaHearts = 3666;
            PcGamer.RAM.Fabricante.Name = "Corsair";
            PcGamer.RAM.Fabricante.Modelo = "Corsair RGB 8GB";
            PcGamer.HardDisk.Gibas = "2TB";
            PcGamer.HardDisk.Rotação = 7200;
            PcGamer.VideoCard.Gibas = "8GB";
            PcGamer.VideoCard.TereFlops = 14000;
            PcGamer.VideoCard.Fabricante.Name = "NVidia";
            PcGamer.VideoCard.Fabricante.Modelo = "GForce GTX 3090 Super";
            PcGamer.Gabinet.Fabricante.Name = "Kabum";
            PcGamer.Gabinet.Fabricante.Modelo = "Tranforme XP-Extrem Acelaration 2000";

        }
    }
}
