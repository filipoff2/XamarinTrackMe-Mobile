﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrackMe.Core.Localization.Resx {
    using System;
    using System.Reflection;
    
    
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
    public class AppResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TrackMe.Core.Localization.Resx.AppResources", typeof(AppResources).GetTypeInfo().Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot stop tracking because internet is unavailable.
        /// </summary>
        public static string CannotStopTrackingNoInternet {
            get {
                return ResourceManager.GetString("CannotStopTrackingNoInternet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        public static string Error {
            get {
                return ResourceManager.GetString("Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is connection problem.
        /// </summary>
        public static string ErrorConnectionProblem {
            get {
                return ResourceManager.GetString("ErrorConnectionProblem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error sending position.
        /// </summary>
        public static string ErrorSendingPosition {
            get {
                return ResourceManager.GetString("ErrorSendingPosition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GPS searching.
        /// </summary>
        public static string GPSSearching {
            get {
                return ResourceManager.GetString("GPSSearching", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GPS is turned off.
        /// </summary>
        public static string GPSTurnedOff {
            get {
                return ResourceManager.GetString("GPSTurnedOff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Click the link and see online where I am:.
        /// </summary>
        public static string MailContent {
            get {
                return ResourceManager.GetString("MailContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No.
        /// </summary>
        public static string No {
            get {
                return ResourceManager.GetString("No", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enable localization(gps).
        /// </summary>
        public static string NoGpsEnabled {
            get {
                return ResourceManager.GetString("NoGpsEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please connect to internet.
        /// </summary>
        public static string NoInternetEnabled {
            get {
                return ResourceManager.GetString("NoInternetEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Share.
        /// </summary>
        public static string ShareButton {
            get {
                return ResourceManager.GetString("ShareButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sharing could not be started..
        /// </summary>
        public static string ShareStartError {
            get {
                return ResourceManager.GetString("ShareStartError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to stop sharing the link?.
        /// </summary>
        public static string StopSharingQuestion {
            get {
                return ResourceManager.GetString("StopSharingQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stop tracking.
        /// </summary>
        public static string StopTrackingButton {
            get {
                return ResourceManager.GetString("StopTrackingButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Yes.
        /// </summary>
        public static string Yes {
            get {
                return ResourceManager.GetString("Yes", resourceCulture);
            }
        }
    }
}