using Intralism_Mapping_Assistant.Util;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace Intralism_Mapping_Assistant
{
    partial class MainForm : Form
    {
        private bool calledErrorAlready = false;

        private string defaultTextBoxMessage = "Choose the settings you want then click \"Create\" when you're ready!";

        private void CreateEnvObjects()
        {
            ConfigPreviewEOC.Text = "";

            if (MakeMultipleCopiesNUD.Value > 0)
                for (int i = 0; i < MakeMultipleCopiesNUD.Value && !calledErrorAlready; i++)
                    ConfigPreviewEOC.Text +=
                       ChangeEnvObjToString(CreateEnvironmentObjectWithCurrentSettings(i + 1));
            else
                ConfigPreviewEOC.Text +=
                   ChangeEnvObjToString(CreateEnvironmentObjectWithCurrentSettings(0));

            calledErrorAlready = false;
        }

        private string ChangeEnvObjToString(EnvironmentObject envObj)
        {
            try
            {
                switch (envObj.Type)
                {
                    case EnvironmentObjectType.Sun:
                        return ((Sun)envObj).ToString();
                    case EnvironmentObjectType.Satellite:
                        return ((Satellite)envObj).ToString();
                    case EnvironmentObjectType.ParticleEmitter:
                        return ((ParticleEmitter)envObj).ToString();
                    default:
                        return defaultTextBoxMessage;
                }
            }
            catch
            {
                if (!calledErrorAlready)
                    ErrorMessage("There was an issue during the creation process! Make sure all your values are formatted correctly.");

                calledErrorAlready = true;

                return defaultTextBoxMessage;
            }
        }

        private EnvironmentObject CreateEnvironmentObjectWithCurrentSettings(int i)
        {
            if (string.IsNullOrEmpty(EnvObjTB.Text)) return null;

            if (SunRB.Checked)
                return CreateSunWithCurrentSettings(i);
            else if (SatelliteRB.Checked)
                return CreateSatelliteWithCurrentSettings(i);
            else if (ParticleEmitterRB.Checked)
                return CreateParticleEmitterWithCurrentSettings(i);
            else if (!calledErrorAlready)
                ErrorMessage("Select \"Sun\", \"Satellite\", or \"Particle Emitter\"!");

            return null;
        }

        private Sun CreateSunWithCurrentSettings(int copy = 0)
        => new Sun()
        {
            ID = EnvObjTB.Text + (copy != 0 ? $"{copy}" : ""),
            ParentID = ParentIDCB.Checked ? ParentIDTB.Text : null,

            SpawnTime = (double?)SpawnTimeNUD.Value,
            RemoveTime = RemoveTimeCB.Checked ? (double?)RemoveTimeNUD.Value : null,

            Position = PositionCB.Checked ? (Vector3?)new Vector3((float)PositionXNUD.Value, (float)PositionYNUD.Value, (float)PositionZNUD.Value) : null,
            Rotation = RotationCB.Checked ? (Vector3?)new Vector3((float)RotationXNUD.Value, (float)RotationYNUD.Value, (float)RotationZNUD.Value) : null,
            Scale = RotationCB.Checked ? (Vector3?)new Vector3((float)ScaleXNUD.Value, (float)ScaleYNUD.Value, (float)ScaleZNUD.Value) : null,

            MaxLivesHex = MaxLivesCB.Checked ? MaxLivesColorTB.Text : "",
            NoLivesHex = NoLivesColorCB.Checked ? NoLivesColorTB.Text : "",

            Emission = SunEmissionCB.Checked ? (double?)SunEmissionNUD.Value : null,
            InputType = SunInputCB.Checked ? (int?)SunInputNUD.Value : null,
            Speed = SunLerpSpeedCB.Checked ? (double?)SunLerpNUD.Value : null,
            Sensitivity = SunSensivityCB.Checked ? (double?)SunSensitivityNUD.Value : null,

            MinSize = SunMinSizeCB.Checked ? (Vector3?)new Vector3((float)SunMinSizeXNUD.Value, (float)SunMinSizeYNUD.Value, (float)SunMinSizeZNUD.Value) : null,
            MaxSize = SunMaxSizeCB.Checked ? (Vector3?)new Vector3((float)SunMaxSizeXNUD.Value, (float)SunMaxSizeYNUD.Value, (float)SunMaxSizeZNUD.Value) : null,
            DirectionVector = SunDirectionVectorCB.Checked ? (Vector3?)new Vector3((float)DirectionVectorXNUD.Value, (float)DirectionVectorYNUD.Value, (float)DirectionVectorZNUD.Value) : null,
        };

        private Satellite CreateSatelliteWithCurrentSettings(int copy = 0)
        => new Satellite()
        {
            ID = EnvObjTB.Text + (copy != 0 ? $"{copy}" : ""),
            ParentID = ParentIDCB.Checked ? ParentIDTB.Text : null,

            SpawnTime = (double?)SpawnTimeNUD.Value,
            RemoveTime = RemoveTimeCB.Checked ? (double?)RemoveTimeNUD.Value : null,

            Position = PositionCB.Checked ? (Vector3?)new Vector3((float)PositionXNUD.Value, (float)PositionYNUD.Value, (float)PositionZNUD.Value) : null,
            Rotation = RotationCB.Checked ? (Vector3?)new Vector3((float)RotationXNUD.Value, (float)RotationYNUD.Value, (float)RotationZNUD.Value) : null,
            Scale = RotationCB.Checked ? (Vector3?)new Vector3((float)ScaleXNUD.Value, (float)ScaleYNUD.Value, (float)ScaleZNUD.Value) : null,

            ColorHex = SatelliteColorCB.Checked ? SatelliteColorTB.Text : "",

            Emission = SatelliteEmissionCB.Checked ? (double?)SatelliteEmissionNUD.Value : null,
            InputType = SatelliteTypeCB.Checked ? (int?)SatelliteInputNUD.Value : null,
            Speed = SatelliteLerpSpeedCB.Checked ? (double?)SatelliteLerpSpeedNUD.Value : null,
            Sensitivity = SatelliteSensitivityCB.Checked ? (double?)SatelliteSensitivityNUD.Value : null,

            RotationSpeed = SatelliteRotationCB.Checked ? (double?)SatelliteRotationSpeedNUD.Value : null,
            Radius = SatelliteRadiusCB.Checked ? (double?)SatelliteRadiusNUD.Value : null,
            TrailFadeTime = SatelliteTrailFadeTimeCB.Checked ? (double?)SatelliteTrailTimeNUD.Value : null,
            TrailWidth = SatellieTrailWidthCB.Checked ? (double?)SatelliteTrailWidthNUD.Value : null,
            MinimumVertexDistance = SatelliteMinimumVertexCB.Checked ? (double?)SatelliteMinimumVertexDistanceNUD.Value : null,
        };

        private ParticleEmitter CreateParticleEmitterWithCurrentSettings(int copy = 0)
        => new ParticleEmitter()
        {
            ID = EnvObjTB.Text + (copy != 0 ? $"{copy}" : ""),
            ParentID = ParentIDCB.Checked ? ParentIDTB.Text : null,

            SpawnTime = (double?)SpawnTimeNUD.Value,
            RemoveTime = RemoveTimeCB.Checked ? (double?)RemoveTimeNUD.Value : null,

            Position = PositionCB.Checked ? (Vector3?)new Vector3((float)PositionXNUD.Value, (float)PositionYNUD.Value, (float)PositionZNUD.Value) : null,
            Rotation = RotationCB.Checked ? (Vector3?)new Vector3((float)RotationXNUD.Value, (float)RotationYNUD.Value, (float)RotationZNUD.Value) : null,
            Scale = RotationCB.Checked ? (Vector3?)new Vector3((float)ScaleXNUD.Value, (float)ScaleYNUD.Value, (float)ScaleZNUD.Value) : null,

            ColorHex = ParticleEmitterColorCB.Checked ? ParticleEmitterColorTB.Text : "",

            Emission = ParticleEmitterEmissionCB.Checked ? (double?)ParticleEmitterEmissionNUD.Value : null,
            InputType = ParticleEmitterTypeCB.Checked ? (int?)ParticleEmitterInputNUD.Value : null,
            Speed = ParticleEmitterSpeedCB.Checked ? (double?)ParticleEmitterSpeedNUD.Value : null,

            Gravity = ParticleEmitterGravityCB.Checked ? (double?)ParticleEmitterGravityNUD.Value : null,
            ParticlesPerBeat = ParticleEmitterPPBCB.Checked ? (double?)ParticleEmitterPPBNUD.Value : null,
            Size = ParticleEmitterSizeCB.Checked ? (double?)ParticleEmitterSizeNUD.Value : null,
        };

        private void ReactivatePropertyBoxes(EnvironmentObjectType envObj)
        {
            DisableAllPropertyBoxes();

            switch (envObj)
            {
                case EnvironmentObjectType.Sun:
                    SunGroupBox.Enabled = true;
                    break;
                case EnvironmentObjectType.Satellite:
                    SatelliteGroupBox.Enabled = true;
                    break;
                case EnvironmentObjectType.ParticleEmitter:
                    ParticleEmitterGroupBox.Enabled = true;
                    break;
                default:
                    ErrorMessage("You *REALLY* shouldn't be seeing this...");
                    throw new System.Exception("Heh, GAAAAAY");
            }
        }

        private void DisableAllPropertyBoxes()
        {
            SunGroupBox.Enabled = false;
            SatelliteGroupBox.Enabled = false;
            ParticleEmitterGroupBox.Enabled = false;
        }

        private void FillTextBoxWithSelectedColorCode(TextBox textBox)
        {
            ColorDialog.ShowDialog();

            textBox.Text = RGBColorToHex(ColorDialog.Color);
        }

        private static string RGBColorToHex(Color? c)
            => "#" + c?.R.ToString("X2") + c?.G.ToString("X2") + c?.B.ToString("X2");

        private void ChangeEnabledStatus(Control[] controls, bool status)
        {
            for (int i = 0; i < controls.Length; i++)
                controls[i].Enabled = status;
        }
    }
}
