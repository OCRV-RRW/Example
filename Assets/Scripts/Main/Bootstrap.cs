using Game;
using UnityEngine;
using ContainerData = Configs.ContainerData;

namespace Main
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private ContainerData data;

        private void Awake()
        {
            if (data)
                return;
            Game.Bootstrap.Initiate(data.data);
        }

        private void Update() => MonoLoop.Update();
        private void LateUpdate() => MonoLoop.LateUpdate();
        private void FixedUpdate() => MonoLoop.FixedUpdate();

        private void OnDestroy()
        {
            Game.Bootstrap.Dispose();
        }
    }
}