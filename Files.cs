using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortie
{
    public class Files
    {
        public int ID
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Path
        {
            get; set;
        }
        public string Extension
        {
            get; set;
        }
        public bool IsChecked
        {
            get; set;
        }
        public bool IsSorted
        {
            get; set;
        }
        public bool IsCurrent
        {
            get; set;
        }

        public Files (int id, string name, string path, string ext, bool isChecked, bool isSorted, bool isCurrent)
        {
            this.ID = id;
            this.Name = name;
            this.Path = path;
            this.Extension = ext;
            this.IsChecked = isChecked;
            this.IsSorted = isSorted;
            this.IsCurrent = isCurrent;
        }
    }
}