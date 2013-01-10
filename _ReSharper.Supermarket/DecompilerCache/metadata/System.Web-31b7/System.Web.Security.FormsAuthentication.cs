// Type: System.Web.Security.FormsAuthentication
// Assembly: System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\System.Web.dll

using System;
using System.Collections.Specialized;
using System.Runtime;
using System.Web;
using System.Web.Configuration;

namespace System.Web.Security
{
    /// <summary>
    /// Manages forms-authentication services for Web applications. This class cannot be inherited.
    /// </summary>
    public sealed class FormsAuthentication
    {
        internal const string RETURN_URL = "ReturnUrl";

        static FormsAuthentication();

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Web.Security.FormsAuthentication"/> class.
        /// </summary>
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public FormsAuthentication();

        /// <summary>
        /// Gets a value that indicates whether forms authentication is enabled.
        /// </summary>
        /// 
        /// <returns>
        /// true if forms authentication is enabled; otherwise, false.
        /// </returns>
        public static bool IsEnabled { get; }

        /// <summary>
        /// Gets the name of the cookie used to store the forms-authentication ticket.
        /// </summary>
        /// 
        /// <returns>
        /// The name of the cookie used to store the forms-authentication ticket. The default is ".ASPXAUTH".
        /// </returns>
        public static string FormsCookieName { get; }

        /// <summary>
        /// Gets the path for the forms-authentication cookie.
        /// </summary>
        /// 
        /// <returns>
        /// The path of the cookie where the forms-authentication ticket information is stored. The default is "/".
        /// </returns>
        public static string FormsCookiePath { get; }

        /// <summary>
        /// Gets a value indicating whether the forms-authentication cookie requires SSL in order to be returned to the server.
        /// </summary>
        /// 
        /// <returns>
        /// true if SSL is required to return the forms-authentication cookie to the server; otherwise, false. The default is false.
        /// </returns>
        public static bool RequireSSL { get; }

        /// <summary>
        /// Gets the time-out value, in minutes, that is specified in the configuration file.
        /// </summary>
        /// 
        /// <returns>
        /// The time-out value in minutes that is specified in the configuration file. The default is 30 minutes.
        /// </returns>
        public static TimeSpan Timeout { get; }

        /// <summary>
        /// Gets a value indicating whether sliding expiration is enabled.
        /// </summary>
        /// 
        /// <returns>
        /// true if sliding expiration is enabled; otherwise, false. The default is true.
        /// </returns>
        public static bool SlidingExpiration { get; }

        /// <summary>
        /// Gets a value that indicates whether the application is configured for cookieless forms authentication.
        /// </summary>
        /// 
        /// <returns>
        /// One of the <see cref="T:System.Web.HttpCookieMode"/> values that indicates whether the application is configured for cookieless forms authentication. The default is <see cref="F:System.Web.HttpCookieMode.UseDeviceProfile"/>.
        /// </returns>
        public static HttpCookieMode CookieMode { get; }

        /// <summary>
        /// Gets the value of the domain of the forms-authentication cookie.
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="P:System.Web.HttpCookie.Domain"/> of the forms-authentication cookie. The default is an empty string ("").
        /// </returns>
        public static string CookieDomain { get; }

        /// <summary>
        /// Gets a value indicating whether authenticated users can be redirected to URLs in other Web applications.
        /// </summary>
        /// 
        /// <returns>
        /// true if authenticated users can be redirected to URLs in other Web applications; otherwise, false. The default is false.
        /// </returns>
        public static bool EnableCrossAppRedirects { get; }

        /// <summary>
        /// Gets the time-ticket compatibility mode that is specified in the configuration files.
        /// </summary>
        /// 
        /// <returns>
        /// The ticket compatibility mode that is specified in the configuration files.
        /// </returns>
        public static TicketCompatibilityMode TicketCompatibilityMode { get; }

        /// <summary>
        /// Gets a value that indicates whether the application is configured to support cookieless forms authentication.
        /// </summary>
        /// 
        /// <returns>
        /// true if the application is configured to support cookieless forms authentication; otherwise, false.
        /// </returns>
        public static bool CookiesSupported { get; }

        /// <summary>
        /// Gets the URL for the login page that the <see cref="T:System.Web.Security.FormsAuthentication"/> class will redirect to.
        /// </summary>
        /// 
        /// <returns>
        /// The URL for the login page that the <see cref="T:System.Web.Security.FormsAuthentication"/> class will redirect to. The default is "login.aspx."
        /// </returns>
        public static string LoginUrl { get; }

