﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CruisersApi.Domain.Communication;
using CruisersApi.Domain.Entities;
using CruisersApi.Domain.Repository;
using CruisersApi.Persistence.Repositories;
using CruisersApi.Resources;

namespace CruisersApi.Domain.Services
{
    public class CruiserService : ICruiserService
    {
        private readonly ICruiserDAO _cruiserDao;
        private readonly IUnitOfWork _unitOfWork;

        public CruiserService(ICruiserDAO cruiserDao, IUnitOfWork unitOfWork)
        {
            _cruiserDao = cruiserDao;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Cruiser>> GetCruisersAsync()
        {
           return await _cruiserDao.GetCruisersAsync();
        }

        public async Task<SaveCruiserResponse> SaveCruiserAsync(Cruiser cruiser)
        {
            try
            {
                await _cruiserDao.SaveCrusierAsync(cruiser);
                await _unitOfWork.CompleteAsync();
                return new SaveCruiserResponse(cruiser);
            }
            catch (Exception e)
            {
                return new SaveCruiserResponse($"An error occurred when saving the Cruiser: {e.Message}");
            }
        }

        public async Task<SaveCruiserResponse> UpdateCruiserAsync(int id, Cruiser cruiser)
        {
            var dbCruiser = await _cruiserDao.FindCruiserByIdAsync(id);
            if (dbCruiser == null) return new SaveCruiserResponse("Cruiser not found");
            dbCruiser.Name = cruiser.Name;
            dbCruiser.Line = cruiser.Line;
            dbCruiser.Model = cruiser.Model;
            dbCruiser.Status = cruiser.Status;
            dbCruiser.LoadingShipCap = cruiser.LoadingShipCap;
            dbCruiser.Picture = cruiser.Picture;
            dbCruiser.Capacity = cruiser.Capacity;
            try
            {
                _cruiserDao.UpdateCruiser(dbCruiser);
                await _unitOfWork.CompleteAsync();
                return new SaveCruiserResponse(dbCruiser);
            }
            catch (Exception e)
            {
                return new SaveCruiserResponse($"An error occurred when updating the Cruiser: {e.Message}");
            }
        }
    }
}
