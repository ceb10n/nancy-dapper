using nancy_dapper.App.Service;

namespace nancy_dapper.Modules
{
    public class HomeModule : Nancy.NancyModule
    {
        public HomeModule(MusicService service)
        {
            Get["/"] = parameters =>
            {
                return View["Index", service.All()];
            };
        }
    }
}