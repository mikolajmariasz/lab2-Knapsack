namespace GUI
{
    partial class KnapsackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnapsackForm));
            panel1 = new Panel();
            generateBtn = new Button();
            capacityTextBox = new TextBox();
            numberOfItemsTextBox = new TextBox();
            seedTextBox = new TextBox();
            capacityLabel = new Label();
            numberOfItemsLabel = new Label();
            seedLabel = new Label();
            generatedLst = new ListView();
            selectedLst = new ListView();
            panel2 = new Panel();
            totalValueLbl = new Label();
            totalWeightLbl = new Label();
            solveBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(generateBtn);
            panel1.Controls.Add(capacityTextBox);
            panel1.Controls.Add(numberOfItemsTextBox);
            panel1.Controls.Add(seedTextBox);
            panel1.Controls.Add(capacityLabel);
            panel1.Controls.Add(numberOfItemsLabel);
            panel1.Controls.Add(seedLabel);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // generateBtn
            // 
            resources.ApplyResources(generateBtn, "generateBtn");
            generateBtn.Name = "generateBtn";
            generateBtn.UseVisualStyleBackColor = true;
            generateBtn.Click += generateBtn_Click;
            // 
            // capacityTextBox
            // 
            resources.ApplyResources(capacityTextBox, "capacityTextBox");
            capacityTextBox.Name = "capacityTextBox";
            // 
            // numberOfItemsTextBox
            // 
            resources.ApplyResources(numberOfItemsTextBox, "numberOfItemsTextBox");
            numberOfItemsTextBox.Name = "numberOfItemsTextBox";
            // 
            // seedTextBox
            // 
            resources.ApplyResources(seedTextBox, "seedTextBox");
            seedTextBox.Name = "seedTextBox";
            // 
            // capacityLabel
            // 
            resources.ApplyResources(capacityLabel, "capacityLabel");
            capacityLabel.Name = "capacityLabel";
            // 
            // numberOfItemsLabel
            // 
            resources.ApplyResources(numberOfItemsLabel, "numberOfItemsLabel");
            numberOfItemsLabel.Name = "numberOfItemsLabel";
            // 
            // seedLabel
            // 
            resources.ApplyResources(seedLabel, "seedLabel");
            seedLabel.Name = "seedLabel";
            // 
            // generatedLst
            // 
            generatedLst.AutoArrange = false;
            generatedLst.FullRowSelect = true;
            generatedLst.GridLines = true;
            resources.ApplyResources(generatedLst, "generatedLst");
            generatedLst.Name = "generatedLst";
            generatedLst.UseCompatibleStateImageBehavior = false;
            generatedLst.View = View.Details;
            // 
            // selectedLst
            // 
            selectedLst.AutoArrange = false;
            selectedLst.FullRowSelect = true;
            selectedLst.GridLines = true;
            resources.ApplyResources(selectedLst, "selectedLst");
            selectedLst.Name = "selectedLst";
            selectedLst.UseCompatibleStateImageBehavior = false;
            selectedLst.View = View.Details;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(totalValueLbl);
            panel2.Controls.Add(totalWeightLbl);
            panel2.Controls.Add(solveBtn);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // totalValueLbl
            // 
            resources.ApplyResources(totalValueLbl, "totalValueLbl");
            totalValueLbl.Name = "totalValueLbl";
            // 
            // totalWeightLbl
            // 
            resources.ApplyResources(totalWeightLbl, "totalWeightLbl");
            totalWeightLbl.Name = "totalWeightLbl";
            // 
            // solveBtn
            // 
            resources.ApplyResources(solveBtn, "solveBtn");
            solveBtn.Name = "solveBtn";
            solveBtn.UseVisualStyleBackColor = true;
            solveBtn.Click += solveBtn_Click;
            // 
            // KnapsackForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(selectedLst);
            Controls.Add(generatedLst);
            Controls.Add(panel1);
            Name = "KnapsackForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button generateBtn;
        private TextBox capacityTextBox;
        private TextBox numberOfItemsTextBox;
        private TextBox seedTextBox;
        private Label capacityLabel;
        private Label numberOfItemsLabel;
        private Label seedLabel;
        private DataGridView dataGridView1;
        private ListView generatedLst;
        private ListView selectedLst;
        private Panel panel2;
        private Label totalValueLbl;
        private Label totalWeightLbl;
        private Button solveBtn;
    }
}