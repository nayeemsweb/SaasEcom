using Autofac;
using EcommerceSubDomain.Worker.HostFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceSubDomain.Worker
{
    internal class WorkerModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HostFile>().AsSelf();

            base.Load(builder);
        }
    }
}
