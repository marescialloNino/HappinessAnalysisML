using System; // Includes the namespace 'System' for the 'Console' class

namespace Lecture8
{
    //Switzerland   7.587		139.651
    //Italy	        5.948	    125.114
    //Iran          4.686	    10.088
    class MainClass
    {
        public static double MSE(double[] x, double[] y, IPredictor p)
        {
            double[] tilde_y = p.Predict(x);
            double sse = 0;
            for (int i = 0; i < tilde_y.Length; i++)
            { 
                sse += Math.Pow(tilde_y[i] - y[i], 2);
            }
            return sse / x.Length;
        }

        public static void PrintProjectHeading()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Nicola Schiavo");
            Console.WriteLine("Ordinary Least Square Regression");
            Console.WriteLine("Dataset: World Happiness");
            Console.WriteLine("www.kaggle.com/unsdsn/world-happiness");
            Console.WriteLine("-------------------------------------");
        }

        public static void DummyTest()
        {
            
            double[] x = { 139.65, 125.11, 10.09};
            double[] y = { 7.587, 5.948, 4.686 };
            IPredictor p = new OLSPredictor(x, y);
            double mse = MSE(x, y, p);
            Console.WriteLine("MSE: {0}", mse);
            Console.WriteLine("ME:  {0}", Math.Sqrt(mse));
        }

        public static void HierarchyTest()
        {
            Country switzerland = new Country("Switzerland");
            Region wEu = new Region();
            Console.WriteLine(switzerland.Population);
            Console.WriteLine(wEu.Population);
            Console.WriteLine(switzerland.Name);

            Console.WriteLine(wEu.Name);
        }

        public static void Main(string[] args)
        {
            PrintProjectHeading();
            DummyTest();
            HierarchyTest();
            /*
             * 1. Look at the data and identify x and y
             * 2. Prepare a dummy predictor
             * 3. Prepare a dummy dataset
             * 4. Classes and interfaces for predictor and dataset
             * 5. Do OLS
             * 6. Test
             * 7. ...
             */
        }
    }
}