        /// <summary>
        /// Gets the URL that the <see cref="T:System.Web.Security.FormsAuthentication"/> class will redirect to if no redirect URL is specified.
        /// </summary>
        /// 
        /// <returns>
        /// The URL that the <see cref="T:System.Web.Security.FormsAuthentication"/> class will redirect to if no redirect URL is specified. The default is "default.aspx."
        /// </returns>
        public static string DefaultUrl { get; }

        /// <summary>
        /// Produces a hash password suitable for storing in a configuration file based on the specified password and hash algorithm.
        /// </summary>
        /// 
        /// <returns>
        /// The hashed password.
        /// </returns>
        /// <param name="password">The password to hash. </param><param name="passwordFormat">The hash algorithm to use. <paramref name="passwordFormat"/> is a String that represents one of the <see cref="T:System.Web.Configuration.FormsAuthPasswordFormat"/> enumeration values.</param><exception cref="T:System.ArgumentNullException"><paramref name="password"/> is null-or-<paramref name="passwordFormat"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="passwordFormat"/> is not a valid <see cref="T:System.Web.Configuration.FormsAuthPasswordFormat"/> value.</exception>
        public static string HashPasswordForStoringInConfigFile(string password, string passwordFormat);

        /// <summary>
        /// Initializes the <see cref="T:System.Web.Security.FormsAuthentication"/> object based on the configuration settings for the application.
        /// </summary>
        public static void Initialize();

        /// <summary>
        /// Creates a <see cref="T:System.Web.Security.FormsAuthenticationTicket"/> object based on the encrypted forms-authentication ticket passed to the method.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Web.Security.FormsAuthenticationTicket"/> object. If the <paramref name="encryptedTicket"/> parameter is not a valid ticket, null is returned.
        /// </returns>
        /// <param name="encryptedTicket">The encrypted authentication ticket. </param><exception cref="T:System.ArgumentException"><paramref name="encryptedTicket"/> is null.- or -<paramref name="encryptedTicket"/> is an empty string ("").- or -<paramref name="encryptedTicket"/> is of an invalid format. </exception>
        public static FormsAuthenticationTicket Decrypt(string encryptedTicket);

        /// <summary>
        /// Creates a string containing an encrypted forms-authentication ticket suitable for use in an HTTP cookie.
        /// </summary>
        /// 
        /// <returns>
        /// A string containing an encrypted forms-authentication ticket.
        /// </returns>
        /// <param name="ticket">The <see cref="T:System.Web.Security.FormsAuthenticationTicket"/> object with which to create the encrypted forms-authentication ticket. </param><exception cref="T:System.ArgumentNullException"><paramref name="ticket"/> is null.</exception>
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static string Encrypt(FormsAuthenticationTicket ticket);

        /// <summary>
        /// Validates a user name and password against credentials stored in the configuration file for an application.
        /// </summary>
        /// 
        /// <returns>
        /// true if the user name and password are valid; otherwise, false.
        /// </returns>
        /// <param name="name">The user name.</param><param name="password">The password for the user. </param>
        public static bool Authenticate(string name, string password);

        /// <summary>
        /// Removes the forms-authentication ticket from the browser.
        /// </summary>
        public static void SignOut();

        /// <summary>
        /// Creates an authentication ticket for the supplied user name and adds it to the cookies collection of the response, or to the URL if you are using cookieless authentication.
        /// </summary>
        /// <param name="userName">The name of an authenticated user. This does not have to map to a Windows account. </param><param name="createPersistentCookie">true to create a persistent cookie (one that is saved across browser sessions); otherwise, false. </param><exception cref="T:System.Web.HttpException"><see cref="P:System.Web.Security.FormsAuthentication.RequireSSL"/> is true and <see cref="P:System.Web.HttpRequest.IsSecureConnection"/> is false.</exception>
        public static void SetAuthCookie(string userName, bool createPersistentCookie);

        /// <summary>
        /// Creates an authentication ticket for the supplied user name and adds it to the cookies collection of the response, using the supplied cookie path, or using the URL if you are using cookieless authentication.
        /// </summary>
        /// <param name="userName">The name of an authenticated user. </param><param name="createPersistentCookie">true to create a durable cookie (one that is saved across browser sessions); otherwise, false. </param><param name="strCookiePath">The cookie path for the forms-authentication ticket.</param><exception cref="T:System.Web.HttpException"><see cref="P:System.Web.Security.FormsAuthentication.RequireSSL"/> is true and <see cref="P:System.Web.HttpRequest.IsSecureConnection"/> is false.</exception>
        public static void SetAuthCookie(string userName, bool createPersistentCookie, string strCookiePath);

