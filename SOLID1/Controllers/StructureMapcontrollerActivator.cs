using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SOLID1.Controllers
{
    public class StructureMapControllerActivator : IControllerActivator
    {
        private IContainer _container;

        public StructureMapControllerActivator(IContainer container)
        {
            _container = container;
        }

        public IController Create(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return _container.GetInstance(controllerType) as IController;
        }
    }
}