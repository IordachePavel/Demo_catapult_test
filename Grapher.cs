using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Windows.Forms;

namespace Catapult
{
    public partial class Grapher : Form
    {
        private double angleDegrees;
        private double initialVelocity;
        private double timeOfFlight;
        private double g = 9.81; // Acceleration due to gravity (m/s^2)
        private Timer realTimeTimer;
        private double timeElapsed = 0;
        private double simulationInterval = 0.1; // Time interval for real-time updates (seconds)

        public Grapher(double timeOfFlight, double angleDegrees)
        {
            InitializeComponent();
            this.angleDegrees = angleDegrees;
            this.timeOfFlight = timeOfFlight;
            this.initialVelocity = CalculateInitialVelocity(timeOfFlight, angleDegrees);

            // Plot static trajectory
            PlotStaticTrajectory();

            // Initialize and start the timer for real-time simulation
            realTimeTimer = new Timer();
            realTimeTimer.Interval = (int)(simulationInterval * 1000); // Convert to milliseconds
            realTimeTimer.Tick += RealTimeSimulation_Tick;
            realTimeTimer.Start();
        }

        private double CalculateInitialVelocity(double timeOfFlight, double angleDegrees)
        {
            double angleRadians = angleDegrees * Math.PI / 180; // Convert angle to radians
            return (g * timeOfFlight) / (2 * Math.Sin(angleRadians));
        }

        private void PlotStaticTrajectory()
        {
            double angleRadians = angleDegrees * Math.PI / 180; // Convert angle to radians

            // Create plot model
            var plotModel = new PlotModel { Title = "Projectile Trajectory" };

            // Create series
            var lineSeries = new LineSeries
            {
                Title = "Trajectory",
                Color = OxyColors.Blue
            };

            // Calculate time step for plotting
            double dt = timeOfFlight / 100; // Time step

            // Calculate and add data points
            for (double t = 0; t <= timeOfFlight; t += dt)
            {
                double x = initialVelocity * Math.Cos(angleRadians) * t;
                double y = initialVelocity * Math.Sin(angleRadians) * t - 0.5 * g * t * t;
                lineSeries.Points.Add(new DataPoint(x, y));
            }

            // Add series to the plot model
            plotModel.Series.Add(lineSeries);

            // Set axis limits to include the full range of the trajectory
            double maxX = initialVelocity * Math.Cos(angleRadians) * timeOfFlight;
            double maxY = initialVelocity * Math.Sin(angleRadians) * timeOfFlight - 0.5 * g * timeOfFlight * timeOfFlight;
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = 0, Maximum = maxX });
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = 0, Maximum = Math.Max(0, maxY) });

            // Set the plot model to the PlotView control
            plotViewStatic.Model = plotModel;
        }

        private void RealTimeSimulation_Tick(object sender, EventArgs e)
        {
            timeElapsed += simulationInterval;

            // Clear previous points
           // plotViewRealTime.Model.Series.Clear();

            // Create plot model for real-time simulation
            var plotModel = new PlotModel { Title = "Real-Time Trajectory Simulation" };
            var lineSeries = new LineSeries
            {
                Title = "Trajectory",
                Color = OxyColors.Red
            };

            // Calculate trajectory points
            for (double t = 0; t <= timeElapsed; t += simulationInterval)
            {
                double x = initialVelocity * Math.Cos(angleDegrees * Math.PI / 180) * t;
                double y = initialVelocity * Math.Sin(angleDegrees * Math.PI / 180) * t - 0.5 * g * t * t;
                lineSeries.Points.Add(new DataPoint(x, y));
            }

            // Add series to the plot model
            plotModel.Series.Add(lineSeries);

            // Set axis limits
            double maxX = initialVelocity * Math.Cos(angleDegrees * Math.PI / 180) * timeOfFlight;
            double maxY = initialVelocity * Math.Sin(angleDegrees * Math.PI / 180) * timeOfFlight - 0.5 * g * timeOfFlight * timeOfFlight;
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = 0, Maximum = maxX });
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = 0, Maximum = Math.Max(0, maxY) });

            // Set the plot model to the PlotView control for real-time updates
            plotViewRealTime.Model = plotModel;
        }
    }
}
