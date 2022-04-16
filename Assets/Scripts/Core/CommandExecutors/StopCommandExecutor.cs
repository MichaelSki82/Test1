using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class StopCommandExecutor : CommandExecutorBase<IStopCommand>
{
    public CancellationTokenSource CancellationTokenSource { get; set; }
    public override async Task ExecuteSpecificCommand(IStopCommand command)
    {
        Debug.Log("Stop");
        CancellationTokenSource?.Cancel();
    }
}
