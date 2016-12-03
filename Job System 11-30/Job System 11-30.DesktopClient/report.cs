//using System;
//using System.Net;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Documents;
//using System.Windows.Ink;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Animation;
//using System.Windows.Shapes;
//using System.Runtime.InteropServices.Automation;
//using System.Xml;

////using <xmlns:ns0="urn:microsoft:ordermanager:jobcard">;


//namespace LightSwitchApplication
//{
//    public class Report
//    {
//        private JobCard _j;

//        public Report(JobCard j){ j = this._j; }

//        public void RunCustomerReportFixedTemplate(JobCard j)
//        {
//            //XmlDocument xml = new System.Xml.XmlDocument();
//            //XmlElement root = xml.CreateElement("customers");
//            //xml.AppendChild(root);

//            //    XmlElement child = xml.CreateElement("JobCard");
//            //    child.SetAttribute("Desp", _j.JDescription);
//            //    child.SetAttribute("Date", _j.JDate);
//            //    child.SetAttribute("Est", _j.JHoursEstmated);
//            //    child.SetAttribute("Act", _j.JHoursTook);
//            //    child.SetAttribute("War", _j.JWarrenty);
//            //    child.SetAttribute("Sqrs", _j.JSquares);
//            //    child.SetAttribute("Price", _j.JPrice);
//            //    child.SetAttribute("JobName", _j.JName);
//            //    root.AppendChild(child);
//            //string s = xml.OuterXml;



           
//        }
////    If AutomationFactory.IsAvailable Then
////        Try
////            'Create the XML data from our entity properties dynamically
////            Dim myXML = <customer>
////                            <%= From prop In cust.Details.Properties.All
////                                Select <<%= prop.Name.ToLower %>><%= If(prop.Value, "-") %></>
////                            %>
////                        </customer>

////            Using word = AutomationFactory.CreateObject("Word.Application")
////                Dim doc = word.Documents.Open("C:\Reports\CustomerDetails.docx")

////                'Grab the existing bound custom XML in the doc
////                Dim customXMLPart = doc.CustomXMLParts("urn:microsoft:ordermanager:customer")

////                Dim all = customXMLPart.SelectSingleNode("//*")
////                Dim replaceNode = customXMLPart.SelectSingleNode("/ns0:root[1]/customer[1]")

////                'replace the <customer> node in the existing custom XML with this new data
////                all.ReplaceChildSubtree(myXML.ToString, replaceNode)

////                word.Visible = True

////            End Using
////        Catch ex As Exception
////            Throw New InvalidOperationException("Failed to create customer report.", ex)
////        End Try
////    End If
////End Sub













//    }
//}







