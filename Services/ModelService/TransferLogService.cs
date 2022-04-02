using Metrology.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Metrology.Models.Dtos;

namespace Metrology.Services.ModelService
{
    public class TransferLogService
    {
        private static TransferLogService instance;
        private readonly DeviceService _deviceService;

        private TransferLogService()
        {
            _deviceService = new DeviceService();
        }

        public static TransferLogService GetInstance()
        {
            if (instance == null)
                instance = new TransferLogService();
            return instance;
        }
        public void HandOverDeviceWithAccept(long deviceId, long userToId, string note = "")
        {

            using ApplicationContext db = new ApplicationContext();
            var device = db.Devices.FirstOrDefault(x => x.Id == deviceId);
            var userFrom = db.Users.FirstOrDefault(x => x.ID == LoginService.CurrentUser.ID); 
            var userTo = db.Users.FirstOrDefault(x => x.ID == userToId);

            db.TransferLog.Add( new TransferLog()
            {
                Device = device,
                UserFrom = userFrom,
                UserTo = userTo,
                Note = note,
                TransferDate = DateTime.Now,
                Accepted = false,
                AcceptedDate = DateTime.Now,
            });
            db.SaveChanges();
        }
        public TransferLogDto GetLastTransferLogDtoBy(int deviceId)
        {
            using ApplicationContext db = new ApplicationContext();
            var mapService = new MapService();
            return db.TransferLog
                .Include(x => x.Device)
                .Include(x => x.UserTo)
                .Include(x => x.UserFrom)
                .Where(d => d.Device.Id == deviceId).OrderByDescending(t => t.ID).Select(x => mapService.MapToTransferLogDto(x)).FirstOrDefault();
        }

        public void CancelActualTransfer(int deviceId)
        {
            using ApplicationContext db = new ApplicationContext();
            var transferLog = db.TransferLog
                .Include(x => x.Device)
                .Where(d => d.Device.Id == deviceId).OrderByDescending(t => t.ID)
                .FirstOrDefault();
            if (transferLog == null)
            {
                return;
            }
            db.Remove<TransferLog>(transferLog);
            db.SaveChanges();
        }

        public void ReceiveActualTransfer(int selectedDeviceId)
        {
            using ApplicationContext db = new ApplicationContext();
            var transferLog = GetTransferLogByDeviceId(selectedDeviceId);
            if (transferLog == null)
            {
                return;
            }

            transferLog.Accepted = true;
            db.TransferLog.Update(transferLog);
            db.SaveChanges();
            
            _deviceService.SetOwner(selectedDeviceId, LoginService.CurrentUser.ID);
        }

        private TransferLog GetTransferLogByDeviceId(int deviceId)
        {
            using ApplicationContext db = new ApplicationContext();
            return db.TransferLog
                .Include(x => x.Device).Where(x => x.Device.Id == deviceId).OrderByDescending(x => x.ID).FirstOrDefault();
        }
    }
}
