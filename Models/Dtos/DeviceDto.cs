using System;

namespace Metrology.Models.Dtos
{
    public class DeviceDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DeviceType Type { get; set; }
        public DateTime DeviceDate { get; set; }
        public DateTime DateExplotationStart { get; set; }
        public DateTime DateExplotationEnd { get; set; }
        public string SerialNumber { get; set; }
        public Location Location { get; set; }
        public PresenceStatus Status { get; set; }
        public User OwnerUser { get; set; }
        public string FullDeviceName { get => Name + " - " + SerialNumber; }
    }
}