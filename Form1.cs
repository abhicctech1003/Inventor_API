using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventor;

namespace ExtrudeCommand
{
    public partial class Form1 : Form
    {
        Inventor.Application inventorApplication;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                inventorApplication = (Inventor.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Inventor.Application");
                MessageBox.Show("Connnection is done");
            }
            catch
            {
                MessageBox.Show("Inventor is not running");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This will open part document for us
            PartDocument oPartDoc = (PartDocument)inventorApplication.Documents.Add(DocumentTypeEnum.kPartDocumentObject, inventorApplication.FileManager.GetTemplateFile(DocumentTypeEnum.kPartDocumentObject));
            //It is component definition
            PartComponentDefinition oPartComDef = oPartDoc.ComponentDefinition;

            PlanarSketch oSketch = oPartComDef.Sketches.Add(oPartComDef.WorkPlanes[3]);

            TransientGeometry transGeo = inventorApplication.TransientGeometry;

            //Point2d name = transGeo.CreatePoint2d();

            SketchEntitiesEnumerator oRectangle = oSketch.SketchLines.AddAsTwoPointRectangle(transGeo.CreatePoint2d(0, 0), transGeo.CreatePoint2d(4, 3));

            Profile oProfile = oSketch.Profiles.AddForSolid();

            ExtrudeDefinition ExtrudeDef = oPartComDef.Features.ExtrudeFeatures.CreateExtrudeDefinition(oProfile, PartFeatureOperationEnum.kJoinOperation);

            ExtrudeDef.SetDistanceExtent(4, PartFeatureExtentDirectionEnum.kNegativeExtentDirection);

            ExtrudeFeature oExtrude = oPartComDef.Features.ExtrudeFeatures.Add(ExtrudeDef);

        }
    }
}
