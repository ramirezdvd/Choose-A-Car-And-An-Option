namespace UIControlsAndMultiLine_DavidRamirez_II
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.groupBoxChooseCar = new System.Windows.Forms.GroupBox();
            this.radioButtonFordPinto = new System.Windows.Forms.RadioButton();
            this.radioButtonChevVolt = new System.Windows.Forms.RadioButton();
            this.groupBoxChooseFearures = new System.Windows.Forms.GroupBox();
            this.checkBoxGasTnk = new System.Windows.Forms.CheckBox();
            this.checkBoxDVDPl = new System.Windows.Forms.CheckBox();
            this.checkBoxSunRf = new System.Windows.Forms.CheckBox();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.LblTCOC = new System.Windows.Forms.Label();
            this.LblTotalCost = new System.Windows.Forms.Label();
            this.LblOrdered = new System.Windows.Forms.Label();
            this.LblFinalOrder = new System.Windows.Forms.Label();
            this.groupBoxChooseCar.SuspendLayout();
            this.groupBoxChooseFearures.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonCalculate.BackgroundImage")));
            this.ButtonCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCalculate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonCalculate.Location = new System.Drawing.Point(422, 30);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(93, 43);
            this.ButtonCalculate.TabIndex = 0;
            this.ButtonCalculate.Text = "Calculate";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // groupBoxChooseCar
            // 
            this.groupBoxChooseCar.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxChooseCar.Controls.Add(this.radioButtonFordPinto);
            this.groupBoxChooseCar.Controls.Add(this.radioButtonChevVolt);
            this.groupBoxChooseCar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChooseCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxChooseCar.Location = new System.Drawing.Point(25, 17);
            this.groupBoxChooseCar.Name = "groupBoxChooseCar";
            this.groupBoxChooseCar.Size = new System.Drawing.Size(252, 100);
            this.groupBoxChooseCar.TabIndex = 1;
            this.groupBoxChooseCar.TabStop = false;
            this.groupBoxChooseCar.Text = "Choose One Car to Buy";
            // 
            // radioButtonFordPinto
            // 
            this.radioButtonFordPinto.AutoSize = true;
            this.radioButtonFordPinto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFordPinto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonFordPinto.Location = new System.Drawing.Point(7, 54);
            this.radioButtonFordPinto.Name = "radioButtonFordPinto";
            this.radioButtonFordPinto.Size = new System.Drawing.Size(165, 20);
            this.radioButtonFordPinto.TabIndex = 1;
            this.radioButtonFordPinto.TabStop = true;
            this.radioButtonFordPinto.Text = "1970 Ford Pinto ($1,000)";
            this.radioButtonFordPinto.UseVisualStyleBackColor = true;
            // 
            // radioButtonChevVolt
            // 
            this.radioButtonChevVolt.AutoSize = true;
            this.radioButtonChevVolt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonChevVolt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonChevVolt.Location = new System.Drawing.Point(7, 20);
            this.radioButtonChevVolt.Name = "radioButtonChevVolt";
            this.radioButtonChevVolt.Size = new System.Drawing.Size(197, 20);
            this.radioButtonChevVolt.TabIndex = 0;
            this.radioButtonChevVolt.TabStop = true;
            this.radioButtonChevVolt.Text = "2014 Chevrolet Volt ($50,000)";
            this.radioButtonChevVolt.UseVisualStyleBackColor = true;
            // 
            // groupBoxChooseFearures
            // 
            this.groupBoxChooseFearures.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxChooseFearures.Controls.Add(this.checkBoxGasTnk);
            this.groupBoxChooseFearures.Controls.Add(this.checkBoxDVDPl);
            this.groupBoxChooseFearures.Controls.Add(this.checkBoxSunRf);
            this.groupBoxChooseFearures.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChooseFearures.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxChooseFearures.Location = new System.Drawing.Point(22, 164);
            this.groupBoxChooseFearures.Name = "groupBoxChooseFearures";
            this.groupBoxChooseFearures.Size = new System.Drawing.Size(253, 100);
            this.groupBoxChooseFearures.TabIndex = 2;
            this.groupBoxChooseFearures.TabStop = false;
            this.groupBoxChooseFearures.Text = "Choose One or More Optional Features";
            // 
            // checkBoxGasTnk
            // 
            this.checkBoxGasTnk.AutoSize = true;
            this.checkBoxGasTnk.Location = new System.Drawing.Point(7, 68);
            this.checkBoxGasTnk.Name = "checkBoxGasTnk";
            this.checkBoxGasTnk.Size = new System.Drawing.Size(214, 20);
            this.checkBoxGasTnk.TabIndex = 2;
            this.checkBoxGasTnk.Text = "Non-exploding Gas Tank ($100)";
            this.checkBoxGasTnk.UseVisualStyleBackColor = true;
            // 
            // checkBoxDVDPl
            // 
            this.checkBoxDVDPl.AutoSize = true;
            this.checkBoxDVDPl.Location = new System.Drawing.Point(7, 44);
            this.checkBoxDVDPl.Name = "checkBoxDVDPl";
            this.checkBoxDVDPl.Size = new System.Drawing.Size(132, 20);
            this.checkBoxDVDPl.TabIndex = 1;
            this.checkBoxDVDPl.Text = "DVD Player ($500)";
            this.checkBoxDVDPl.UseVisualStyleBackColor = true;
            this.checkBoxDVDPl.CheckedChanged += new System.EventHandler(this.checkBoxDVDPl_CheckedChanged);
            // 
            // checkBoxSunRf
            // 
            this.checkBoxSunRf.AutoSize = true;
            this.checkBoxSunRf.Location = new System.Drawing.Point(7, 21);
            this.checkBoxSunRf.Name = "checkBoxSunRf";
            this.checkBoxSunRf.Size = new System.Drawing.Size(127, 20);
            this.checkBoxSunRf.TabIndex = 0;
            this.checkBoxSunRf.Text = "Sun Roof ($1,000)";
            this.checkBoxSunRf.UseVisualStyleBackColor = true;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClearAll.BackgroundImage")));
            this.buttonClearAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearAll.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearAll.Location = new System.Drawing.Point(540, 30);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(93, 43);
            this.buttonClearAll.TabIndex = 3;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // LblTCOC
            // 
            this.LblTCOC.BackColor = System.Drawing.Color.Transparent;
            this.LblTCOC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTCOC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTCOC.Location = new System.Drawing.Point(435, 112);
            this.LblTCOC.Name = "LblTCOC";
            this.LblTCOC.Size = new System.Drawing.Size(183, 23);
            this.LblTCOC.TabIndex = 5;
            this.LblTCOC.Text = "Total Cost of Car and Options";
            this.LblTCOC.Click += new System.EventHandler(this.LblTCOC_Click);
            // 
            // LblTotalCost
            // 
            this.LblTotalCost.BackColor = System.Drawing.Color.Black;
            this.LblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTotalCost.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalCost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTotalCost.Location = new System.Drawing.Point(438, 130);
            this.LblTotalCost.Name = "LblTotalCost";
            this.LblTotalCost.Size = new System.Drawing.Size(168, 23);
            this.LblTotalCost.TabIndex = 6;
            // 
            // LblOrdered
            // 
            this.LblOrdered.BackColor = System.Drawing.Color.Transparent;
            this.LblOrdered.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrdered.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblOrdered.Location = new System.Drawing.Point(433, 175);
            this.LblOrdered.Name = "LblOrdered";
            this.LblOrdered.Size = new System.Drawing.Size(122, 16);
            this.LblOrdered.TabIndex = 7;
            this.LblOrdered.Text = "What You Ordered";
            // 
            // LblFinalOrder
            // 
            this.LblFinalOrder.BackColor = System.Drawing.Color.Black;
            this.LblFinalOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblFinalOrder.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFinalOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFinalOrder.Location = new System.Drawing.Point(436, 193);
            this.LblFinalOrder.Name = "LblFinalOrder";
            this.LblFinalOrder.Size = new System.Drawing.Size(206, 84);
            this.LblFinalOrder.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 286);
            this.Controls.Add(this.LblFinalOrder);
            this.Controls.Add(this.LblOrdered);
            this.Controls.Add(this.LblTotalCost);
            this.Controls.Add(this.LblTCOC);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.groupBoxChooseFearures);
            this.Controls.Add(this.groupBoxChooseCar);
            this.Controls.Add(this.ButtonCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxChooseCar.ResumeLayout(false);
            this.groupBoxChooseCar.PerformLayout();
            this.groupBoxChooseFearures.ResumeLayout(false);
            this.groupBoxChooseFearures.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.GroupBox groupBoxChooseCar;
        private System.Windows.Forms.RadioButton radioButtonFordPinto;
        private System.Windows.Forms.RadioButton radioButtonChevVolt;
        private System.Windows.Forms.GroupBox groupBoxChooseFearures;
        private System.Windows.Forms.CheckBox checkBoxGasTnk;
        private System.Windows.Forms.CheckBox checkBoxDVDPl;
        private System.Windows.Forms.CheckBox checkBoxSunRf;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Label LblTCOC;
        private System.Windows.Forms.Label LblTotalCost;
        private System.Windows.Forms.Label LblOrdered;
        private System.Windows.Forms.Label LblFinalOrder;
    }
}

