using System;
using System.Collections.Generic;

namespace HelloWorld
{
    [Tekla.Structures.Plugins.Plugin("HelloWorld")]
    [Tekla.Structures.Plugins.PluginUserInterface("HelloWorld.HelloWorldForm")]
    [Tekla.Structures.Plugins.InputObjectDependency(InputObjectDependency.NOT_DEPENDENT)]
    public class HelloWorldPlugin : Tekla.Structures.Plugins.PluginBase
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
