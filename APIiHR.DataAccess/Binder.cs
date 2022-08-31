using APIiHR.DataAccess.DataAccess.Implementations;
using APIiHR.DataAccess.DataAccess.Interfaces;
using APIiHR.DataAccess.DatabaseContexts;
using APIiHR.DataAccess.Repositories.Implementations;
using APIiHR.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;


namespace APIiHR.DataAccess
{
    public static class Binder
    {
        public static void Setup(IServiceCollection services, IConfiguration config)
        {
            services.AddTransient<IAuthenRespository, AuthenRespository>();
            services.AddTransient<IAuthenDataAccess, AuthenDataAccess>();

            services.AddTransient<IReqotRespository, ReqotRespository>();
            services.AddTransient<IReqotDataAccess, ReqotDataAccess>();

            services.AddTransient<IReqleaveRespository, ReqleaveRespository>();
            services.AddTransient<IReqleaveDataAccess, ReqleaveDataAccess>();

            services.AddTransient<IReqchgshiftRespository, ReqchgshiftRespository>();
            services.AddTransient<IReqchgshiftDataAccess, ReqchgshiftDataAccess>();

            services.AddTransient<IReqattdRespository, ReqattdRespository>();
            services.AddTransient<IReqattdDataAccess, ReqattdDataAccess>();

            services.AddTransient<IReqinfoRespository, ReqinfoRespository>();
            services.AddTransient<IReqinfoDataAccess, ReqinfoDataAccess>();

            services.AddTransient<ISysleavetypeRespository, SysleavetypeRespository>();
            services.AddTransient<ISysleavetypeDataAccess, SysleavetypeDataAccess>();

            services.AddTransient<ISysfileessRespository, SysfileessRespository>();
            services.AddTransient<ISysfileessDataAccess, SysfileessDataAccess>();

            services.AddTransient<IWorkflowmasterRespository, WorkflowmasterRespository>();
            services.AddTransient<IWorkflowmasterDataAccess, WorkflowmasterDataAccess>();

            services.AddTransient<ISysmtappRespository, SysmtappRespository>();
            services.AddTransient<ISysmtappDataAccess, SysmtappDataAccess>();

            services.AddTransient<ISysmtapp_workerRespository, Sysmtapp_workerRespository>();
            services.AddTransient<ISysmtapp_workerDataAccess, Sysmtapp_workerDataAccess>();

            services.AddTransient<ISysinfo_addRespository, Sysinfo_addRespository>();
            services.AddTransient<ISysinfo_addDataAccess, Sysinfo_addDataAccess>();

            services.AddTransient<ISysinfo_cardRespository, Sysinfo_cardRespository>();
            services.AddTransient<ISysinfo_cardDataAccess, Sysinfo_cardDataAccess>();

            services.AddTransient<IWorkflowtranRespository, WorkflowtranRespository>();
            services.AddTransient<IWorkflowtranDataAccess, WorkflowtranDataAccess>();

            services.AddTransient<IFilemanagerRespository, FilemanagerRespository>();
            services.AddTransient<IFilemanagerDataAccess, FilemanagerDataAccess>();

            services.AddTransient<IPdpaformRespository, PdpaformRespository>();
            services.AddTransient<IPdpaformDataAccess, PdpaformDataAccess>();

            services.AddTransient<ICertfRespository, CertfRespository>();
            services.AddTransient<ICertfDataAccess, CertfDataAccess>();

            services.AddTransient<IApptransRespository, ApptransRespository>();
            services.AddTransient<IApptransDataAccess, ApptransDataAccess>();

            services.AddTransient<ISysmtapp_routeRespository, Sysmtapp_routeRespository>();
            services.AddTransient<ISysmtapp_routeDataAccess, Sysmtapp_routeDataAccess>();

            services.AddTransient<ISysmttaskRespository, SysmttaskRespository>();
            services.AddTransient<ISysmttaskDataAccess, SysmttaskDataAccess>();

            services.AddTransient<ISysmttask_lineRespository, Sysmttask_lineRespository>();
            services.AddTransient<ISysmttask_lineDataAccess, Sysmttask_lineDataAccess>();

            services.AddTransient<ICheckinRespository, CheckinRespository>();
            services.AddTransient<ICheckinDataAccess, CheckinDataAccess>();

            services.AddTransient<ISysinfo_contactRespository, Sysinfo_contactRespository>();
            services.AddTransient<ISysinfo_contactDataAccess, Sysinfo_contactDataAccess>();

            services.AddTransient<ICheckinpoiRespository, CheckinpoiRespository>();
            services.AddTransient<ICheckinpoiDataAccess, CheckinpoiDataAccess>();

            services.AddTransient<IWorkflowtranlogRespository, WorkflowtranlogRespository>();
            services.AddTransient<IWorkflowtranlogDataAccess, WorkflowtranlogDataAccess>();

            services.AddTransient<ITeammasterRespository, TeammasterRespository>();
            services.AddTransient<ITeammasterDataAccess, TeammasterDataAccess>();

            services.AddTransient<ITeamlineRespository, TeamlineRespository>();
            services.AddTransient<ITeamlineDataAccess, TeamlineDataAccess>();

            services.AddTransient<ISysmodulenoRespository, SysmodulenoRespository>();
            services.AddTransient<ISysmodulenoDataAccess, SysmodulenoDataAccess>();

            services.AddTransient<ISyslogininfoRespository, SyslogininfoRespository>();
            services.AddTransient<ISyslogininfoDataAccess, SyslogininfoDataAccess>();

            services.AddTransient<ISysmttask_linechkRespository, Sysmttask_linechkRespository>();
            services.AddTransient<ISysmttask_linechkDataAccess, Sysmttask_linechkDataAccess>();

            services.AddTransient<ISyslocationRespository, SyslocationRespository>();
            services.AddTransient<ISyslocationDataAccess, SyslocationDataAccess>();

            services.AddTransient<ISysuserempRespository, SysuserempRespository>();
            services.AddTransient<ISysuserempDataAccess, SysuserempDataAccess>();

            var connStr = config.GetConnectionString("ConnDB");
            services.AddDbContextPool<tbMTWebUserContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<tbMTEmpMainContext>(options => options.UseSqlServer(connStr));

            services.AddDbContextPool<DbReqotContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbReqleaveContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbReqchgshiftContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbReqattdContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbReqinfoContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbSysleavetypeContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbSysfileessContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbWorkflowmasterContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbSysmtappContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbSysmtapp_workerContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbSysinfo_addContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbSysinfo_cardContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbWorkflowtranContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbFilemanagerContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbPdpaformContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbCertfContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbApptransContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbSysmtapp_routeContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbSysmttaskContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbSysmttask_lineContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbCheckinContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbSysinfo_contactContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbCheckinpoiContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbWorkflowtranlogContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbTeammasterContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbTeamlineContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbSysmodulenoContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbSyslogininfoContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbSysmttask_linechkContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbSyslocationContext>(options => options.UseSqlServer(connStr));
            services.AddDbContextPool<DbSysuserempContext>(options => options.UseSqlServer(connStr));
        }
    }
}

