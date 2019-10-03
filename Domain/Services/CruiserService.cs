using System;
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

        public async Task<CruiserResponse> GetCruiserByIdAsync(int id)
        {
            var cruiser = await _cruiserDao.FindCruiserByIdAsync(id);
            if(cruiser == null) 
                return new CruiserResponse("Cruiser not found");
            return new CruiserResponse(cruiser);
        }

        public async Task<CruiserResponse> SaveCruiserAsync(Cruiser cruiser)
        {
            try
            {
                await _cruiserDao.SaveCrusierAsync(cruiser);
                await _unitOfWork.CompleteAsync();
                return new CruiserResponse(cruiser);
            }
            catch (Exception e)
            {
                return new CruiserResponse($"An error occurred when saving the Cruiser: {e.Message}");
            }
        }

        public async Task<CruiserResponse> UpdateCruiserAsync(int id, Cruiser cruiser)
        {
            var dbCruiser = await _cruiserDao.FindCruiserByIdAsync(id);
            if (dbCruiser == null) return new CruiserResponse("Cruiser not found");
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
                return new CruiserResponse(dbCruiser);
            }
            catch (Exception e)
            {
                return new CruiserResponse($"An error occurred when updating the Cruiser: {e.Message}");
            }
        }

        public async Task<CruiserResponse> DeleteCruiserAsync(int id)
        {
            var cruiser = await _cruiserDao.FindCruiserByIdAsync(id);
            if(cruiser == null) return new CruiserResponse("Cruiser not found");
            try
            {
                _cruiserDao.DeleteCruiser(cruiser);
                await _unitOfWork.CompleteAsync();
                return new CruiserResponse(cruiser);
            }
            catch (Exception e)
            {
                return new CruiserResponse($"An error occurred when deleting the Cruiser: {e.Message}");
            }
        }
    }
}
