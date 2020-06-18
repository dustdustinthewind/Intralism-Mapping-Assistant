using Intralism_Mapping_Assistant.Util;
using System;
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

            // Find start index and "fix" the ID if it has numbers at the end
            string nameOldText = EnvObjTB.Text;
            string nameAdjustedText = nameOldText;
            int nameStartIndex = FindStartIndex(ref nameAdjustedText, true);

            string parentOldText = ParentIDTB.Text;
            bool careAboutParent = MultipleParentsCB.Checked && !string.IsNullOrEmpty(parentOldText);
            string parentAdjustedText = parentOldText;
            int parentStartIndex = 0;
            // Parent could be null
            if (careAboutParent)
            {
                parentStartIndex = FindStartIndex(ref parentAdjustedText, true, true);
            }

            // If we received an error in FindStartIndex return
            if (nameStartIndex < 0 || (careAboutParent && parentStartIndex < 0)) { return; }

            EnvObjTB.Text = nameAdjustedText;
            ParentIDTB.Text = parentAdjustedText;

            if (MakeMultipleCopiesNUD.Value > 0)
            {
                int currentStep = 0;
                for (int i = nameStartIndex - 1;
                    i < MakeMultipleCopiesNUD.Value + nameStartIndex && !calledErrorAlready;
                    i++)
                {
                    ConfigPreviewEOC.Text +=
                       ChangeEnvObjToString(CreateEnvironmentObjectWithCurrentSettings(i + 1, (careAboutParent, currentStep + parentStartIndex)));


                    currentStep++;
                }
            }
            else
            {
                ConfigPreviewEOC.Text +=
                   ChangeEnvObjToString(CreateEnvironmentObjectWithCurrentSettings(0, (false, 0)));
            }

            // restore the user submitted ID
            EnvObjTB.Text = nameOldText;
            ParentIDTB.Text = parentOldText;

            calledErrorAlready = false;
        }

        private int FindStartIndex(ref string adjustedText, bool first = false, bool parent = false)
        {
            // Make sure adjustText has anything in it oops
            if (first && string.IsNullOrEmpty(adjustedText))
            {
                ErrorMessage($"Please give {(parent ? "a parent" : "an object")} ID!");
                return -1;
            }

            // Get the last char of a string
            string lastDigit = adjustedText.Substring(adjustedText.Length - 1);
            
            // The digit at the end
            int result;

            // Check if it's a digit, if not, return 0
            try
            {
                if (!int.TryParse(adjustedText.Substring(adjustedText.Length - 1), out result))
                {
                    return 0;
                }
                // If it is a digit, see if there is another digit and add them together as a string
                // and then convert said string into an int again.
                else
                {
                    adjustedText = adjustedText.Substring(0, adjustedText.Length - 1);

                    return int.Parse
                    (
                        FindStartIndex(ref adjustedText, false, parent).ToString() + result.ToString()
                    );
                }
            }
            catch
            {
                ErrorMessage($"Please do not use {(parent ? "a parent" : "an object")} ID " +
                    $"with all numbers, it'd break the program and it's not a good way of " +
                    $"naming your objects anyway.");

                adjustedText = string.Empty;

                return -1;
            }
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
                    case EnvironmentObjectType.EnvironmentSprite:
                        return ((EnvironmentSprite)envObj).ToString();
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

        private EnvironmentObject CreateEnvironmentObjectWithCurrentSettings(int index, (bool, int) parentTuple)
        {
            if (string.IsNullOrEmpty(EnvObjTB.Text)) return null;

            if (SunRB.Checked)
                return CreateSunWithCurrentSettings(parentTuple, index);
            else if (SatelliteRB.Checked)
                return CreateSatelliteWithCurrentSettings(parentTuple, index);
            else if (ParticleEmitterRB.Checked)
                return CreateParticleEmitterWithCurrentSettings(parentTuple, index);
            else if (EnvSpriteRB.Checked)
                return CreateEnvironmentSpriteWithCurrentSettings(parentTuple, index);
            else if (!calledErrorAlready)
                ErrorMessage("Select \"Sun\", \"Satellite\", \"Particle Emitter\", or \"Environment Sprite\"!");

            return null;
        }

        // Mirror is activated when the cb is enabled AND checked.
        private bool MirrorX => MirrorXCB.Enabled && MirrorXCB.Checked;
        private bool MirrorY => MirrorYCB.Enabled && MirrorYCB.Checked;
        private bool MirrorZ => MirrorZCB.Enabled && MirrorZCB.Checked;

        private Sun CreateSunWithCurrentSettings((bool, int) parentTuple, int copy = 0)
        {
            // Every even object turn on the mirror toggle.
            float flip = 1;
            if (copy % 2 == 0)
                flip = -1;

            // If the axis should be mirrorred, multiply it by flip (which will be inverted for
            // every even copy)
            float posX = (float)PositionXNUD.Value * (MirrorX ? flip : 1);
            float posY = (float)PositionYNUD.Value * (MirrorY ? flip : 1);
            float posZ = (float)PositionZNUD.Value * (MirrorZ ? flip : 1);

            float rotX = (float)RotationXNUD.Value * (MirrorX ? flip : 1);
            float rotY = (float)RotationYNUD.Value * (MirrorY ? flip : 1);
            float rotZ = (float)RotationZNUD.Value * (MirrorZ ? flip : 1);

            return new Sun()
            {
                IsNew = CreateNewObjectsCB.Checked,

                ID = EnvObjTB.Text + (copy != 0 ? $"{copy}" : ""),
                ParentID =  ParentIDCB.Checked ?
                            (
                                parentTuple.Item1 ?
                                    ParentIDTB.Text + (parentTuple.Item2 != 0 ? $"{parentTuple.Item2}" : "") :
                                    ParentIDTB.Text
                            ) : null,

                SpawnTime = (double?)SpawnTimeNUD.Value,
                RemoveTime = RemoveTimeCB.Checked ? (double?)RemoveTimeNUD.Value : null,

                TrailZoomSpeed = TrailZoomSpeedCB.Checked ? (double?)TrailZoomSpeedNUD.Value : null,

                Position = PositionCB.Checked ? (Vector3?)new Vector3(posX, posY, posZ) : null,
                Rotation = RotationCB.Checked ? (Vector3?)new Vector3(rotX, rotY, rotZ) : null,
                Scale = ScaleCB.Checked ? (Vector3?)new Vector3((float)ScaleXNUD.Value, (float)ScaleYNUD.Value, (float)ScaleZNUD.Value) : null,

                MaxLivesHex = ColorsCB.Checked ? MaxLivesColorTB.Text : "",
                NoLivesHex = ColorsCB.Checked ? NoLivesColorTB.Text : "",

                Emission = SunEmissionCB.Checked ? (double?)SunEmissionNUD.Value : null,
                InputType = SunInputCB.Checked ? (int?)SunInputNUD.Value : null,
                Speed = SunLerpSpeedCB.Checked ? (double?)SunLerpNUD.Value : null,
                Sensitivity = SunSensivityCB.Checked ? (double?)SunSensitivityNUD.Value : null,

                MinSize = SunMinSizeCB.Checked ? (Vector3?)new Vector3((float)SunMinSizeXNUD.Value, (float)SunMinSizeYNUD.Value, (float)SunMinSizeZNUD.Value) : null,
                MaxSize = SunMaxSizeCB.Checked ? (Vector3?)new Vector3((float)SunMaxSizeXNUD.Value, (float)SunMaxSizeYNUD.Value, (float)SunMaxSizeZNUD.Value) : null,
                DirectionVector = SunDirectionVectorCB.Checked ? (Vector3?)new Vector3((float)DirectionVectorXNUD.Value, (float)DirectionVectorYNUD.Value, (float)DirectionVectorZNUD.Value) : null,
            };
        }

        private Satellite CreateSatelliteWithCurrentSettings((bool, int) parentTuple, int copy = 0)
        {
            // Every even object turn on the mirror toggle.
            float flip = 1;
            if (copy % 2 == 0)
                flip = -1;

            // If the axis should be mirrorred, multiply it by flip (which will be inverted for
            // every even copy)
            float posX = (float)PositionXNUD.Value * (MirrorX ? flip : 1);
            float posY = (float)PositionYNUD.Value * (MirrorY ? flip : 1);
            float posZ = (float)PositionZNUD.Value * (MirrorZ ? flip : 1);

            float rotX = (float)RotationXNUD.Value * (MirrorX ? flip : 1);
            float rotY = (float)RotationYNUD.Value * (MirrorY ? flip : 1);
            float rotZ = (float)RotationZNUD.Value * (MirrorZ ? flip : 1);

            return new Satellite()
            {
                IsNew = CreateNewObjectsCB.Checked,

                ID = EnvObjTB.Text + (copy != 0 ? $"{copy}" : ""),
                ParentID = ParentIDCB.Checked ?
                            (
                                parentTuple.Item1 ?
                                    ParentIDTB.Text + (parentTuple.Item2 != 0 ? $"{parentTuple.Item2}" : "") :
                                    ParentIDTB.Text
                            ) : null,

                SpawnTime = (double?)SpawnTimeNUD.Value,
                RemoveTime = RemoveTimeCB.Checked ? (double?)RemoveTimeNUD.Value : null,

                TrailZoomSpeed = TrailZoomSpeedCB.Checked ? (double?)TrailZoomSpeedNUD.Value : null,

                Position = PositionCB.Checked ? (Vector3?)new Vector3(posX, posY, posZ) : null,
                Rotation = RotationCB.Checked ? (Vector3?)new Vector3(rotX, rotY, rotZ) : null,
                Scale = ScaleCB.Checked ? (Vector3?)new Vector3((float)ScaleXNUD.Value, (float)ScaleYNUD.Value, (float)ScaleZNUD.Value) : null,

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
        }

        private ParticleEmitter CreateParticleEmitterWithCurrentSettings((bool, int) parentTuple, int copy = 0)
        {
            // Every even object turn on the mirror toggle.
            float flip = 1;
            if (copy % 2 == 0)
                flip = -1;

            // If the axis should be mirrorred, multiply it by flip (which will be inverted for
            // every even copy)
            float posX = (float)PositionXNUD.Value * (MirrorX ? flip : 1);
            float posY = (float)PositionYNUD.Value * (MirrorY ? flip : 1);
            float posZ = (float)PositionZNUD.Value * (MirrorZ ? flip : 1);

            float rotX = (float)RotationXNUD.Value * (MirrorX ? flip : 1);
            float rotY = (float)RotationYNUD.Value * (MirrorY ? flip : 1);
            float rotZ = (float)RotationZNUD.Value * (MirrorZ ? flip : 1);

            return new ParticleEmitter()
            {
                IsNew = CreateNewObjectsCB.Checked,

                ID = EnvObjTB.Text + (copy != 0 ? $"{copy}" : ""),
                ParentID = ParentIDCB.Checked ?
                            (
                                parentTuple.Item1 ?
                                    ParentIDTB.Text + (parentTuple.Item2 != 0 ? $"{parentTuple.Item2}" : "") :
                                    ParentIDTB.Text
                            ) : null,

                SpawnTime = (double?)SpawnTimeNUD.Value,
                RemoveTime = RemoveTimeCB.Checked ? (double?)RemoveTimeNUD.Value : null,

                TrailZoomSpeed = TrailZoomSpeedCB.Checked ? (double?)TrailZoomSpeedNUD.Value : null,

                Position = PositionCB.Checked ? (Vector3?)new Vector3(posX, posY, posZ) : null,
                Rotation = RotationCB.Checked ? (Vector3?)new Vector3(rotX, rotY, rotZ) : null,
                Scale = ScaleCB.Checked ? (Vector3?)new Vector3((float)ScaleXNUD.Value, (float)ScaleYNUD.Value, (float)ScaleZNUD.Value) : null,

                ColorHex = ParticleEmitterColorCB.Checked ? ParticleEmitterColorTB.Text : "",

                Emission = ParticleEmitterEmissionCB.Checked ? (double?)ParticleEmitterEmissionNUD.Value : null,
                InputType = ParticleEmitterTypeCB.Checked ? (int?)ParticleEmitterInputNUD.Value : null,
                Speed = ParticleEmitterSpeedCB.Checked ? (double?)ParticleEmitterSpeedNUD.Value : null,

                Gravity = ParticleEmitterGravityCB.Checked ? (double?)ParticleEmitterGravityNUD.Value : null,
                ParticlesPerBeat = ParticleEmitterPPBCB.Checked ? (double?)ParticleEmitterPPBNUD.Value : null,
                Size = ParticleEmitterSizeCB.Checked ? (double?)ParticleEmitterSizeNUD.Value : null,
            };
        }

        private EnvironmentSprite CreateEnvironmentSpriteWithCurrentSettings((bool, int) parentTuple, int copy = 0)
        {
            if (string.IsNullOrEmpty(ParentIDTB.Text))
            {
                ErrorMessage("Please provide an image resource for this Sprite!");
                return null;
            }

            // Every even object turn on the mirror toggle.
            float flip = 1;
            if (copy % 2 == 0)
                flip = -1;

            // If the axis should be mirrorred, multiply it by flip (which will be inverted for
            // every even copy)
            float posX = (float)PositionXNUD.Value * (MirrorX ? flip : 1);
            float posY = (float)PositionYNUD.Value * (MirrorY ? flip : 1);
            float posZ = (float)PositionZNUD.Value * (MirrorZ ? flip : 1);

            float rotX = (float)RotationXNUD.Value * (MirrorX ? flip : 1);
            float rotY = (float)RotationYNUD.Value * (MirrorY ? flip : 1);
            float rotZ = (float)RotationZNUD.Value * (MirrorZ ? flip : 1);

            return new EnvironmentSprite()
            {
                IsNew = CreateNewObjectsCB.Checked,

                ID = EnvObjTB.Text + (copy != 0 ? $"{copy}" : ""),
                ParentID = ParentIDCB.Checked ?
                            (
                                parentTuple.Item1 ?
                                    ParentIDTB.Text + (parentTuple.Item2 != 0 ? $"{parentTuple.Item2}" : "") :
                                    ParentIDTB.Text
                            ) : null,

                SpawnTime = (double?)SpawnTimeNUD.Value,
                RemoveTime = RemoveTimeCB.Checked ? (double?)RemoveTimeNUD.Value : null,

                TrailZoomSpeed = TrailZoomSpeedCB.Checked ? (double?)TrailZoomSpeedNUD.Value : null,

                Position = PositionCB.Checked ? (Vector3?)new Vector3(posX, posY, posZ) : null,
                Rotation = RotationCB.Checked ? (Vector3?)new Vector3(rotX, rotY, rotZ) : null,
                Scale = ScaleCB.Checked ? (Vector3?)new Vector3((float)ScaleXNUD.Value, (float)ScaleYNUD.Value, (float)ScaleZNUD.Value) : null,

                ColorHex = EnvSpriteColorTB.Text,
                Speed = (double?)EnvSpriteSpeedNUD.Value
            };
        }

        private void ReactivatePropertyBoxes(EnvironmentObjectType envObj)
        {
            DisableAllPropertyBoxes();

            switch (envObj)
            {
                case EnvironmentObjectType.Sun:
                    SunGroupBox.Enabled = true;
                    ParentIDCB.Text = "Parent ID";
                    ParentIDCB.Enabled = true;
                    break;
                case EnvironmentObjectType.Satellite:
                    SatelliteGroupBox.Enabled = true;
                    ParentIDCB.Text = "Parent ID";
                    ParentIDCB.Enabled = true;
                    break;
                case EnvironmentObjectType.ParticleEmitter:
                    ParticleEmitterGroupBox.Enabled = true;
                    ParentIDCB.Text = "Parent ID";
                    ParentIDCB.Enabled = true;
                    break;
                case EnvironmentObjectType.EnvironmentSprite:
                    groupBox1.Enabled = true;
                    ParentIDCB.Enabled = false;
                    ParentIDCB.Checked = true;
                    ParentIDCB.Text = "Image Resource";
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

        private void RefreshEnvSpriteTB()
        {
            EnvSpriteColorTB.Text = RGBColorToHex(ColorDialog.Color);
            EnvSpriteColorTB.Text += trackBar1.Value.ToString("X2");
        }
    }
}
