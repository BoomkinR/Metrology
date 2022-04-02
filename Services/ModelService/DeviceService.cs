using Metrology.Models;
using Metrology.Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Metrology.Services.ModelService
{
    public class DeviceService
    {
       public void SaveDevice(DeviceDto deviceDto, VerificationJournalDto verificationJournalDto)
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
            device.OwnerUser = db.Users.FirstOrDefault(x => x.ID == LoginService.CurrentUser.ID);
            
            db.Devices.Add(device);
            db.SaveChanges();
            CreateVerificationForDevice(verificationJournalDto, device);
            

        }

       private void CreateVerificationForDevice(VerificationJournalDto verificationJournalDto, Device device)
       {
           using ApplicationContext db = new ApplicationContext();
           var verificationJournal = new VerificationJournal
           {
               ID = verificationJournalDto.Id,
               Device = db.Devices.FirstOrDefault(x => x.Id == device.Id),
               Organization = verificationJournalDto.Organization,
               IsDone = false,
               VerificationDate = verificationJournalDto.VerificationDate
           };
           db.VerificationJournals.Add(verificationJournal);
           db.SaveChanges();
       }

        public IEnumerable<DeviceDto> GetAllDevices()
        {
            using ApplicationContext db = new ApplicationContext();
            var mapService = new MapService();
            return db.Devices
                .Include(u => u.Type)
                .Include(u => u.Status)
                .Include(u => u.OwnerUser)
                .Select(x => mapService.MapToDeviceDto(x)).ToList();

        }

        public IEnumerable<DeviceDto> GetAllDevicesForUser()
        {
            var unacceptedDeviceIds = GetUnacceptedDevicesForCurrentUser();
            return GetAllDevices().Where(x => x.OwnerUser?.ID == LoginService.CurrentUser.ID || unacceptedDeviceIds.Contains(x.Id)).ToArray();

        }

        private int[] GetUnacceptedDevicesForCurrentUser()
        {
            using ApplicationContext db = new ApplicationContext();
            var TransferLogs = db.TransferLog
                .Include(x =>x.Device)
                .Include(x => x.UserTo).ToList();
            return TransferLogs.Where(x => x.Accepted == false && x.UserTo.ID == LoginService.CurrentUser.ID).Select(x => x.Device.Id).ToArray();
        }

        public IEnumerable<DeviceType> GetDeviceTypes()
        {
            using ApplicationContext db = new ApplicationContext();
            return db.DeviceTypes.ToList();
        }

        public List<Location> GetAllLocations()
        {
            using ApplicationContext db = new ApplicationContext();
            return db.Location.ToList();
        }

        public List<Organization> GetAllOrganizations()
        {
            using ApplicationContext db = new ApplicationContext();
            return db.Organizations.ToList();
        }
        public DeviceType GetDeviceTypeById(int id)
        {
            using ApplicationContext db = new ApplicationContext();
            return db.DeviceTypes.FirstOrDefault(x => x.ID == id);
        }

        public void SetOwner(int deviceId, int userId)
        {
            using ApplicationContext db = new ApplicationContext();
            var device = db.Devices.FirstOrDefault(x => x.Id == deviceId);
            if (device == null)
            {
                return;
            }

            device.OwnerUser = db.Users.FirstOrDefault(x => x.ID == userId);
            db.Devices.Update(device);
            db.SaveChanges();
        }
    }
}
