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
        
        public UserDto MapToUserDto(User user)
        {
            return new UserDto
            {
                ID = user.ID,
                Name = user.Name,
                Surname = user.Surname,
                PatrName = user.PatrName,
                Email = user.Email,
                BirthDay = user.BirthDay,
                RegistrationDate = user.RegistrationDate,
                Phone = user.Phone,
                Role = user.Role
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
                OwnerUser = device.OwnerUser,
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

        public TransferLogDto MapToTransferLogDto(TransferLog transferLog)
        {
           return new TransferLogDto
           {
               ID = transferLog.ID,
               UserFrom = transferLog.UserFrom,
               UserTo = transferLog.UserTo,
               Device = transferLog.Device,
               Accepted = transferLog.Accepted != null && transferLog.Accepted.Value,
               TransferDate = transferLog.TransferDate,
               AcceptedDate = transferLog.AcceptedDate,
               Note = transferLog.Note
           };
        }

        public VerificationJournalDto MapToVerificationJournalDto(VerificationJournal verificationJournal)
        {
            return new VerificationJournalDto
            {
                Id = verificationJournal.ID,
                Device = verificationJournal.Device,
                Organization = verificationJournal.Organization,
                IsDone = verificationJournal.IsDone,
                VerificationDate = verificationJournal.VerificationDate
            };
        }
        
    }
}
