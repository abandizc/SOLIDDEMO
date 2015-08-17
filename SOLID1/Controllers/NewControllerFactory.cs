using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace SOLID1.Controllers
{
    public class NewControllerFactory : DefaultControllerFactory
    {
        private readonly IContainer _container;

        public NewControllerFactory(IContainer container)
        {
            _container = container;
        }

        public override IController CreateController(System.Web.Routing.RequestContext requestContext, string controllerName)
        {
            return _container.GetInstance<IController>(controllerName.ToLowerInvariant());
        }

        public override void ReleaseController(IController controller)
        {
            return;
        }

        protected override System.Web.SessionState.SessionStateBehavior GetControllerSessionBehavior(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return SessionStateBehavior.Default;
        }
    }
}