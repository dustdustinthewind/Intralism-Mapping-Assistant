using Intralism_Mapping_Assistant.Util;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace Intralism_Mapping_Assistant
{
    partial class MainForm : Form
    {
        private void CreateAnimationESA()
        {
            string id = SpriteIDESATB.Text;
            double startTime = (double)StartTimeNUDESA.Value;

            string[] frames = FramesESARTB.Text.Replace(" ", "").Split(',');

            double timePerFrame = FrameTimeCBESA.Checked ? (double)TimePerFrameNUDESA.Value : 1d / (double)FramesPerSecondNUDESA.Value;

            double endTime = EndTimeCBESA.Checked
                ? (double)EndTimeNUDESA.Value + timePerFrame
                : FindEndTime(startTime, frames.Length, timePerFrame);

            double currentTime = startTime;
            int currentFrame = 0;

            PreviewRTBESA.Text = "";

            while (currentTime <= endTime)
            {
                if (currentFrame >= frames.Length)
                    currentFrame = 0;

                PreviewRTBESA.Text += CreateSpriteSetEvent(currentTime, id, frames[currentFrame]) + ",";

                currentTime += timePerFrame;
                currentFrame++;
            }
        }

        private string CreateSpriteSetEvent(double currentTime, string id, string imageResource)
            => new Event() { time = currentTime, data = new string[] { "SetEnvSpriteImage", $"{id},{imageResource}" } }.ToString();

        private double FindEndTime(double startTime, int numberOfFrames, double frameTime)
        {
            int totalFrames = (int)LoopAmountNUDESA.Value * numberOfFrames;

            return startTime + (totalFrames * frameTime);
        }
    }
}
