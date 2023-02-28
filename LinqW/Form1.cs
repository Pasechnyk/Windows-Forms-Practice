using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Intro to LINQ
// Task - Make a listBox with 7 functions.
namespace LinqW
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        List<int> years = new List<int>();
        List<string> strings = new List<string>();
        public Form1()
        {
            InitializeComponent();

            // data lists
            numbers.AddRange(new[]
            {
                 -6, -17, 8, 74, 15, 41, 0, 26, 99, 108, 3
            });
            years.AddRange(new[]
            {
                2000, 2004, 2007, 2009, 2012, 2016, 2020, 2023
            });
            strings.AddRange(new[]
            {
                "Black", "cat", "sits", "in", "the", "garden"
            });

            combinedList.DataSource = numbers;
        }

        // Task 1 - Sort array by ascending
        private void SortByAscBtnClick(object sender, EventArgs e)
        {
            combinedList.DataSource = null;
            combinedList.DataSource = numbers.Where(num => num > 0).OrderBy(x => x).ToList();
        }

        // Task 2 - Find sum of positive 2-digit numbers
        private void AverageCountBtnClick(object sender, EventArgs e)
        {
            combinedList.DataSource = null;
            var poisitivTwoDigits = numbers.Where(x => x > 0 && x >= 10 && x <= 99).ToList();
            var average = poisitivTwoDigits.Average();

            MessageBox.Show($"Amount of positive 2-digit values is {poisitivTwoDigits.Count()}" +
                $" and their value is {average}.");
        }

        // Task 3 - Show leap years sorted by descending
        private void LeapYearBtnClick(object sender, EventArgs e)
        {
            combinedList.DataSource = null;
            var leapYears = years.Where(x => DateTime.IsLeapYear(x)).OrderByDescending(x => x).ToList();

            combinedList.DataSource = leapYears;
        }

        // Task 4 - Find max even number 
        private void EvenValueBtnClick(object sender, EventArgs e)
        {
            combinedList.DataSource = null;
            var evenNumbers = numbers.Where(num => num % 2 == 0).ToList();
            var maxEven = evenNumbers.Max();

            combinedList.Items.Add(maxEven);
        }

        // Task 5 - Add 3 exclamation marks to string
        private void ExclMarkBtnClick(object sender, EventArgs e)
        {
            combinedList.DataSource = null;
            var updatedString = strings.Select(x => x + "!!!").ToList();

            combinedList.DataSource = updatedString;
        }

        // Task 6 - Show string with given symbol
        private void FindSymbolBtnClick(object sender, EventArgs e)
        {
            combinedList.DataSource = null;
            char symbol = 'c';
            var symbolString = strings.Where(x => x.Contains(symbol)).ToList();

            combinedList.DataSource = symbolString;
        }

        // Task 7 - Group strings by symbols amount
        private void GroupByCountBtnClick(object sender, EventArgs e)
        {
            combinedList.DataSource = null;
            var groupedString = strings.GroupBy(x => x.Length);

            foreach (var item in groupedString)
            {
                combinedList.Items.Add(item.Key);
            }
        }
    }
}
