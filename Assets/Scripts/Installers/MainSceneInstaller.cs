using Events;
using Extensions.Unity.MonoHelper;
using UnityEngine;
using Zenject;

namespace Installers
{
  public class MainSceneInstaller : EventListenerInstaller<MainSceneInstaller>
  {
    [SerializeField] private Camera _camera;
    [Inject] private GridEvents GridEvents { get; set; }
    private MainSceneEvents _mainSceneEvents;
    
    public override void InstallBindings()
    {
      Container.BindInstance(_camera);
      _mainSceneEvents = new MainSceneEvents();
      Container.BindInstance(_mainSceneEvents);
    }

    public override void Start()
    {
      _mainSceneEvents.MainSceneStart?.Invoke();
    }

    protected override void RegisterEvents()
    {
      GridEvents.InsRequest += OnInsRequest;
    }

    private GameObject OnInsRequest(GameObject prefabRefAsGameObject)
    {
      return Container.InstantiatePrefab(prefabRefAsGameObject);
    }

    protected override void UnRegisterEvents()
    {
      GridEvents.InsRequest -= OnInsRequest;
    }
  }
}