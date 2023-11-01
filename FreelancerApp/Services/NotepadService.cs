using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreelancerApp.Service;
using FreelancerApp.Common;
using FreelancerApp.Abstract;

namespace FreelancerApp.Service
{
    public class NotepadService
    {

        public void SaveToNotepad(ICsvConvertible data)
        {
            string path = $"{FileLocation.ProjectFolder}\\Database";
            string type = data.GetType().ToString().Split(".").LastOrDefault() ;

            if (!Directory.Exists(path)) 
                Directory.CreateDirectory(path);

            string filePath = $"{path}\\{type}.txt"; 

            File.AppendAllText(filePath, $"{data.GetValuesCSV()}\n");
        }


        public string GetOnNotepad(string path)
        {
            if(File.Exists(path))
                return File.ReadAllText(path);

            throw new Exception("File Doesn't Exist");
        }
    }
}
