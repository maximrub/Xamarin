using Android.Content;
using Exrin.IOC;
using Friends.Domain.Peoples.Interfaces;
using Friends.Domain.Phone.Interfaces;
using Friends.Droid.Infrastructure.Phone.Services;
using LightInject;
using Microsoft.Extensions.DependencyInjection;
using Xamarin.FileStorage.Abstractions;
using Xamarin.FileStorage.Android;

namespace Friends.Droid
{
    public class AndroidInitializer : PlatformInitializer
    {
        protected override void Register(ServiceContainer i_Container)
        {
            base.Register(i_Container);
            i_Container.Register<IPhoneDialer, PhoneDialer>();
            i_Container.Register<IFileStorage, FileStorage>();
        }

        protected override void ConfigureServices(IServiceCollection i_Services)
        {
            base.ConfigureServices(i_Services);
        }

        protected override void OnInitialized(ServiceContainer i_Container)
        {
            base.OnInitialized(i_Container);
        }
    }
}