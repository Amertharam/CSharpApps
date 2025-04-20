using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Concurrent;

namespace HighAvailabilityTradingSystem
{
    public class DataPoint
    {
        public long Timestamp { get; set; }
        public string Source { get; set; }
        public double Value { get; set; }

        public override string ToString()
        {
            return $"[{Timestamp}] {Source}: {Value}";
        }
    }

    public class HighAvailabilitySimulator
    {
        private static ConcurrentQueue<DataPoint> dataQueue = new ConcurrentQueue<DataPoint>();
        private static volatile bool isProcessing = true;

        public static void DataIngestionSimulation()
        {
            Random random = new Random();
            string[] sources = { "SensorA", "SensorB", "ExternalFeed" };

            Console.WriteLine("Simulating data ingestion...");
            while (isProcessing)
            {
                Stopwatch sw = Stopwatch.StartNew();
                var data = new DataPoint
                {
                    Timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
                    Source = sources[random.Next(sources.Length)],
                    Value = Math.Round(random.NextDouble() * 100, 2)
                };
                dataQueue.Enqueue(data);
                sw.Stop();

                // Simulate low latency requirement by pausing briefly
                int delay = Math.Max(0, 10 - (int)sw.ElapsedMilliseconds); // Aim for ~10ms ingestion
                Thread.Sleep(delay);
            }
            Console.WriteLine("Data ingestion stopped.");
        }

        public static void DataProcessingSimulation()
        {
            Console.WriteLine("Simulating data processing...");
            while (isProcessing || !dataQueue.IsEmpty)
            {
                if (dataQueue.TryDequeue(out var dataPoint))
                {
                    // Simulate a critical processing step that requires data integrity
                    // Here, we'll just log it, but in a real system, this could be a calculation
                    Console.WriteLine($"Processed: {dataPoint}");

                    // Simulate a very brief processing time
                    Thread.Sleep(1);
                }
                else
                {
                    // If the queue is empty and ingestion is still running, wait a bit
                    if (isProcessing)
                    {
                        Thread.Sleep(5);
                    }
                }
            }
            Console.WriteLine("Data processing stopped.");
        }

        public static void IntegrityCheckSimulation()
        {
            // In a real system, this would involve more sophisticated checks
            // like comparing against a known state, checksums, or audit logs.
            Console.WriteLine("Simulating basic data integrity awareness...");
            long lastTimestamp = 0;
            int outOfOrderCount = 0;

            // We'll just peek at the queue without removing to simulate a monitoring process
            var queueSnapshot = dataQueue.ToArray();
            foreach (var data in queueSnapshot)
            {
                if (data.Timestamp < lastTimestamp)
                {
                    outOfOrderCount++;
                    Console.WriteLine($"Potential data integrity issue: Out-of-order data point found - {data}");
                }
                lastTimestamp = data.Timestamp;
            }

            if (outOfOrderCount > 0)
            {
                Console.WriteLine($"Detected {outOfOrderCount} potential out-of-order data points.");
            }
            else
            {
                Console.WriteLine("Basic integrity check passed (no obvious out-of-order issues at this point).");
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("High Availability Simulation (Focus on Low Latency & Data Integrity)");

            // Start data ingestion and processing on separate threads
            Thread ingestionThread = new Thread(DataIngestionSimulation);
            Thread processingThread = new Thread(DataProcessingSimulation);

            ingestionThread.Start();
            processingThread.Start();

            // Let the simulation run for a bit
            Thread.Sleep(5000);

            // Signal to stop data ingestion
            isProcessing = false;
            Console.WriteLine("Stopping data ingestion...");

            // Wait for the processing to finish
            processingThread.Join();

            // Perform a basic integrity check
            IntegrityCheckSimulation();

            Console.WriteLine("Simulation complete.");
            Console.ReadKey();
        }
    }
}
