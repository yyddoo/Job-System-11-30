using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
namespace LightSwitchApplication
{
    public partial class SearchJobCards
    {
        //partial void (ref bool result)
      //  {
            // Write your code here.


        partial void MyOwnMethod_Execute()
        {
            // Write your code here.

            JobCard jc = new JobCard();
            jc = this.JobCards.SelectedItem;
            try
            {
                if (this.JobCards.CanDelete)
                {
                    jc.Delete();
                    this.Save();
                    this.Refresh();
                    
                    //this.ShowMessageBox("Record Delted!");
                }
                //else this.ShowMessageBox("You do not have permission to do this, bro!");

                
            }
            catch(Exception ex)
            {
                this.ShowMessageBox(ex.Message);
            }
            
           

            



           
            

        }

        partial void SearchJobCards_Saving(ref bool handled)
        {
            // Write your code here.
            
        }

    }
        
}
    

