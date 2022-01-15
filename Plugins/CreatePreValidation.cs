using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;

namespace Plugins
{
    class CreatePreValidation : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            string logicalName = "account";
            string email = "email";
            string correctFormat = "correctFormat";
            bool b;
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                Entity entity = (Entity)context.InputParameters["Target"];
                b = entity.Attributes[email].ToString().Contains(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (entity.LogicalName == logicalName)
                {
                    if (entity.Attributes.Contains(email) && b)
                    {
                        entity.Attributes.Add(correctFormat, true);
                    }
                    else
                    {
                        entity.Attributes.Add(correctFormat, false);
                    }
                }
            }
        }
    }
}
