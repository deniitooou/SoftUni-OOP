using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        private string model;
        private string color;

        public Seat(string model, string color)
        {
            this.model = model;
            this.color = color;
        }

        public string Model =>this.model;
        public string Color => this.color;

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{ this.Color} { this.GetType().Name} { this.Model}");
            sb.AppendLine(this.Start());
            sb.AppendLine(this.Stop());

            return sb.ToString().Trim();
        }
    }
}
