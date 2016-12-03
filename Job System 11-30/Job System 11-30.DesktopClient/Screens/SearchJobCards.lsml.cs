using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using OfficeIntegration;
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

        partial void Print_Execute()
        {
           
            
          // Write your code here.

            // Function to format a field as Currency.  
           // dynamic formatPrice = (decimal x) => { return Strings.Format(x, "c2"); };

            // Map the Word column names to the entity column names.  
            List<ColumnMapping> mapContent = new List<ColumnMapping>();
            mapContent.Add(new ColumnMapping("JName", "JName"));
            mapContent.Add(new ColumnMapping("JDescription", "JDescription"));
            mapContent.Add(new ColumnMapping("JDate", "JDate"));
            mapContent.Add(new ColumnMapping("JHoursEstmated", "JHoursEstmated"));
            mapContent.Add(new ColumnMapping("JHoursTook", "JHoursTook"));
            mapContent.Add(new ColumnMapping("JWarrenty", "JWarrenty"));
            mapContent.Add(new ColumnMapping("JSquares", "JSquares"));
            mapContent.Add(new ColumnMapping("JPrice", "JPrice"));
            // Format the price as Currency using the Function created above.  
           // mapContent.Add(new ColumnMapping("JPrice", "JPrice", FormatDelegate: formatPrice));;
            

            // Define the document object.  
            object doc = Word.GenerateDocument(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TEMP.docx", this.JobCards.SelectedItem, mapContent);
            // Export the document object to Word.  
            Word.Export(doc, "JobCards", 2, false, this.JobCards, mapContent);

           // Word.SaveAsPDF(doc, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Product Catalog.pdf", true);  





        }

    }
        
}
    

