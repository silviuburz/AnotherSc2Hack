﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using PluginInterface;

namespace AnotherSc2Hack.Classes.BackEnds
{
    /// <summary>
    /// Localplugins that will hold information about a plugin's path and the plugindata itself.
    /// See IPlugin interface for the plugin information.
    /// </summary>
    public class LocalPlugins
    {
        /// <summary>
        /// The PluginPath (local)
        /// </summary>
        public String PluginPath { get; private set; }

        /// <summary>
        /// The Plugin itself
        /// </summary>
        public IPlugins Plugin { get; private set; }

        /// <summary>
        /// The hash which is created at construction
        /// </summary>
        public String Md5Hash { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="plugin">The reference to the plugin</param>
        /// <param name="pluginPath">The path to the plugin</param>
        public LocalPlugins(IPlugins plugin, string pluginPath)
        {
            PluginPath = pluginPath;
            Plugin = plugin;
            Md5Hash = Hashes.HashFromFile(PluginPath, Hashes.HashAlgorithm.Md5);
        }
    }

    /// <summary>
    /// Online Plugins that are displayed in the listview for available plugins
    /// This class helps you to parse the pluginfile from the server and manage
    /// serveral plugins that way.
    /// </summary>
    [DebuggerDisplay("Name: {Name}; Description: {Description}; Version: {Version}; Link: {DownloadLink}")]
    public class OnlinePlugin
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public OnlinePlugin()
        {
            InitCode();
        }

        /// <summary>
        /// Initiate the accessors.
        /// Especially lists are dangerous!
        /// </summary>
        private void InitCode()
        {
            ImageLinks = new List<String>();
            Images = new List<Image>();
            Name = String.Empty;
            Description = String.Empty;
            Version = new Version(0, 0, 0, 0);
            RequiresUpdate = false;
            LocalPath = String.Empty;
            Md5Hash = String.Empty;
        }


        /// <summary>
        /// Name of plugin
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Destcription of plugin
        /// </summary>
        public String Description { get; set; }
        /// <summary>
        /// List of urls to Images
        /// </summary>
        public List<String> ImageLinks { get; set; }
        /// <summary>
        /// List of images that need to be downloaded separately
        /// </summary>
        public List<Image> Images { get; set; }
        /// <summary>
        /// Version of plugin
        /// </summary>
        public Version Version { get; set; }
        /// <summary>
        /// Downloadlink of plugin
        /// </summary>
        public String DownloadLink { get; set; }
        /// <summary>
        /// Tells you if this update is really needed - unused
        /// </summary>
        public Boolean RequiresUpdate { get; set; }
        /// <summary>
        /// Path to the localplugin (if available) - unused
        /// </summary>
        public String LocalPath { get; set; }
        /// <summary>
        /// Md5 checksum to compare plugins
        /// </summary>
        public String Md5Hash { get; set; }
    }
}