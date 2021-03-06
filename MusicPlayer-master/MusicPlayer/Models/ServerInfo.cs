﻿using System.Collections.Generic;

namespace MusicPlayer.Models
{
    /// <summary>
    /// Describes the server info.
    /// </summary>
    public class ServerInfo
    {
        /// <summary>
        /// Gets or sets the host ip address.
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Gest or sets a value indicating whether we are host. 
        /// </summary>
        public bool IsHost { get; set; }

        /// <summary>
        /// Gets or sets the server port.
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// The connected clients ip: port.
        /// </summary>
        public Dictionary<string, int> Clients { get; set; }

        /// <summary>
        /// Gets the number of connected clients.
        /// </summary>
        public int Count
        {
            get
            {
                var count = Clients?.Keys?.Count;
                return count ?? 0;
            }
        }

        /// <summary>
        /// In client mode this is used to play a video.
        /// </summary>
        public string VideoUrl { get; set; }

        /// <summary>
        /// The position of the video.
        /// </summary>
        public double VideoPosition { get; set; }
    }
}
