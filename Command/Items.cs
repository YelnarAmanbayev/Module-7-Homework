using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Light
    {
        public bool IsOn { get; private set; }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Свет включен.");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Свет выключен.");
        }
    }

    public class Door
    {
        public bool IsOpen { get; private set; }

        public void Open()
        {
            IsOpen = true;
            Console.WriteLine("Дверь открыта.");
        }

        public void Close()
        {
            IsOpen = false;
            Console.WriteLine("Дверь закрыта.");
        }
    }

    public class Thermostat
    {
        public int Temperature { get; private set; }

        public Thermostat(int initialTemperature = 22)
        {
            Temperature = initialTemperature;
        }

        public void IncreaseTemperature()
        {
            Temperature++;
            Console.WriteLine($"Температура увеличена до {Temperature}°C.");
        }

        public void DecreaseTemperature()
        {
            Temperature--;
            Console.WriteLine($"Температура уменьшена до {Temperature}°C.");
        }
    }

    public class TV
    {
        public bool IsOn { get; private set; }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Телевизор включен.");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Телевизор выключен.");
        }
    }
}
