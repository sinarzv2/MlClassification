using System;

namespace MlClassification
{
    class Program
    {
        static void Main(string[] args)
        {
            var sampleData = new PredictDisease.ModelInput()
            {
                Pelvic_incidence = 63.03F,
                Pelvic_tilt = 22.55F,
                Lumbar_lordosis_angle = 39.61F,
                Sacral_slope = 40.48F,
                Pelvic_radius = 98.67F,
                Degree_spondylolisthesis = -0.25F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = PredictDisease.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Class with predicted Class from sample data...\n\n");


            Console.WriteLine($"Pelvic_incidence: {sampleData.Pelvic_incidence}");
            Console.WriteLine($"Pelvic_tilt: {sampleData.Pelvic_tilt}");
            Console.WriteLine($"Lumbar_lordosis_angle: {sampleData.Lumbar_lordosis_angle}");
            Console.WriteLine($"Sacral_slope: {sampleData.Sacral_slope}");
            Console.WriteLine($"Pelvic_radius: {sampleData.Pelvic_radius}");
            Console.WriteLine($"Degree_spondylolisthesis: {sampleData.Degree_spondylolisthesis}");


            Console.WriteLine($"\n\nPredicted Class: {predictionResult.PredictedLabel}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
