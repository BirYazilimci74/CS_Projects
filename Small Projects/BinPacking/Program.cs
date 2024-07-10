using System;
using Google.OrTools.LinearSolver;

public class BinPacking
{
    class DataModel
    {
        public static double[] Weights = { 48, 30, 19, 36, 36, 27, 42, 42, 36, 24, 30 };
        public int NumItems = Weights.Length;
        public int NumBins = Weights.Length;
        public double BinCapacity = 100.0;
    }
    public static void Main()
    {
        DataModel data = new DataModel();

        // Create the linear solver with the SCIP backend.
        Solver solver = Solver.CreateSolver("SCIP");
        if (solver is null)
        {
            return;
        }

        Variable[,] x = new Variable[data.NumItems, data.NumBins];
        for (int i = 0; i < data.NumItems; i++)
        {
            for (int j = 0; j < data.NumBins; j++)
            {
                x[i, j] = solver.MakeIntVar(0, 1, $"x_{i}_{j}");
            }
        }
        Variable[] y = new Variable[data.NumBins];
        for (int j = 0; j < data.NumBins; j++)
        {
            y[j] = solver.MakeIntVar(0, 1, $"y_{j}");
        }

        for (int i = 0; i < data.NumItems; ++i)
        {
            Constraint constraint = solver.MakeConstraint(1, 1, "");
            for (int j = 0; j < data.NumBins; ++j)
            {
                constraint.SetCoefficient(x[i, j], 1);
            }
        }

        for (int j = 0; j < data.NumBins; ++j)
        {
            Constraint constraint = solver.MakeConstraint(0, Double.PositiveInfinity, "");
            constraint.SetCoefficient(y[j], data.BinCapacity);
            for (int i = 0; i < data.NumItems; ++i)
            {
                constraint.SetCoefficient(x[i, j], -DataModel.Weights[i]);
            }
        }

        Objective objective = solver.Objective();
        for (int j = 0; j < data.NumBins; ++j)
        {
            objective.SetCoefficient(y[j], 1);
        }
        objective.SetMinimization();

        Solver.ResultStatus resultStatus = solver.Solve();

        // Check that the problem has an optimal solution.
        if (resultStatus != Solver.ResultStatus.OPTIMAL)
        {
            Console.WriteLine("The problem does not have an optimal solution!");
            return;
        }
        Console.WriteLine($"Number of bins used: {solver.Objective().Value()}");
        double TotalWeight = 0.0;
        for (int j = 0; j < data.NumBins; ++j)
        {
            double BinWeight = 0.0;
            if (y[j].SolutionValue() == 1)
            {
                Console.WriteLine($"Bin {j}");
                for (int i = 0; i < data.NumItems; ++i)
                {
                    if (x[i, j].SolutionValue() == 1)
                    {
                        Console.WriteLine($"Item {i} weight: {DataModel.Weights[i]}");
                        BinWeight += DataModel.Weights[i];
                    }
                }
                Console.WriteLine($"Packed bin weight: {BinWeight}");
                TotalWeight += BinWeight;
            }
        }
        Console.WriteLine($"Total packed weight: {TotalWeight}");
    }
}