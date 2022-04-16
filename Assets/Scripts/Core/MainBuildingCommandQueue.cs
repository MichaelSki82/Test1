using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

public class MainBuildingCommandQueue : MonoBehaviour, ICommandsQueue
{

    [Inject] CommandExecutorBase<IProduceUnitCommand> _produceUnitCommandExecutor;


    public async Task EnqueueCommand(object command)
    {
        await _produceUnitCommandExecutor.TryExecuteCommand(command);

    }

    public void Clear()
    {
    }


}