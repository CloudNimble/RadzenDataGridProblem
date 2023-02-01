using RadzenGridProblem.Client.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace RadzenGridProblem.Core
{

    /// <summary>
    /// 
    /// </summary>
    public partial class Company : IIdentifiable<Guid>
    {
    
        #region Private Members
        
        private string _city;
        private string _companyName;
        private string _corporationName;
        private string _country;
        private Guid _createdById;
        private Nullable<long> _crunchbaseId;
        private DateTimeOffset _dateCreated;
        private Nullable<DateTimeOffset> _dateUpdated;
        private string _graphColor;
        private Guid _id;
        private string _logoUrl;
        private Nullable<Guid> _partnerContactId;
        private string _partnerId;
        private string _state;
        private Nullable<Guid> _updatedById;
       
        #endregion
        
        #region Public Properties
        
        /// <summary>
        /// 
        /// </summary>
        public Guid Id { get; set; } 
        
        /// <summary>
        /// 
        /// </summary>
        public Nullable<long> CrunchbaseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(30)]
        public string PartnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Nullable<Guid> PartnerContactId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(50)]
        public string CompanyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(50)]
        public string CorporationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(50)]
        public string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(25)]
        public string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(10)]
        public string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(100)]
        public string LogoUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [StringLength(7)]
        public string GraphColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid CreatedById { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTimeOffset DateCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Nullable<Guid> UpdatedById { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Nullable<DateTimeOffset> DateUpdated { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public Company()
        {
        }
        
        #endregion
        
    }
    
}
