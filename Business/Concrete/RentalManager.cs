﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {

        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal; 
        }

        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate != null)
                return new ErrorResult(Messages.RentalNotExists); 
            
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded); 
        }

        public IResult Delete(Rental rental)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id), Messages.UserAdded);
        }



        public IResult Update(Rental rental)
        {
            throw new NotImplementedException();
        }
    }
}
