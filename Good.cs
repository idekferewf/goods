using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goods
{
    public class Good
    {
        private string name_;
        private double price_;
        private Groups group_;

        public Good(string name, int price, Groups group)
        {
            this.name_ = name;
            this.price_ = price;
            this.group_ = group;
        }

        public string GetName()
        {
            return this.name_;
        }

        public double GetPrice()
        {
            return this.price_;
        }

        public Groups GetGroup()
        {
            return this.group_;
        }
    }
}
