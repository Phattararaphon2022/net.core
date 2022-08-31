using APIiHR.Business.Managers.Implementations;
using APIiHR.Business.Managers.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;


namespace APIiHR.Business
{
    public static class Binder
    {
        public static void Setup(IServiceCollection services)
        {
           
            services.AddTransient<IReqotManager, ReqotManager>();
            services.AddTransient<IReqleaveManager, ReqleaveManager>();
            services.AddTransient<IReqchgshiftManager, ReqchgshiftManager>();
            services.AddTransient<IReqattdManager, ReqattdManager>();
            services.AddTransient<IReqinfoManager, ReqinfoManager>();
            services.AddTransient<ISysleavetypeManager, SysleavetypeManager>();
            services.AddTransient<ISysfileessManager, SysfileessManager>();
            services.AddTransient<IWorkflowmasterManager, WorkflowmasterManager>();
            services.AddTransient<ISysmtappManager, SysmtappManager>();
            services.AddTransient<ISysmtapp_workerManager, Sysmtapp_workerManager>();
            services.AddTransient<ISysinfo_addManager, Sysinfo_addManager>();
            services.AddTransient<ISysinfo_cardManager, Sysinfo_cardManager>();
            services.AddTransient<IWorkflowtranManager, WorkflowtranManager>();
            services.AddTransient<IFilemanagerManager, FilemanagerManager>();
            services.AddTransient<IPdpaformManager, PdpaformManager>();
            services.AddTransient<ICertfManager, CertfManager>();
            services.AddTransient<IApptransManager, ApptransManager>();
            services.AddTransient<ISysmtapp_routeManager, Sysmtapp_routeManager>();
            services.AddTransient<ISysmttaskManager, SysmttaskManager>();
            services.AddTransient<ISysmttask_lineManager, Sysmttask_lineManager>();
            services.AddTransient<ICheckinManager, CheckinManager>();
            services.AddTransient<ISysinfo_contactManager, Sysinfo_contactManager>();
            services.AddTransient<ICheckinpoiManager, CheckinpoiManager>();
            services.AddTransient<IWorkflowtranlogManager, WorkflowtranlogManager>();
            services.AddTransient<ITeammasterManager, TeammasterManager>();
            services.AddTransient<ITeamlineManager, TeamlineManager>();
            services.AddTransient<ISysmodulenoManager, SysmodulenoManager>();
            services.AddTransient<ISyslogininfoManager, SyslogininfoManager>();
            services.AddTransient<ISysmttask_linechkManager, Sysmttask_linechkManager>();
            services.AddTransient<ISyslocationManager, SyslocationManager>();
            services.AddTransient<ISysuserempManager, SysuserempManager>();

        }
    }
}
