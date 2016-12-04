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


using Microsoft.VisualBasic;

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
           
            GenerateDocument_Execute2();
        }
 
            
          // Write your code here.

        
        void GenerateDocument_Execute2() {
        object MyDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string WordFile =  "C:\\JCTEMP.docx";
        var selItem = JobCards.SelectedItem;
        //if (File.Exists(WordFile)) {
            // Map the content control tag names in the word document to the entity field names
            List<OfficeIntegration.ColumnMapping> custFields = new List<OfficeIntegration.ColumnMapping>();
            custFields.Add(new OfficeIntegration.ColumnMapping("JName", "JName"));
            custFields.Add(new OfficeIntegration.ColumnMapping("JDescription", "JDescription"));
            custFields.Add(new OfficeIntegration.ColumnMapping("JDate", "JDate", null, FormatDelegate: formatDelegate));
            custFields.Add(new OfficeIntegration.ColumnMapping("JHoursEstmated", "JHoursEstmated"));
            custFields.Add(new OfficeIntegration.ColumnMapping("JHoursTook", "JHoursTook"));
            custFields.Add(new OfficeIntegration.ColumnMapping("JWarrenty", "JWarrenty"));
            custFields.Add(new OfficeIntegration.ColumnMapping("JSquares", "JSquares"));
            custFields.Add(new OfficeIntegration.ColumnMapping("JPrice", "JPrice"));


            dynamic doc = OfficeIntegration.Word.GenerateDocument(WordFile, selItem, custFields);

            //System.Windows.Forms.SendKeys.Send("{RIGHT}"); 

          //  doc.Application.Visible = false;

            //print here

           // doc.Application.Quit();
           //dynamic formatPrice = (decimal x) => { return Strings.Format(x, "c2"); };


        //partial void MyOwnMethod_CanExecute(ref bool result)
        {}
        // Write your code here.

        }


        Func<DateTime, string> formatDelegate = x => x.ToString("MM/dd/yyyy");


        
    }


}


    

