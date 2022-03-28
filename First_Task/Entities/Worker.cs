﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using First_Task_Employee.Entities.Enumerators;

namespace First_Task_Employee.Entities
{
    internal class Worker
    {
        public string Name { get; set; }

        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        public List<HourContract> Contracts { get; private set; } = new List<HourContract>(); //Instanciar para garantir que a lista não seja nula

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double basesalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = basesalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.totalValue();
                }             
            
            }
            return sum;
        }




    }
}



