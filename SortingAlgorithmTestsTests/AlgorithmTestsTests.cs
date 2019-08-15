using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithmTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace SortingAlgorithmTests.Tests
{
    [TestClass()]
    public class AlgorithmTestsTests
    {
        [TestMethod()]
        public void CreateArrayTest()
        {
            bool[] algorithms = new bool[6] { true, true, true, true, true, true };
            int[] array_size = new int[6] { 20, 0, 0, 0, 0, 0 };
            int min = -10, max = 10;
            AlgorithmTests test = new AlgorithmTests(algorithms, 1, array_size, min, max);
            test.CreateArray();
            for (int i = 0; i < 20; i++)
            {
                if (test.array[i] < -10 || test.array[i] > 10)
                {
                    Assert.Fail("Array members out of range");
                }
            }
        }

        [TestMethod()]
        public void SetProgressBarTest()
        {
            MainUI main = new MainUI();
            bool[] algorithms = new bool[6] { true, true, true, true, true, true };
            int[] array_size = new int[6] { 20, 0, 0, 0, 0, 0 };
            int min = -10, max = 10;
            main.algorithms = new bool[6] { true, true, true, true, true, true };
            main.testRepetitions = 1;
            AlgorithmTests test = new AlgorithmTests(algorithms, 1, array_size, min, max);
            test.GetMainReference(main);
            main.SetProgressBar();
            Assert.AreEqual(main.testProgress.Minimum, 0, "Progressbar minimum not set correctly");
            Assert.AreEqual(main.testProgress.Maximum, 6, "Progressbar maximum not set correctly");
            Assert.AreEqual(main.testProgress.Step, 1, "Progressbar step not set correctly");
            Assert.AreEqual(main.testProgress.Value, 0, "Progressbar value not set correctly");
        }

        [TestMethod()]
        public void FileReadTest()
        {
            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            string json = File.ReadAllText(wanted_path + "\\testfile.json");
            bool[] algs = new bool[6] { true, true, false, false, true, false };
            AlgorithmTests test = new AlgorithmTests();
            test = JsonConvert.DeserializeObject<AlgorithmTests>(json);
            if (test.array_size[0] != 10000 ||
                test.array_size[1] != 20000 ||
                test.array_size[2] != 30000)
                Assert.Fail("Array size incorrect");
            Assert.AreEqual(test.n_rep, 3, "Number of repetitions incorrect");
            Assert.AreEqual(test.min, -30000, "Minimum array value incorrect");
            Assert.AreEqual(test.max, 30000, "Maximum array value incorrect");
            if (algs[0] != test.algorithms[0] ||
                algs[1] != test.algorithms[1] ||
                algs[2] != test.algorithms[2] ||
                algs[3] != test.algorithms[3] ||
                algs[4] != test.algorithms[4] ||
                algs[5] != test.algorithms[5])
                Assert.Fail("Algorithm chosen incorrect");
        }

        [TestMethod()]
        public void FileWriteTest()
        {
            string expectedFile = "{\"array_size\":[10000,20000,30000,0,0],\"n_rep\":3,\"min\":-30000,\"max\":30000,\"algorithms\":[true,true,false,false,true,false],\"timeBubble\":[0.432114,1.7300627,3.8883213,0.0,0.0],\"timeHeap\":[0.0036458999999999997,0.0072492999999999993,0.0110721,0.0,0.0],\"timeInsertion\":[0.0,0.0,0.0,0.0,0.0],\"timeMerge\":[0.0,0.0,0.0,0.0,0.0],\"timeQuick\":[0.0019952,0.0046278,0.0069803999999999995,0.0,0.0],\"timeSelection\":[0.0,0.0,0.0,0.0,0.0],\"complete\":true}";
            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            string jsonRead = File.ReadAllText(wanted_path + "\\testfile.json");
            AlgorithmTests test = new AlgorithmTests();
            test = JsonConvert.DeserializeObject<AlgorithmTests>(jsonRead);
            var settings = new JsonSerializerSettings() { StringEscapeHandling = StringEscapeHandling.EscapeHtml };
            string jsonToWrite = (JsonConvert.SerializeObject(test, settings));
            File.WriteAllText(wanted_path + "\\testfile2.json", jsonToWrite);
            string actualFile = File.ReadAllText(wanted_path + "\\testfile2.json");
            Assert.AreEqual(expectedFile, actualFile, "Written file does not match read file");
        }
    }
}