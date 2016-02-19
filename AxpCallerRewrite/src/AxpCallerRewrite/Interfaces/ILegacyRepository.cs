﻿using AxpCallerRewrite.Models;
using AxpCallerRewrite.Models.Database_Models;
using System.Collections.Generic;

namespace AxpCallerRewrite.Interfaces
{
    public interface ILegacyRepository
    {
        IEnumerable<CompanyType> GetCompanyTypes();
        IEnumerable<State> GetStates();
        IEnumerable<OEM> GetOEMs();
        IEnumerable<Product> GetProducts();
        IEnumerable<Feature> GetFeatures();
        void GetOecProducts();
        void GetActivateFeature();
        void GetDeactivateFeature();
    }
}