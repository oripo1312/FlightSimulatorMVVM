﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flightSimulator
{
    public interface IFlightModel : INotifyPropertyChanged
    {
        void connect(string ip, int port);
        void disconnect();
        void start();


    }
}
