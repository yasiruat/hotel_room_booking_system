namespace HotelRooms
{
    public partial class Form1 : Form
    {
        private const decimal singleRoomPrice = 5000;
        private const decimal doubleRoomPrice = 7500;
        private const decimal familyRoomPrice = 8000;
        private const decimal suiteRoomPrice = 12500;

        private int numberOfSingleRooms = 10;
        private int numberOfDoubleRooms = 7;
        private int numberOfFamilyRooms = 4;
        private int numberOfSuiteRooms = 2;

        private List<Booking> bookings;

        public Form1()
        {
            InitializeComponent();
            bookings = new List<Booking>();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTxt.Text) || string.IsNullOrEmpty(addressTxt.Text) || 
                string.IsNullOrEmpty(roomTypeComboBox.Text) || string.IsNullOrEmpty(numberOfDaysTxt.Text) || 
                string.IsNullOrEmpty(numberOfRoomsTxt.Text) || string.IsNullOrEmpty(anotherBookingComboBox.Text))
            {
                MessageBox.Show("All fields need to be filled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(!int.TryParse(numberOfRoomsTxt.Text, out int numberOfRooms))
            {
                MessageBox.Show("Number of Rooms must be a number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return;
            }

            if (!int.TryParse(numberOfDaysTxt.Text, out int numberOfDays))
            {
                MessageBox.Show("Number of Days must be a number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedRoomType = roomTypeComboBox.SelectedItem.ToString();


            if(!CheckAvailability(selectedRoomType, numberOfRooms)) 
            {
                MessageBox.Show(String.Format("{0} Rooms are not available at the moment", selectedRoomType), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalPrice = roomSelect(selectedRoomType, numberOfRooms, numberOfDays);

            Booking currentBooking = new Booking
            {
                RoomType = selectedRoomType,
                NumberOfRooms = numberOfRooms,
                NumberOfDays = numberOfDays,
                TotalPrice = totalPrice
            };
            bookings.Add(currentBooking);

            UpdateAvailability(selectedRoomType, numberOfRooms);

            CalculateTotalCost();

            string anotherBooking = anotherBookingComboBox.SelectedItem.ToString();
            if (anotherBooking == "Yes")
            {
                roomTypeComboBox.SelectedIndex = -1;
                numberOfRoomsTxt.Clear();
                numberOfDaysTxt.Clear();
                anotherBookingComboBox.SelectedIndex = -1;
            }
            else
            {
                calculateBtn.Enabled = false;
            }
        }

        private void UpdateAvailability(string selectedRoomType, int numberOfRooms)
        {
            switch (selectedRoomType)
            {
                case "Single":
                    numberOfRooms -= numberOfSingleRooms;
                    break;
                case "Double":
                    numberOfRooms -= numberOfDoubleRooms;
                    break;
                case "Family":
                    numberOfRooms -= numberOfFamilyRooms;
                    break;
                case "Suite":
                    numberOfRooms -= numberOfSuiteRooms;
                    break;
                
            }
        }

        private bool CheckAvailability(string selectedRoomType, int numberOfRooms)
        {
            int availableRooms = 0;
            
            switch(selectedRoomType)
            {
                case "Single":
                    availableRooms = numberOfSingleRooms;
                    break;
                case "Double":
                    availableRooms = numberOfDoubleRooms;
                    break;
                case "Family":
                    availableRooms = numberOfFamilyRooms;
                    break;
                case "Suite":
                    availableRooms = numberOfSuiteRooms;
                    break;
            }

            if(numberOfRooms > availableRooms)
            {
                return false;
            }

            int bookedRooms = GetNumberOfBookedRooms(selectedRoomType);
            if(numberOfRooms + bookedRooms > availableRooms)
            {
                return false;
            }
            return true;
        }

        private int GetNumberOfBookedRooms(string selectedRoomType)
        {
            int bookedRooms = 0;

            foreach(var booking in bookings)
            {
                if(booking.RoomType == selectedRoomType)
                {
                    bookedRooms += booking.NumberOfRooms;
                }
            }
            return bookedRooms;
        }

        private decimal roomSelect(String selectedRoomType, int numberOfRooms, int numberOfDays)
        {
            decimal totalPrice = 0;
            switch (selectedRoomType)
            {
                case "Single":
                    totalPrice = singleRoomPrice * numberOfRooms * numberOfDays;
                    break;
                case "Double":
                    if (numberOfDays > 5)
                    {
                        totalPrice = doubleRoomPrice * numberOfRooms * numberOfDays;
                        decimal discount = totalPrice * Convert.ToDecimal(0.05);
                        totalPrice = totalPrice - discount;
                    }
                    else
                    {
                        totalPrice = doubleRoomPrice * numberOfRooms * numberOfDays;
                    }
                    break;

                case "Family":
                    totalPrice = familyRoomPrice * numberOfRooms * numberOfDays;
                    break;
                case "Suite":
                    if (numberOfDays > 5)
                    {
                        totalPrice = suiteRoomPrice * numberOfRooms * numberOfDays;
                        decimal discount = totalPrice * Convert.ToDecimal(0.12);
                        totalPrice = totalPrice - discount;
                    }
                    else
                    {
                        totalPrice = suiteRoomPrice * numberOfRooms * numberOfDays;
                    }
                    break;
            }
            return totalPrice;
        }

        private void CalculateTotalCost()
        {
            decimal totalCost = 0;
            foreach (var booking in bookings)
            {
                totalCost += booking.TotalPrice;
            }
            totalCostLabel.Text = "";
            totalCostLabel.Text += totalCost.ToString();
        }

       
        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTxt.Clear();
            addressTxt.Clear();
            roomTypeComboBox.SelectedIndex = -1;
            numberOfRoomsTxt.Clear();
            numberOfDaysTxt.Clear();
            anotherBookingComboBox.SelectedIndex = -1;
            totalCostLabel.Text = "";
            bookings.Clear();
            calculateBtn.Enabled = true;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    class Booking
    {
        public string RoomType { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfDays { get; set; }
        public decimal TotalPrice { get; set; }
    }
}