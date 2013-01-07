using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OctopressManager
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            UpdateBlogInfo();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            folderBrowserDialog1.Description = "Select octopress folder";
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if( result == System.Windows.Forms.DialogResult.OK )
            {

                if( File.Exists( folderBrowserDialog1.SelectedPath + @"\_config.yml" ) ) // dirty check
                {
                    // Open App.Config of executable
                    Configuration config = ConfigurationManager.OpenExeConfiguration( ConfigurationUserLevel.None );
                    // Add an Application Setting.
                    config.AppSettings.Settings["OctopressFolder"].Value = folderBrowserDialog1.SelectedPath;
                    // Save the configuration file.
                    config.Save( ConfigurationSaveMode.Modified, false );
                    // Force a reload of a changed section.
                    ConfigurationManager.RefreshSection( "appSettings" );

                    UpdateBlogInfo();
                }
                else MessageBox.Show( "This folder is not an OctopressFolder" );
            }
        }

        private void UpdateBlogInfo()
        {
            string octopressFolder = ConfigurationManager.AppSettings["OctopressFolder"];
            textBox1.Text = octopressFolder;
            if( !string.IsNullOrEmpty( octopressFolder ) )
            {
                OctopressManager mrg = new OctopressManager( octopressFolder );
                this.urlVal.Text = mrg.Url;
                this.titleVal.Text = mrg.Title;
                this.subtitleVal.Text = mrg.Subtitle;
                this.authorVal.Text = mrg.Author;
            }
        }

        private void button2_Click( object sender, EventArgs e )
        {
            string octopressFolder = ConfigurationManager.AppSettings["OctopressFolder"];
            OctopressManager mrg = new OctopressManager( octopressFolder );
            mrg.OpenCmd();
        }

        private void button5_Click( object sender, EventArgs e )
        {
            string octopressFolder = ConfigurationManager.AppSettings["OctopressFolder"];
            OctopressManager mrg = new OctopressManager( octopressFolder );
            mrg.OpenPreview();
        }

        private void button3_Click( object sender, EventArgs e )
        {
            string octopressFolder = ConfigurationManager.AppSettings["OctopressFolder"];
            OctopressManager mrg = new OctopressManager( octopressFolder );
            mrg.OpenGenerate();
        }

        private void button4_Click( object sender, EventArgs e )
        {
            string octopressFolder = ConfigurationManager.AppSettings["OctopressFolder"];
            OctopressManager mrg = new OctopressManager( octopressFolder );
            mrg.OpenDeploy();
        }

        private void button6_Click( object sender, EventArgs e )
        {
            string octopressFolder = ConfigurationManager.AppSettings["OctopressFolder"];
            OctopressManager mrg = new OctopressManager( octopressFolder );
            mrg.CreatePost(textBox2.Text);
        }
    }
}
