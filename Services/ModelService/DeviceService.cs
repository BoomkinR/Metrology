using Metrology.Models;
using Metrology.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;

namespace Metrology.Services.ModelService
{
    public class DeviceService
    {
       public void SaveDevice(DeviceDto deviceDto)
        {
            if (deviceDto == null)
            {
                return;
            }
            using ApplicationContext db = new ApplicationContext();
            var mapService = new MapService();
            var device = mapService.MapToDevice(deviceDto);
            device.Type = db.DeviceTypes.FirstOrDefault(x => x.ID == device.Type.ID);
            device.Status = db.PresenceStatus.FirstOrDefault(x => x.Id == device.Status.Id);
            db.Devices.Add(device);
            db.SaveChanges();

        }

        public IEnumerable<DeviceDto> GetAllDevices()
        {
            using ApplicationContext db = new ApplicationContext();
            var mapService = new MapService();
            return db.Devices
                .Include(u => u.Type)
                .Include(u => u.Status)
                .Select(x => mapService.MapToDeviceDto(x)).ToList();

        }

        public IEnumerable<DeviceType> GetDeviceTypes()
        {
            using ApplicationContext db = new ApplicationContext();
            return db.DeviceTypes.ToList();
        }

        public DeviceType GetDeviceTypeById(int id)
        {
            using ApplicationContext db = new ApplicationContext();
            return db.DeviceTypes.FirstOrDefault(x => x.ID == id);
        }
    }
}
