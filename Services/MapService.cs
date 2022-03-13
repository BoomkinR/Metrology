using Metrology.Models;
using Metrology.Models.Dtos;
using Metrology.Services.ModelService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrology.Services
{
    public class MapService
    {
        private readonly DeviceService _deviceService = new DeviceService();
        public User MapToUser(UserDto userDto)
        {
            return new User
            {
                ID = userDto.ID,
                Name = userDto.Name,
                Surname = userDto.Surname,
                PatrName = userDto.PatrName,
                Email = userDto.Email,
                BirthDay = userDto.BirthDay,
                RegistrationDate = userDto.RegistrationDate,
                Phone = userDto.Phone,
                Login = userDto.Login,
                Password = userDto.Password,
                Role = userDto.Role
            };
        }

        public DeviceDto MapToDeviceDto(Device device)
        {
            return new DeviceDto
            {
                Id = device.Id,
                Name = device.Name,
                Type = device.Type,
                DeviceDate = device.DeviceDate,
                DateExplotationStart = device.DateExplotationStart,
                DateExplotationEnd = device.DateExplotationEnd,
                SerialNumber = device.SerialNumber,
                Location = device.Location,
                Status = device.Status
            };
        }

        public Device MapToDevice(DeviceDto deviceDto)
        {            
            return new Device
            {
                Id = deviceDto.Id,
                Name = deviceDto.Name,
                Type = deviceDto.Type,
                DeviceDate = deviceDto.DeviceDate,
                DateExplotationStart = deviceDto.DateExplotationStart,
                DateExplotationEnd = deviceDto.DateExplotationEnd,
                SerialNumber = deviceDto.SerialNumber,
                Location = deviceDto.Location,
                Status = deviceDto.Status
            };
        }
        
    }
}
