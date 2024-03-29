﻿using System.Collections.Generic;
using StudentManagementSystem.Business.Abstract;
using StudentManagementSystem.Business.ValidationRules.FluentValidation;
using StudentManagementSystem.Core.CrossCuttingConcerns.Validation.FluentValidation;
using StudentManagementSystem.Core.Utilities.Results;
using StudentManagementSystem.Core.Utilities.Validation;
using StudentManagementSystem.DataAccess.Abstract;
using StudentManagementSystem.Entities.Concrete;

namespace StudentManagementSystem.Business.Concrete
{
    public class AdviserApprovalManager : CrudOperation<AdviserApproval>, IAdviserApprovalService
    {
        private readonly IAdviserApprovalDal _adviserApprovalDal;
        private readonly AdviserApprovalValidator _adviserApprovalValidator = new AdviserApprovalValidator();

        public AdviserApprovalManager(IAdviserApprovalDal adviserApprovalDal) : base(typeof(AdviserApprovalValidator), adviserApprovalDal)
        {
            _adviserApprovalDal = adviserApprovalDal;
        }

        public override IDataResult<List<AdviserApproval>> GetAll()
        {
            return _adviserApprovalDal.GetAll(null);
        }

        public IDataResult<List<AdviserApproval>> GetAllByStudentNo(int studentNo)
        {
            if (studentNo > 0)
            {
                return _adviserApprovalDal.GetAll(new Dictionary<string, dynamic>() { { "ogrenci_no", studentNo } });
            }

            return new ErrorDataResult<List<AdviserApproval>>("Öğrenci no 0'dan büyük olmalıdır");
        }

        public IDataResult<List<AdviserApproval>> GetAllByCourseNo(int courseNo)
        {
            if (courseNo > 0)
            {
                return _adviserApprovalDal.GetAll(new Dictionary<string, dynamic>() { { "katalog_ders_kodu", courseNo } });
            }

            return new ErrorDataResult<List<AdviserApproval>>("Ders no 0'dan büyük olmalıdır");
        }
    }
}
