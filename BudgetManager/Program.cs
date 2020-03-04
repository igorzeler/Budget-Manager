﻿using BudgetManager.Models.DB;
using BudgetManager.Models.Services;
using BudgetManager.Models.Stats;
using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using BudgetManager.Models.BL;

namespace BudgetManager
{
    class Program
    {
        private static IWriter _writer;
        private static IReader _reader;
        private static IMenu _menu;

        static void Main(string[] args)
        {
            _reader = new Reader("db.txt");
            _writer = new Writer("db.txt");
            var selected = "";
            do
            {
                DisplayMenu();
                selected = Console.ReadLine();
                RunSelected(selected);
            }
            while (selected != "6");
        }
        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Transaction list");
            Console.WriteLine("2 - Monthly summary");
            Console.WriteLine("3 - Add outcome");
            Console.WriteLine("4 - Add income");
            Console.WriteLine("5 - Remove transaction");
            Console.WriteLine("6 - Exit");
            Console.WriteLine("Chosen action: ");
        }
        private static void RunSelected(string selected)
        {
            switch (selected)
            {
                case "1":
                    ShowList();
                    break;
                case "2":
                    ShowReport();
                    break;
                case "3":
                    AddOutcome();
                    break;
                case "4":
                    AddIncome();
                    break;
                case "5":
                    RemoveTransaction();
                    break;
            }
        }

        private static void ShowList()
        {
            Console.Clear();
            Console.WriteLine("Display transactions");

            List list = new List(_reader);

            list.DisplayList();
            Console.ReadKey();
        }
        private static void ShowReport()
        {
            Console.Clear();

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            Summary report = new Summary(_reader);

            report.DisplayReport(year, month);
            Console.ReadKey();
        }
        private static void AddOutcome()
        {
            Console.Clear();

            Console.WriteLine("New outcome");

            Console.WriteLine("Name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Amount: ");
            var value = Console.ReadLine();
            var amount = decimal.Parse(value);

            Console.WriteLine("Date: ");
            value = Console.ReadLine();
            DateTime date = DateTime.Parse(value);

            Service service = new Service(_reader, _writer);
            service.AddOutcome(amount, name, date);
        }
        private static void AddIncome()
        {
            Console.Clear();

            Console.WriteLine("New income");

            Console.WriteLine("Name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Amount: ");
            var value = Console.ReadLine();
            var amount = decimal.Parse(value);

            Console.WriteLine("Date: ");
            value = Console.ReadLine();
            DateTime date = DateTime.Parse(value);

            Service service = new Service(_reader, _writer);
            service.AddIncome(amount, name, date);
        }
        private static void RemoveTransaction()
        {
            Console.Clear();
            Console.WriteLine("Input ID to remove: ");
            var selectedId = Console.ReadLine();
            var id = int.Parse(selectedId);

            Service service = new Service(_reader, _writer);
            service.RemoveById(id);
        }
    }
}
