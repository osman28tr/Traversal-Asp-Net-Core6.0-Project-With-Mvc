using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ICommentService, CommentManager>();
            serviceCollection.AddScoped<ICommentDal, EfCommentDal>();
            serviceCollection.AddScoped<IDestinationService, DestinationManager>();
            serviceCollection.AddScoped<IDestinationDal, EfDestinationDal>();
            serviceCollection.AddScoped<IAppUserService, AppUserManager>();
            serviceCollection.AddScoped<IAppUserDal, EfAppUserDal>();
            serviceCollection.AddScoped<IReservationService, ReservationManager>();
            serviceCollection.AddScoped<IReservationDal, EfReservationDal>();
        }
    }
}
