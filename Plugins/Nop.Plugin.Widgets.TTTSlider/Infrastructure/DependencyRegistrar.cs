using Autofac;
using Autofac.Core;
using Nop.Core.Configuration;
using Nop.Core.Data;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Data;
using Nop.Web.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Widgets.TTTSlider.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        private const string CONTEXT_NAME = "nop_object_context_ttt_slider";
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            builder.RegisterType<Services.TTTSliderService>().As<Services.ITTTSliderService>().InstancePerLifetimeScope();
            //data context
            this.RegisterPluginDataContext<Data.TTTSliderContext>(builder, CONTEXT_NAME);
            //override required repository with our custom context
            builder.RegisterType<EfRepository<Domain.TTTSlider>>()
            .As<IRepository<Domain.TTTSlider>>()
            .WithParameter(ResolvedParameter.ForNamed<IDbContext>(CONTEXT_NAME))
            .InstancePerLifetimeScope();
        }
        public int Order
        {
            get { return 1; }
        }
    }
}
