﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IPublisher
    {
        void NotifyAll();
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
    }
}
