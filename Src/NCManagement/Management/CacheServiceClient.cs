// Copyright (c) 2015 Alachisoft
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Alachisoft.NCache.ServiceControl;
using Alachisoft.NCache.Caching;
using Alachisoft.NCache.Common;
using Alachisoft.NCache.Config.Dom;

using Alachisoft.NCache.Management.ServiceControl;
using Alachisoft.NCache.Common.Logger;
using Alachisoft.NCache.Management.Management;

namespace Alachisoft.NCache.Management
{
    public class CacheServiceClient
    {
        /// <summary> CacheServer object running on other nodes. </summary>
       
        protected ICacheServer _server = null;

        /// <summary> Address of the machine. </summary>
        protected string _address;
        /// <summary> Port </summary>
        protected int _port;
        /// <summary> Cluster IP address </summary>
        private string _clusterIpAddress;
        /// <summary> Bind Ip address </summary>
        private string _bindIpAddress;

        private bool _useRemoting = false;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="address"></param>
        public CacheServiceClient(string address)
            : this(address, RuntimeContext.CurrentContext == RtContextValue.JVCACHE ? CacheConfigManager.JvCacheTcpPort : CacheConfigManager.NCacheTcpPort)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="address"></param>
        /// <param name="port"></param>
        public CacheServiceClient(string address, int port)
        {
           
            _address = address;
            _port = port;

            Initialize();

            _bindIpAddress = _server.GetBindIP();
            _clusterIpAddress = _server.GetClusterIP();

        }
        /// <summary>
        /// initilaise
        /// </summary>
        protected virtual void Initialize()
        {
            CacheService cacheService = null;
            cacheService = new NCacheRPCService(_address, _port);
            try
            {
                _server = cacheService.GetCacheServer(TimeSpan.FromSeconds(7));
            }
            finally
            {
                cacheService.Dispose();
            }
        }

        protected ICacheServer CacheServer
        {
            get { return _server; }
        }

        public string BindIP
        {
            get
            { return _bindIpAddress; }
        }

        public string ClusterIP
        {
            get { return _clusterIpAddress; }
        }

        /// <summary>
        /// Get the list of running server caches
        /// </summary>
        /// <returns></returns>
        public virtual Hashtable GetServerCaches()
        {
            try
            {
                Hashtable cacheList = new Hashtable();
                IDictionary coll = _server.GetCacheProps();

                IDictionaryEnumerator ie = coll.GetEnumerator();
                while (ie.MoveNext())
                {
                    if (ie.Value is CacheServerConfig)
                    {
                        CacheServerConfig cacheProp = (CacheServerConfig)ie.Value;
                        if (cacheProp.Cluster != null)
                        {
                            if ((cacheProp.Cluster.Topology == "partitioned-server") || (cacheProp.Cluster.Topology == "replicated-server"))
                            {
                                cacheList.Add(ie.Key, cacheProp);
                            }
                        }
                    }
                    else if (ie.Value is Hashtable)
                    {
                        cacheList.Add(ie.Key, ie.Value);
                    }
                }
                return cacheList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
