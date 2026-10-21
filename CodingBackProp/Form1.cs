using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CodingBackProp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Wire up the button click event programmatically if not linked in designer
            btnStartTraining.Click += BtnStartTraining_Click;

            // Customize appearance if desired
            richTextBoxLog.BackColor = Color.Black;
            richTextBoxLog.ForeColor = Color.Lime;
            richTextBoxLog.Font = new Font("Consolas", 10);
            this.Text = "Neural Network Backpropagation (Cross-Entropy + Weight Decay)";
        }

        private async void BtnStartTraining_Click(object sender, EventArgs e)
        {
            btnStartTraining.Enabled = false;
            richTextBoxLog.Clear();

            // Parse parameters safely from designer text boxes
            int maxEpochs = int.TryParse(txtEpochs.Text, out int ep) ? ep : 1000;
            double learnRate = double.TryParse(txtLearnRate.Text, out double lr) ? lr : 0.05;
            double momentum = double.TryParse(txtMomentum.Text, out double mom) ? mom : 0.01;
            double decayRate = double.TryParse(txtDecayRate.Text, out double dec) ? dec : 0.0005;

            // Redirect Console.Out to our RichTextBox log window
            var textboxWriter = new TextBoxWriter(richTextBoxLog);
            Console.SetOut(textboxWriter);

            // Run training asynchronously so the UI thread doesn't freeze
            await System.Threading.Tasks.Task.Run(() =>
            {
                RunFormDemo(maxEpochs, learnRate, momentum, decayRate);
            });

            btnStartTraining.Enabled = true;
        }

        // Adapted version of your BackPropProgram logic that accepts UI parameters
        public static void RunFormDemo(int maxEpochs, double learnRate, double momentum, double decayRate)
        {
            Console.WriteLine("Begin neural network back-propagation demo (Cross-Entropy + Weight Decay)");

            int numInput = 4;
            int numHidden = 5;
            int numOutput = 3;
            int numRows = 1000;
            int seed = 1;

            Console.WriteLine($"\nGenerating {numRows} artificial data items with {numInput} features...");
            double[][] allData = BackPropProgram.MakeAllDataForForm(numInput, numHidden, numOutput, numRows, seed);
            Console.WriteLine("Done.");

            Console.WriteLine("\nCreating train (80%) and test (20%) matrices...");
            BackPropProgram.SplitTrainTest(allData, 0.80, seed, out double[][] trainData, out double[][] testData);
            Console.WriteLine("Done.\n");

            Console.WriteLine($"Creating a {numInput}-{numHidden}-{numOutput} neural network...");
            NeuralNetwork nn = new NeuralNetwork(numInput, numHidden, numOutput);

            Console.WriteLine($"\nParameters: maxEpochs={maxEpochs}, learnRate={learnRate:F2}, momentum={momentum:F2}, decayRate={decayRate:F4}");
            Console.WriteLine("\nStarting training...");

            double[] weights = nn.Train(trainData, maxEpochs, learnRate, momentum, decayRate);
            Console.WriteLine("Training completed successfully.");

            double trainAcc = nn.Accuracy(trainData);
            Console.WriteLine($"\nFinal accuracy on training data = {trainAcc:F4}");

            double testAcc = nn.Accuracy(testData);
            Console.WriteLine($"Final accuracy on test data     = {testAcc:F4}\n");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Placeholder for designer event hook if accidentally clicked
        }
    }

    // Helper class to safely stream Console.WriteLine outputs into a WinForms RichTextBox
    public class TextBoxWriter : TextWriter
    {
        private readonly RichTextBox _output;

        public TextBoxWriter(RichTextBox output)
        {
            _output = output;
        }

        public override void Write(char value)
        {
            base.Write(value);
            AppendText(value.ToString());
        }

        public override void Write(string value)
        {
            base.Write(value);
            AppendText(value);
        }

        public override Encoding Encoding => Encoding.UTF8;

        private void AppendText(string text)
        {
            if (_output.InvokeRequired)
            {
                _output.Invoke(new Action<string>(AppendText), text);
            }
            else
            {
                _output.AppendText(text);
                _output.ScrollToCaret();
            }
        }
    }
}