using Microsoft.Maui.Controls;

namespace OrthoGlitch
{
    public class GlitchEffectBehavior : Behavior<View>
    {
        public int Intensity { get; set; } = 2;
        private View attachedView;

        protected override void OnAttachedTo(View bindable)
        {
            base.OnAttachedTo(bindable);
            attachedView = bindable;
            StartGlitch();
        }

        protected override void OnDetachingFrom(View bindable)
        {
            attachedView = null;
            base.OnDetachingFrom(bindable);
        }

        async void StartGlitch()
        {
            while (attachedView != null)
            {
                await Task.Delay(new Random().Next(1000, 3000));
                await attachedView.TranslateTo(
                    new Random().Next(-Intensity, Intensity),
                    new Random().Next(-Intensity, Intensity),
                    50, Easing.Linear);
                await attachedView.TranslateTo(0, 0, 50, Easing.Linear);
            }
        }
    }
}