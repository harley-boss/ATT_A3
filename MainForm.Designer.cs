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
            this.rbMoviesForActor = new System.Windows.Forms.RadioButton();
            this.rbFindActorsInMovie = new System.Windows.Forms.RadioButton();
            this.rbOverview = new System.Windows.Forms.RadioButton();
            this.cmbActorsList = new System.Windows.Forms.ComboBox();
            this.lblActorList = new System.Windows.Forms.Label();
            this.lblSearchCriteria = new System.Windows.Forms.Label();
            this.lBoxResults = new System.Windows.Forms.ListBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpRadioButtons = new System.Windows.Forms.GroupBox();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMovies = new System.Windows.Forms.Label();
            this.cmbMoviesList = new System.Windows.Forms.ComboBox();
            this.grpRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbMoviesForActor
            // 
            this.rbMoviesForActor.AutoSize = true;
            this.rbMoviesForActor.Location = new System.Drawing.Point(9, 19);
            this.rbMoviesForActor.Name = "rbMoviesForActor";
            this.rbMoviesForActor.Size = new System.Drawing.Size(206, 17);
            this.rbMoviesForActor.TabIndex = 3;
            this.rbMoviesForActor.TabStop = true;
            this.rbMoviesForActor.Text = "1. Find all movies an actor has been in";
            this.rbMoviesForActor.UseVisualStyleBackColor = true;
            this.rbMoviesForActor.CheckedChanged += new System.EventHandler(this.rbMovieChanged);
            // 
            // rbFindActorsInMovie
            // 
            this.rbFindActorsInMovie.AutoSize = true;
            this.rbFindActorsInMovie.Location = new System.Drawing.Point(9, 61);
            this.rbFindActorsInMovie.Name = "rbFindActorsInMovie";
            this.rbFindActorsInMovie.Size = new System.Drawing.Size(153, 17);
            this.rbFindActorsInMovie.TabIndex = 4;
            this.rbFindActorsInMovie.TabStop = true;
            this.rbFindActorsInMovie.Text = "2. Find all actors in a movie";
            this.rbFindActorsInMovie.UseVisualStyleBackColor = true;
            this.rbFindActorsInMovie.CheckedChanged += new System.EventHandler(this.rbActorChanged);
            // 
            // rbOverview
            // 
            this.rbOverview.AutoSize = true;
            this.rbOverview.Location = new System.Drawing.Point(9, 106);
            this.rbOverview.Name = "rbOverview";
            this.rbOverview.Size = new System.Drawing.Size(131, 17);
            this.rbOverview.TabIndex = 5;
            this.rbOverview.TabStop = true;
            this.rbOverview.Text = "3. Search by overview";
            this.rbOverview.UseVisualStyleBackColor = true;
            this.rbOverview.CheckedChanged += new System.EventHandler(this.rbOverviewChanged);
            // 
            // cmbActorsList
            // 
            this.cmbActorsList.FormattingEnabled = true;
            this.cmbActorsList.Location = new System.Drawing.Point(292, 50);
            this.cmbActorsList.Name = "cmbActorsList";
            this.cmbActorsList.Size = new System.Drawing.Size(701, 21);
            this.cmbActorsList.TabIndex = 6;
            this.cmbActorsList.SelectedIndexChanged += new System.EventHandler(this.ActorsListChanged);
            // 
            // lblActorList
            // 
            this.lblActorList.AutoSize = true;
            this.lblActorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActorList.Location = new System.Drawing.Point(288, 27);
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
            // lBoxResults
            // 
            this.lBoxResults.FormattingEnabled = true;
            this.lBoxResults.Location = new System.Drawing.Point(22, 236);
            this.lBoxResults.Name = "lBoxResults";
            this.lBoxResults.Size = new System.Drawing.Size(1336, 511);
            this.lBoxResults.TabIndex = 11;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(20, 207);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(60, 16);
            this.lblResults.TabIndex = 12;
            this.lblResults.Text = "Results";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(830, 158);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpRadioButtons
            // 
            this.grpRadioButtons.Controls.Add(this.rbMoviesForActor);
            this.grpRadioButtons.Controls.Add(this.rbFindActorsInMovie);
            this.grpRadioButtons.Controls.Add(this.rbOverview);
            this.grpRadioButtons.Location = new System.Drawing.Point(23, 46);
            this.grpRadioButtons.Name = "grpRadioButtons";
            this.grpRadioButtons.Size = new System.Drawing.Size(222, 147);
            this.grpRadioButtons.TabIndex = 14;
            this.grpRadioButtons.TabStop = false;
            // 
            // tbKeyword
            // 
            this.tbKeyword.Location = new System.Drawing.Point(292, 161);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(511, 20);
            this.tbKeyword.TabIndex = 15;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.Location = new System.Drawing.Point(289, 142);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(67, 16);
            this.lblKeyword.TabIndex = 16;
            this.lblKeyword.Text = "Keyword";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1283, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovies.Location = new System.Drawing.Point(288, 85);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(58, 16);
            this.lblMovies.TabIndex = 19;
            this.lblMovies.Text = "Movies";
            // 
            // cmbMoviesList
            // 
            this.cmbMoviesList.FormattingEnabled = true;
            this.cmbMoviesList.Location = new System.Drawing.Point(292, 108);
            this.cmbMoviesList.Name = "cmbMoviesList";
            this.cmbMoviesList.Size = new System.Drawing.Size(701, 21);
            this.cmbMoviesList.TabIndex = 18;
            this.cmbMoviesList.SelectedIndexChanged += new System.EventHandler(this.MoviesListChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.lblMovies);
            this.Controls.Add(this.cmbMoviesList);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.tbKeyword);
            this.Controls.Add(this.grpRadioButtons);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lBoxResults);
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

        private System.Windows.Forms.RadioButton rbMoviesForActor;
        private System.Windows.Forms.RadioButton rbFindActorsInMovie;
        private System.Windows.Forms.RadioButton rbOverview;
        private System.Windows.Forms.ComboBox cmbActorsList;
        private System.Windows.Forms.Label lblActorList;
        private System.Windows.Forms.Label lblSearchCriteria;
        private System.Windows.Forms.ListBox lBoxResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpRadioButtons;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.ComboBox cmbMoviesList;
    }
}