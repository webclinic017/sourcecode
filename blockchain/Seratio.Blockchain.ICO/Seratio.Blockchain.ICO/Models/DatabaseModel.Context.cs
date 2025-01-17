﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Seratio.Platform.ICO.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseEntities : DbContext
    {
        public DatabaseEntities()
            : base("name=DatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AcceptedRetailPolicy> AcceptedRetailPolicies { get; set; }
        public virtual DbSet<AcceptedSocialActivity> AcceptedSocialActivities { get; set; }
        public virtual DbSet<ActivityNotification> ActivityNotifications { get; set; }
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<AdministratorSession> AdministratorSessions { get; set; }
        public virtual DbSet<Blockchain> Blockchains { get; set; }
        public virtual DbSet<Coin> Coins { get; set; }
        public virtual DbSet<ExchangeRate> ExchangeRates { get; set; }
        public virtual DbSet<FailedForgotPasswordAttempt> FailedForgotPasswordAttempts { get; set; }
        public virtual DbSet<FailedSignInAttempt> FailedSignInAttempts { get; set; }
        public virtual DbSet<FailedWalletTransactionAttempt> FailedWalletTransactionAttempts { get; set; }
        public virtual DbSet<Investment> Investments { get; set; }
        public virtual DbSet<MCRTokenInvestment> MCRTokenInvestments { get; set; }
        public virtual DbSet<MCRTokenTransfer> MCRTokenTransfers { get; set; }
        public virtual DbSet<ModuleAccessRequest> ModuleAccessRequests { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RetailPolicy> RetailPolicies { get; set; }
        public virtual DbSet<SERTokenInvestment> SERTokenInvestments { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<SocialActivity> SocialActivities { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserSession> UserSessions { get; set; }
        public virtual DbSet<UserWalletHistory> UserWalletHistories { get; set; }
        public virtual DbSet<WalletTransaction> WalletTransactions { get; set; }
    }
}
