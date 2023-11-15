
namespace PizzaFormButBetter
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraLargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newsizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allergyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glutenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dairyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eggsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizza_Picture = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.topping_Combo = new System.Windows.Forms.ComboBox();
            this.Quantity_lbl = new System.Windows.Forms.Label();
            this.decrease_btn = new System.Windows.Forms.Button();
            this.increase_btn = new System.Windows.Forms.Button();
            this.price_lbl = new System.Windows.Forms.Label();
            this.purchase_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reg_btn = new System.Windows.Forms.RadioButton();
            this.Sweet = new System.Windows.Forms.RadioButton();
            this.spicy_btn = new System.Windows.Forms.RadioButton();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizza_Picture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newsizeToolStripMenuItem,
            this.allergyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.smallToolStripMenuItem.Text = "Small";
            this.smallToolStripMenuItem.Click += new System.EventHandler(this.smallToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.largeToolStripMenuItem.Text = "Large";
            this.largeToolStripMenuItem.Click += new System.EventHandler(this.largeToolStripMenuItem_Click);
            // 
            // extraLargeToolStripMenuItem
            // 
            this.extraLargeToolStripMenuItem.Name = "extraLargeToolStripMenuItem";
            this.extraLargeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.extraLargeToolStripMenuItem.Text = "Extra Large";
            this.extraLargeToolStripMenuItem.Click += new System.EventHandler(this.extraLargeToolStripMenuItem_Click);
            // 
            // newsizeToolStripMenuItem
            // 
            this.newsizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.largeToolStripMenuItem,
            this.extraLargeToolStripMenuItem});
            this.newsizeToolStripMenuItem.Name = "newsizeToolStripMenuItem";
            this.newsizeToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.newsizeToolStripMenuItem.Text = "Size";
            this.newsizeToolStripMenuItem.Click += new System.EventHandler(this.quantityToolStripMenuItem_Click);
            // 
            // allergyToolStripMenuItem
            // 
            this.allergyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.glutenToolStripMenuItem,
            this.dairyToolStripMenuItem,
            this.eggsToolStripMenuItem});
            this.allergyToolStripMenuItem.Name = "allergyToolStripMenuItem";
            this.allergyToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.allergyToolStripMenuItem.Text = "Allergy Concerns";
            // 
            // glutenToolStripMenuItem
            // 
            this.glutenToolStripMenuItem.Name = "glutenToolStripMenuItem";
            this.glutenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.glutenToolStripMenuItem.Text = "Gluten";
            this.glutenToolStripMenuItem.Click += new System.EventHandler(this.glutenToolStripMenuItem_Click);
            // 
            // dairyToolStripMenuItem
            // 
            this.dairyToolStripMenuItem.Name = "dairyToolStripMenuItem";
            this.dairyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dairyToolStripMenuItem.Text = "Dairy";
            this.dairyToolStripMenuItem.Click += new System.EventHandler(this.dairyToolStripMenuItem_Click);
            // 
            // eggsToolStripMenuItem
            // 
            this.eggsToolStripMenuItem.Name = "eggsToolStripMenuItem";
            this.eggsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eggsToolStripMenuItem.Text = "Eggs";
            this.eggsToolStripMenuItem.Click += new System.EventHandler(this.eggsToolStripMenuItem_Click);
            // 
            // pizza_Picture
            // 
            this.pizza_Picture.Location = new System.Drawing.Point(24, 66);
            this.pizza_Picture.Name = "pizza_Picture";
            this.pizza_Picture.Size = new System.Drawing.Size(173, 166);
            this.pizza_Picture.TabIndex = 1;
            this.pizza_Picture.TabStop = false;
            // 
            // topping_Combo
            // 
            this.topping_Combo.FormattingEnabled = true;
            this.topping_Combo.Location = new System.Drawing.Point(325, 87);
            this.topping_Combo.Name = "topping_Combo";
            this.topping_Combo.Size = new System.Drawing.Size(121, 21);
            this.topping_Combo.TabIndex = 2;
            // 
            // Quantity_lbl
            // 
            this.Quantity_lbl.AutoSize = true;
            this.Quantity_lbl.Location = new System.Drawing.Point(361, 153);
            this.Quantity_lbl.Name = "Quantity_lbl";
            this.Quantity_lbl.Size = new System.Drawing.Size(52, 13);
            this.Quantity_lbl.TabIndex = 3;
            this.Quantity_lbl.Text = "Quantity: ";
            // 
            // decrease_btn
            // 
            this.decrease_btn.Location = new System.Drawing.Point(283, 209);
            this.decrease_btn.Name = "decrease_btn";
            this.decrease_btn.Size = new System.Drawing.Size(75, 23);
            this.decrease_btn.TabIndex = 4;
            this.decrease_btn.Text = "Remove";
            this.decrease_btn.UseVisualStyleBackColor = true;
            this.decrease_btn.Click += new System.EventHandler(this.decrease_btn_Click);
            // 
            // increase_btn
            // 
            this.increase_btn.Location = new System.Drawing.Point(413, 209);
            this.increase_btn.Name = "increase_btn";
            this.increase_btn.Size = new System.Drawing.Size(75, 23);
            this.increase_btn.TabIndex = 5;
            this.increase_btn.Text = "Add";
            this.increase_btn.UseVisualStyleBackColor = true;
            this.increase_btn.Click += new System.EventHandler(this.increase_btn_Click);
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Location = new System.Drawing.Point(100, 311);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(37, 13);
            this.price_lbl.TabIndex = 6;
            this.price_lbl.Text = "Price: ";
            // 
            // purchase_btn
            // 
            this.purchase_btn.Location = new System.Drawing.Point(338, 306);
            this.purchase_btn.Name = "purchase_btn";
            this.purchase_btn.Size = new System.Drawing.Size(75, 23);
            this.purchase_btn.TabIndex = 7;
            this.purchase_btn.Text = "Purchase";
            this.purchase_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spicy_btn);
            this.groupBox1.Controls.Add(this.Sweet);
            this.groupBox1.Controls.Add(this.reg_btn);
            this.groupBox1.Location = new System.Drawing.Point(203, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 121);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sauce";
            // 
            // reg_btn
            // 
            this.reg_btn.AutoSize = true;
            this.reg_btn.Location = new System.Drawing.Point(6, 19);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(62, 17);
            this.reg_btn.TabIndex = 0;
            this.reg_btn.TabStop = true;
            this.reg_btn.Text = "Regular";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.CheckedChanged += new System.EventHandler(this.reg_btn_CheckedChanged);
            // 
            // Sweet
            // 
            this.Sweet.AutoSize = true;
            this.Sweet.Location = new System.Drawing.Point(6, 52);
            this.Sweet.Name = "Sweet";
            this.Sweet.Size = new System.Drawing.Size(55, 17);
            this.Sweet.TabIndex = 1;
            this.Sweet.TabStop = true;
            this.Sweet.Text = "Sweet";
            this.Sweet.UseVisualStyleBackColor = true;
            this.Sweet.CheckedChanged += new System.EventHandler(this.Sweet_CheckedChanged);
            // 
            // spicy_btn
            // 
            this.spicy_btn.AutoSize = true;
            this.spicy_btn.Location = new System.Drawing.Point(6, 85);
            this.spicy_btn.Name = "spicy_btn";
            this.spicy_btn.Size = new System.Drawing.Size(51, 17);
            this.spicy_btn.TabIndex = 2;
            this.spicy_btn.TabStop = true;
            this.spicy_btn.Text = "Spicy";
            this.spicy_btn.UseVisualStyleBackColor = true;
            this.spicy_btn.CheckedChanged += new System.EventHandler(this.spicy_btn_CheckedChanged);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 400);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.purchase_btn);
            this.Controls.Add(this.price_lbl);
            this.Controls.Add(this.increase_btn);
            this.Controls.Add(this.decrease_btn);
            this.Controls.Add(this.Quantity_lbl);
            this.Controls.Add(this.topping_Combo);
            this.Controls.Add(this.pizza_Picture);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizza_Picture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newsizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraLargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allergyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glutenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dairyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eggsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pizza_Picture;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox topping_Combo;
        private System.Windows.Forms.Label Quantity_lbl;
        private System.Windows.Forms.Button decrease_btn;
        private System.Windows.Forms.Button increase_btn;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.Button purchase_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton spicy_btn;
        private System.Windows.Forms.RadioButton Sweet;
        private System.Windows.Forms.RadioButton reg_btn;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
    }
}

