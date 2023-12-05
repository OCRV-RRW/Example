using Game.Utilities;
using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(menuName = Paths.Game + nameof(ContainerData))]
    public class ContainerData : ScriptableObject
    {
        public Game.ContainerData data;
    }
}