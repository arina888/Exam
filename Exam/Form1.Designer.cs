using Microsoft.VisualBasic.Devices;
using System.ComponentModel.Design;

namespace Exam
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
            apartmentsDataGridView = new DataGridView();
            addressColumn = new DataGridViewTextBoxColumn();
            categoryColumn = new DataGridViewTextBoxColumn();
            areaColumn = new DataGridViewTextBoxColumn();
            Rooms = new DataGridViewTextBoxColumn();
            priceColumn = new DataGridViewTextBoxColumn();
            filterGroupBox = new GroupBox();
            label1 = new Label();
            roomTextBox = new TextBox();
            maxPriceTextBox = new TextBox();
            minAreaTextBox = new TextBox();
            maxPriceLabel = new Label();
            minAreaLabel = new Label();
            categoryCheckedListBox = new CheckedListBox();
            categoryLabel = new Label();
            findButton = new Button();
            ((System.ComponentModel.ISupportInitialize)apartmentsDataGridView).BeginInit();
            filterGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // apartmentsDataGridView
            // 
            apartmentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            apartmentsDataGridView.Columns.AddRange(new DataGridViewColumn[] { addressColumn, categoryColumn, areaColumn, Rooms, priceColumn });
            apartmentsDataGridView.Location = new Point(15, 15);
            apartmentsDataGridView.Margin = new Padding(4, 3, 4, 3);
            apartmentsDataGridView.Name = "apartmentsDataGridView";
            apartmentsDataGridView.Size = new Size(652, 308);
            apartmentsDataGridView.TabIndex = 0;
            // 
            // addressColumn
            // 
            addressColumn.HeaderText = "Адрес";
            addressColumn.Name = "addressColumn";
            addressColumn.Width = 210;
            // 
            // categoryColumn
            // 
            categoryColumn.HeaderText = "Категория";
            categoryColumn.Name = "categoryColumn";
            // 
            // areaColumn
            // 
            areaColumn.HeaderText = "Площадь";
            areaColumn.Name = "areaColumn";
            // 
            // Rooms
            // 
            Rooms.HeaderText = "Кол-во комнат";
            Rooms.Name = "Rooms";
            // 
            // priceColumn
            // 
            priceColumn.HeaderText = "Цена";
            priceColumn.Name = "priceColumn";
            // 
            // filterGroupBox
            // 
            filterGroupBox.Controls.Add(label1);
            filterGroupBox.Controls.Add(roomTextBox);
            filterGroupBox.Controls.Add(maxPriceTextBox);
            filterGroupBox.Controls.Add(minAreaTextBox);
            filterGroupBox.Controls.Add(maxPriceLabel);
            filterGroupBox.Controls.Add(minAreaLabel);
            filterGroupBox.Controls.Add(categoryCheckedListBox);
            filterGroupBox.Controls.Add(categoryLabel);
            filterGroupBox.Controls.Add(findButton);
            filterGroupBox.Location = new Point(15, 330);
            filterGroupBox.Margin = new Padding(4, 3, 4, 3);
            filterGroupBox.Name = "filterGroupBox";
            filterGroupBox.Padding = new Padding(4, 3, 4, 3);
            filterGroupBox.Size = new Size(652, 171);
            filterGroupBox.TabIndex = 1;
            filterGroupBox.TabStop = false;
            filterGroupBox.Text = "Фильтрация квартир";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 120);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 8;
            label1.Text = "Кол-во комнат";
            // 
            // roomTextBox
            // 
            roomTextBox.Location = new Point(136, 112);
            roomTextBox.Name = "roomTextBox";
            roomTextBox.Size = new Size(116, 23);
            roomTextBox.TabIndex = 7;
            // 
            // maxPriceTextBox
            // 
            maxPriceTextBox.Location = new Point(136, 68);
            maxPriceTextBox.Margin = new Padding(4, 3, 4, 3);
            maxPriceTextBox.Name = "maxPriceTextBox";
            maxPriceTextBox.Size = new Size(116, 23);
            maxPriceTextBox.TabIndex = 6;
            // 
            // minAreaTextBox
            // 
            minAreaTextBox.Location = new Point(136, 19);
            minAreaTextBox.Margin = new Padding(4, 3, 4, 3);
            minAreaTextBox.Name = "minAreaTextBox";
            minAreaTextBox.Size = new Size(116, 23);
            minAreaTextBox.TabIndex = 5;
            // 
            // maxPriceLabel
            // 
            maxPriceLabel.AutoSize = true;
            maxPriceLabel.Location = new Point(8, 76);
            maxPriceLabel.Margin = new Padding(4, 0, 4, 0);
            maxPriceLabel.Name = "maxPriceLabel";
            maxPriceLabel.Size = new Size(112, 15);
            maxPriceLabel.TabIndex = 4;
            maxPriceLabel.Text = "Макс. цена за м.кв.";
            // 
            // minAreaLabel
            // 
            minAreaLabel.AutoSize = true;
            minAreaLabel.Location = new Point(8, 27);
            minAreaLabel.Margin = new Padding(4, 0, 4, 0);
            minAreaLabel.Name = "minAreaLabel";
            minAreaLabel.Size = new Size(91, 15);
            minAreaLabel.TabIndex = 3;
            minAreaLabel.Text = "Мин. площадь:";
            // 
            // categoryCheckedListBox
            // 
            categoryCheckedListBox.FormattingEnabled = true;
            categoryCheckedListBox.Items.AddRange(new object[] { "Кирпичный", "Монолитный", "Панельный" });
            categoryCheckedListBox.Location = new Point(432, 27);
            categoryCheckedListBox.Margin = new Padding(4, 3, 4, 3);
            categoryCheckedListBox.Name = "categoryCheckedListBox";
            categoryCheckedListBox.Size = new Size(194, 76);
            categoryCheckedListBox.TabIndex = 2;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(352, 27);
            categoryLabel.Margin = new Padding(4, 0, 4, 0);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(67, 15);
            categoryLabel.TabIndex = 1;
            categoryLabel.Text = "Категории:";
            // 
            // findButton
            // 
            findButton.Location = new Point(270, 138);
            findButton.Margin = new Padding(4, 3, 4, 3);
            findButton.Name = "findButton";
            findButton.Size = new Size(113, 27);
            findButton.TabIndex = 0;
            findButton.Text = "Найти";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 515);
            Controls.Add(filterGroupBox);
            Controls.Add(apartmentsDataGridView);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Квартиры на продажу";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)apartmentsDataGridView).EndInit();
            filterGroupBox.ResumeLayout(false);
            filterGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView apartmentsDataGridView;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.CheckedListBox categoryCheckedListBox;
        private System.Windows.Forms.Label minAreaLabel;
        private System.Windows.Forms.Label maxPriceLabel;
        private System.Windows.Forms.TextBox minAreaTextBox;
        private System.Windows.Forms.TextBox maxPriceTextBox;
        private DataGridViewTextBoxColumn addressColumn;
        private DataGridViewTextBoxColumn categoryColumn;
        private DataGridViewTextBoxColumn areaColumn;
        private DataGridViewTextBoxColumn Rooms;
        private DataGridViewTextBoxColumn priceColumn;
        private Label label1;
        private TextBox roomTextBox;
    }
}