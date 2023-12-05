using System;
using Core.ObjectsSystem;
using Game.Contexts;
using Game.LocationObjects;
using Game.Locations.Model;
using UnityEngine;

namespace Locations
{
    public class SceneLocation : Location, ILocationObject
    {
        public SceneLocation(SceneLocationSetting model, IContext context, IDroppable parent) : base(model, context, parent)
        {
        }

        public Guid Id { get; }
        public Transform Transform { get; }
    }
}