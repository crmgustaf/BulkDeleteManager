using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace BulkDeleteManager
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "BulkDeleteManager  "),
        ExportMetadata("Description", "Manage you bulk deletes in your Dataverse instance. List, create new and  (soon) copy"),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAMAAABEpIrGAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAIuUExURf////7+/uTk5N3d3d7e3uDg4Ofn59vb29zc3Pj4+Onp6fPz87XB0uDi5MDH0Yifv/z8/L/FzpSoxC975S9yzy9/7i575mCLyG6VyrXC0667zC586C9+7TCB8mSLwuXm6L3Ezk2AyDJ316q5zf39/S1tyJ6twfX19fT09PLy8itx0zJ528TM1+Li4uHh4fv7+2CDtFaFx5+yzFKDyYmgv/Dw8Pb29tPT0bOzo1R8qC123OTk5dvc3S565DCA8K+7zPf399ra2tfXvMvLP9bWBfj4AOHhAKe2LS5758bM1L3Fzy9+7FqHxt/f38LCOf//AFd/fDV52F2KyDN52j56zcbM1eXl5ZmZeL+/hc3NT83NJs7OEKquEy9uwkp/yM7OHdfXC83NQ83Nbc7OhM7Oi2+KnjZ62l2CtO/v78HLHlOCkC9965mtyL29Sfv7AGGIeER9zjpttJ+fZa6ukM3NdM3NS87ONc7OLc7OMs7ORaapdJKbpmh3W0x/xliGxU1/xurr7Pr6+uzsAM3NHs3NSM7OXs7OZs7OYc3NTs3NKeLiAubmAMTFx/n5+f7+AJubQ+fnAObm5rm5X+vrAeTkALm5Ne3t7aOjT62tkMLCj83NcM7OWs7OUs7OV83NasjIiqiokaGhUMPDw/39ANfXBM3NI87OOs7OQc7OPLu7KbGxCNbWANXVAIqKQ8rKidXVDN7eBMLCX87Ovs3Nlc7Of87Od87OfM7Oj83NtOzs7NnjmgYAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAGMSURBVDhPY6AVYITSWAETMzMLKzMblIcOGNk5OKFMVMDFDaZ4ePn4sRvPDMQCgkLCIqJi4hKSEDEUwALEUtIysmAgJw8RRAZABQqKEGkgUFKGCiMAC4OKKlQWBNTUNaASMMDCoKkFlQQBbR1dJqgMFOjpG4AdYGhkDKJETRhM2aFSYGBmbmEJkrCyZrCxBdJ29gwMDo5QSQYGJ2cXVzd3kAIPTwYvbxDDByis7guRZmDw8weCAJC4bGBQMIgKCQWJh8FcGh4RGRUdEwtWAQFxEAlQ8IFAfEJiUnJKKlQSCNLSIRIZEIohHmSFf2ZWNlReNgcqAQO5eWAV/vkQ6YJCTagEDBQVl5SWlVdUVlXX2NbW1Tc0QsXhIL6puaW1rb2js6u7h0GToxcqjAAQN/j79/VPmMgwEUtamjQZqmLKVA32aVBBZDB9xsxZs+fMnTd/wcJFGPaDQPziJUuXLV+xctXqNROhQqgA7oa1QDdgA+vWL4ao2LBRACqEBtQ3bd6yddv2HTuh/EEFGBgANAFjArbKkKgAAAAASUVORK5CYII="),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "#ffffff"),
        ExportMetadata("PrimaryFontColor", "Black"),
        ExportMetadata("SecondaryFontColor", "Gray")]
    public class BulkDeleteManager : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new BDM();
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        public BulkDeleteManager()
        {
            // If you have external assemblies that you need to load, uncomment the following to 
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}