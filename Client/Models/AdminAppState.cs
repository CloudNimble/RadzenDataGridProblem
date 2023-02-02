using CloudNimble.BlazorEssentials;
using CloudNimble.BlazorEssentials.Navigation;
using CloudNimble.EasyAF.Configuration;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RadzenGridProblem.Client.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class AdminAppState : AppStateBase
    {

        #region Private Members

        private readonly ConfigurationBase config;

        private bool disposedValue;

        #endregion

        #region Properties

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="navigationManager"></param>
        /// <param name="httpClientFactory"></param>
        /// <param name="jsRuntime"></param>
        /// <param name="hostEnvironment"></param>
        /// <param name="config"></param>
        /// <param name="oDataClient"></param>
        public AdminAppState(NavigationManager navigationManager, IHttpClientFactory httpClientFactory, IJSRuntime jsRuntime, IWebAssemblyHostEnvironment hostEnvironment, ConfigurationBase config)
            : base(navigationManager, httpClientFactory, jsRuntime, hostEnvironment)
        {
            this.config = config;
            var nav = new List<NavigationItem>
            {
                new NavigationItem("Dashboard",     "fad fa-fw fa-desktop",     "",     "System",       true,   "Dashboard",    "fad fa-fw fa-2x fa-desktop",   "admin"),
            };
            LoadNavItems(nav);

            //this.PropertyChanged += AdminAppState_PropertyChanged;
        }

        #endregion

        #region Event Handlers

        //private void AdminAppState_PropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    switch (e.PropertyName)
        //    {
        //        //case nameof(ClaimsPrincipal):
        //        //    if (ClaimsPrincipal is null) return;
        //        //    _ = Load();
        //        //    break;
        //    }
        //    StateHasChangeAction();
        //}

        #endregion

        #region Public Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public async Task Load()
        {
            LoadingStatus = LoadingStatus.Loading;

            LoadingStatus = LoadingStatus.Loaded;
        }

        #endregion

        #region IDisposable

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (!disposedValue)
            {
                if (disposing)
                {
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        #endregion

    }

}
