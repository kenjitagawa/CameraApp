using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCamera
{
    internal class Camera : ICamera
    {
        public ICarteMemoire CarteMemoireCourante => throw new NotImplementedException();

        public int FacteurCompression => throw new NotImplementedException();

        public enuFlash Flash { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IPhoto PhotoCourante => throw new NotImplementedException();

        public enuDimension Dimension { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int PosPhotoCourante => throw new NotImplementedException();

        public enuQualite Qualite { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public long TailleEnOctetsEstimee => throw new NotImplementedException();

        public Size TailleEnPixelsSelonDimension => throw new NotImplementedException();

        public enuSensibilite Sensibilite { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ChargerParametres()
        {
            throw new NotImplementedException();
        }

        public void DimensionSuivante()
        {
            throw new NotImplementedException();
        }

        public void EjecterCarteMemoire()
        {
            throw new NotImplementedException();
        }

        public void EnregistrerParametres()
        {
            throw new NotImplementedException();
        }

        public void InsererCarteMemoire(ICarteMemoire pCarteMemoire)
        {
            throw new NotImplementedException();
        }

        public bool PeutPrendreUnePhoto()
        {
            throw new NotImplementedException();
        }

        public void PhotoPrecedente()
        {
            throw new NotImplementedException();
        }

        public void PhotoSuivante()
        {
            throw new NotImplementedException();
        }

        public void PrendrePhoto()
        {
            throw new NotImplementedException();
        }

        public void QualiteSuivante()
        {
            throw new NotImplementedException();
        }

        public void SensibiliteSuivante()
        {
            throw new NotImplementedException();
        }

        public void SupprimerPhotoCourante()
        {
            throw new NotImplementedException();
        }

        public void ViderLaCarte()
        {
            throw new NotImplementedException();
        }
    }
}
