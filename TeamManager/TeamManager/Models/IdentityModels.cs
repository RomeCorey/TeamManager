﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TeamManager.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<TeamManager.Models.Player> Players { get; set; }

        public System.Data.Entity.DbSet<TeamManager.Models.Coach> Coaches { get; set; }

        public System.Data.Entity.DbSet<TeamManager.Models.TeamPractice> TeamPractices { get; set; }

        public System.Data.Entity.DbSet<TeamManager.Models.Tournament> Tournaments { get; set; }

        public System.Data.Entity.DbSet<TeamManager.Models.TeamMeeting> TeamMeetings { get; set; }

        public System.Data.Entity.DbSet<TeamManager.Models.TeamDinner> TeamDinners { get; set; }

        public System.Data.Entity.DbSet<TeamManager.Models.ScoutingEvent> ScoutingEvents { get; set; }

        public System.Data.Entity.DbSet<TeamManager.Models.CoachPayment> CoachPayments { get; set; }

        public System.Data.Entity.DbSet<TeamManager.Models.Events> Events { get; set; }

        public System.Data.Entity.DbSet<TeamManager.Models.CoachNotes> CoachNotes { get; set; }
    }
}