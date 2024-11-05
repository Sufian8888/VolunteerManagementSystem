using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V_M_S.DATA_LAYER;


namespace V_M_S.BUSSINESS_LAYER
{
    internal  class Project
    {
        private string Name;
        private string ID;
        private string Skills;

        public Project()
        {
             
        }
        public string id { get { return ID; } set { ID = value; } }
        public string  name {get { return Name; } set { Name = value; } }
        public string skills
        {
            get { return Skills; }
            set { Skills = value; }
        }

        public Project(string ID,string Name,string Skills)
        {
           this.Name = Name;
            this.ID = ID;
            this.Skills = Skills;
        }

    }
}
