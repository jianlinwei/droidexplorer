﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DroidExplorer.Core.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DroidExplorer.Core.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to uses-permission:\s?name=&apos;([^&apos;]+)&apos;.
        /// </summary>
        internal static string ApkPermissionsRegexPattern {
            get {
                return ResourceManager.GetString("ApkPermissionsRegexPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^([a-z0-9_-]+(?:\s?[\.a-z0-9_-]+)?(?:\:\d{1,})?)\s+(device|offline|unknown|bootloader|recovery|download|unauthorized)(?:\s+product:([^:]+)\s+model\:([^:]+)\s+device\:([^:]+))?$.
        /// </summary>
        internal static string DeviceListExRegexPattern {
            get {
                return ResourceManager.GetString("DeviceListExRegexPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^([a-z0-9\-_]+(?:\s[a-z0-9\-_]+)?)\s+(device|offline|unknown|bootloader|recovery|download|unauthorized)\s*$.
        /// </summary>
        internal static string DeviceListRegexPattern {
            get {
                return ResourceManager.GetString("DeviceListRegexPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mem\:\s+(?:(\d{1,})\s+){5}Swap\:\s+(?:(\d{1,})\s+){3}Total\:\s+(?:(\d{1,})(?:\s+|\s?)){3}.
        /// </summary>
        internal static string FreeMemoryRegexPattern {
            get {
                return ResourceManager.GetString("FreeMemoryRegexPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (/[^\s]+)\s+([^\s]+)\s+([^\s]+)\s+([^\s]+).
        /// </summary>
        internal static string FSTabRegexPattern {
            get {
                return ResourceManager.GetString("FSTabRegexPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \[([^\]]+)\]:\s\[([^]]+)\].
        /// </summary>
        internal static string GetPropRegexPattern {
            get {
                return ResourceManager.GetString("GetPropRegexPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^error\:\s+(.+)$.
        /// </summary>
        internal static string IsErrorResultRegexPattern {
            get {
                return ResourceManager.GetString("IsErrorResultRegexPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to busybox ls -lFa --color=never &quot;{0}&quot;.
        /// </summary>
        internal static string ListDirectoryCommand {
            get {
                return ResourceManager.GetString("ListDirectoryCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^([ldcbp-])([rwxt-]{3}){3}\s+(\d{1,})\s+(\d{1,}|\S{1,})\s+(\d{1,}|\S{1,})\s+(\d{1,})\s+(\w+\s+\d{1,2}\s+(?:\d{4})?)(\d{2}:\d{2})?\s+(.+?)([/@=*\|]?)\s?$.
        /// </summary>
        internal static string LsResultRegexPattern {
            get {
                return ResourceManager.GetString("LsResultRegexPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to package\:.+?name=&apos;([^&apos;]+?)&apos;.+?versionName=&apos;([^&apos;]+?)&apos;.+?label=&apos;([^&apos;]+?)&apos;.+?icon=&apos;([^&apos;]+?)&apos;.
        /// </summary>
        internal static string PackageIconRegexPattern {
            get {
                return ResourceManager.GetString("PackageIconRegexPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to package\:([^\=]+)\=(.+)\s?.
        /// </summary>
        internal static string PackageManagerListPackagesRegexPattern {
            get {
                return ResourceManager.GetString("PackageManagerListPackagesRegexPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ([a-z0-9_-]+)\s+(\d{1,})\s+(\d{1,})\s+(\d{1,})\s+\d{1,}\s+[a-f0-9]+\s+[a-f0-9]+\s+\w\s+([a-z0-9\-_\.]+).
        /// </summary>
        internal static string ProcessStatsRegexPattern {
            get {
                return ResourceManager.GetString("ProcessStatsRegexPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^([\w-_\.\#@$^&amp;*+\[=]+)\s-\&gt;\s([\w-_\.\/\#@$^&amp;*+\[=]+)$.
        /// </summary>
        internal static string SymbolicLinkRegexPattern {
            get {
                return ResourceManager.GetString("SymbolicLinkRegexPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (\d{1,})\s+(\d{1,3})%\s+(S|R|D)\s+(\d{1,})\s+(\d{1,})K\s+(\d{1,})K\s+([a-z0-9_]+)\s+([a-z0-9_\.\-\/]+).
        /// </summary>
        internal static string TopProcessRegexPattern {
            get {
                return ResourceManager.GetString("TopProcessRegexPattern", resourceCulture);
            }
        }
    }
}