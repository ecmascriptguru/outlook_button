using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookButton
{
    public partial class Popup : Form
    {
        private Microsoft.Office.Interop.Outlook.Application App;

        public Popup()
        {
            InitializeComponent();
        }

        public Popup(Microsoft.Office.Interop.Outlook.Application _app)
        {
            App = _app;
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //This is just to prepare the message. From 8 to 8 words it will write another line
            List<string> lineInfo = new List<string>();

            string[] words = txtBody.Text.Split(new char[0]);

            int j = 1;
            StringBuilder line = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                //On the 8th line it breaks the line
                if (j++ % 8 == 0)
                {
                    lineInfo.Add(line.ToString());
                    line = new StringBuilder(words[i] + " ");
                }
                else
                {
                    line.Append(words[i] + " ");
                }
            }
            if (!string.IsNullOrWhiteSpace(line.ToString()))
                lineInfo.Add(line.ToString());

            SendMessage(App, lineInfo, txtBody.Text, txtFromEmail.Text, txtSubject.Text, txtFromEmail.Text, txtHeading.Text);
        }

        private void SendMessage(Microsoft.Office.Interop.Outlook.Application oApp, List<string> bodyMessage, string stringBodyMessage, string receiver, string subject, string from, string to)
        {
            try
            {
                // Create a new mail item. Pass the application received on the form as parameter
                Microsoft.Office.Interop.Outlook.MailItem oMsg = (Microsoft.Office.Interop.Outlook.MailItem)oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);

                //add the body of the email
                oMsg.HTMLBody = stringBodyMessage;
                //Add an attachment.
                String sDisplayName = "MyAttachment";
                int iPosition = (int)oMsg.Body.Length + 1;
                int iAttachType = (int)Microsoft.Office.Interop.Outlook.OlAttachmentType.olByValue;
                //now attached the file
                prepareMessage(bodyMessage, from, to);
                //clearFieldsAndClose();

                string thePath = Path.Combine
                (AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "picture1.png");
                Microsoft.Office.Interop.Outlook.Attachment oAttach =
                    oMsg.Attachments.Add(thePath, iAttachType, iPosition, sDisplayName);

                //Subject line
                oMsg.Subject = subject;
                // Add a recipient.
                Microsoft.Office.Interop.Outlook.Recipients oRecips =
                    (Microsoft.Office.Interop.Outlook.Recipients)oMsg.Recipients;
                // Change the recipient in the next line if necessary.
                Microsoft.Office.Interop.Outlook.Recipient oRecip =
                    (Microsoft.Office.Interop.Outlook.Recipient)oRecips.Add(receiver);
                oRecip.Resolve();
                // Send.
                oMsg.Send();
                // Clean up.
                oRecip = null;
                oRecips = null;
                oMsg = null;
                oApp = null;

            }//end of try block
            catch (System.Exception ex)
            {
                MessageBox.Show("An error occurs. " + ex.Message);
            }//end of catch
        }

        //this step clears the fields and waits a little bit of time, to make sure the image is saved and released before 
        //the e-mail tries to attach it and send it
        private void clearFieldsAndClose()
        {
            txtBody.Text = string.Empty;
            txtToEmail.Text = string.Empty;
            txtSubject.Text = string.Empty;
            txtFromEmail.Text = string.Empty;
            txtHeading.Text = string.Empty;
            Close();
            //sleep to make sure the e-mail is sent after the picture has been saved
            Thread.Sleep(3000);
        }

        //This is the step that will get the image, and write the content of the message within it
        private void prepareMessage(List<string> body, string from, string to)
        {
            PointF location = new PointF(30f, 30f);

            string imageFilePath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "picture.png");

            Bitmap bitmap = (Bitmap)Image.FromFile(imageFilePath);//load the image file

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                using (Font arialFont = new Font("Comic Sans", 30))
                {
                    if (!string.IsNullOrWhiteSpace(to))
                    {
                        graphics.DrawString(to + ",", arialFont, Brushes.CornflowerBlue, location);
                        location.Y += 30;
                    }

                    foreach (string line in body)
                    {
                        graphics.DrawString(line, arialFont, Brushes.CornflowerBlue, location);
                        location.Y += 30;
                    }
                }
                //PointF lastPoint = new PointF(800f, 700f);

                //using (Font aRial = new Font("Comic Sans", 30))
                //{
                //    graphics.DrawString(from, aRial, Brushes.MediumBlue, lastPoint);
                //}
            }
            //it then saves the image using another name, avoiding it to be overriden.
            imageFilePath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "picture1.png");
            bitmap.Save(imageFilePath);//save the image file

        }
    }
}
