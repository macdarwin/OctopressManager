using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace OctopressManager
{
    public class OctopressManager
    {
        string _rootFolder;

        public string Url { get; private set; }
        public string Title { get; private set; }
        public string Subtitle { get; private set; }
        public string Author { get; private set; } 

        public OctopressManager( string rootFolder )
        {
            _rootFolder = rootFolder;
            ReadConfig();
        }

        public static Regex titleReg = new Regex( "^title:(?<val>.*)$",
            RegexOptions.Multiline
            | RegexOptions.ExplicitCapture
            | RegexOptions.CultureInvariant
            | RegexOptions.Compiled
            );
        public static Regex urlReg = new Regex( "^url:(?<val>.*)$",
            RegexOptions.Multiline
            | RegexOptions.ExplicitCapture
            | RegexOptions.CultureInvariant
            | RegexOptions.Compiled
            );
        public static Regex subtitleReg = new Regex( "^subtitle:(?<val>.*)$",
            RegexOptions.Multiline
            | RegexOptions.ExplicitCapture
            | RegexOptions.CultureInvariant
            | RegexOptions.Compiled
            );
        public static Regex authorReg = new Regex( "^author:(?<val>.*)$",
            RegexOptions.Multiline
            | RegexOptions.ExplicitCapture
            | RegexOptions.CultureInvariant
            | RegexOptions.Compiled
            );


        private void ReadConfig()
        {
            string configFile = File.ReadAllText( _rootFolder + @"\_config.yml");

            var result = titleReg.Match( configFile );
            Title = result.Success ? result.Groups["val"].Value : "No value";

            result = urlReg.Match( configFile );
            Url = result.Success ? result.Groups["val"].Value : "No value";

            result = subtitleReg.Match( configFile );
            Subtitle = result.Success ? result.Groups["val"].Value : "No value";

            result = authorReg.Match( configFile );
            Author = result.Success ? result.Groups["val"].Value : "No value";
        }

        internal void OpenCmd(string args = "")
        {            
            ProcessStartInfo cmd = new ProcessStartInfo(@"C:\Windows\System32\cmd.exe", args);
            cmd.WorkingDirectory = _rootFolder;
            Process.Start( cmd );
        }

        internal void OpenDeploy()
        {
            OpenCmd( "/K rake deploy" );
        }

        internal void OpenGenerate()
        {
            OpenCmd( "/K rake generate" );
        }

        internal void OpenPreview()
        {
            OpenCmd( "/K rake preview" );
            Thread.Sleep( 2000 );
            Process.Start( "http://localhost:4000/" );
        }

        internal void CreatePost( string p )
        {
            OpenCmd( string.Format( "/C rake new_post[\"{0}\"]", p ) );
            Thread.Sleep( 1000 );
            Process.Start( _rootFolder + @"\source\_posts" );
        }
    }
}
