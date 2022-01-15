using JobAdderChallenge.Services.JobAdderService;
using JobAdderChallenge.Services.RecruitmentService;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace JobAdderChallenge
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IJobAdderService, JobAdderService>();
            container.RegisterType<IRecruitmentService, RecruitmentService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}