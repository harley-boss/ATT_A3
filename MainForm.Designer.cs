namespace A3_MongoDB_hboss {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.rbMultiple = new System.Windows.Forms.RadioButton();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.rbKeyword = new System.Windows.Forms.RadioButton();
            this.cmbActorsList = new System.Windows.Forms.ComboBox();
            this.lblActorList = new System.Windows.Forms.Label();
            this.lblSearchCriteria = new System.Windows.Forms.Label();
            this.lBoxActors = new System.Windows.Forms.ListBox();
            this.lblActorsToSearch = new System.Windows.Forms.Label();
            this.lBoxResults = new System.Windows.Forms.ListBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpRadioButtons = new System.Windows.Forms.GroupBox();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbMultiple
            // 
            this.rbMultiple.AutoSize = true;
            this.rbMultiple.Location = new System.Drawing.Point(9, 19);
            this.rbMultiple.Name = "rbMultiple";
            this.rbMultiple.Size = new System.Drawing.Size(191, 17);
            this.rbMultiple.TabIndex = 3;
            this.rbMultiple.TabStop = true;
            this.rbMultiple.Text = "1. Search movies by multiple actors";
            this.rbMultiple.UseVisualStyleBackColor = true;
            this.rbMultiple.CheckedChanged += new System.EventHandler(this.rbMultiple_CheckedChanged);
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Location = new System.Drawing.Point(9, 61);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(178, 17);
            this.rbSingle.TabIndex = 4;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "2. Search movies by single actor";
            this.rbSingle.UseVisualStyleBackColor = true;
            this.rbSingle.CheckedChanged += new System.EventHandler(this.rbSingle_CheckedChanged);
            // 
            // rbKeyword
            // 
            this.rbKeyword.AutoSize = true;
            this.rbKeyword.Location = new System.Drawing.Point(9, 106);
            this.rbKeyword.Name = "rbKeyword";
            this.rbKeyword.Size = new System.Drawing.Size(128, 17);
            this.rbKeyword.TabIndex = 5;
            this.rbKeyword.TabStop = true;
            this.rbKeyword.Text = "3. Search by keyword";
            this.rbKeyword.UseVisualStyleBackColor = true;
            this.rbKeyword.CheckedChanged += new System.EventHandler(this.rbKeyword_CheckedChanged);
            // 
            // cmbActorsList
            // 
            this.cmbActorsList.FormattingEnabled = true;
            this.cmbActorsList.Location = new System.Drawing.Point(260, 50);
            this.cmbActorsList.Name = "cmbActorsList";
            this.cmbActorsList.Size = new System.Drawing.Size(248, 21);
            this.cmbActorsList.TabIndex = 6;
            this.cmbActorsList.SelectedIndexChanged += new System.EventHandler(this.ActorsListChanged);
            // 
            // lblActorList
            // 
            this.lblActorList.AutoSize = true;
            this.lblActorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActorList.Location = new System.Drawing.Point(256, 27);
            this.lblActorList.Name = "lblActorList";
            this.lblActorList.Size = new System.Drawing.Size(52, 16);
            this.lblActorList.TabIndex = 7;
            this.lblActorList.Text = "Actors";
            // 
            // lblSearchCriteria
            // 
            this.lblSearchCriteria.AutoSize = true;
            this.lblSearchCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCriteria.Location = new System.Drawing.Point(32, 27);
            this.lblSearchCriteria.Name = "lblSearchCriteria";
            this.lblSearchCriteria.Size = new System.Drawing.Size(111, 16);
            this.lblSearchCriteria.TabIndex = 8;
            this.lblSearchCriteria.Text = "Search Criteria";
            // 
            // lBoxActors
            // 
            this.lBoxActors.FormattingEnabled = true;
            this.lBoxActors.Location = new System.Drawing.Point(260, 231);
            this.lBoxActors.Name = "lBoxActors";
            this.lBoxActors.Size = new System.Drawing.Size(248, 147);
            this.lBoxActors.TabIndex = 9;
            // 
            // lblActorsToSearch
            // 
            this.lblActorsToSearch.AutoSize = true;
            this.lblActorsToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActorsToSearch.Location = new System.Drawing.Point(257, 212);
            this.lblActorsToSearch.Name = "lblActorsToSearch";
            this.lblActorsToSearch.Size = new System.Drawing.Size(128, 16);
            this.lblActorsToSearch.TabIndex = 10;
            this.lblActorsToSearch.Text = "Actors To Search";
            // 
            // lBoxResults
            // 
            this.lBoxResults.FormattingEnabled = true;
            this.lBoxResults.Location = new System.Drawing.Point(531, 50);
            this.lBoxResults.Name = "lBoxResults";
            this.lBoxResults.Size = new System.Drawing.Size(248, 329);
            this.lBoxResults.TabIndex = 11;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(528, 27);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(60, 16);
            this.lblResults.TabIndex = 12;
            this.lblResults.Text = "Results";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(704, 410);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpRadioButtons
            // 
            this.grpRadioButtons.Controls.Add(this.rbMultiple);
            this.grpRadioButtons.Controls.Add(this.rbSingle);
            this.grpRadioButtons.Controls.Add(this.rbKeyword);
            this.grpRadioButtons.Location = new System.Drawing.Point(23, 46);
            this.grpRadioButtons.Name = "grpRadioButtons";
            this.grpRadioButtons.Size = new System.Drawing.Size(219, 147);
            this.grpRadioButtons.TabIndex = 14;
            this.grpRadioButtons.TabStop = false;
            // 
            // tbKeyword
            // 
            this.tbKeyword.Location = new System.Drawing.Point(260, 107);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(248, 20);
            this.tbKeyword.TabIndex = 15;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.Location = new System.Drawing.Point(257, 88);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(67, 16);
            this.lblKeyword.TabIndex = 16;
            this.lblKeyword.Text = "Keyword";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(531, 410);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.tbKeyword);
            this.Controls.Add(this.grpRadioButtons);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lBoxResults);
            this.Controls.Add(this.lblActorsToSearch);
            this.Controls.Add(this.lBoxActors);
            this.Controls.Add(this.lblSearchCriteria);
            this.Controls.Add(this.lblActorList);
            this.Controls.Add(this.cmbActorsList);
            this.Name = "MainForm";
            this.Text = "Assignment 3 - Mongo DB";
            this.grpRadioButtons.ResumeLayout(false);
            this.grpRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMultiple;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.RadioButton rbKeyword;
        private System.Windows.Forms.ComboBox cmbActorsList;
        private System.Windows.Forms.Label lblActorList;
        private System.Windows.Forms.Label lblSearchCriteria;
        private System.Windows.Forms.ListBox lBoxActors;
        private System.Windows.Forms.Label lblActorsToSearch;
        private System.Windows.Forms.ListBox lBoxResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpRadioButtons;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Button btnReset;
    }
}