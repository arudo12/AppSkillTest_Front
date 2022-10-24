using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_Front.Models;
using App_Front.Models.DbModel;

namespace App_Back.Provider
{
    public interface IAppService
    {
        
        IEnumerable<DropdownViewModel> GetLocation();
    }

    public class AppProvider : IAppService
    {
        Context _context;

        public AppProvider(Context context)
        {
            _context = context;
        }

        public IEnumerable<DropdownViewModel> GetLocation()
        {
            var q = from a in _context.ms_storage_location
                    select new DropdownViewModel()
                    {
                        Text = a.location_name,
                        Value = a.location_id
                    };

            return q;
        }
    }
}
