using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace V_M_S.BUSSINESS_LAYER
{
    internal class Volunteer:Project
    {
        private string Name;
        private string ID;
        private string Skills;
        private string Email;
        private string Availability;
        private Project project;
        private Project associatedProject;


        public Volunteer()
        {
            
        }
        public Volunteer(string Name)
        {
            this.name = Name;        
        }
    
        public Volunteer(string Name, string ID, string Skills): base(Name, ID, Skills)
        {

        }
        public Project AssociatedProject
        {
            get { return associatedProject; }
            set { associatedProject = value; }
        }
        public Volunteer(string Name,string ID,string Skills,string Email,string Availability, Project associatedproject):base(Name,ID,Skills)
        {
            this.Email = Email;
            this.Availability = Availability;
            project = associatedproject;
        }
    }
  
   
   
}

