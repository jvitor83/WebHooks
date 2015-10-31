﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AspNet.WebHooks.Properties {
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
    internal class InstagramReceiverResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal InstagramReceiverResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNet.WebHooks.Properties.InstagramReceiverResources", typeof(InstagramReceiverResources).Assembly);
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
        ///   Looks up a localized string similar to Could not retrieve Instagram media for geo ID &apos;{0}&apos;. Received status code &apos;{1}&apos; and error message &apos;{2}&apos;..
        /// </summary>
        internal static string Client_GeoFailure {
            get {
                return ResourceManager.GetString("Client_GeoFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not get current Instagram subscriptions. Received status code &apos;{0}&apos; and error message &quot;{1}&apos;..
        /// </summary>
        internal static string Client_GetSubscriptionsFailure {
            get {
                return ResourceManager.GetString("Client_GetSubscriptionsFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook callback must be an absolute URI and requires HTTPS in order to be secure. Please use a WebHook callback URI of type &apos;{0}&apos;..
        /// </summary>
        internal static string Client_NoHttps {
            get {
                return ResourceManager.GetString("Client_NoHttps", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The URI for where Instagram will send WebHook requests must be an absolute URI. By default this should be of the form &apos;{0}&apos;..
        /// </summary>
        internal static string Client_NotAbsoluteCallback {
            get {
                return ResourceManager.GetString("Client_NotAbsoluteCallback", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not create Instagram subscription. Received status code &apos;{0}&apos; and error message &apos;{1}&apos;..
        /// </summary>
        internal static string Client_SubscribeFailure {
            get {
                return ResourceManager.GetString("Client_SubscribeFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not delete Instagram subscriptions. Received status code &apos;{0}&apos; and error message &quot;{1}&quot;..
        /// </summary>
        internal static string Client_UnsubscribeFailure {
            get {
                return ResourceManager.GetString("Client_UnsubscribeFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot read value &apos;{0}&apos; as type &apos;{1}&apos;..
        /// </summary>
        internal static string DateTime_BadFormat {
            get {
                return ResourceManager.GetString("DateTime_BadFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot convert null value to type &apos;{0}&apos;..
        /// </summary>
        internal static string DateTime_NullError {
            get {
                return ResourceManager.GetString("DateTime_NullError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not parse WebHook data: {0}.
        /// </summary>
        internal static string Receiver_BadEvent {
            get {
                return ResourceManager.GetString("Receiver_BadEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; header value is invalid. It must be a valid base64-encoded string..
        /// </summary>
        internal static string Receiver_BadHeaderEncoding {
            get {
                return ResourceManager.GetString("Receiver_BadHeaderEncoding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find a valid configuration for WebHook receiver &apos;{0}&apos; and instance &apos;{1}&apos;. The setting must be set to a value between {2} and {3} characters long..
        /// </summary>
        internal static string Receiver_BadSecret {
            get {
                return ResourceManager.GetString("Receiver_BadSecret", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook verification request must contain a &apos;{0}&apos; query parameter which will get echoed back in a successful response..
        /// </summary>
        internal static string Receiver_NoChallenge {
            get {
                return ResourceManager.GetString("Receiver_NoChallenge", resourceCulture);
            }
        }
    }
}