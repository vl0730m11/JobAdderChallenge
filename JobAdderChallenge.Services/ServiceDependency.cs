using Autofac;
using JobAdderChallenge.Services.JobAdderService;
using JobAdderChallenge.Services.RecruitmentService;

namespace JobAdderChallenge.Services
{
    public static class ServiceDependency
    {
        public static void Register(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<JobAdderService.JobAdderService>().As<IJobAdderService>().InstancePerRequest();
            containerBuilder.RegisterType<RecruitmentService.RecruitmentService>().As<IRecruitmentService>().InstancePerRequest();
        }
    }
}
