using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSharingPlugin
{

        [Tekla.Structures.Plugins.Plugin("ModelSharingPlugin")]
        [Tekla.Structures.Plugins.PluginUserInterface("ModelSharingPlugin.ModelSharingForm")]
        [Tekla.Structures.Plugins.InputObjectDependency(InputObjectDependency.NOT_DEPENDENT)]
        public class ModelSharingPlugin : Tekla.Structures.Plugins.PluginBase
        {
            public override List<InputDefinition> DefineInput()
            {
                return null;
            }

            public override bool Run(List<InputDefinition> Input)
            {
                return false;
            }
        }
}
