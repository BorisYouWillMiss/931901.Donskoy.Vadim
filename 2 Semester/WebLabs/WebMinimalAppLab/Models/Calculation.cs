namespace WebMinimalAppLab.Models
{
    public class Calculation
    {
        public Calculation(int a, int b) 
        {
            Doable = true;

            ValueOne = a;
            ValueTwo = b;

            Sum = a + b;
            Mult = a * b;

            if (b != 0)
            { Div = a / b; }
            else Doable = false;

            Sub = a - b;
        }
        public Calculation()
        {
            Doable = true;

            var Rand = new Random();
            int Num1 = Rand.Next(10);
            int Num2 = Rand.Next(10);


            ValueOne = Num1;
            ValueTwo = Num2;
            Sum = Num1 + Num2;
            Mult = Num1 * Num2;
            Sub = Num1 - Num2;
            Div = 0;

            if (Num2 == 0) Doable = false;
            else 
                Div = Num1/ Num2;

        }
        public int ValueOne { get; set; }
        public int ValueTwo { get; set; }
        private int Helper { get; set; }
        public bool Doable { get; set; }

        public int Sum { get; set; }
        public int Mult { get; set; }
        public int Div { get; set; }
        public int Sub { get; set; }

    }
}
