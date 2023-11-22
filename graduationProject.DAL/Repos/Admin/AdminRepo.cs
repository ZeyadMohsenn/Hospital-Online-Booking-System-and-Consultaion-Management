﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graduationProject.DAL
{
    public class AdminRepo : IAdminRepo
    {
        private readonly HospitalContext _context;
        public AdminRepo(HospitalContext context)
        {
              _context = context;
        }
        public Doctor? UpdateDoctorById(string doctorId)
        {
            Doctor? doctorToUpdate = _context.Set<Doctor>().FirstOrDefault(d => d.Id == doctorId);

            if (doctorToUpdate != null)
            {
                 _context.Set<Doctor>().Update(doctorToUpdate);
                
            }
            return doctorToUpdate;
        }

        public Doctor? ChangeDoctorStatus(string doctorId)
        {
            Doctor? doctorToUpdate = _context.Set<Doctor>().FirstOrDefault(d => d.Id == doctorId);
            if (doctorToUpdate != null)
            {
                _context.Set<Doctor>().Update(doctorToUpdate);

            }
            return doctorToUpdate;

        }

        public void AddSpecialization(Specialization? specialization) 
        {
            if (specialization == null)
            {
                throw new ArgumentNullException(nameof(specialization), "Specialization cannot be null.");
            }

            _context.Set<Specialization>().Add(specialization);

        }



    }
}
