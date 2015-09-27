using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

namespace Popup.Dictionairy.OData
{
    public class CourseDataService : DataService<CourseDbEntities>
    {
       
        public static void InitializeService(DataServiceConfiguration config)
        {       
            config.SetEntitySetAccessRule("Courses", EntitySetRights.All); 
            config.SetEntitySetAccessRule("Questions", EntitySetRights.All); 
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
        }
    }
}
