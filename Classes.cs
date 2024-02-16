namespace Lecture8
{
    /*
     * You can put more classes in the same file (in Jave you
     * cannot do it). However, it is always convenient to work
     * with small files (few hundreds lines of code) which
     * naturally leads to one file per class (as suggested in
     * the handouts). Here, I'm lazy and I use one file for all
     * classes and interfaces.
     */

    // Dataset

    interface IPredictor
    {
        double Predict(double x);
        double[] Predict(double[] x);
  
    }

    // Predictor
    public class OLSPredictor : IPredictor
    {
        private double[] betas;

        public OLSPredictor(double[] x, double[] y)
        {
            betas = OrdinaryLeastSquare.Regression(x, y);
            //betas[1] = 1.0/18; // 1/18 --> 0 (int) 1.0/18 = 1/18.0 --> 0.05555 (double)
        }

        public double Predict(double x)
        {
            // y = beta0 + beta1 * x (y = beta0 + beta1*x1 + beta2*x2 ...)
            return betas[0] + betas[1] * x;
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
