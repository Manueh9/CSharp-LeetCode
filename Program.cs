using src.problems.arrays;

namespace src
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var optionSection = args.Length > 0 ? args[0] : "1";
            var optionExecution = args.Length > 0 ? args[1] : "Array";
            
            Methods.MethodSection(optionSection, optionExecution);
        }
    }

    public static class Methods
    {
        public static void MethodSection(string optionSection, string optionExecution)
        {
            switch (optionSection)
            {
                case "Array": MethodToExecute(optionExecution); break;
            }
        }

        private static void MethodToExecute(string optionExecution)
        {
            switch (optionExecution)
            {
                case "1": case "01":
                case "ConcatenationOfArray": ConcatenationOfArray.Run(); break;

                case "2": case "02":
                case "ShuffleTheArray": ShuffleTheArray.Run(); break;
                
                case "3": case "03":
                case "FindMaxConsecutiveOnes": FindMaxConsecutiveOnes.Run(); break;
            }
        }
    }
}
