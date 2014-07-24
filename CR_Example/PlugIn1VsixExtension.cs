using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace CR_Example
{
    [Export(typeof(IVsixPluginExtension))]
    public class CR_ExampleExtension : IVsixPluginExtension { }
}