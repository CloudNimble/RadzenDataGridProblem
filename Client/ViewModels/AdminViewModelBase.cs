using CloudNimble.BlazorEssentials;
using CloudNimble.EasyAF.Configuration;
using CloudNimble.EasyAF.Core;
using Microsoft.AspNetCore.Components;
using Radzen;
using RadzenGridProblem.Client.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RadzenGridProblem.Client.ViewModels
{

    /// <summary>
    /// Base class for all view models in the admin tool.
    /// </summary>
    public class AdminViewModelBase<T> : ViewModelBase<ConfigurationBase, AdminAppState> where T : IIdentifiable<Guid>
    {

        #region Private Members

        readonly JsonSerializerOptions _serializerOptions = new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, PropertyNamingPolicy = null };
        private T _selectedItem;

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public List<T> Entities { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public NotificationService NotificationService { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public int PageSize { get; set; } = 20;

        /// <summary>
        /// 
        /// </summary>
        public int ResultCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public T SelectedItem 
        {
            get => _selectedItem;
            set => Set(() => SelectedItem, ref _selectedItem, value);
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="notificationService"></param>
        /// <param name="navigationManager"></param>
        /// <param name="configuration"></param>
        /// <param name="appState"></param>
        /// <param name="httpClientFactory"></param>
        /// <param name="apiClient"></param>
        public AdminViewModelBase(NotificationService notificationService, NavigationManager navigationManager, IHttpClientFactory httpClientFactory,
                    ConfigurationBase configuration, AdminAppState appState)
            : base(navigationManager, httpClientFactory, configuration, appState)
        {
            Entities = new List<T>();
            NotificationService = notificationService;
            PropertyChanged += AdminViewModelBase_PropertyChanged;
        }

        private void AdminViewModelBase_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(LoadingStatus):
                    StateHasChanged.Action();
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual async Task Load(bool reload = false)
        {
            if (Entities.Count == 0 || reload)
            {
                LoadingStatus = LoadingStatus.Loading;
                //if (reload)
                //{
                //    Entities.Clear();
                //}

                await Task.Delay(2500);

                ResultCount = Entities.Count;
                LoadingStatus = LoadingStatus.Loaded;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void AddNew(T entity)
        {
            //Entities.Insert(0, entity);
            //Entities = Entities.ToList(); // Update the reference so the DataGrid refreshes its cache
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public virtual async Task Save(T entity)
        {
            var notification = new NotificationMessage
            {
                Duration = 4000
            };

            await Task.Delay(2500);

            notification.Severity = NotificationSeverity.Success;
            notification.Summary = $"{nameof(T)} {entity.Id} was {(entity.Id == Guid.Empty ? "added" : "updated")}.";
            NotificationService.Notify(notification);

            await Load(true).ConfigureAwait(false);

            StateHasChanged.Action();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<bool> Delete(T entity)
        {
            var notification = new NotificationMessage
            {
                Duration = 4000
            };

            await Task.Delay(2500);

            Entities.Remove(entity);
            notification.Severity = NotificationSeverity.Success;
            notification.Summary = $"{nameof(T)} {entity.Id} was deleted.";
            NotificationService.Notify(notification);

            StateHasChanged.Action();
            return true;
        }

    }

}
