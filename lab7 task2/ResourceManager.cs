﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab7_task2
{
    internal class ResourceManager
    {
        private Semaphore semaphore;
        private Mutex mutex;
        private Dictionary<int, Resource> resources;

        public ResourceManager(int resourceCount)
        {
            semaphore = new Semaphore(resourceCount, resourceCount);
            mutex = new Mutex();
            resources = new Dictionary<int, Resource>();

            for (int i = 0; i < resourceCount; i++)
            {
                resources[i] = new Resource { Id = i };
            }
        }
        public Resource AcquireResource(int threadId)
        {
            semaphore.WaitOne();

            mutex.WaitOne();

            Resource acquiredResource = null;
            foreach (var resource in resources.Values)
            {
                if (resource.Id % 2 == threadId % 2)
                {
                    acquiredResource = resource;
                    break;
                }
            }

            mutex.ReleaseMutex();

            return acquiredResource;
        }

        public void ReleaseResource(Resource resource)
        {
            semaphore.Release();
        }
    }
}