        /// <summary>
        /// Creates an authentication cookie for a given user name. This does not set the cookie as part of the outgoing response, so that an application can have more control over how the cookie is issued.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Web.HttpCookie"/> that contains encrypted forms-authentication ticket information. The default value for the <see cref="P:System.Web.Security.FormsAuthentication.FormsCookiePath"/> property is used.
        /// </returns>
        /// <param name="userName">The name of the authenticated user. </param><param name="createPersistentCookie">true to create a durable cookie (one that is saved across browser sessions); otherwise, false. </param>
        public static HttpCookie GetAuthCookie(string userName, bool createPersistentCookie);

        /// <summary>
        /// Creates an authentication cookie for a given user name. This does not set the cookie as part of the outgoing response.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Web.HttpCookie"/> that contains encrypted forms-authentication ticket information.
        /// </returns>
        /// <param name="userName">The name of the authenticated user. </param><param name="createPersistentCookie">true to create a durable cookie (one that is saved across browser sessions); otherwise, false. </param><param name="strCookiePath">The <see cref="P:System.Web.HttpCookie.Path"/> of the authentication cookie. </param>
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static HttpCookie GetAuthCookie(string userName, bool createPersistentCookie, string strCookiePath);

        internal static string GetReturnUrl(bool useDefaultIfAbsent);

        /// <summary>
        /// Returns the redirect URL for the original request that caused the redirect to the login page.
        /// </summary>
        /// 
        /// <returns>
        /// A string that contains the redirect URL.
        /// </returns>
        /// <param name="userName">The name of the authenticated user. </param><param name="createPersistentCookie">This parameter is ignored.</param>
        public static string GetRedirectUrl(string userName, bool createPersistentCookie);

        /// <summary>
        /// Redirects an authenticated user back to the originally requested URL or the default URL.
        /// </summary>
        /// <param name="userName">The authenticated user name. </param><param name="createPersistentCookie">true to create a durable cookie (one that is saved across browser sessions); otherwise, false. </param><exception cref="T:System.Web.HttpException">The return URL specified in the query string contains a protocol other than HTTP: or HTTPS:.</exception>
        public static void RedirectFromLoginPage(string userName, bool createPersistentCookie);

        /// <summary>
        /// Redirects an authenticated user back to the originally requested URL or the default URL using the specified cookie path for the forms-authentication cookie.
        /// </summary>
        /// <param name="userName">The authenticated user name. </param><param name="createPersistentCookie">true to create a durable cookie (one that is saved across browser sessions); otherwise, false. </param><param name="strCookiePath">The cookie path for the forms-authentication ticket. </param><exception cref="T:System.Web.HttpException">The return URL specified in the query string contains a protocol other than HTTP: or HTTPS:.</exception>
        public static void RedirectFromLoginPage(string userName, bool createPersistentCookie, string strCookiePath);

        /// <summary>
        /// Conditionally updates the issue date and time and expiration date and time for a <see cref="T:System.Web.Security.FormsAuthenticationTicket"/>.
        /// </summary>
        /// 
        /// <returns>
        /// The updated <see cref="T:System.Web.Security.FormsAuthenticationTicket"/>.
        /// </returns>
        /// <param name="tOld">The forms-authentication ticket to update.</param>
        public static FormsAuthenticationTicket RenewTicketIfOld(FormsAuthenticationTicket tOld);

        /// <summary>
        /// Enables forms authentication using the specified configuration data.
        /// </summary>
        /// <param name="configurationData">The configuration data to use for forms authentication.</param><exception cref="T:System.InvalidOperationException">The method was called from the Application_Start method in the Global.asax file, or after that method.</exception>
        public static void EnableFormsAuthentication(NameValueCollection configurationData);

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        internal static string GetLoginPage(string extraQueryString);

        internal static string GetLoginPage(string extraQueryString, bool reuseReturnUrl);

        /// <summary>
        /// Redirects the browser to the login URL.
        /// </summary>
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static void RedirectToLoginPage();

        /// <summary>
        /// Redirects the browser to the login URL with the specified query string.
        /// </summary>
        /// <param name="extraQueryString">The query string to include with the redirect URL.</param>
        public static void RedirectToLoginPage(string extraQueryString);

        internal static string RemoveQueryStringVariableFromUrl(string strUrl, string QSVar);
    }
}
