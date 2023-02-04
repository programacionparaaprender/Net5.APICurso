using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hangfire_webapi2.Jobs
{
    interface IPrimerJob
    {
        [AutomaticRetry(Attempts = 0)]
        Task Run(IJobCancellationToken token);
        void PrimerMetodoJob();
    }
}
