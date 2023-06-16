using Imtihon29.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Imtihon29
{
    internal static class Program
    {
        public static string RenameText { get; set; }

        public static bool Checker { get; set; } = true;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static List<SectionClass> SectionList = new List<SectionClass>();

        public static List<Book> BookList = new List<Book>();

        public static List<Rent> RentList = new List<Rent>();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static void AddSection(string sectionName, string ImagePath)
        {
            SectionClass section = new SectionClass(sectionName, ImagePath);
            SectionList.Add(section);

            Directory.CreateDirectory("C:/IqroData");
            string path = $"C:/IqroData/{sectionName}.json";
            File.WriteAllText(path, "[]");
        }

        public static void FillSectionList()
        {
            try
            {
                string path = "C:/IqroData/sections.json";
                string JsonContent = File.ReadAllText(path);
                SectionList.Clear();
                SectionList = JsonConvert.DeserializeObject<List<SectionClass>>(JsonContent);
            }
            catch
            {
            }
        }

        public static void WriteSectionFile()
        {
            try
            {
                string path = "C:/IqroData/sections.json";
                var JsonContent = JsonConvert.SerializeObject(SectionList);
                File.WriteAllText(path, JsonContent);
            }
            catch
            {
            }
        }

        public static void AddBook(string name, string author, double price, int pageCount, int count, string imagePath, string ebout)
        {
            Book book = new Book(name, author, price, pageCount, count, imagePath);
            book.Ebout = ebout;
            BookList.Add(book);
        }

        public static void FillBookList(string name)
        {
            try
            {
                string path = $"C:/IqroData/{name}.json";
                string JsonContent = File.ReadAllText(path);
                BookList.Clear();
                BookList = JsonConvert.DeserializeObject<List<Book>>(JsonContent);
            }
            catch
            {
            }
        }

        public static void WriteBookFile(string name)
        {
            try
            {
                string path = $"C:/IqroData/{name}.json";
                var JsonContent = JsonConvert.SerializeObject(BookList);
                File.WriteAllText(path, JsonContent);
            }
            catch
            {
            }
        }

        public static void AddRentBook(string fullname, string pasData, string Pnumber, DateTime delDate, DateTime retDate, string ebout, Book obj)
        {
            Rent rent = new Rent(fullname,pasData,Pnumber,delDate,retDate,obj);
            rent.AddInformation = ebout;
            RentList.Add(rent);
        }

        public static void FillRentBookList()
        {
            try
            {
                string path = "C:/IqroData/rentbook.json";
                string JsonContent = File.ReadAllText(path);
                RentList.Clear();
                RentList = JsonConvert.DeserializeObject<List<Rent>>(JsonContent);
            }
            catch
            {
            }
        }

        public static void WriteRentBookFile()
        {
            try
            {
                string path = "C:/IqroData/rentbook.json";
                var JsonContent = JsonConvert.SerializeObject(RentList);
                File.WriteAllText(path, JsonContent);
            }
            catch
            {
            }
        }
    }
}
