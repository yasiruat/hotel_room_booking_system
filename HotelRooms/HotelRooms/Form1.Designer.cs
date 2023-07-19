namespace HotelRooms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nameTxt = new TextBox();
            addressTxt = new TextBox();
            numberOfRoomsTxt = new TextBox();
            roomTypeComboBox = new ComboBox();
            calculateBtn = new Button();
            clearBtn = new Button();
            exitBtn = new Button();
            label6 = new Label();
            anotherBookingComboBox = new ComboBox();
            label7 = new Label();
            totalCostLabel = new Label();
            label8 = new Label();
            numberOfDaysTxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(324, 34);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 0;
            label1.Text = "Booking Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(53, 86);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 129);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(53, 171);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 3;
            label4.Text = "Room Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(53, 209);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 4;
            label5.Text = "Number of Rooms";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(210, 79);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(272, 27);
            nameTxt.TabIndex = 5;
            // 
            // addressTxt
            // 
            addressTxt.Location = new Point(210, 126);
            addressTxt.Name = "addressTxt";
            addressTxt.Size = new Size(272, 27);
            addressTxt.TabIndex = 6;
            // 
            // numberOfRoomsTxt
            // 
            numberOfRoomsTxt.Location = new Point(210, 206);
            numberOfRoomsTxt.Name = "numberOfRoomsTxt";
            numberOfRoomsTxt.Size = new Size(66, 27);
            numberOfRoomsTxt.TabIndex = 7;
            // 
            // roomTypeComboBox
            // 
            roomTypeComboBox.FormattingEnabled = true;
            roomTypeComboBox.Items.AddRange(new object[] { "Single", "Double", "Family", "Suite" });
            roomTypeComboBox.Location = new Point(210, 168);
            roomTypeComboBox.Name = "roomTypeComboBox";
            roomTypeComboBox.Size = new Size(151, 28);
            roomTypeComboBox.TabIndex = 8;
            // 
            // calculateBtn
            // 
            calculateBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            calculateBtn.Location = new Point(608, 77);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(147, 29);
            calculateBtn.TabIndex = 9;
            calculateBtn.Text = "Calculate the Price ";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.Location = new Point(608, 124);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(78, 29);
            clearBtn.TabIndex = 10;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.Location = new Point(608, 171);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(78, 29);
            exitBtn.TabIndex = 11;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(53, 309);
            label6.Name = "label6";
            label6.Size = new Size(287, 20);
            label6.TabIndex = 12;
            label6.Text = "Do you want to do an another booking?";
            // 
            // anotherBookingComboBox
            // 
            anotherBookingComboBox.FormattingEnabled = true;
            anotherBookingComboBox.Items.AddRange(new object[] { "Yes", "No" });
            anotherBookingComboBox.Location = new Point(346, 306);
            anotherBookingComboBox.Name = "anotherBookingComboBox";
            anotherBookingComboBox.Size = new Size(69, 28);
            anotherBookingComboBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(539, 309);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 14;
            label7.Text = "Total Cost";
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Location = new Point(636, 309);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(0, 20);
            totalCostLabel.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(53, 255);
            label8.Name = "label8";
            label8.Size = new Size(124, 20);
            label8.TabIndex = 16;
            label8.Text = "Number of Days";
            // 
            // numberOfDaysTxt
            // 
            numberOfDaysTxt.Location = new Point(210, 248);
            numberOfDaysTxt.Name = "numberOfDaysTxt";
            numberOfDaysTxt.Size = new Size(66, 27);
            numberOfDaysTxt.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(numberOfDaysTxt);
            Controls.Add(label8);
            Controls.Add(totalCostLabel);
            Controls.Add(label7);
            Controls.Add(anotherBookingComboBox);
            Controls.Add(label6);
            Controls.Add(exitBtn);
            Controls.Add(clearBtn);
            Controls.Add(calculateBtn);
            Controls.Add(roomTypeComboBox);
            Controls.Add(numberOfRoomsTxt);
            Controls.Add(addressTxt);
            Controls.Add(nameTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nameTxt;
        private TextBox addressTxt;
        private TextBox numberOfRoomsTxt;
        private ComboBox roomTypeComboBox;
        private Button calculateBtn;
        private Button clearBtn;
        private Button exitBtn;
        private Label label6;
        private ComboBox anotherBookingComboBox;
        private Label label7;
        private Label totalCostLabel;
        private Label label8;
        private TextBox numberOfDaysTxt;
    }
}