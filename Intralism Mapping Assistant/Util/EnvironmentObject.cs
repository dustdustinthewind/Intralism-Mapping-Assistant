using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Intralism_Mapping_Assistant;

namespace Intralism_Mapping_Assistant.Util
{
    public class EnvironmentObject
    {
        public bool IsNew = true;

        public const double TIME_BETWEEN_EVENTS = 0.001;

        public string ID;
        public string ParentID;

        private double? spawnTime = null;
        private bool usedOnce = false;
        public double? SpawnTime
        {
            get
            {
                if (usedOnce)
                    // Add extra time so they can be modified in the editor more easily.
                    spawnTime += TIME_BETWEEN_EVENTS;
                else
                    usedOnce = true;

                return spawnTime;
            }
            set => spawnTime = value - (TIME_BETWEEN_EVENTS * 2);
        }

        public double? RemoveTime = null;
        public Vector3? Position = null;
        public Vector3? Rotation = null;
        public Vector3? Scale = null;
        public EnvironmentObjectType? Type = null;

        public string ColorHex;
        public double? Emission = null;
        public int? InputType = null;
        public double? Speed = null;
        public double? TrailZoomSpeed = null;

        public override string ToString()
            => (IsNew ? CreateAddEvent() : AdjustTime()) + CreateParentEvent() +  CreatePositionEvent() + CreateRotationEvent()
                + CreateScaleEvent();

        protected virtual string CreateAddEvent()
            => SpawnTime >= -(TIME_BETWEEN_EVENTS * 2) && Type != null
                ? CreateEvent("AddEnvironmentObject", $"{(int)Type},{ID}") : "";

        private string CreateParentEvent()
            => !string.IsNullOrEmpty(ParentID)
                ? CreateEvent("SetParent", $"{ID},{ParentID}") : "";

        protected string CreatePositionEvent()
            => CreateVector3Event(Position, "SetPosition");

        protected string CreateRotationEvent()
            => CreateVector3Event(Rotation, "SetRotation");

        protected string CreateScaleEvent()
            => CreateVector3Event(Scale, "SetScale");

        protected string CreateVector3Event(Vector3? vector, string eventName)
            => vector != null && !string.IsNullOrEmpty(eventName)
                ? CreateEvent(eventName, $"{ID},{vector?.X},{vector?.Y},{vector?.Z}") : "";

        protected string CreateColorEvent(string colorHex, string eventName)
            => !string.IsNullOrEmpty(colorHex) && !string.IsNullOrEmpty(eventName)
                ? CreateEvent(eventName, $"{ID},{colorHex}") : "";

        protected string CreateEmissionEvent(string eventName)
            => Emission != null
                ? CreateEvent(eventName, $"{ID},{Emission}") : "";

        protected string CreateInputTypeEvent(string eventName)
            => InputType != null
                ? CreateEvent(eventName, $"{ID},{InputType}") : "";

        protected string CreateSpeedEvent(string eventName)
            => Speed != null
                ? CreateEvent(eventName, $"{ID},{Speed}") : "";

        protected string CreateRemoveEvent()
            => RemoveTime != null && RemoveTime > SpawnTime
                ? new Event()
                {
                    time = (double)RemoveTime,
                    data = new string[] { "RemoveEnvironmentObject", ID }
                }.ToString() + ","
                : "";

        protected string CreateTrailZoomSpeedEvent()
            => TrailZoomSpeed != null
                ? CreateEvent("SetTrailZoomSpeed", $"{TrailZoomSpeed}") : "";

        protected string CreateEvent(string eventName, string eventData)
            => SpawnTime != null && !string.IsNullOrEmpty(eventName) && !string.IsNullOrEmpty(eventData)
                ? new Event()
                {
                    time = (double)SpawnTime,
                    data = new string[] { eventName, eventData }
                }.ToString() + ","
                : "";

        protected string AdjustTime() => CreateEvent("", "");
    }

    public class Sun : EnvironmentObject
    {
        public string MaxLivesHex;
        public string NoLivesHex;
        public double? Sensitivity = null;
        public Vector3? MinSize = null;
        public Vector3? MaxSize = null;
        public Vector3? DirectionVector = null;

        public Sun() => Type = EnvironmentObjectType.Sun;

        public override string ToString()
            => base.ToString() + CreateColorsEvent() + CreateEmissionEvent("SetSunEmission")
                + CreateInputTypeEvent("SetSunInput") + CreateSpeedEvent("SetSunLerpSpeed")
                + CreateSensitivityEvent() + CreateMinSizeEvent() + CreateMaxSizeEvent()
                + CreateDirectionVectorEvent() + CreateTrailZoomSpeedEvent() + CreateRemoveEvent();

        private string CreateColorsEvent()
            => !string.IsNullOrEmpty(MaxLivesHex) && !string.IsNullOrEmpty(NoLivesHex)
                ? CreateEvent("SetSunColors", $"{ID},{MaxLivesHex},{NoLivesHex}").ToString()
                : "";

