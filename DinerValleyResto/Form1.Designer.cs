namespace DinerValleyResto
{
    partial class FormOne
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxDrinkSelection = new System.Windows.Forms.GroupBox();
            this.radioButtonCoffee = new System.Windows.Forms.RadioButton();
            this.radioButtonTea = new System.Windows.Forms.RadioButton();
            this.radioButtonLemonade = new System.Windows.Forms.RadioButton();
            this.radioButtonSoda = new System.Windows.Forms.RadioButton();
            this.radioButtonJuice = new System.Windows.Forms.RadioButton();
            this.radioButtonMilk = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxEntreeSelection = new System.Windows.Forms.ListBox();
            this.labelEntreeSelection = new System.Windows.Forms.Label();
            this.labelSpecialRequest = new System.Windows.Forms.Label();
            this.comboBoxSpecialRequest = new System.Windows.Forms.ComboBox();
            this.checkBoxWater = new System.Windows.Forms.CheckBox();
            this.groupBoxDrinkSelection.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDrinkSelection
            // 
            this.groupBoxDrinkSelection.Controls.Add(this.radioButtonCoffee);
            this.groupBoxDrinkSelection.Controls.Add(this.radioButtonTea);
            this.groupBoxDrinkSelection.Controls.Add(this.radioButtonLemonade);
            this.groupBoxDrinkSelection.Controls.Add(this.radioButtonSoda);
            this.groupBoxDrinkSelection.Controls.Add(this.radioButtonJuice);
            this.groupBoxDrinkSelection.Controls.Add(this.radioButtonMilk);
            this.groupBoxDrinkSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDrinkSelection.Location = new System.Drawing.Point(218, 74);
            this.groupBoxDrinkSelection.Name = "groupBoxDrinkSelection";
            this.groupBoxDrinkSelection.Size = new System.Drawing.Size(172, 203);
            this.groupBoxDrinkSelection.TabIndex = 0;
            this.groupBoxDrinkSelection.TabStop = false;
            this.groupBoxDrinkSelection.Text = "Drink Selection";
            this.groupBoxDrinkSelection.Enter += new System.EventHandler(this.groupBoxDrinkSelection_Enter);
            // 
            // radioButtonCoffee
            // 
            this.radioButtonCoffee.AutoSize = true;
            this.radioButtonCoffee.Font = new System.Drawing.Font("Calibri", 12F);
            this.radioButtonCoffee.Location = new System.Drawing.Point(6, 175);
            this.radioButtonCoffee.Name = "radioButtonCoffee";
            this.radioButtonCoffee.Size = new System.Drawing.Size(69, 23);
            this.radioButtonCoffee.TabIndex = 5;
            this.radioButtonCoffee.Text = "Coffee";
            this.radioButtonCoffee.UseVisualStyleBackColor = true;
            this.radioButtonCoffee.CheckedChanged += new System.EventHandler(this.radioButtonCoffee_CheckedChanged);
            // 
            // radioButtonTea
            // 
            this.radioButtonTea.AutoSize = true;
            this.radioButtonTea.Font = new System.Drawing.Font("Calibri", 12F);
            this.radioButtonTea.Location = new System.Drawing.Point(6, 146);
            this.radioButtonTea.Name = "radioButtonTea";
            this.radioButtonTea.Size = new System.Drawing.Size(50, 23);
            this.radioButtonTea.TabIndex = 4;
            this.radioButtonTea.Text = "Tea";
            this.radioButtonTea.UseVisualStyleBackColor = true;
            this.radioButtonTea.CheckedChanged += new System.EventHandler(this.radioButtonTea_CheckedChanged);
            // 
            // radioButtonLemonade
            // 
            this.radioButtonLemonade.AutoSize = true;
            this.radioButtonLemonade.Font = new System.Drawing.Font("Calibri", 12F);
            this.radioButtonLemonade.Location = new System.Drawing.Point(6, 118);
            this.radioButtonLemonade.Name = "radioButtonLemonade";
            this.radioButtonLemonade.Size = new System.Drawing.Size(94, 23);
            this.radioButtonLemonade.TabIndex = 3;
            this.radioButtonLemonade.Text = "Lemonade";
            this.radioButtonLemonade.UseVisualStyleBackColor = true;
            this.radioButtonLemonade.CheckedChanged += new System.EventHandler(this.radioButtonLemonade_CheckedChanged);
            // 
            // radioButtonSoda
            // 
            this.radioButtonSoda.AutoSize = true;
            this.radioButtonSoda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSoda.Location = new System.Drawing.Point(6, 88);
            this.radioButtonSoda.Name = "radioButtonSoda";
            this.radioButtonSoda.Size = new System.Drawing.Size(58, 23);
            this.radioButtonSoda.TabIndex = 2;
            this.radioButtonSoda.Text = "Soda";
            this.radioButtonSoda.UseVisualStyleBackColor = true;
            this.radioButtonSoda.CheckedChanged += new System.EventHandler(this.radioButtonSoda_CheckedChanged);
            // 
            // radioButtonJuice
            // 
            this.radioButtonJuice.AutoSize = true;
            this.radioButtonJuice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonJuice.Location = new System.Drawing.Point(6, 58);
            this.radioButtonJuice.Name = "radioButtonJuice";
            this.radioButtonJuice.Size = new System.Drawing.Size(59, 23);
            this.radioButtonJuice.TabIndex = 1;
            this.radioButtonJuice.Text = "Juice";
            this.radioButtonJuice.UseVisualStyleBackColor = true;
            this.radioButtonJuice.CheckedChanged += new System.EventHandler(this.radioButtonJuice_CheckedChanged);
            // 
            // radioButtonMilk
            // 
            this.radioButtonMilk.AutoSize = true;
            this.radioButtonMilk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMilk.Location = new System.Drawing.Point(6, 28);
            this.radioButtonMilk.Name = "radioButtonMilk";
            this.radioButtonMilk.Size = new System.Drawing.Size(55, 23);
            this.radioButtonMilk.TabIndex = 0;
            this.radioButtonMilk.Text = "Milk";
            this.radioButtonMilk.UseVisualStyleBackColor = true;
            this.radioButtonMilk.CheckedChanged += new System.EventHandler(this.radioButtonMilk_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(402, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeOrderToolStripMenuItem,
            this.clearOrderToolStripMenuItem,
            this.displayOrderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // placeOrderToolStripMenuItem
            // 
            this.placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            this.placeOrderToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.placeOrderToolStripMenuItem.Text = "Place Order";
            this.placeOrderToolStripMenuItem.Click += new System.EventHandler(this.placeOrderToolStripMenuItem_Click);
            // 
            // clearOrderToolStripMenuItem
            // 
            this.clearOrderToolStripMenuItem.Name = "clearOrderToolStripMenuItem";
            this.clearOrderToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.clearOrderToolStripMenuItem.Text = "Clear Order";
            this.clearOrderToolStripMenuItem.Click += new System.EventHandler(this.clearOrderToolStripMenuItem_Click);
            // 
            // displayOrderToolStripMenuItem
            // 
            this.displayOrderToolStripMenuItem.Name = "displayOrderToolStripMenuItem";
            this.displayOrderToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.displayOrderToolStripMenuItem.Text = "Display Order";
            this.displayOrderToolStripMenuItem.Click += new System.EventHandler(this.displayOrderToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entreeToolStripMenuItem,
            this.drinkToolStripMenuItem,
            this.specialRequestToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // entreeToolStripMenuItem
            // 
            this.entreeToolStripMenuItem.Name = "entreeToolStripMenuItem";
            this.entreeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.entreeToolStripMenuItem.Text = "Entree";
            this.entreeToolStripMenuItem.Click += new System.EventHandler(this.entreeToolStripMenuItem_Click);
            // 
            // drinkToolStripMenuItem
            // 
            this.drinkToolStripMenuItem.Name = "drinkToolStripMenuItem";
            this.drinkToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.drinkToolStripMenuItem.Text = "Drink";
            this.drinkToolStripMenuItem.Click += new System.EventHandler(this.drinkToolStripMenuItem_Click);
            // 
            // specialRequestToolStripMenuItem
            // 
            this.specialRequestToolStripMenuItem.Name = "specialRequestToolStripMenuItem";
            this.specialRequestToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.specialRequestToolStripMenuItem.Text = "Special Requests";
            this.specialRequestToolStripMenuItem.Click += new System.EventHandler(this.specialRequestToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // listBoxEntreeSelection
            // 
            this.listBoxEntreeSelection.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxEntreeSelection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEntreeSelection.FormattingEnabled = true;
            this.listBoxEntreeSelection.ItemHeight = 19;
            this.listBoxEntreeSelection.Items.AddRange(new object[] {
            "Chicken Salad",
            "Ham and Cheese",
            "Turkey",
            "Vegetable Wrap",
            "Tuna Salad",
            "Avocado and Cheese",
            "Club",
            "Peanut Butter and Jelly",
            "Grilled Cheese",
            "Reuben"});
            this.listBoxEntreeSelection.Location = new System.Drawing.Point(12, 102);
            this.listBoxEntreeSelection.Name = "listBoxEntreeSelection";
            this.listBoxEntreeSelection.Size = new System.Drawing.Size(162, 156);
            this.listBoxEntreeSelection.TabIndex = 2;
            this.listBoxEntreeSelection.SelectedIndexChanged += new System.EventHandler(this.listBoxEntreeSelection_SelectedIndexChanged);
            // 
            // labelEntreeSelection
            // 
            this.labelEntreeSelection.AutoSize = true;
            this.labelEntreeSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntreeSelection.Location = new System.Drawing.Point(12, 75);
            this.labelEntreeSelection.Name = "labelEntreeSelection";
            this.labelEntreeSelection.Size = new System.Drawing.Size(165, 24);
            this.labelEntreeSelection.TabIndex = 3;
            this.labelEntreeSelection.Text = "Entree Selection";
            // 
            // labelSpecialRequest
            // 
            this.labelSpecialRequest.AutoSize = true;
            this.labelSpecialRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecialRequest.Location = new System.Drawing.Point(30, 276);
            this.labelSpecialRequest.Name = "labelSpecialRequest";
            this.labelSpecialRequest.Size = new System.Drawing.Size(139, 18);
            this.labelSpecialRequest.TabIndex = 4;
            this.labelSpecialRequest.Text = "Special Requests";
            // 
            // comboBoxSpecialRequest
            // 
            this.comboBoxSpecialRequest.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxSpecialRequest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSpecialRequest.FormattingEnabled = true;
            this.comboBoxSpecialRequest.Items.AddRange(new object[] {
            "Whole Wheat",
            "White Bread",
            "Rye Bread",
            "Hold the Dressing",
            "Hold the Onion",
            "Hold the Mayo"});
            this.comboBoxSpecialRequest.Location = new System.Drawing.Point(33, 297);
            this.comboBoxSpecialRequest.Name = "comboBoxSpecialRequest";
            this.comboBoxSpecialRequest.Size = new System.Drawing.Size(128, 27);
            this.comboBoxSpecialRequest.TabIndex = 5;
            this.comboBoxSpecialRequest.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpecialRequest_SelectedIndexChanged);
            // 
            // checkBoxWater
            // 
            this.checkBoxWater.AutoSize = true;
            this.checkBoxWater.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWater.Location = new System.Drawing.Point(224, 297);
            this.checkBoxWater.Name = "checkBoxWater";
            this.checkBoxWater.Size = new System.Drawing.Size(71, 23);
            this.checkBoxWater.TabIndex = 6;
            this.checkBoxWater.Text = "Water ";
            this.checkBoxWater.UseVisualStyleBackColor = true;
            this.checkBoxWater.CheckedChanged += new System.EventHandler(this.checkBoxWater_CheckedChanged);
            // 
            // FormOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(402, 409);
            this.Controls.Add(this.checkBoxWater);
            this.Controls.Add(this.comboBoxSpecialRequest);
            this.Controls.Add(this.labelSpecialRequest);
            this.Controls.Add(this.labelEntreeSelection);
            this.Controls.Add(this.listBoxEntreeSelection);
            this.Controls.Add(this.groupBoxDrinkSelection);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student\'s Diner Valley";
            this.groupBoxDrinkSelection.ResumeLayout(false);
            this.groupBoxDrinkSelection.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDrinkSelection;
        private System.Windows.Forms.RadioButton radioButtonMilk;
        private System.Windows.Forms.RadioButton radioButtonTea;
        private System.Windows.Forms.RadioButton radioButtonLemonade;
        private System.Windows.Forms.RadioButton radioButtonSoda;
        private System.Windows.Forms.RadioButton radioButtonJuice;
        private System.Windows.Forms.RadioButton radioButtonCoffee;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxEntreeSelection;
        private System.Windows.Forms.Label labelEntreeSelection;
        private System.Windows.Forms.Label labelSpecialRequest;
        private System.Windows.Forms.ComboBox comboBoxSpecialRequest;
        private System.Windows.Forms.CheckBox checkBoxWater;
    }
}

