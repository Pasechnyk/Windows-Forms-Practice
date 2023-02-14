using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

// Task - Create Booking system application.

namespace BookRoom
{
    public partial class Form1 : Form
    {
        // rooms list
        public List<Room> rooms = new();
        public string RoomChoice { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        // check room type
        public void CheckRoomType()
        {
            if (economRadioBtn.Checked)
            {
                RoomChoice = "Econom";
            }
            else if (standardRadioBtn.Checked)
            {
                RoomChoice = "Standard";
            }
            else if (suiteRadioBtn.Checked)
            {
                RoomChoice = "Suite";
            }
            else { RoomChoice = null; }
        }

        // check if agreeBox is checked
        private void AgreeBoxCheckedChanged(object sender, EventArgs e)
        {
            if (agreeCheckBox.Checked)
            {
                bookBtn.Enabled = true;
            }
            else  { bookBtn.Enabled = false; }
        }

        private void BookRoomBtnClick(object sender, EventArgs e)
        {
            // additional check-up for present room type
            if (agreeCheckBox.Checked && RoomChoice != null)
            {
                CheckRoomType();

                MessageBox.Show($"Successful!\n" +
                    $"Information about your booking: \n\n" +
                    $"Name - {nameBox}\n" +
                    $"Surname: {surnameBox.Text}\n" +
                    $"Contact Information: {contactMaskedBox.Text}\n" +
                    $"Amount of people registered: {amountNumericBox.Value}\n" +
                    $"Room type: {RoomChoice}\n" +
                    $"Recommendations: {recommendationBox.Text}\n" +
                    $"Date: {dateCalendar.Text}");
            }
            else { MessageBox.Show($"You've missed something!"); }
        }

        private void CancelBtnClick(object sender, EventArgs e)
        {
            // clears all information
            nameBox.Clear();
            surnameBox.Clear();
            contactMaskedBox.Clear();
            amountNumericBox.Value = 1; // min value 1

            // uncheck radiobuttons
            economRadioBtn.Checked = false;
            standardRadioBtn.Checked = false;
            suiteRadioBtn.Checked = false;

            recommendationBox.Clear();
            dateCalendar.Value = DateTime.Now;
            agreeCheckBox.Checked = false;
        }

        // serialization
        private void SaveBtnClick(object sender, EventArgs e)
        {
            CheckRoomType();

            rooms.Add(new Room()
            {
                Name = nameBox.Text,
                Surname = surnameBox.Text,
                Contact = contactMaskedBox.Text,
                AmountOfPeople = (int)amountNumericBox.Value,
                RoomType = RoomChoice,
                Recommendation = recommendationBox.Text,
                Date = dateCalendar.ToString()
            });

            try
            {
                string json = JsonConvert.SerializeObject(rooms);
                File.WriteAllText("Bookings.json", json);
                MessageBox.Show("Save is completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // deserialization
        private void LoadBtnClick(object sender, EventArgs e)
        {
            try
            {
                string json = File.ReadAllText("Bookings.json");
                Room room = System.Text.Json.JsonSerializer.Deserialize<Room>(json);

                nameBox.Text = room.Name;
                surnameBox.Text = room.Surname;
                contactMaskedBox.Text = room.Contact;
                amountNumericBox.Value = room.AmountOfPeople;
                if (economRadioBtn.Checked)
                {
                    RoomChoice = "Econom";
                }
                else if (standardRadioBtn.Checked)
                {
                    RoomChoice = "Standard";
                }
                else if (suiteRadioBtn.Checked)
                {
                    RoomChoice = "Suite";
                }
                recommendationBox.Text = room.Recommendation;
                dateCalendar.Value = DateTime.Parse(room.Date);

                MessageBox.Show("Loaded successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
