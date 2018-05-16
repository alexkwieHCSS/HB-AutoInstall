﻿//
// Copyright © 2018 Ranorex All rights reserved
//

using System;
using System.Collections.Generic;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Ranorex.AutomationHelpers.UserCodeCollections
{
    /// <summary>
    /// A collection of popup watcher helper methods.
    /// </summary>
    [UserCodeCollection]
    public static class PopupWatcherLibrary
    {
        private static readonly Dictionary<string, PopupWatcher> watchers = new Dictionary<string, PopupWatcher>();

        /// <summary>
        /// Gets the currently active watchers which were started using the <see cref="StartPopupWatcher"/>
        /// method and have not been stopped using the <see cref="StopPopupWatcher"/> method, yet.
        /// </summary>
        /// <value>
        /// The currently active watchers created using the <see cref="PopupWatcherLibrary"/> class.
        /// </value>
        public static IList<PopupWatcher> Watchers { get { return new List<PopupWatcher>(watchers.Values); } }

        /// <summary>
        /// Waits for a popup window to appear and clicks an element to close the window.
        /// </summary>
        /// <param name="findElement">Element to wait for</param>
        /// <param name="clickElement">Element to click after the popup appears</param>
        /// <returns>Reference to a newly created <see cref="PopupWatcher"/></returns>
        [UserCodeMethod]
        public static PopupWatcher StartPopupWatcher(RepoItemInfo findElement, RepoItemInfo clickElement)
        {
            var key = findElement.GetMetaInfos()["id"] + clickElement.GetMetaInfos()["id"];

            if (watchers.ContainsKey(key))
            {
                throw new ArgumentException("Popup watcher with given parameters already exists.");
            }

            var watcher = new PopupWatcher();
            watcher.WatchAndClick(findElement, clickElement);
            watcher.Start();
            watchers.Add(key, watcher);
            Report.Info("Popup watcher started.");
            return watcher;
        }

        /// <summary>
        /// Stops and removes an active popup watcher.
        /// </summary>
        /// <param name="findElement">Element to wait for</param>
        /// <param name="clickElement">Element to click after the popup appears</param>
        [UserCodeMethod]
        public static void StopPopupWatcher(RepoItemInfo findElement, RepoItemInfo clickElement)
        {
            var key = findElement.GetMetaInfos()["id"] + clickElement.GetMetaInfos()["id"];
            PopupWatcher watcher = null;
            if (watchers.TryGetValue(key, out watcher))
            {
                StopPopupWatcher(key, watcher);
            }
            else
            {
                Report.Warn("The popup watcher you tried to remove does not exist.");
            }
        }

        /// <summary>
        /// Stops all active popup watchers.
        /// </summary>
        [UserCodeMethod]
        public static void StopAllPopupWatchers()
        {
            foreach (var watcher in watchers)
            {
                StopPopupWatcher(watcher.Key, watcher.Value);
            }
        }

        private static void StopPopupWatcher(string key, PopupWatcher watcher)
        {
            watcher.Clear();
            watcher.Stop();
            Report.Info("Popup watcher stopped.");
            watchers.Remove(key);
        }
    }
}