        private string CreateSensitivityEvent()
            => Sensitivity != null
                ? CreateEvent("SetSunSensitivity", $"{ID},{Sensitivity}") : "";

        private string CreateMinSizeEvent()
            => CreateVector3Event(MinSize, "SetSunMinSize");

        private string CreateMaxSizeEvent()
            => CreateVector3Event(MaxSize, "SetSunMaxSize");

        private string CreateDirectionVectorEvent()
            => CreateVector3Event(DirectionVector, "SetSunDirectionVector");
    }

    public class Satellite : EnvironmentObject
    {
        public double? Sensitivity = null;
        public double? RotationSpeed = null;
        public double? Radius = null;
        public double? TrailFadeTime = null;
        public double? TrailWidth = null;
        public double? MinimumVertexDistance = null;

        public Satellite() => Type = EnvironmentObjectType.Satellite;

        public override string ToString()
            => base.ToString() + CreateColorEvent(ColorHex, "SetSatelliteColor")
                + CreateEmissionEvent("SetSatelliteEmission") + CreateInputTypeEvent("SetSatelliteInput")
                + CreateSpeedEvent("SetSatelliteLerpSpeed") + CreateSensitivityEvent()
                + CreateRotationSpeedEvent() + CreateRadiusEvent() + CreateTrailFadeTimeEvent()
                + CreateTrailWidthEvent() + CreateMinimumVertextDistance() + CreateTrailZoomSpeedEvent()
                + CreateRemoveEvent();

        private string CreateSensitivityEvent()
            => Sensitivity != null
                ? CreateEvent("SetSatelliteSensitivity", $"{ID},{Sensitivity}") : "";

        private string CreateRotationSpeedEvent()
            => RotationSpeed != null
                ? CreateEvent("SetSatelliteRotationSpeed", $"{ID},{RotationSpeed}") : "";

        private string CreateRadiusEvent()
            => Radius != null
                ? CreateEvent("SetSatelliteRadius", $"{ID},{Radius}") : "";

        private string CreateTrailFadeTimeEvent()
            => TrailFadeTime != null
                ? CreateEvent("SetSatelliteTrailLength", $"{ID},{TrailFadeTime}") : "";

        private string CreateTrailWidthEvent()
            => TrailWidth != null
                ? CreateEvent("SetSatelliteTrailWidth", $"{ID},{TrailWidth}") : "";

        private string CreateMinimumVertextDistance()
            => MinimumVertexDistance != null
                ? CreateEvent("SetSatelliteTrailMinVertexDistance", $"{ID},{MinimumVertexDistance}") : "";
    }

    public class ParticleEmitter : EnvironmentObject
    {
        public double? Gravity = null;
        public double? ParticlesPerBeat = null;
        public double? Size = null;

        public ParticleEmitter() => Type = EnvironmentObjectType.ParticleEmitter;

        public override string ToString()
            => base.ToString() + CreateColorEvent(ColorHex, "SetParticlesColor")
            + CreateEmissionEvent("SetParticlesEmission") + CreateInputTypeEvent("SetParticlesInput")
            + CreateGravityEvent() + CreateSpeedEvent("SetParticlesParticleSpeed") + CreatePPBEvent()
            + CreateSizeEvent() + CreateTrailZoomSpeedEvent() + CreateRemoveEvent();

        private string CreateGravityEvent()
            => Gravity != null
                ? CreateEvent("SetParticlesGravity", $"{ID},{Gravity}") : "";

        private string CreatePPBEvent()
            => ParticlesPerBeat != null
                ? CreateEvent("SetParticlesCountPerBeat", $"{ID},{ParticlesPerBeat}") : "";

        private string CreateSizeEvent()
            => Size != null
                ? CreateEvent("SetParticlesParticleSize", $"{ID},{Size}") : "";
    }

    public class EnvironmentSprite : EnvironmentObject
    {
        public EnvironmentSprite() => Type = EnvironmentObjectType.EnvironmentSprite;

        protected override string CreateAddEvent()
            => SpawnTime >= 0 && !string.IsNullOrEmpty(ParentID) && !string.IsNullOrEmpty(ColorHex) && Speed != null
                ? CreateEvent("AddEnvironmentSprite", $"{ID},{ParentID},{Speed},{ColorHex}") : "";

        public override string ToString()
            => (IsNew ? CreateAddEvent()
                : AdjustTime() + CreateSetImageEvent() + CreateColorEvent($"{ColorHex},{Speed}", "SetEnvSpriteColor"))
                + CreatePositionEvent() + CreateRotationEvent()
                + CreateScaleEvent() + CreateTrailZoomSpeedEvent() + CreateRemoveEvent();

        private string CreateSetImageEvent()
            => !string.IsNullOrEmpty(ParentID)
                ? CreateEvent("SetEnvSpriteImage", $"{ID},{ParentID}") : "";
    }

    public enum EnvironmentObjectType
    {
        Sun,
        Satellite,
        ParticleEmitter,
        EnvironmentSprite,
    }
}
