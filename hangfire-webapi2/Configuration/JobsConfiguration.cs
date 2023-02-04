using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using hangfire_webapi2.Jobs;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace hangfire_webapi2.Configuration
{
    public static class JobsConfiguration
    {
        public static void ConfigureHandFireJobs(this IApplicationBuilder app)
        {
            try
            {
                var appsettings = app.ApplicationServices.GetRequiredService<IConfiguration>();
                //var setting = appsettings.GetSection("JobSettings").Get<JobSettings>();

                RecurringJob.RemoveIfExists(nameof(PrimerJob));
                RecurringJob.AddOrUpdate<IPrimerJob>(nameof(PrimerJob), job => job.Run(JobCancellationToken.Null), "0 */3 * * *", TimeZoneInfo.Local);

            }
            catch (Exception ex)
            {

            }

        }
    }
}
