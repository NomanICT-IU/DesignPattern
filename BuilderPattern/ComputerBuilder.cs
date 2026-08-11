using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class ComputerBuilder
    {
        private readonly Computer _computer = new Computer();

        public ComputerBuilder SetCpu(string cpu)
        {
            _computer.Cpu = cpu;
            return this;
        }
        public ComputerBuilder SetRam(int ram)
        {
            _computer.Ram = ram;
            return this;
        }
        public ComputerBuilder SetStorage(int storage)
        {
            _computer.Storage = storage;
            return this;

        }
        public ComputerBuilder SetGpu(string gpu)
        {
            _computer.Gpu = gpu;
            return this;
        }
        public ComputerBuilder SetWifi(bool wifi)
        {
            _computer.Wifi = wifi;
            return this;
        }
        public Computer Build()
        {
            return _computer;
        }
      

    }
}
