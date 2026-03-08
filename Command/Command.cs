using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }

        public void Undo()
        {
            _light.TurnOff();
        }
    }

    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }

        public void Undo()
        {
            _light.TurnOn();
        }
    }

    public class DoorOpenCommand : ICommand
    {
        private readonly Door _door;

        public DoorOpenCommand(Door door)
        {
            _door = door;
        }

        public void Execute()
        {
            _door.Open();
        }

        public void Undo()
        {
            _door.Close();
        }
    }

    public class DoorCloseCommand : ICommand
    {
        private readonly Door _door;

        public DoorCloseCommand(Door door)
        {
            _door = door;
        }

        public void Execute()
        {
            _door.Close();
        }

        public void Undo()
        {
            _door.Open();
        }
    }

    public class IncreaseTemperatureCommand : ICommand
    {
        private readonly Thermostat _thermostat;

        public IncreaseTemperatureCommand(Thermostat thermostat)
        {
            _thermostat = thermostat;
        }

        public void Execute()
        {
            _thermostat.IncreaseTemperature();
        }

        public void Undo()
        {
            _thermostat.DecreaseTemperature();
        }
    }

    public class DecreaseTemperatureCommand : ICommand
    {
        private readonly Thermostat _thermostat;

        public DecreaseTemperatureCommand(Thermostat thermostat)
        {
            _thermostat = thermostat;
        }

        public void Execute()
        {
            _thermostat.DecreaseTemperature();
        }

        public void Undo()
        {
            _thermostat.IncreaseTemperature();
        }
    }

    public class TVOnCommand : ICommand
    {
        private readonly TV _tv;

        public TVOnCommand(TV tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.TurnOn();
        }

        public void Undo()
        {
            _tv.TurnOff();
        }
    }

    public class TVOffCommand : ICommand
    {
        private readonly TV _tv;

        public TVOffCommand(TV tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.TurnOff();
        }

        public void Undo()
        {
            _tv.TurnOn();
        }
    }

    public class RemoteControl
    {
        private readonly Stack<ICommand> _history = new Stack<ICommand>();

        public void PressButton(ICommand command)
        {
            command.Execute();
            _history.Push(command);
        }

        public void UndoLastCommand()
        {
            if (_history.Count == 0)
            {
                Console.WriteLine("Ошибка: нет выполненных команд для отмены.");
                return;
            }

            ICommand lastCommand = _history.Pop();
            lastCommand.Undo();
        }

        public void UndoSeveralCommands(int count)
        {
            if (_history.Count == 0)
            {
                Console.WriteLine("Ошибка: история команд пуста.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                if (_history.Count == 0)
                {
                    Console.WriteLine("Больше нет команд для отмены.");
                    break;
                }

                ICommand lastCommand = _history.Pop();
                lastCommand.Undo();
            }
        }
    }
}