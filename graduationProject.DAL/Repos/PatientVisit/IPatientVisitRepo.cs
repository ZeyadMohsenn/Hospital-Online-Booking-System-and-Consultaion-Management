﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graduationProject.DAL
{
   public interface IPatientVisitRepo
    {
        public void AddPatientVisit(PatientVisit patientVisit);
    }
}