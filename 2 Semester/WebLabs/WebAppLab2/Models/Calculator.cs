namespace WebAppLab2.Models
{
    public class Calculator
    {
        public int numberOne { get; set; }
        public int numberTwo { get; set; }
        public string operation { get; set; } = "+";
        public int Calculate()
        {
            if (operation == "+")
                return (numberOne + numberTwo);
            else if (operation == "-")
                return (numberOne - numberTwo);
            else if (operation == "*")
                return (numberOne * numberTwo);
            else if (operation == "/")
                return (numberOne / numberTwo);

            return 0;
        }
    }
}
