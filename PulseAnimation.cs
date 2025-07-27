using Microsoft.Maui.Controls;

namespace OrthoGlitch
{
    public class PulseAnimation : TriggerAction<VisualElement>
    {
        public double Scale { get; set; } = 1.1;
        public uint Duration { get; set; } = 100;

        protected override async void Invoke(VisualElement sender)
        {
            await sender.ScaleTo(Scale, Duration, Easing.SinInOut);
            await sender.ScaleTo(1.0, Duration, Easing.SinInOut);
        }
    }
}