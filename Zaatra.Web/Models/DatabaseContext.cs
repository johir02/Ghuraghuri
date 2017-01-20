using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Zaatra.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("DefaultConnection")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Package> Packages { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<PackageIncludes> PackageIncludeses { get; set; }
        public DbSet<PolicyCondition> PackageConditions { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<ExtraCharge> ExtraCharges { get; set; }
        public DbSet<ChargeType> ChargeTypes { get; set; }
        public DbSet<DayDescription> DayDescriptions { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PackageTag> PackageTags { get; set; }
        public DbSet<PackageImage> PackageImages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Roles> Roleses { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<TagCategory> TagCategories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<VisaInformation> VisaInformations { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<HotelServices> HotelServices { get; set; }
        public DbSet<HotelPolicy> HotelPolicies { get; set; }
        public DbSet<RoomFacilityRelation> RoomFacilityRelations { get; set; }
        public DbSet<HotelImage> HotelImages { get; set; }
        public DbSet<PackageBooking> PackageBookings { get; set; }
        public DbSet<AirTicket> AirTickets { get; set; }
        public DbSet<TicketPersonalInfo> TicketPersonalInfos { get; set; }
        public DbSet<HotelRoomBooking> HotelRoomBookings { get; set; }
    }
}