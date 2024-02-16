namespace Lecture8
{
    public class DummyPredictor : IPredictor
    {
        public double Predict(double x)
        {
            double y = x/18;
            return y;
        }

        public double[] Predict(double[] x)
        {
            int n = x.Length;
            double[] y = new double[n];
            for (int i = 0; i < n; i++)
            {
                y[i] = this.Predict(x[i]);
            }
            return y;
        }
    }
}
