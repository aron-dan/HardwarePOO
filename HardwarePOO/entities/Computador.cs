using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwarePOO.entities
{
    public abstract class Computador
    {
        public Computador()
        {
            Processador = new Processador();
            MotherBoard = new MotherBoard();
            RAM = new RAM();
            HardDisk = new HardDisk();
            VideoCard = new VideoCard();
            Gabinet = new Gabinete();
            Fabricante = new Fabricante();

        }
        public Processador Processador { get; set; }
        public MotherBoard MotherBoard { get; set; }
        public MotherBoard MortherBoard { get; set; }
        public RAM RAM { get; set; }
        public HardDisk HardDisk { get; set; }
        public VideoCard VideoCard { get; set; }
        public Gabinete Gabinet { get; set; }
        public Fabricante Fabricante { get; set; }

        public abstract bool Ligar(bool isOn);
        public abstract bool Desligar(bool isOff);
    }
}
