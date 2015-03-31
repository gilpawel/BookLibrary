using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using BookLibrary.DataAccess.Concrete.Interface;
using BookLibrary.DataAccess.Concrete;

namespace BookLibrary.Infrastracture
{
    public class NInjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NInjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            this.ninjectKernel.Bind<IUnityOfWork>().To<UnityOfWork>().InSingletonScope();
        }

    }
}