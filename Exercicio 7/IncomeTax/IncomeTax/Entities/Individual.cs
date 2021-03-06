﻿namespace IncomeTax.Entities
{
    class Individual : TaxPayer
    {
        public double HealthSpent { get; set; } = 0;

        public Individual(double healthSpent, string name, double anualIncame) : base(name, anualIncame)
        {
            HealthSpent = healthSpent;
        }

        public override double TotalTax()
        {
            if (AnualIncame <= 20000)
            {
                return (AnualIncame * 0.15) - (HealthSpent * 0.5);
            }
            else
            {
                return (AnualIncame * 0.25) - (HealthSpent * 0.5);
            }

        }

    }
}
