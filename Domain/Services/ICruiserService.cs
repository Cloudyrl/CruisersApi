﻿using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using CruisersApi.Domain.Communication;
using CruisersApi.Domain.Entities;
using CruisersApi.Resources;

namespace CruisersApi.Domain.Services
{
    public interface ICruiserService 
    {
        Task<IEnumerable<Cruiser>> GetCruisersAsync();

        Task<SaveCruiserResponse> GetCruiserByIdAsync(int id);
        Task<SaveCruiserResponse> SaveCruiserAsync(Cruiser cruiser);

        Task<SaveCruiserResponse> UpdateCruiserAsync(int id,Cruiser cruiser);
    }
}