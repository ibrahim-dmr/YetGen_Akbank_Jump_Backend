﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductShipping.Services
{
    public class NotepadService
    {
        public string ReadFromNotepad(string filePath)
        {
            if(File.Exists(filePath))
            
                return File.ReadAllText(filePath);
            else
                throw new Exception("File Not Found!");      
        }
    }
}
