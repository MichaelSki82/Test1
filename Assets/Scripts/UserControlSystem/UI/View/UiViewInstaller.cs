using UnityEngine;
using UserControlSystem;
using Zenject;

public class UiViewInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
       
        Container
               .Bind<BottomCenterView>()
               .FromComponentInHierarchy()
               .AsSingle();
    }
}