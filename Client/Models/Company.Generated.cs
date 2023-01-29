using CloudNimble.EasyAF.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace RadzenGridProblem.Core
{

    /// <summary>
    /// 
    /// </summary>
    public partial class Company : DbObservableObject, IIdentifiable<Guid>, ICreatedAuditable, ICreatorTrackable<Guid>, IUpdatedAuditable, IUpdaterTrackable<Guid>
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
        public Guid Id
        {
            get => _id;
            set => Set(() => Id, ref _id, value);
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Nullable<long> CrunchbaseId
        {
            get => _crunchbaseId;
            set => Set(() => CrunchbaseId, ref _crunchbaseId, value);
        }
        
        /// <summary>
        /// 
        /// </summary>
        [StringLength(30)]
        public string PartnerId
        {
            get => _partnerId;
            set => Set(() => PartnerId, ref _partnerId, value);
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Nullable<Guid> PartnerContactId
        {
            get => _partnerContactId;
            set => Set(() => PartnerContactId, ref _partnerContactId, value);
        }
        
        /// <summary>
        /// 
        /// </summary>
        [StringLength(50)]
        public string CompanyName
        {
            get => _companyName;
            set => Set(() => CompanyName, ref _companyName, value);
        }
        
        /// <summary>
        /// 
        /// </summary>
        [StringLength(50)]
        public string CorporationName
        {
            get => _corporationName;
            set => Set(() => CorporationName, ref _corporationName, value);
        }
        
        /// <summary>
        /// 
        /// </summary>
        [StringLength(50)]
        public string City
        {
            get => _city;
            set => Set(() => City, ref _city, value);
        }
        
        /// <summary>
        /// 
        /// </summary>
        [StringLength(25)]
        public string State
        {
            get => _state;
            set => Set(() => State, ref _state, value);
        }
        
        /// <summary>
        /// 
        /// </summary>
        [StringLength(10)]
        public string Country
        {
            get => _country;
            set => Set(() => Country, ref _country, value);
        }
        
        /// <summary>
        /// 
        /// </summary>
        [StringLength(100)]
        public string LogoUrl
        {
            get => _logoUrl;
            set => Set(() => LogoUrl, ref _logoUrl, value);
        }
        
        /// <summary>
        /// 
        /// </summary>
        [StringLength(7)]
        public string GraphColor
        {
            get => _graphColor;
            set => Set(() => GraphColor, ref _graphColor, value);
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Guid CreatedById
        {
            get => _createdById;
            set => Set(() => CreatedById, ref _createdById, value);
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DateTimeOffset DateCreated
        {
            get => _dateCreated;
            set => Set(() => DateCreated, ref _dateCreated, value);
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Nullable<Guid> UpdatedById
        {
            get => _updatedById;
            set => Set(() => UpdatedById, ref _updatedById, value);
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Nullable<DateTimeOffset> DateUpdated
        {
            get => _dateUpdated;
            set => Set(() => DateUpdated, ref _dateUpdated, value);
        }
        
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
