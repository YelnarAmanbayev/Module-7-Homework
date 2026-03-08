using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            Door door = new Door();
            Thermostat thermostat = new Thermostat();
            TV tv = new TV();

            ICommand lightOn = new LightOnCommand(light);
            ICommand lightOff = new LightOffCommand(light);

            ICommand doorOpen = new DoorOpenCommand(door);
            ICommand doorClose = new DoorCloseCommand(door);

            ICommand tempUp = new IncreaseTemperatureCommand(thermostat);
            ICommand tempDown = new DecreaseTemperatureCommand(thermostat);

            ICommand tvOn = new TVOnCommand(tv);
            ICommand tvOff = new TVOffCommand(tv);

            RemoteControl remote = new RemoteControl();

            Console.WriteLine("Работа команд:");
            Console.WriteLine();
            remote.PressButton(lightOn);
            remote.PressButton(doorOpen);
            remote.PressButton(tempUp);
            remote.PressButton(tempUp);
            remote.PressButton(tvOn);

            Console.WriteLine();
            Console.WriteLine("Отмена последних команд:");
            Console.WriteLine();
            remote.UndoLastCommand();
            remote.UndoLastCommand();

            Console.WriteLine();
            Console.WriteLine("Дополнительные команды:");
            Console.WriteLine();
            remote.PressButton(lightOff);
            remote.PressButton(doorClose);
            remote.PressButton(tempDown);
            remote.PressButton(tvOff);

            Console.WriteLine();
            Console.WriteLine("Отмена нескольких команд:");
            Console.WriteLine();
            remote.UndoSeveralCommands(4);

            Console.WriteLine();
            Console.WriteLine("Проверка ошибки:");
            Console.WriteLine();
            RemoteControl emptyRemote = new RemoteControl();
            emptyRemote.UndoLastCommand();
        }
    }
}