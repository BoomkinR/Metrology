using Metrology.Models;
using Metrology.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Metrology.Services.ModelService
{
    public class UserService
    {
        private MapService _mapService;

        public UserService()
        {
            _mapService = new MapService();
        }

        public List<UserDto> GetAllUsers()
        {
            using ApplicationContext db = new ApplicationContext();
            var mapService = new MapService();
            return db.Users.Include(u =>u.Role).Select(x => _mapService.MapToUserDto(x)).ToList();
        }
    }
}
