using Hangfire;
using Hangfire.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hangfire_webapi2.Jobs
{
    public class PrimerJob : IPrimerJob
    {
        private readonly ILog _logger;

        public PrimerJob(ILog logger)
        {
            this._logger = logger;
        }

        public async Task Run(IJobCancellationToken token)
        {
            await Task.Yield();
            token.ThrowIfCancellationRequested();
            PrimerMetodoJob();
        }

        public void PrimerMetodoJob()
        {
            //enviosSmsAutogestionBL.EnviosSmsAutogestionReclamo();
        }

    }
}
