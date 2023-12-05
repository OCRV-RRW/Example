using Core.ObjectsSystem;
using Game.Contexts;
using Game.Locations.Model;
using Game.Utilities;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Locations
{
    [CreateAssetMenu(menuName = Paths.Game + Paths.Settings + nameof(SceneLocation))]
    public class SceneLocationSetting : LocationSetting
    {
        public Object rootObject;
        public string rootObjectPath;
        public string sceneName;
        
        protected override Location GetInstanceInner(IContext context, IDroppable parent)
        {
            return new SceneLocation(this, context, parent);
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            if (rootObject)
                rootObjectPath = Core.Utilities.GetValidPathToResource(rootObject);
        }
#endif
    }
}