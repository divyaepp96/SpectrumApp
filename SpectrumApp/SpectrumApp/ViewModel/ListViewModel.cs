using SpectrumApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpectrumApp.ViewModel
{
    public class ListViewModel : BaseViewModel
    {
        #region Public Properties
        public List<Sheet> Timesheets
        {
            get { return timesheets; }
            set { SetProperty(ref timesheets, value); }
        }

        #endregion

        #region Private Properties
        private List<Sheet> timesheets;

        #endregion
        public ListViewModel()
        {
            FillData();
        }

        public void FillData()
        {
            Timesheets = new List<Sheet>()
            {
                new Sheet(){Id=1, Address="104th Ave SE, Kent, WA", Price=50.00, JobStartTime=DateTime.Now, BreakStartTime=DateTime.Now.AddHours(4), BreakEndTime=DateTime.Now.AddHours(5), JobEndTime=DateTime.Now.AddHours(9) },
                new Sheet(){Id=2, Address="24 South Cicero Avenue, Chicago, IL", Price=50.00, JobStartTime=DateTime.Now, BreakStartTime=DateTime.Now.AddHours(4), BreakEndTime=DateTime.Now.AddHours(5), JobEndTime=DateTime.Now.AddHours(9) },
                new Sheet(){Id=3, Address="54 Front Street North, Issaquah, WA", Price=50.00, JobStartTime=DateTime.Now, BreakStartTime=DateTime.Now.AddHours(4), BreakEndTime=DateTime.Now.AddHours(5), JobEndTime=DateTime.Now.AddHours(9) },
                new Sheet(){Id=4, Address="23rd Avenue South, Kansas, KS", Price=50.00, JobStartTime=DateTime.Now, BreakStartTime=DateTime.Now.AddHours(4), BreakEndTime=DateTime.Now.AddHours(5), JobEndTime=DateTime.Now.AddHours(9) },
                new Sheet(){Id=5, Address="1432 Piedmont Aveneue NE, Atlanta, GA", Price=50.00, JobStartTime=DateTime.Now, BreakStartTime=DateTime.Now.AddHours(4), BreakEndTime=DateTime.Now.AddHours(5), JobEndTime=DateTime.Now.AddHours(9) },
                new Sheet(){Id=6, Address="North McDonnell Road, San Francisco, CA", Price=50.00, JobStartTime=DateTime.Now, BreakStartTime=DateTime.Now.AddHours(4), BreakEndTime=DateTime.Now.AddHours(5), JobEndTime=DateTime.Now.AddHours(9) },
                new Sheet(){Id=7, Address="1234 La Canada St,Las Vegas, NV", Price=50.00, JobStartTime=DateTime.Now, BreakStartTime=DateTime.Now.AddHours(4), BreakEndTime=DateTime.Now.AddHours(5), JobEndTime=DateTime.Now.AddHours(9) },
                new Sheet(){Id=8, Address="115 SE Ave, Houstan, TX", Price=50.00, JobStartTime=DateTime.Now, BreakStartTime=DateTime.Now.AddHours(4), BreakEndTime=DateTime.Now.AddHours(5), JobEndTime=DateTime.Now.AddHours(9) },
            };
        }
    }
}
