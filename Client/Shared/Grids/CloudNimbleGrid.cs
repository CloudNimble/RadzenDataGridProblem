using CloudNimble.EasyAF.Core;
using System;

namespace RadzenGridProblem.Client.Shared.Grids
{

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <remarks>RWM: Generic type constraints have to be specified in partial classes.</remarks>
    public partial class CloudNimbleGrid<TItem> where TItem: IIdentifiable<Guid>
    {
    }

}
