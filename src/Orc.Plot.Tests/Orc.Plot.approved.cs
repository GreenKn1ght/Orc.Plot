﻿[assembly: System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.6", FrameworkDisplayName=".NET Framework 4.6")]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("http://schemas.wildgums.com/orc/plot", "Orc.Plot")]
[assembly: System.Windows.Markup.XmlnsPrefixAttribute("http://schemas.wildgums.com/orc/plot", "orcplot")]
[assembly: System.Windows.ThemeInfoAttribute(System.Windows.ResourceDictionaryLocation.None, System.Windows.ResourceDictionaryLocation.SourceAssembly)]
public class static ModuleInitializer
{
    public static void Initialize() { }
}
namespace Orc.Plot.Animations
{
    public class static AnimationExtensions
    {
        public static int DefaultAnimationDelay { get; set; }
        public static int DefaultAnimationDuration { get; set; }
        public static int DefaultAnimationFrameDuration { get; set; }
        public static System.Threading.Tasks.Task AnimateSeriesAsync(this OxyPlot.PlotModel plotModel, OxyPlot.Series.DataPointSeries series, System.Collections.Generic.List<Orc.Plot.Animations.AnimationFrame> animationFrames) { }
        public static System.Threading.Tasks.Task AnimateSeriesAsync(this OxyPlot.PlotModel plotModel, OxyPlot.Series.LinearBarSeries series, Orc.Plot.Animations.AnimationSettings settings) { }
        public static System.Threading.Tasks.Task AnimateSeriesAsync(this OxyPlot.PlotModel plotModel, OxyPlot.Series.LineSeries series, Orc.Plot.Animations.AnimationSettings settings) { }
        public static Orc.Plot.Animations.AnimationFrame GetFinalAnimationFrame(OxyPlot.Series.DataPointSeries series) { }
    }
    public class AnimationFrame
    {
        public AnimationFrame() { }
        public System.Collections.Generic.List<Orc.Plot.Animations.AnimationPoint> AnimationPoints { get; }
        public System.TimeSpan Duration { get; set; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{X} / {Y} (IsVisible = {IsVisible})")]
    public class AnimationPoint
    {
        public AnimationPoint() { }
        public bool IsVisible { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
    public class AnimationSettings
    {
        public AnimationSettings() { }
        public System.TimeSpan Delay { get; set; }
        public System.TimeSpan Duration { get; set; }
        public Orc.Plot.Animations.IEasingFunction EasingFunction { get; set; }
        public System.TimeSpan FrameDuration { get; set; }
        public double HorizontalPercentage { get; set; }
        public System.Nullable<double> MinimumValue { get; set; }
        public double VerticalPercentage { get; set; }
    }
    public class BackEase : Orc.Plot.Animations.IEasingFunction
    {
        public BackEase() { }
        public double Amplitude { get; set; }
        public double Ease(double value) { }
    }
    public class BounceEase : Orc.Plot.Animations.IEasingFunction
    {
        public BounceEase() { }
        public int Bounces { get; set; }
        public double Bounciness { get; set; }
        public double Ease(double value) { }
    }
    public class CircleEase : Orc.Plot.Animations.IEasingFunction
    {
        public CircleEase() { }
        public double Ease(double value) { }
    }
    public interface IAnimatable
    {
        bool SupportsEasingFunction { get; }
        System.Threading.Tasks.Task AnimateAsync();
        System.Threading.Tasks.Task AnimateAsync(Orc.Plot.Animations.AnimationSettings animationSettings);
    }
    public interface IAnimatablePoint
    {
        double FinalX { get; set; }
        double FinalY { get; set; }
        double X { get; set; }
        double Y { get; set; }
    }
    public interface IEasingFunction
    {
        double Ease(double value);
    }
    public class NoEase : Orc.Plot.Animations.IEasingFunction
    {
        public NoEase() { }
        public double Ease(double value) { }
    }
    public class PowerEase : Orc.Plot.Animations.IEasingFunction
    {
        public PowerEase() { }
        public double Power { get; set; }
        public double Ease(double value) { }
    }
    public class QuadraticEase : Orc.Plot.Animations.IEasingFunction
    {
        public QuadraticEase() { }
        public double Ease(double value) { }
    }
    public class QuarticEase : Orc.Plot.Animations.IEasingFunction
    {
        public QuarticEase() { }
        public double Ease(double value) { }
    }
    public class QuinticEase : Orc.Plot.Animations.IEasingFunction
    {
        public QuinticEase() { }
        public double Ease(double value) { }
    }
    public class SineEase : Orc.Plot.Animations.IEasingFunction
    {
        public SineEase() { }
        public double Ease(double value) { }
    }
}
namespace Orc.Plot
{
    public class PlotView : OxyPlot.Wpf.PlotView
    {
        public PlotView() { }
    }
}