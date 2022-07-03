namespace CelsiusFahrenheitConverter
{
    partial class CelsiusFahrenheit
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
            this.tbTempInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTempFormat = new System.Windows.Forms.ComboBox();
            this.labelError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableTempConversion = new System.Windows.Forms.TableLayoutPanel();
            this.labelR2C14 = new System.Windows.Forms.Label();
            this.labelR2C13 = new System.Windows.Forms.Label();
            this.labelR2C12 = new System.Windows.Forms.Label();
            this.labelR2C11 = new System.Windows.Forms.Label();
            this.labelR2C10 = new System.Windows.Forms.Label();
            this.labelR2C9 = new System.Windows.Forms.Label();
            this.labelR2C8 = new System.Windows.Forms.Label();
            this.labelR2C7 = new System.Windows.Forms.Label();
            this.labelR2C6 = new System.Windows.Forms.Label();
            this.labelR2C5 = new System.Windows.Forms.Label();
            this.labelR2C4 = new System.Windows.Forms.Label();
            this.labelR2C3 = new System.Windows.Forms.Label();
            this.labelR2C2 = new System.Windows.Forms.Label();
            this.labelR2C1 = new System.Windows.Forms.Label();
            this.labelR1C14 = new System.Windows.Forms.Label();
            this.labelR1C13 = new System.Windows.Forms.Label();
            this.labelR1C12 = new System.Windows.Forms.Label();
            this.labelR1C11 = new System.Windows.Forms.Label();
            this.labelR1C10 = new System.Windows.Forms.Label();
            this.labelR1C9 = new System.Windows.Forms.Label();
            this.labelR1C8 = new System.Windows.Forms.Label();
            this.labelR1C7 = new System.Windows.Forms.Label();
            this.labelR1C6 = new System.Windows.Forms.Label();
            this.labelR1C5 = new System.Windows.Forms.Label();
            this.labelR1C4 = new System.Windows.Forms.Label();
            this.labelR1C3 = new System.Windows.Forms.Label();
            this.labelR1C2 = new System.Windows.Forms.Label();
            this.labelR1C1 = new System.Windows.Forms.Label();
            this.labelCelsius = new System.Windows.Forms.Label();
            this.labelFahrenheit = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableTempConversion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTempInput
            // 
            this.tbTempInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTempInput.Location = new System.Drawing.Point(143, 98);
            this.tbTempInput.Name = "tbTempInput";
            this.tbTempInput.Size = new System.Drawing.Size(125, 34);
            this.tbTempInput.TabIndex = 0;
            this.tbTempInput.TextChanged += new System.EventHandler(this.tbTempInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(406, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.Location = new System.Drawing.Point(438, 98);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(64, 28);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Conversion Table";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(201, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Temperature Converter";
            // 
            // cbTempFormat
            // 
            this.cbTempFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTempFormat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTempFormat.FormattingEnabled = true;
            this.cbTempFormat.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit"});
            this.cbTempFormat.Location = new System.Drawing.Point(275, 96);
            this.cbTempFormat.Name = "cbTempFormat";
            this.cbTempFormat.Size = new System.Drawing.Size(125, 36);
            this.cbTempFormat.TabIndex = 1;
            this.cbTempFormat.SelectedIndexChanged += new System.EventHandler(this.cbTempFormat_SelectedIndexChanged);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Coral;
            this.labelError.Location = new System.Drawing.Point(146, 137);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(254, 20);
            this.labelError.TabIndex = 7;
            this.labelError.Text = "*Cannot convert non-numerical value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(143, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Temperature";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(275, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Degrees";
            // 
            // tableTempConversion
            // 
            this.tableTempConversion.ColumnCount = 15;
            this.tableTempConversion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableTempConversion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableTempConversion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableTempConversion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableTempConversion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableTempConversion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableTempConversion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableTempConversion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableTempConversion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableTempConversion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableTempConversion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableTempConversion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableTempConversion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableTempConversion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableTempConversion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableTempConversion.Controls.Add(this.labelR2C14, 14, 1);
            this.tableTempConversion.Controls.Add(this.labelR2C13, 13, 1);
            this.tableTempConversion.Controls.Add(this.labelR2C12, 12, 1);
            this.tableTempConversion.Controls.Add(this.labelR2C11, 11, 1);
            this.tableTempConversion.Controls.Add(this.labelR2C10, 10, 1);
            this.tableTempConversion.Controls.Add(this.labelR2C9, 9, 1);
            this.tableTempConversion.Controls.Add(this.labelR2C8, 8, 1);
            this.tableTempConversion.Controls.Add(this.labelR2C7, 7, 1);
            this.tableTempConversion.Controls.Add(this.labelR2C6, 6, 1);
            this.tableTempConversion.Controls.Add(this.labelR2C5, 5, 1);
            this.tableTempConversion.Controls.Add(this.labelR2C4, 4, 1);
            this.tableTempConversion.Controls.Add(this.labelR2C3, 3, 1);
            this.tableTempConversion.Controls.Add(this.labelR2C2, 2, 1);
            this.tableTempConversion.Controls.Add(this.labelR2C1, 1, 1);
            this.tableTempConversion.Controls.Add(this.labelR1C14, 14, 0);
            this.tableTempConversion.Controls.Add(this.labelR1C13, 13, 0);
            this.tableTempConversion.Controls.Add(this.labelR1C12, 12, 0);
            this.tableTempConversion.Controls.Add(this.labelR1C11, 11, 0);
            this.tableTempConversion.Controls.Add(this.labelR1C10, 10, 0);
            this.tableTempConversion.Controls.Add(this.labelR1C9, 9, 0);
            this.tableTempConversion.Controls.Add(this.labelR1C8, 8, 0);
            this.tableTempConversion.Controls.Add(this.labelR1C7, 7, 0);
            this.tableTempConversion.Controls.Add(this.labelR1C6, 6, 0);
            this.tableTempConversion.Controls.Add(this.labelR1C5, 5, 0);
            this.tableTempConversion.Controls.Add(this.labelR1C4, 4, 0);
            this.tableTempConversion.Controls.Add(this.labelR1C3, 3, 0);
            this.tableTempConversion.Controls.Add(this.labelR1C2, 2, 0);
            this.tableTempConversion.Controls.Add(this.labelR1C1, 1, 0);
            this.tableTempConversion.Controls.Add(this.labelCelsius, 0, 0);
            this.tableTempConversion.Controls.Add(this.labelFahrenheit, 0, 1);
            this.tableTempConversion.Location = new System.Drawing.Point(12, 264);
            this.tableTempConversion.Name = "tableTempConversion";
            this.tableTempConversion.RowCount = 2;
            this.tableTempConversion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableTempConversion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableTempConversion.Size = new System.Drawing.Size(610, 80);
            this.tableTempConversion.TabIndex = 5;
            // 
            // labelR2C14
            // 
            this.labelR2C14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR2C14.AutoSize = true;
            this.labelR2C14.Location = new System.Drawing.Point(573, 50);
            this.labelR2C14.Name = "labelR2C14";
            this.labelR2C14.Size = new System.Drawing.Size(34, 20);
            this.labelR2C14.TabIndex = 29;
            this.labelR2C14.Text = "°F";
            // 
            // labelR2C13
            // 
            this.labelR2C13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR2C13.AutoSize = true;
            this.labelR2C13.Location = new System.Drawing.Point(533, 50);
            this.labelR2C13.Name = "labelR2C13";
            this.labelR2C13.Size = new System.Drawing.Size(34, 20);
            this.labelR2C13.TabIndex = 28;
            this.labelR2C13.Text = "°F";
            // 
            // labelR2C12
            // 
            this.labelR2C12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR2C12.AutoSize = true;
            this.labelR2C12.Location = new System.Drawing.Point(493, 50);
            this.labelR2C12.Name = "labelR2C12";
            this.labelR2C12.Size = new System.Drawing.Size(34, 20);
            this.labelR2C12.TabIndex = 27;
            this.labelR2C12.Text = "°F";
            // 
            // labelR2C11
            // 
            this.labelR2C11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR2C11.AutoSize = true;
            this.labelR2C11.Location = new System.Drawing.Point(453, 50);
            this.labelR2C11.Name = "labelR2C11";
            this.labelR2C11.Size = new System.Drawing.Size(34, 20);
            this.labelR2C11.TabIndex = 26;
            this.labelR2C11.Text = "°F";
            // 
            // labelR2C10
            // 
            this.labelR2C10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR2C10.AutoSize = true;
            this.labelR2C10.Location = new System.Drawing.Point(413, 50);
            this.labelR2C10.Name = "labelR2C10";
            this.labelR2C10.Size = new System.Drawing.Size(34, 20);
            this.labelR2C10.TabIndex = 25;
            this.labelR2C10.Text = "°F";
            // 
            // labelR2C9
            // 
            this.labelR2C9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR2C9.AutoSize = true;
            this.labelR2C9.Location = new System.Drawing.Point(373, 50);
            this.labelR2C9.Name = "labelR2C9";
            this.labelR2C9.Size = new System.Drawing.Size(34, 20);
            this.labelR2C9.TabIndex = 24;
            this.labelR2C9.Text = "°F";
            // 
            // labelR2C8
            // 
            this.labelR2C8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR2C8.AutoSize = true;
            this.labelR2C8.Location = new System.Drawing.Point(333, 50);
            this.labelR2C8.Name = "labelR2C8";
            this.labelR2C8.Size = new System.Drawing.Size(34, 20);
            this.labelR2C8.TabIndex = 23;
            this.labelR2C8.Text = "°F";
            // 
            // labelR2C7
            // 
            this.labelR2C7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR2C7.AutoSize = true;
            this.labelR2C7.Location = new System.Drawing.Point(293, 50);
            this.labelR2C7.Name = "labelR2C7";
            this.labelR2C7.Size = new System.Drawing.Size(34, 20);
            this.labelR2C7.TabIndex = 22;
            this.labelR2C7.Text = "°F";
            // 
            // labelR2C6
            // 
            this.labelR2C6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR2C6.AutoSize = true;
            this.labelR2C6.Location = new System.Drawing.Point(253, 50);
            this.labelR2C6.Name = "labelR2C6";
            this.labelR2C6.Size = new System.Drawing.Size(34, 20);
            this.labelR2C6.TabIndex = 21;
            this.labelR2C6.Text = "°F";
            // 
            // labelR2C5
            // 
            this.labelR2C5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR2C5.AutoSize = true;
            this.labelR2C5.Location = new System.Drawing.Point(213, 50);
            this.labelR2C5.Name = "labelR2C5";
            this.labelR2C5.Size = new System.Drawing.Size(34, 20);
            this.labelR2C5.TabIndex = 20;
            this.labelR2C5.Text = "°F";
            // 
            // labelR2C4
            // 
            this.labelR2C4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR2C4.AutoSize = true;
            this.labelR2C4.Location = new System.Drawing.Point(173, 50);
            this.labelR2C4.Name = "labelR2C4";
            this.labelR2C4.Size = new System.Drawing.Size(34, 20);
            this.labelR2C4.TabIndex = 19;
            this.labelR2C4.Text = "°F";
            // 
            // labelR2C3
            // 
            this.labelR2C3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR2C3.AutoSize = true;
            this.labelR2C3.Location = new System.Drawing.Point(133, 50);
            this.labelR2C3.Name = "labelR2C3";
            this.labelR2C3.Size = new System.Drawing.Size(34, 20);
            this.labelR2C3.TabIndex = 18;
            this.labelR2C3.Text = "°F";
            // 
            // labelR2C2
            // 
            this.labelR2C2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR2C2.AutoSize = true;
            this.labelR2C2.Location = new System.Drawing.Point(93, 50);
            this.labelR2C2.Name = "labelR2C2";
            this.labelR2C2.Size = new System.Drawing.Size(34, 20);
            this.labelR2C2.TabIndex = 17;
            this.labelR2C2.Text = "°F";
            // 
            // labelR2C1
            // 
            this.labelR2C1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR2C1.AutoSize = true;
            this.labelR2C1.Location = new System.Drawing.Point(53, 50);
            this.labelR2C1.Name = "labelR2C1";
            this.labelR2C1.Size = new System.Drawing.Size(34, 20);
            this.labelR2C1.TabIndex = 16;
            this.labelR2C1.Text = "°F";
            // 
            // labelR1C14
            // 
            this.labelR1C14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR1C14.AutoSize = true;
            this.labelR1C14.Location = new System.Drawing.Point(573, 10);
            this.labelR1C14.Name = "labelR1C14";
            this.labelR1C14.Size = new System.Drawing.Size(34, 20);
            this.labelR1C14.TabIndex = 15;
            this.labelR1C14.Text = "°C";
            // 
            // labelR1C13
            // 
            this.labelR1C13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR1C13.AutoSize = true;
            this.labelR1C13.Location = new System.Drawing.Point(533, 10);
            this.labelR1C13.Name = "labelR1C13";
            this.labelR1C13.Size = new System.Drawing.Size(34, 20);
            this.labelR1C13.TabIndex = 14;
            this.labelR1C13.Text = "°C";
            // 
            // labelR1C12
            // 
            this.labelR1C12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR1C12.AutoSize = true;
            this.labelR1C12.Location = new System.Drawing.Point(493, 10);
            this.labelR1C12.Name = "labelR1C12";
            this.labelR1C12.Size = new System.Drawing.Size(34, 20);
            this.labelR1C12.TabIndex = 13;
            this.labelR1C12.Text = "°C";
            // 
            // labelR1C11
            // 
            this.labelR1C11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR1C11.AutoSize = true;
            this.labelR1C11.Location = new System.Drawing.Point(453, 10);
            this.labelR1C11.Name = "labelR1C11";
            this.labelR1C11.Size = new System.Drawing.Size(34, 20);
            this.labelR1C11.TabIndex = 12;
            this.labelR1C11.Text = "°C";
            // 
            // labelR1C10
            // 
            this.labelR1C10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR1C10.AutoSize = true;
            this.labelR1C10.Location = new System.Drawing.Point(413, 10);
            this.labelR1C10.Name = "labelR1C10";
            this.labelR1C10.Size = new System.Drawing.Size(34, 20);
            this.labelR1C10.TabIndex = 11;
            this.labelR1C10.Text = "°C";
            // 
            // labelR1C9
            // 
            this.labelR1C9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR1C9.AutoSize = true;
            this.labelR1C9.Location = new System.Drawing.Point(373, 10);
            this.labelR1C9.Name = "labelR1C9";
            this.labelR1C9.Size = new System.Drawing.Size(34, 20);
            this.labelR1C9.TabIndex = 10;
            this.labelR1C9.Text = "°C";
            // 
            // labelR1C8
            // 
            this.labelR1C8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR1C8.AutoSize = true;
            this.labelR1C8.Location = new System.Drawing.Point(333, 10);
            this.labelR1C8.Name = "labelR1C8";
            this.labelR1C8.Size = new System.Drawing.Size(34, 20);
            this.labelR1C8.TabIndex = 9;
            this.labelR1C8.Text = "°C";
            // 
            // labelR1C7
            // 
            this.labelR1C7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR1C7.AutoSize = true;
            this.labelR1C7.Location = new System.Drawing.Point(293, 10);
            this.labelR1C7.Name = "labelR1C7";
            this.labelR1C7.Size = new System.Drawing.Size(34, 20);
            this.labelR1C7.TabIndex = 8;
            this.labelR1C7.Text = "°C";
            // 
            // labelR1C6
            // 
            this.labelR1C6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR1C6.AutoSize = true;
            this.labelR1C6.Location = new System.Drawing.Point(253, 10);
            this.labelR1C6.Name = "labelR1C6";
            this.labelR1C6.Size = new System.Drawing.Size(34, 20);
            this.labelR1C6.TabIndex = 7;
            this.labelR1C6.Text = "°C";
            // 
            // labelR1C5
            // 
            this.labelR1C5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR1C5.AutoSize = true;
            this.labelR1C5.Location = new System.Drawing.Point(213, 10);
            this.labelR1C5.Name = "labelR1C5";
            this.labelR1C5.Size = new System.Drawing.Size(34, 20);
            this.labelR1C5.TabIndex = 6;
            this.labelR1C5.Text = "°C";
            // 
            // labelR1C4
            // 
            this.labelR1C4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR1C4.AutoSize = true;
            this.labelR1C4.Location = new System.Drawing.Point(173, 10);
            this.labelR1C4.Name = "labelR1C4";
            this.labelR1C4.Size = new System.Drawing.Size(34, 20);
            this.labelR1C4.TabIndex = 5;
            this.labelR1C4.Text = "°C";
            // 
            // labelR1C3
            // 
            this.labelR1C3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR1C3.AutoSize = true;
            this.labelR1C3.Location = new System.Drawing.Point(133, 10);
            this.labelR1C3.Name = "labelR1C3";
            this.labelR1C3.Size = new System.Drawing.Size(34, 20);
            this.labelR1C3.TabIndex = 4;
            this.labelR1C3.Text = "°C";
            // 
            // labelR1C2
            // 
            this.labelR1C2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR1C2.AutoSize = true;
            this.labelR1C2.Location = new System.Drawing.Point(93, 10);
            this.labelR1C2.Name = "labelR1C2";
            this.labelR1C2.Size = new System.Drawing.Size(34, 20);
            this.labelR1C2.TabIndex = 3;
            this.labelR1C2.Text = "°C";
            // 
            // labelR1C1
            // 
            this.labelR1C1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelR1C1.AutoSize = true;
            this.labelR1C1.Location = new System.Drawing.Point(53, 10);
            this.labelR1C1.Name = "labelR1C1";
            this.labelR1C1.Size = new System.Drawing.Size(34, 20);
            this.labelR1C1.TabIndex = 2;
            this.labelR1C1.Text = "°C";
            // 
            // labelCelsius
            // 
            this.labelCelsius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCelsius.AutoSize = true;
            this.labelCelsius.Location = new System.Drawing.Point(3, 10);
            this.labelCelsius.Name = "labelCelsius";
            this.labelCelsius.Size = new System.Drawing.Size(44, 20);
            this.labelCelsius.TabIndex = 0;
            this.labelCelsius.Text = "°C";
            // 
            // labelFahrenheit
            // 
            this.labelFahrenheit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFahrenheit.AutoSize = true;
            this.labelFahrenheit.Location = new System.Drawing.Point(3, 50);
            this.labelFahrenheit.Name = "labelFahrenheit";
            this.labelFahrenheit.Size = new System.Drawing.Size(44, 20);
            this.labelFahrenheit.TabIndex = 1;
            this.labelFahrenheit.Text = "°F";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "↺ ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CelsiusFahrenheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableTempConversion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTempFormat);
            this.Controls.Add(this.tbTempInput);
            this.Name = "CelsiusFahrenheit";
            this.Text = "Celsius to Fahrenheit Converter";
            this.Load += new System.EventHandler(this.CelsiusFahrenheit_Load);
            this.tableTempConversion.ResumeLayout(false);
            this.tableTempConversion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbTempInput;
        private Label label1;
        private Label labelResult;
        private Label label3;
        private Label label4;
        private ComboBox cbTempFormat;
        private Label labelError;
        private Label label2;
        private Label label5;
        private TableLayoutPanel tableTempConversion;
        private Label labelCelsius;
        private Label labelR2C13;
        private Label labelR2C12;
        private Label labelR2C11;
        private Label labelR2C10;
        private Label labelR2C9;
        private Label labelR2C8;
        private Label labelR2C7;
        private Label labelR2C6;
        private Label labelR2C5;
        private Label labelR2C4;
        private Label labelR2C3;
        private Label labelR2C2;
        private Label labelR2C1;
        private Label labelR1C13;
        private Label labelR1C12;
        private Label labelR1C11;
        private Label labelR1C10;
        private Label labelR1C9;
        private Label labelR1C8;
        private Label labelR1C7;
        private Label labelR1C6;
        private Label labelR1C5;
        private Label labelR1C4;
        private Label labelR1C3;
        private Label labelR1C2;
        private Label labelR1C1;
        private Label labelFahrenheit;
        private Label labelR2C14;
        private Label labelR1C14;
        private Button button1;
    }
}