﻿namespace SqualrClient.Source.Api
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Static class for sending requests to the native browser.
    /// </summary>
    internal static class NativeBrowser
    {
        /// <summary>
        /// Opens the url in the native browser.
        /// </summary>
        /// <param name="url">The url to open.</param>
        public static void Open(String url)
        {
            Process.Start(url);
        }
    }
    //// End class
}
//// End namespace