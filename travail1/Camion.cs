using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travail1
{
    class Camion
    {
        private int poidsDuCamion;
        private int volumeDuCamion;

        public Camion(int poidsDuCamion, int volumeDuCamion)
        {
            PoidsDuCamionInfo = poidsDuCamion;
            VolumeDuCamionInfo = volumeDuCamion;
        }

        public int PoidsDuCamionInfo { get => poidsDuCamion; set => poidsDuCamion = value; }
        public int VolumeDuCamionInfo { get => volumeDuCamion; set => volumeDuCamion = value; }

    
    public override string ToString()
        {
            return PoidsDuCamionInfo.ToString() + "Lbs , " + volumeDuCamion.ToString();
        }
    }
}
