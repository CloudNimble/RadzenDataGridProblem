namespace RadzenGridProblem.Core
{

    public partial class Company
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="companyName"></param>
        /// <param name="corporationName"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="country"></param>
        public Company(string companyName, string corporationName, string city, string state, string country)
        {
            CompanyName = companyName;
            CorporationName = corporationName;
            City = city;
            State = state;
            Country = country;
        }

    }

}
